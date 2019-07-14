namespace eventsRegisterInterface
{
    partial class frmListUser
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
            this.components = new System.ComponentModel.Container();
            this.dtgridUsers = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNamePage = new System.Windows.Forms.Label();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dtgridUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgridUsers
            // 
            this.dtgridUsers.AllowUserToAddRows = false;
            this.dtgridUsers.AllowUserToDeleteRows = false;
            this.dtgridUsers.AllowUserToResizeColumns = false;
            this.dtgridUsers.AllowUserToResizeRows = false;
            this.dtgridUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgridUsers.Location = new System.Drawing.Point(12, 112);
            this.dtgridUsers.MultiSelect = false;
            this.dtgridUsers.Name = "dtgridUsers";
            this.dtgridUsers.ReadOnly = true;
            this.dtgridUsers.RowHeadersWidth = 45;
            this.dtgridUsers.Size = new System.Drawing.Size(487, 305);
            this.dtgridUsers.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(12, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(487, 2);
            this.label1.TabIndex = 28;
            // 
            // lblNamePage
            // 
            this.lblNamePage.AutoSize = true;
            this.lblNamePage.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNamePage.ForeColor = System.Drawing.Color.DimGray;
            this.lblNamePage.Location = new System.Drawing.Point(6, 43);
            this.lblNamePage.Name = "lblNamePage";
            this.lblNamePage.Size = new System.Drawing.Size(251, 31);
            this.lblNamePage.TabIndex = 27;
            this.lblNamePage.Text = "Listado de usuarios";
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(eventsRegisterInterface.User);
            // 
            // frmListUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 429);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNamePage);
            this.Controls.Add(this.dtgridUsers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmListUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            ((System.ComponentModel.ISupportInitialize)(this.dtgridUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgridUsers;
        private System.Windows.Forms.BindingSource userBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNamePage;
    }
}