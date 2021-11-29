using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Photos
{
    public partial class frmMaintenanceSelection : Form
    {
        public frmMaintenanceSelection()
        {
            InitializeComponent();
        }

        private void btnMaintFamilyMember_Click(object sender, EventArgs e)
        {
            Form frm = new frmMaintenanceFamilyMembers();
            frm.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMaintOccasion_Click(object sender, EventArgs e)
        {
            Form frm = new frmMaintenanceOccasions();
            frm.Show();
        }

        private void btnMaintPhotoDetails_Click(object sender, EventArgs e)
        {
            Form frm = new frmMaintenancePhotos();
            frm.Show();
        }
    }
}
