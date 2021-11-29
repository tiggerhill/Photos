
namespace Photos
{
    partial class frmMaintenanceFamilyMembers
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgFamilyMembers = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgFamilyMembers)).BeginInit();
            this.SuspendLayout();
            // 
            // dgFamilyMembers
            // 
            this.dgFamilyMembers.AllowUserToAddRows = false;
            this.dgFamilyMembers.AllowUserToDeleteRows = false;
            this.dgFamilyMembers.AllowUserToOrderColumns = true;
            this.dgFamilyMembers.Location = new System.Drawing.Point(8, 10);
            this.dgFamilyMembers.Margin = new System.Windows.Forms.Padding(1);
            this.dgFamilyMembers.Name = "dgFamilyMembers";
            this.dgFamilyMembers.ReadOnly = true;
            this.dgFamilyMembers.RowTemplate.Height = 33;
            this.dgFamilyMembers.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgFamilyMembers.Size = new System.Drawing.Size(606, 223);
            this.dgFamilyMembers.TabIndex = 2;
            this.dgFamilyMembers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgFamilyMembers_CellClick);
            this.dgFamilyMembers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgFamilyMembers_CellContentClick);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(8, 255);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(1);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(60, 27);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "&Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(554, 255);
            this.btnExit.Margin = new System.Windows.Forms.Padding(1);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(60, 27);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "&Close";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmMaintenanceFamilyMembers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 288);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgFamilyMembers);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "frmMaintenanceFamilyMembers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Family Member Maintenance";
            this.Load += new System.EventHandler(this.frmMaintenance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgFamilyMembers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgFamilyMembers;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnExit;
    }
}