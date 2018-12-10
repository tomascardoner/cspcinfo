namespace CSPCInfo
{
    partial class formMain
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
            this.Icon = Properties.Resources.APPLICATION_32;

            this.labelComputerName = new System.Windows.Forms.Label();
            this.textboxCampouterName = new System.Windows.Forms.TextBox();
            this.listviewNetworkInterfaces = new System.Windows.Forms.ListView();
            this.columnName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnDescription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnMACAddress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnIPAddress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelNetworkAdapters = new System.Windows.Forms.Label();
            this.buttonAbout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelComputerName
            // 
            this.labelComputerName.AutoSize = true;
            this.labelComputerName.Location = new System.Drawing.Point(12, 15);
            this.labelComputerName.Name = "labelComputerName";
            this.labelComputerName.Size = new System.Drawing.Size(84, 13);
            this.labelComputerName.TabIndex = 0;
            this.labelComputerName.Text = "Computer name:";
            // 
            // textboxCampouterName
            // 
            this.textboxCampouterName.Location = new System.Drawing.Point(121, 12);
            this.textboxCampouterName.Name = "textboxCampouterName";
            this.textboxCampouterName.ReadOnly = true;
            this.textboxCampouterName.Size = new System.Drawing.Size(176, 20);
            this.textboxCampouterName.TabIndex = 1;
            // 
            // listviewNetworkInterfaces
            // 
            this.listviewNetworkInterfaces.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listviewNetworkInterfaces.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnName,
            this.columnDescription,
            this.columnStatus,
            this.columnMACAddress,
            this.columnIPAddress});
            this.listviewNetworkInterfaces.FullRowSelect = true;
            this.listviewNetworkInterfaces.GridLines = true;
            this.listviewNetworkInterfaces.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listviewNetworkInterfaces.Location = new System.Drawing.Point(12, 74);
            this.listviewNetworkInterfaces.MultiSelect = false;
            this.listviewNetworkInterfaces.Name = "listviewNetworkInterfaces";
            this.listviewNetworkInterfaces.ShowItemToolTips = true;
            this.listviewNetworkInterfaces.Size = new System.Drawing.Size(437, 183);
            this.listviewNetworkInterfaces.TabIndex = 7;
            this.listviewNetworkInterfaces.UseCompatibleStateImageBehavior = false;
            this.listviewNetworkInterfaces.View = System.Windows.Forms.View.Details;
            // 
            // columnName
            // 
            this.columnName.Text = "Name";
            this.columnName.Width = 150;
            // 
            // columnDescription
            // 
            this.columnDescription.Text = "Description";
            this.columnDescription.Width = 220;
            // 
            // columnStatus
            // 
            this.columnStatus.Text = "Status";
            this.columnStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnMACAddress
            // 
            this.columnMACAddress.Text = "MAC Address";
            this.columnMACAddress.Width = 120;
            // 
            // columnIPAddress
            // 
            this.columnIPAddress.Text = "IPAddress";
            this.columnIPAddress.Width = 100;
            // 
            // labelNetworkAdapters
            // 
            this.labelNetworkAdapters.AutoSize = true;
            this.labelNetworkAdapters.Location = new System.Drawing.Point(12, 55);
            this.labelNetworkAdapters.Name = "labelNetworkAdapters";
            this.labelNetworkAdapters.Size = new System.Drawing.Size(94, 13);
            this.labelNetworkAdapters.TabIndex = 8;
            this.labelNetworkAdapters.Text = "Network adapters:";
            // 
            // buttonAbout
            // 
            this.buttonAbout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAbout.Location = new System.Drawing.Point(388, 12);
            this.buttonAbout.Name = "buttonAbout";
            this.buttonAbout.Size = new System.Drawing.Size(61, 20);
            this.buttonAbout.TabIndex = 9;
            this.buttonAbout.Text = "About...";
            this.buttonAbout.UseVisualStyleBackColor = true;
            this.buttonAbout.Click += new System.EventHandler(this.buttonAbout_Click);
            // 
            // formMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 269);
            this.Controls.Add(this.buttonAbout);
            this.Controls.Add(this.labelNetworkAdapters);
            this.Controls.Add(this.listviewNetworkInterfaces);
            this.Controls.Add(this.textboxCampouterName);
            this.Controls.Add(this.labelComputerName);
            this.Name = "formMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Title";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.formMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelComputerName;
        private System.Windows.Forms.TextBox textboxCampouterName;
        private System.Windows.Forms.ListView listviewNetworkInterfaces;
        private System.Windows.Forms.ColumnHeader columnName;
        private System.Windows.Forms.ColumnHeader columnDescription;
        private System.Windows.Forms.ColumnHeader columnStatus;
        private System.Windows.Forms.ColumnHeader columnIPAddress;
        private System.Windows.Forms.ColumnHeader columnMACAddress;
        private System.Windows.Forms.Label labelNetworkAdapters;
        private System.Windows.Forms.Button buttonAbout;
    }
}

