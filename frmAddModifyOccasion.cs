using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Photos.Models.DataLayer;

namespace Photos
{
    public partial class frmAddModifyOccasion : Form
    {
        public frmAddModifyOccasion()
        {
            InitializeComponent();
        }

        public Occasions Occasion { get; set; }
        public bool AddOccasion { get; set; }

        private void frmAddModifyOccasion_Load(object sender, EventArgs e)
        {
            if (AddOccasion)
            {
                this.Text = "Add Occasion";
            }
            else
            {
                this.Text = "Modify Occasion";
                this.DisplayOccasion();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (IsValidData())
            {
                if (AddOccasion)
                {
                    Occasion = new Occasions();
                }
                this.LoadOccasion();
                this.DialogResult = DialogResult.OK;
            }
        }

        private void LoadOccasion()
        {
            Occasion.OccasionName = txtOccasionName.Text;
            Occasion.Year = txtOccasionYear.Text;
            Occasion.Notes = txtOccasionNotes.Text;
        }

        private bool IsValidData()
        {
            bool success = true;


            return success;
        }

        private void DisplayOccasion()
        {
            txtOccasionName.Text = Occasion.OccasionName;
            txtOccasionYear.Text = Occasion.Year;
            txtOccasionNotes.Text = Occasion.Notes;
        }
    }
}
