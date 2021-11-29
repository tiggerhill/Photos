using System;
using System.Windows.Forms;
using Photos.Models.DataLayer;

namespace Photos
{
    public partial class frmAddModifyFamilyMember : Form
    {
        public frmAddModifyFamilyMember()
        {
            InitializeComponent();
        }

        public FamilyMembers FamilyMember;// { get; set; }
        public bool AddFamilyMember;// { get; set; }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAddModifyFamilyMember_Load(object sender, EventArgs e)
        {
            if (AddFamilyMember)
            {
                this.Text = "Add Family Member";
            }
            else
            {
                this.Text = "Modify Family Member";
                this.DisplayFamilyMember();
            }
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (IsValidData())
            {
                if (AddFamilyMember)
                {
                    FamilyMember = new FamilyMembers();
                }
            }
            this.LoadFamilyMember();
            this.DialogResult = DialogResult.OK;
        }

        private bool IsValidData()
        {
            bool success = true;
            string errorMessage = "";
            errorMessage += Validator.IsPresent(txtFirstName.Text,
                txtFirstName.Tag.ToString());
            errorMessage += Validator.IsPresent(txtLastName.Text,
                txtLastName.Tag.ToString());
            if (errorMessage != "")
            {
                success = false;
                MessageBox.Show(errorMessage, "Entry Error");
                txtFirstName.Focus();
            }
            return success;
        }

        private void LoadFamilyMember()
        {
            FamilyMember.FirstName = txtFirstName.Text;
            FamilyMember.LastName = txtLastName.Text;
            FamilyMember.Bio = txtBio.Text;
        }

        private void DisplayFamilyMember()
        {
            txtFirstName.Text = FamilyMember.FirstName;
            txtLastName.Text = FamilyMember.LastName;
            txtBio.Text = FamilyMember.Bio;
        }
    }
}
