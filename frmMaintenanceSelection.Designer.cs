
namespace Photos
{
    partial class frmMaintenanceSelection
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnMaintFamilyMember = new System.Windows.Forms.Button();
            this.btnMaintOccasion = new System.Windows.Forms.Button();
            this.btnMaintPhotoDetails = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Perform Maintenance on:";
            // 
            // btnMaintFamilyMember
            // 
            this.btnMaintFamilyMember.Location = new System.Drawing.Point(69, 66);
            this.btnMaintFamilyMember.Name = "btnMaintFamilyMember";
            this.btnMaintFamilyMember.Size = new System.Drawing.Size(121, 29);
            this.btnMaintFamilyMember.TabIndex = 1;
            this.btnMaintFamilyMember.Text = "Family Member";
            this.btnMaintFamilyMember.UseVisualStyleBackColor = true;
            this.btnMaintFamilyMember.Click += new System.EventHandler(this.btnMaintFamilyMember_Click);
            // 
            // btnMaintOccasion
            // 
            this.btnMaintOccasion.Location = new System.Drawing.Point(69, 113);
            this.btnMaintOccasion.Name = "btnMaintOccasion";
            this.btnMaintOccasion.Size = new System.Drawing.Size(121, 29);
            this.btnMaintOccasion.TabIndex = 2;
            this.btnMaintOccasion.Text = "Occasion";
            this.btnMaintOccasion.UseVisualStyleBackColor = true;
            this.btnMaintOccasion.Click += new System.EventHandler(this.btnMaintOccasion_Click);
            // 
            // btnMaintPhotoDetails
            // 
            this.btnMaintPhotoDetails.Location = new System.Drawing.Point(69, 160);
            this.btnMaintPhotoDetails.Name = "btnMaintPhotoDetails";
            this.btnMaintPhotoDetails.Size = new System.Drawing.Size(121, 29);
            this.btnMaintPhotoDetails.TabIndex = 3;
            this.btnMaintPhotoDetails.Text = "Photo Details";
            this.btnMaintPhotoDetails.UseVisualStyleBackColor = true;
            this.btnMaintPhotoDetails.Click += new System.EventHandler(this.btnMaintPhotoDetails_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(179, 232);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 29);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmMaintenanceSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(256, 263);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnMaintPhotoDetails);
            this.Controls.Add(this.btnMaintOccasion);
            this.Controls.Add(this.btnMaintFamilyMember);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmMaintenanceSelection";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Maintenance";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMaintFamilyMember;
        private System.Windows.Forms.Button btnMaintOccasion;
        private System.Windows.Forms.Button btnMaintPhotoDetails;
        private System.Windows.Forms.Button btnClose;
    }
}