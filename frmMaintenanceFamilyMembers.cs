using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Photos.Models.DataLayer;

namespace Photos
{
    public partial class frmMaintenanceFamilyMembers : Form
    {
        public frmMaintenanceFamilyMembers()
        {
            InitializeComponent();
        }

        // create an instance of the DB context
        private PhotosContext context = new PhotosContext();
        private FamilyMembers selectedFamilyMember;

        // constants for the index values of the modify and delete buttons
        private const int ModifyIndex = 4;
        private const int DeleteIndex = 5;

        private void frmMaintenance_Load(object sender, EventArgs e)
        {
            DisplayFamilyMembers();
        }

        private void DisplayFamilyMembers()
        {
            dgFamilyMembers.Columns.Clear();

            // count number of family members
            var query = context.FamilyMembers
              .OrderBy(f => f.FirstName)
              .Select(f => new { f.Id, f.LastName, f.FirstName, f.Bio })
              .ToList();

            // bind results of LINQ query to the DataGridView
            dgFamilyMembers.DataSource = query;

            //set the visible property so this column isn't displayed
            dgFamilyMembers.Columns[0].Visible = false;

            //format grid
            //resize the columns for the data fits nicely in each column 
            dgFamilyMembers.AutoResizeColumns();
            //set the column header style
            dgFamilyMembers.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9, FontStyle.Bold);
            //set the background color on alternating rows to beige so it's easier to read
            dgFamilyMembers.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige;

            //add two button columns to the grid
            //add column for modify button
            var modifyColumn = new DataGridViewButtonColumn()
            {
                UseColumnTextForButtonValue = true, // make sure the text shows up in the button
                HeaderText = "Modify Family Member",
                Text = "Modify",
                Name = "colModify"
            };
            dgFamilyMembers.Columns.Insert(ModifyIndex, modifyColumn);

            //add column for delete button
            var deleteColumn = new DataGridViewButtonColumn()
            {
                UseColumnTextForButtonValue = true, // make sure the text shows up in the button
                HeaderText = "Delete FamilyMember",
                Text = "Delete",
                Name = "colDelete"
            };
            dgFamilyMembers.Columns.Insert(DeleteIndex, deleteColumn);
        }

        

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var addModifyFamilyMemberForm = new frmAddModifyFamilyMember()
            {
                AddFamilyMember = true
            };
            DialogResult result = addModifyFamilyMemberForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                try
                {
                    selectedFamilyMember = addModifyFamilyMemberForm.FamilyMember;
                    context.FamilyMembers.Add(selectedFamilyMember);
                    context.SaveChanges();
                    DisplayFamilyMembers();
                }
                catch (DbUpdateException ex)
                {
                    HandleDatabaseError(ex);
                }
                catch (Exception ex)
                {
                    HandleGeneralError(ex);
                }
            }
   
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgFamilyMembers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >=0)  // don't do anything if header row was clicked
            {
                // determine which customer was clicked
                int familyID = Convert.ToInt32(dgFamilyMembers.Rows[e.RowIndex].Cells[0].Value.ToString().Trim());
                selectedFamilyMember = context.FamilyMembers.Find(familyID);

                // modify or delete
                if (e.ColumnIndex == ModifyIndex)
                {
                    ModifyFamilyMember();
                }
                if (e.ColumnIndex == DeleteIndex)
                {
                    DeleteFamilyMember();
                }
            }
        }

        private void ModifyFamilyMember ()
        {
            var addModifyFamilyForm = new frmAddModifyFamilyMember()
            {
                AddFamilyMember = false,
                FamilyMember = selectedFamilyMember
            };

            DialogResult result = addModifyFamilyForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                try
                {
                    selectedFamilyMember = addModifyFamilyForm.FamilyMember;
                    context.SaveChanges();
                    DisplayFamilyMembers();
                }
                catch (DbUpdateConcurrencyException ex)
                {
                    HandleConcurrencyError(ex);
                }
                catch (DbUpdateException ex)
                {
                    HandleDatabaseError(ex);
                }
                catch (Exception ex)
                {
                    HandleGeneralError(ex);
                }

            }
        }

        private void DeleteFamilyMember()
        {
            DialogResult result =
                MessageBox.Show($"Delete {selectedFamilyMember.FirstName}?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    context.FamilyMembers.Remove(selectedFamilyMember);
                    context.SaveChanges();
                    DisplayFamilyMembers();
                }
                catch (DbUpdateConcurrencyException ex)
                {
                    HandleConcurrencyError(ex);
                }
                catch (DbUpdateException ex)
                {
                    HandleDatabaseError(ex);
                }
                catch (Exception ex)
                {
                    HandleGeneralError(ex);
                }
            }
        }

        private void HandleDatabaseError(DbUpdateException ex)
        {
            string errorMessage = "";
            var sqlException = (SqlException)ex.InnerException;
            foreach (SqlError error in sqlException.Errors)
            {
                errorMessage += "ERROR CODE:  " + error.Number + " " +
                                error.Message + "\n";
            }
            MessageBox.Show(errorMessage);
        }

        private void HandleConcurrencyError(DbUpdateConcurrencyException ex)
        {
            
        }

        private void HandleGeneralError(Exception ex)
        {
            MessageBox.Show(ex.Message, ex.GetType().ToString());
        }

        private void dgFamilyMembers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
