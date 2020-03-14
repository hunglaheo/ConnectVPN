using System;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Net.NetworkInformation;
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
            Status1.Text = "Loading";
            if (!Directory.Exists(FolderPath))
                Directory.CreateDirectory(FolderPath);
            //string txtHost = "103.142.139.35";
            string txtUsrname = "loliteam";
            string txtPassword = "Hungkute@)@)";
            var sb = new StringBuilder();
            sb.AppendLine("[VPN]");
            sb.AppendLine("Encoding=1");
            sb.AppendLine("PBVersion=5");
            sb.AppendLine("Type=2");
            sb.AppendLine("AutoLogon=0");
            sb.AppendLine("UseRasCredentials=1");
            sb.AppendLine("LowDateTime=1329103376");
            sb.AppendLine("HighDateTime=30788644");
            sb.AppendLine("DialParamsUID=180541562");
            sb.AppendLine("Guid=CFC43CF33182064990833D158F143E7E");
            sb.AppendLine("VpnStrategy=2");
            sb.AppendLine("ExcludedProtocols=0");
            sb.AppendLine("LcpExtensions=1");
            sb.AppendLine("DataEncryption=256");
            sb.AppendLine("SwCompression=1");
            sb.AppendLine("NegotiateMultilinkAlways=0");
            sb.AppendLine("SkipDoubleDialDialog=0");
            sb.AppendLine("DialMode=1");
            sb.AppendLine("OverridePref=15");
            sb.AppendLine("RedialAttempts=3");
            sb.AppendLine("RedialSeconds=60");
            sb.AppendLine("IdleDisconnectSeconds=0");
            sb.AppendLine("RedialOnLinkFailure=0");
            sb.AppendLine("CallbackMode=0");
            sb.AppendLine("CustomDialDll=");
            sb.AppendLine("CustomDialFunc=");
            sb.AppendLine("CustomRasDialDll=");
            sb.AppendLine("ForceSecureCompartment=0");
            sb.AppendLine("DisableIKENameEkuCheck=0");
            sb.AppendLine("AuthenticateServer=0");
            sb.AppendLine("ShareMsFilePrint=1");
            sb.AppendLine("BindMsNetClient=1");
            sb.AppendLine("SharedPhoneNumbers=0");
            sb.AppendLine("GlobalDeviceSettings=0");
            sb.AppendLine("PrerequisiteEntry=");
            sb.AppendLine("PrerequisitePbk=");
            sb.AppendLine("PreferredPort=VPN2-0");
            sb.AppendLine("PreferredDevice=WAN Miniport (IKEv2)");
            sb.AppendLine("PreferredBps=0");
            sb.AppendLine("PreferredHwFlow=1");
            sb.AppendLine("PreferredProtocol=1");
            sb.AppendLine("PreferredCompression=1");
            sb.AppendLine("PreferredSpeaker=1");
            sb.AppendLine("PreferredMdmProtocol=0");
            sb.AppendLine("PreviewUserPw=1");
            sb.AppendLine("PreviewDomain=1");
            sb.AppendLine("PreviewPhoneNumber=0");
            sb.AppendLine("ShowDialingProgress=1");
            sb.AppendLine("ShowMonitorIconInTaskBar=1");
            sb.AppendLine("CustomAuthKey=0");
            sb.AppendLine("AuthRestrictions=544");
            sb.AppendLine("IpPrioritizeRemote=1");
            sb.AppendLine("IpInterfaceMetric=0");
            sb.AppendLine("IpHeaderCompression=0");
            sb.AppendLine("IpAddress=0.0.0.0");
            sb.AppendLine("IpDnsAddress=0.0.0.0");
            sb.AppendLine("IpDns2Address=0.0.0.0");
            sb.AppendLine("IpWinsAddress=0.0.0.0");
            sb.AppendLine("IpWins2Address=0.0.0.0");
            sb.AppendLine("IpAssign=1");
            sb.AppendLine("IpNameAssign=1");
            sb.AppendLine("IpDnsFlags=0");
            sb.AppendLine("IpNBTFlags=1");
            sb.AppendLine("TcpWindowSize=0");
            sb.AppendLine("UseFlags=2");
            sb.AppendLine("IpSecFlags=0");
            sb.AppendLine("IpDnsSuffix=");
            sb.AppendLine("Ipv6Assign=1");
            sb.AppendLine("Ipv6Address=::");
            sb.AppendLine("Ipv6PrefixLength=0");
            sb.AppendLine("Ipv6PrioritizeRemote=1");
            sb.AppendLine("Ipv6InterfaceMetric=0");
            sb.AppendLine("Ipv6NameAssign=1");
            sb.AppendLine("Ipv6DnsAddress=::");
            sb.AppendLine("Ipv6Dns2Address=::");
            sb.AppendLine("Ipv6Prefix=0000000000000000");
            sb.AppendLine("Ipv6InterfaceId=0000000000000000");
            sb.AppendLine("DisableClassBasedDefaultRoute=0");
            sb.AppendLine("DisableMobility=0");
            sb.AppendLine("NetworkOutageTime=0");
            sb.AppendLine("IDI=");
            sb.AppendLine("IDR=");
            sb.AppendLine("ImsConfig=0");
            sb.AppendLine("IdiType=0");
            sb.AppendLine("IdrType=0");
            sb.AppendLine("ProvisionType=0");
            sb.AppendLine("PreSharedKey=");
            sb.AppendLine("CacheCredentials=1");
            sb.AppendLine("NumCustomPolicy=0");
            sb.AppendLine("NumEku=0");
            sb.AppendLine("UseMachineRootCert=0");
            sb.AppendLine("Disable_IKEv2_Fragmentation=0");
            sb.AppendLine("NumServers=0");
            sb.AppendLine("RouteVersion=1");
            sb.AppendLine("NumRoutes=0");
            sb.AppendLine("NumNrptRules=0");
            sb.AppendLine("AutoTiggerCapable=0");
            sb.AppendLine("NumAppIds=0");
            sb.AppendLine("NumClassicAppIds=0");
            sb.AppendLine("SecurityDescriptor=");
            sb.AppendLine("ApnInfoProviderId=");
            sb.AppendLine("ApnInfoUsername=");
            sb.AppendLine("ApnInfoPassword=");
            sb.AppendLine("ApnInfoAccessPoint=");
            sb.AppendLine("ApnInfoAuthentication=1");
            sb.AppendLine("ApnInfoCompression=0");
            sb.AppendLine("DeviceComplianceEnabled=0");
            sb.AppendLine("DeviceComplianceSsoEnabled=0");
            sb.AppendLine("DeviceComplianceSsoEku=");
            sb.AppendLine("DeviceComplianceSsoIssuer=");
            sb.AppendLine("FlagsSet=0");
            sb.AppendLine("Options=0");
            sb.AppendLine("DisableDefaultDnsSuffixes=0");
            sb.AppendLine("NumTrustedNetworks=0");
            sb.AppendLine("NumDnsSearchSuffixes=0");
            sb.AppendLine("PowershellCreatedProfile=0");
            sb.AppendLine("ProxyFlags=0");
            sb.AppendLine("ProxySettingsModified=0");
            sb.AppendLine("ProvisioningAuthority=");
            sb.AppendLine("AuthTypeOTP=0");
            sb.AppendLine("GREKeyDefined=0");
            sb.AppendLine("NumPerAppTrafficFilters=0");
            sb.AppendLine("AlwaysOnCapable=0");
            sb.AppendLine("DeviceTunnel=0");
            sb.AppendLine("PrivateNetwork=0");
            sb.AppendLine("");
            sb.AppendLine("NETCOMPONENTS=");
            sb.AppendLine("ms_server=1");
            sb.AppendLine("ms_msclient=1");
            sb.AppendLine("");
            sb.AppendLine("MEDIA=rastapi");
            sb.AppendLine("Port=VPN2-0");
            sb.AppendLine("Device=WAN Miniport (IKEv2)");
            sb.AppendLine("");
            sb.AppendLine("DEVICE=vpn");
            sb.AppendLine("PhoneNumber=45.119.84.52");
            sb.AppendLine("AreaCode=");
            sb.AppendLine("CountryCode=0");
            sb.AppendLine("CountryID=0");
            sb.AppendLine("UseDialingRules=0");
            sb.AppendLine("Comment=");
            sb.AppendLine("FriendlyName=");
            sb.AppendLine("LastSelectedPhone=0");
            sb.AppendLine("PromoteAlternates=0");
            sb.AppendLine("TryNextAlternateOnFail=1");
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
            bool statusvpn = false;
            if (NetworkInterface.GetIsNetworkAvailable())
            {
                NetworkInterface[] interfaces = NetworkInterface.GetAllNetworkInterfaces();
                foreach (NetworkInterface Interface in interfaces)
                {
                    if (Interface.OperationalStatus == OperationalStatus.Up)
                    {
                        if ((Interface.NetworkInterfaceType == NetworkInterfaceType.Ppp) && (Interface.NetworkInterfaceType != NetworkInterfaceType.Loopback))
                        {
                            statusvpn = true;
                        }
                    }
                }
            }
            if (statusvpn)
            {
                btnConnect.Enabled = false;
                btnDisconnect.Enabled = true;
                RunUpdate.Enabled = true;
                Status1.Text = "";
                status.ForeColor = System.Drawing.Color.Green;
                status.Text = "Đã thiết lập bảo mật thành công";
            }
            else
            {
                Status1.Text = "";
                status.ForeColor = System.Drawing.Color.Red;
                status.Text = "Đã thiết lập bảo mật thất bại";
            }
           
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
            Directory.Delete(FolderPath, true);
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
            if (File.Exists("AutoUpdate.exe"))
            {
                System.Diagnostics.Process.Start("AutoUpdate.exe");
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