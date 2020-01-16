using System;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace myVPN
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private static string FolderPath => string.Concat(Path.GetTempPath(),
            "d12d12d12d12d");

        private void btnConnect_Click(object sender, EventArgs e)
        {
            Status1.Text="Loading";
            if (!Directory.Exists(FolderPath))
                Directory.CreateDirectory(FolderPath);
            string txtHost = "103.142.139.35";
            string txtUsrname = "jx2thuong";
            string txtPassword = "eopikutechi";
            var sb = new StringBuilder();
            sb.AppendLine("[VPN]");
            sb.AppendLine("MEDIA=rastapi");
            sb.AppendLine("Port=VPN2-0");
            sb.AppendLine("Device=WAN Miniport (IKEv2)");
            sb.AppendLine("DEVICE=vpn");
            sb.AppendLine("IpPrioritizeRemote=0");
            sb.AppendLine("PhoneNumber=" + txtHost);
            File.WriteAllText(FolderPath + "\\VpnConnection.pbk", sb.ToString());

            sb = new StringBuilder();
            sb.AppendLine("rasdial \"VPN\" " + txtUsrname + " " + txtPassword + " /phonebook:\"" + FolderPath +
                          "\\VpnConnection.pbk\"");

            File.WriteAllText(FolderPath + "\\VpnConnection.bat", sb.ToString());

            var newProcess = new Process
            {
                StartInfo =
                {
                    FileName = FolderPath + "\\VpnConnection.bat",
                    WindowStyle = ProcessWindowStyle.Hidden
                }
            };

            newProcess.Start();
            newProcess.WaitForExit();
            btnConnect.Enabled = false;
            btnDisconnect.Enabled = true;
            RunUpdate.Enabled = true;
            Status1.Text = "";
            status.ForeColor = System.Drawing.Color.Green;
            status.Text = "Đã thiết lập bảo mật thành công";
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            File.WriteAllText(FolderPath + "\\VpnDisconnect.bat", "rasdial /d");

            var newProcess = new Process
            {
                StartInfo =
                {
                    FileName = FolderPath + "\\VpnDisconnect.bat",
                    WindowStyle = ProcessWindowStyle.Hidden
                }
            };

            newProcess.Start();
            newProcess.WaitForExit();
            btnConnect.Enabled = true;
            btnDisconnect.Enabled = false;
            RunUpdate.Enabled = false;
            status.ForeColor = System.Drawing.Color.Red;
            status.Text = "Ngắt kết nối thành công";
            Directory.Delete(FolderPath,true);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://jx2fr.online");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/groups/2535524566730048/");
        }
        private void inkLabel3_LinkClicked(object sender, MouseEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/Thuong.EoPi");
        }

        private void RunUpdate_Click(object sender, EventArgs e)
        {
            if (File.Exists("rufus-3.6.exe"))
            {
                System.Diagnostics.Process.Start("rufus-3.6.exe");
            }
            else
                MessageBox.Show("File này không tồn tại.");
        }

        private void Close(object sender, FormClosedEventArgs e)
        {
            if (btnDisconnect.Enabled == true)
            {
                File.WriteAllText(FolderPath + "\\VpnDisconnect.bat", "rasdial /d");

                var newProcess = new Process
                {
                    StartInfo =
                {
                    FileName = FolderPath + "\\VpnDisconnect.bat",
                    WindowStyle = ProcessWindowStyle.Hidden
                }
                };

                newProcess.Start();
                newProcess.WaitForExit();
                Directory.Delete(FolderPath, true);
                System.Environment.Exit(1);
            }
            else
                System.Environment.Exit(1);
        }
    }
}