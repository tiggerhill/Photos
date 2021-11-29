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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        /* PM>
         * Scaffold-DbContext –Connection "Data Source=(LocalDB)\MSSQLLocalDB; AttachDBFilename=C:\Users\tony\source\repos\Photos\Photos.mdf;Integrated security=True" -Provider Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models\DataLayer -Context PhotosContext -DataAnnotations –Force
        */

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            lstYear.Items.Clear();
            lstOccasion.Items.Clear();
            lstFamilyMember.Items.Clear();


        }

        private void btnMaintenance_Click(object sender, EventArgs e)
        {
            //Form frm = new frmMaintenanceFamilyMembers();
            Form frm = new frmMaintenanceSelection();
            frm.Show();
        }
    }
}
