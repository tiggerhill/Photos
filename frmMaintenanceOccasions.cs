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
    public partial class frmMaintenanceOccasions : Form
    {
        public frmMaintenanceOccasions()
        {
            InitializeComponent();
        }

        private PhotosContext context = new PhotosContext();
        private Occasions selectedOccasion;

        // constants for the index values of the modify and delete buttons
        private const int ModifyIndex = 4;
        private const int DeleteIndex = 5;

        private void frmMaintenanceOccasions_Load(object sender, EventArgs e)
        {
            DisplayOccasions();
        }

        private void DisplayOccasions()
        {
            dgOccasions.Columns.Clear();

            // count number of occasions
            var query = context.Occasions
                .OrderBy(o => o.OccasionName)
                .Select(o => new { o.Id, o.OccasionName, o.Year, o.Notes })
                .ToList();

            // bind results of LINQ query to the DataGrid
            dgOccasions.DataSource = query;

            // set the visible property so this column isn't displayed
            dgOccasions.Columns[0].Visible = false;

            // format grid
            dgOccasions.AutoResizeColumns();
            // column header
            dgOccasions.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9, FontStyle.Bold);
            // change colors on alternating rows for readability
            dgOccasions.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige;

            // add two button columns and two buttons to the grid
            var modifyColumn = new DataGridViewButtonColumn()
            {
                UseColumnTextForButtonValue = true,
                HeaderText = "Modify Occasion",
                Text = "Modify",
                Name = "colModify"
            };
            dgOccasions.Columns.Insert(ModifyIndex, modifyColumn);

            var deleteColumn = new DataGridViewButtonColumn()
            {
                UseColumnTextForButtonValue = true,
                HeaderText = "Delete Occasion",
                Text = "Delete",
                Name = "colDelete"
            };
            dgOccasions.Columns.Insert(DeleteIndex, deleteColumn);

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var addModifyOccasionForm = new frmAddModifyOccasion()
            {
                AddOccasion = true
            };
            DialogResult result = addModifyOccasionForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                try
                {
                    selectedOccasion = addModifyOccasionForm.Occasion;
                    context.Occasions.Add(selectedOccasion);
                    context.SaveChanges();
                    DisplayOccasions();
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

        private void dgOccasions_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // don't do anhything if header row was clicked
            {
                // determine which occasion was clicked
                int occasionID = Convert.ToInt32(dgOccasions.Rows[e.RowIndex].Cells[0].Value.ToString().Trim());
                selectedOccasion = context.Occasions.Find(occasionID);

                // modify or delete
                if (e.ColumnIndex == ModifyIndex)
                {
                    ModifyOccasion();
                }
                if (e.ColumnIndex == DeleteIndex)
                {
                    DeleteOccasion();
                }
            }
        }

        private void ModifyOccasion()
        {
            var addModifyOcassionForm = new frmAddModifyOccasion()
            {
                AddOccasion = false,
                Occasion = selectedOccasion

            };

            DialogResult result = addModifyOcassionForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                try
                {
                    selectedOccasion = addModifyOcassionForm.Occasion;
                    context.SaveChanges();
                    DisplayOccasions();
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

        private void DeleteOccasion()
        {
            DialogResult result =
                MessageBox.Show($"Delete {selectedOccasion.OccasionName}?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    context.Occasions.Remove(selectedOccasion);
                    context.SaveChanges();
                    DisplayOccasions();
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


    }
}
