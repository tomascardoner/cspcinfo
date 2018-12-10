using System;
using System.Net.NetworkInformation;
using System.Windows.Forms;

namespace CSPCInfo
{
    public partial class formMain : Form
    {
        public formMain()
        {
            InitializeComponent();
        }

        private void formMain_Load(object sender, EventArgs e)
        {
            this.Text = CardonerSistemas.My.Application.Info.Title;

            InitializeNetworkInterfacesListView();

            GetNetworkInfo();
        }

        private void InitializeNetworkInterfacesListView()
        {
            // Create groups
            foreach (int enumValue in Enum.GetValues(typeof(NetworkInterfaceType)))
            {
                ListViewGroup newlvg = new ListViewGroup("listviewgroup" + enumValue, Enum.GetName(typeof(NetworkInterfaceType), enumValue));
                listviewNetworkInterfaces.Groups.Add(newlvg);
            }
        }

        private void GetNetworkInfo()
        {
            textboxCampouterName.Text = Environment.MachineName;

            foreach (NetworkInterface ni in NetworkInterface.GetAllNetworkInterfaces())
            {
                ListViewItem newlvi = new ListViewItem(ni.Name);
                newlvi.Group = listviewNetworkInterfaces.Groups["listviewgroup" + (int)ni.NetworkInterfaceType];
                newlvi.SubItems.Add(ni.Description);
                newlvi.SubItems.Add(Enum.GetName(typeof(OperationalStatus), (int)ni.OperationalStatus));
                newlvi.SubItems.Add(CardonerSistemas.Network.FormatMACAddress(ni.GetPhysicalAddress().ToString()));

                foreach (UnicastIPAddressInformation uipai in ni.GetIPProperties().UnicastAddresses)
                {
                    if (uipai.Address.AddressFamily != System.Net.Sockets.AddressFamily.InterNetworkV6)
                    {
                        newlvi.SubItems.Add(uipai.Address.ToString());
                        break;
                    }
                }

                listviewNetworkInterfaces.Items.Add(newlvi);
            }
        }

        private void buttonAbout_Click(object sender, EventArgs e)
        {
            new formAbout().ShowDialog(this);
        }
    }
}
