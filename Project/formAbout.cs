using System;
using System.Drawing;
using System.Windows.Forms;

namespace CSPCInfo
{
    public partial class formAbout : Form
    {
        public formAbout()
        {
            InitializeComponent();

            pictureboxIcon.Image = Bitmap.FromHicon(Properties.Resources.APPLICATION_32.Handle);
            labelTitle.Text = CardonerSistemas.My.Application.Info.Title;
            labelVersion.Text = CardonerSistemas.My.Application.Info.Version.ToString();
            labelCopyright.Text = CardonerSistemas.My.Application.Info.Copyright;
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkWebAddress_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(linkWebAddress.Text);
        }
    }
}
