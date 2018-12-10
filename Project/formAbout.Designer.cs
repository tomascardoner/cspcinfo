namespace CSPCInfo
{
    partial class formAbout
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
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelVersion = new System.Windows.Forms.Label();
            this.buttonOk = new System.Windows.Forms.Button();
            this.labelCopyright = new System.Windows.Forms.Label();
            this.linkWebAddress = new System.Windows.Forms.LinkLabel();
            this.pictureboxIcon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(12, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(288, 25);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Title";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelVersion
            // 
            this.labelVersion.Location = new System.Drawing.Point(12, 34);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(288, 19);
            this.labelVersion.TabIndex = 1;
            this.labelVersion.Text = "Version";
            this.labelVersion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonOk
            // 
            this.buttonOk.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonOk.Location = new System.Drawing.Point(125, 151);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(59, 27);
            this.buttonOk.TabIndex = 2;
            this.buttonOk.Text = "&Ok";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // labelCopyright
            // 
            this.labelCopyright.Location = new System.Drawing.Point(12, 74);
            this.labelCopyright.Name = "labelCopyright";
            this.labelCopyright.Size = new System.Drawing.Size(288, 19);
            this.labelCopyright.TabIndex = 3;
            this.labelCopyright.Text = "Copyright";
            this.labelCopyright.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // linkWebAddress
            // 
            this.linkWebAddress.Location = new System.Drawing.Point(12, 111);
            this.linkWebAddress.Name = "linkWebAddress";
            this.linkWebAddress.Size = new System.Drawing.Size(288, 19);
            this.linkWebAddress.TabIndex = 5;
            this.linkWebAddress.TabStop = true;
            this.linkWebAddress.Text = "www.cardonersistemas.com.ar";
            this.linkWebAddress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.linkWebAddress.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkWebAddress_LinkClicked);
            // 
            // pictureboxIcon
            // 
            this.pictureboxIcon.Location = new System.Drawing.Point(12, 12);
            this.pictureboxIcon.Name = "pictureboxIcon";
            this.pictureboxIcon.Size = new System.Drawing.Size(40, 40);
            this.pictureboxIcon.TabIndex = 6;
            this.pictureboxIcon.TabStop = false;
            // 
            // formAbout
            // 
            this.AcceptButton = this.buttonOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonOk;
            this.ClientSize = new System.Drawing.Size(312, 190);
            this.Controls.Add(this.pictureboxIcon);
            this.Controls.Add(this.linkWebAddress);
            this.Controls.Add(this.labelCopyright);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.labelVersion);
            this.Controls.Add(this.labelTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "About";
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelVersion;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Label labelCopyright;
        private System.Windows.Forms.LinkLabel linkWebAddress;
        private System.Windows.Forms.PictureBox pictureboxIcon;
    }
}