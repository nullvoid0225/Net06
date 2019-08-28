using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Configuration;

using NativeWifi;
using System.Threading;
using System.IO;

using System.Net.NetworkInformation;

namespace Net06
{
    public partial class Form1 : Form
    {
        private static Form1 staticForm;

        public Form1()
        {
            InitializeComponent();
            staticForm = this;
        }

        //ip change
        string OrgNICName = "";
        string OrgIPAdress = "";
        string OrgSubnet = "";
        string OrgGateway = "";
        IPChange ip = new IPChange();

        //wifi scanner
        WlanClient wlanClient = new WlanClient();
        Thread thrAP = null;
        private delegate void OnWifiDelegate(ListViewItem lvi, bool f);
        private OnWifiDelegate OnWifi = null;



        private void Form1_Load(object sender, EventArgs e)
        {
            //ip change
            OrgNICName = ConfigurationManager.AppSettings["NICName"];
            OrgIPAdress = ConfigurationManager.AppSettings["IPAdress"];
            OrgSubnet = ConfigurationManager.AppSettings["Subnet"];
            OrgGateway = ConfigurationManager.AppSettings["Gateway"];

            this.Text = " [" +OrgNICName + "] [" + OrgIPAdress + "] [" + OrgSubnet + "] [" + OrgGateway + "]";

            //wifi scanner
            OnWifi = new OnWifiDelegate(OnWifiView);
            thrAP = new Thread(ThreadList);
            thrAP.Start();

            //Net Check
            Init_Net_Check();
        }

        //@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
        // ip change

        private void btnChange_Click(object sender, EventArgs e)
        {
            if (this.txtIp.Text == "")
            {
                MessageBox.Show("아이피가 입력되지 않았습니다.", "알림",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtIp.Focus();
            }
            else if (this.txtSubnet.Text == "")
            {
                MessageBox.Show("서브넷이 입력되지 않았습니다.", "알림",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtSubnet.Focus();
            }
            else if (this.txtGateway.Text == "")
            {
                MessageBox.Show("게이트웨이가 입력되지 않았습니다.", "알림",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtGateway.Focus();
            }
            else
            {
                bool Result = ip.IPChangeRun(OrgNICName, this.txtIp.Text,
                    this.txtSubnet.Text, this.txtGateway.Text);
                if (Result == true)
                {
                    MessageBox.Show("아이피 정보가 정상적으로 변경되었습니다.", "알림",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("아이피 정보가 정상적으로 변경되지 않았습니다.", "알림",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            bool Result = ip.IPChangeRun(OrgNICName, OrgIPAdress, OrgSubnet, OrgGateway);
            if (Result == true)
            {
                MessageBox.Show("아이피 정보가 정상적으로 변경되었습니다.", "알림",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("아이피 정보가 정상적으로 변경되지 않았습니다.", "알림",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDHCP_Click(object sender, EventArgs e)
        {
            bool Result = ip.IPChangeRun(OrgNICName, "", "", "");
            if (Result == true)
            {
                MessageBox.Show("아이피 정보가 정상적으로 변경되었습니다.", "알림",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("아이피 정보가 정상적으로 변경되지 않았습니다.", "알림",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
        // wifi scanner

        private void OnWifiView(ListViewItem lvi, bool f)
        {
            if (f == true)
                this.lvAP.Items.Add(lvi);
            else
                this.lvAP.Items.Clear();
        }

        private void ThreadList()
        {
            while (true)
            {
                Invoke(OnWifi, null, false);
                Wlan.WlanAvailableNetwork[] wlanBssEntries =
                    wlanClient.Interfaces[0].GetAvailableNetworkList(0);
                foreach (Wlan.WlanAvailableNetwork network in wlanBssEntries)
                {
                    var lvt = new ListViewItem(new string[] {
                        GetStringForSSID(network.dot11Ssid),
                        network.wlanSignalQuality.ToString(),
                        network.securityEnabled.ToString(),
                        GetMacChanel(1, ConvertToMAC(network.dot11Ssid.SSID)),
                        network.dot11DefaultCipherAlgorithm.ToString(),
                        network.dot11DefaultAuthAlgorithm.ToString(),
                        GetMacChanel(2, ConvertToMAC(network.dot11Ssid.SSID)) });
                    Invoke(OnWifi, lvt, true);
                }
                Thread.Sleep(10000);
            }
        }
        private string GetMacChanel(int i, string Name)
        {
            Wlan.WlanBssEntry[] lstWlanBss =
                wlanClient.Interfaces[0].GetNetworkBssList();
            var reAP = "";
            foreach (var oWlan in lstWlanBss)
            {
                if (i == 2)
                {
                    if (ConvertToMAC(oWlan.dot11Ssid.SSID) == Name)
                    {
                        reAP = ConvertToMAC(oWlan.dot11Bssid);
                    }
                }
                else if (i == 1)
                {
                    if (ConvertToMAC(oWlan.dot11Ssid.SSID) == Name)
                    {
                        var chnl = oWlan.chCenterFrequency.ToString();
                        switch (chnl)
                        {
                            case "2412000":
                                reAP = "1";
                                break;
                            case "2417000":
                                reAP = "2";
                                break;
                            case "2422000":
                                reAP = "3";
                                break;
                            case "2427000":
                                reAP = "4";
                                break;
                            case "2432000":
                                reAP = "5";
                                break;
                            case "2437000":
                                reAP = "6";
                                break;
                            case "2442000":
                                reAP = "7";
                                break;
                            case "2447000":
                                reAP = "8";
                                break;
                            case "2452000":
                                reAP = "9";
                                break;
                            case "2457000":
                                reAP = "10";
                                break;
                            case "2462000":
                                reAP = "11";
                                break;
                            case "2467000":
                                reAP = "12";
                                break;
                            case "2472000":
                                reAP = "13";
                                break;
                        }
                    }

                }
            }
            return reAP;
        }
        string ConvertToMAC(byte[] MAC)
        {
            string strMAC = "";
            for (int index = 0; index < 6; index++)
                strMAC += MAC[index].ToString("X2") + "-";
            return strMAC.Substring(0, strMAC.Length - 1);
        }

        static string GetStringForSSID(Wlan.Dot11Ssid ssid)
        {
            return Encoding.ASCII.GetString(ssid.SSID,
                0, (int)ssid.SSIDLength);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.thrAP != null)
                thrAP.Abort();
            Application.ExitThread();
        }


        //@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
        // Net Check

        public static string HostNameEntry = "";
        public static string DescriptionEntry = "";
        public static int Hostcount = 0;

        public NetCheck nc;

        public void Init_Net_Check()
        {
            this.tslcbTime.Text = "5 초";
            MainConfig();

            nc = new NetCheck();
        }

        private void MainConfig()
        {
            if (File.Exists("ICMPConfig.ini") == true)
            {
                string ss = string.Empty;
                using (StreamReader sr = new StreamReader("ICMPConfig.ini"))
                {
                    ss = sr.ReadLine();
                    while (ss != null)
                    {
                        HostNameEntry = sr.ReadLine();
                        DescriptionEntry = sr.ReadLine();
                        AddList(HostNameEntry, DescriptionEntry);
                        ss = sr.ReadLine();
                    }
                    sr.Close();
                }
            }
        }

        public static void AddList(string AnyHostEntry, string DescriptionEntry)
        {
            string[] Entry = new string[8];

            Entry[0] = AnyHostEntry;
            Entry[1] = DescriptionEntry;
            int hold = 0;

            ListViewItem Entries = new ListViewItem(Entry);
            staticForm.lvStatus.Items.Add(Entries);
            Hostcount = Hostcount + 1;
            for (int column = 2; column < 7; column++)
                if (column < 6)
                    staticForm.lvStatus.Items[Hostcount - 1].SubItems[column].Text = hold.ToString();
                else
                    staticForm.lvStatus.Items[Hostcount - 1].SubItems[column].Text = "";

            staticForm.lvStatus.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            staticForm.lvStatus.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void tslcbTime_Click(object sender, EventArgs e)
        {
            switch (this.tslcbTime.Text)
            {
                case "5 초":
                    this.Timer.Interval = 5000;
                    break;
                case "10 초":
                    this.Timer.Interval = 10000;
                    break;
                case "15 초":
                    this.Timer.Interval = 15000;
                    break;
                case "20 초":
                    this.Timer.Interval = 20000;
                    break;
                case "30 초":
                    this.Timer.Interval = 30000;
                    break;
            }
        }

        private void tlsBar_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            string itemname = e.ClickedItem.Text;
            switch (itemname)
            {
                case "AddHost":
                    AddHost frm2 = new AddHost();
                    frm2.ShowDialog();
                    break;
                case "Start":
                    this.Timer.Enabled = true;
                    tsslblStatus.Text = "상태 : 시작 ";
                    break;
                case "Stop":
                    this.Timer.Enabled = false;
                    tsslblStatus.Text = "상태 : 정지 ";
                    break;
            }
        }

        

        private Thread SoundPlayThread; //사운드 실행 스레드 개체 생성
 
        private void Timer_Tick(object sender, EventArgs e)
        {
            if (this.lvStatus.Items.Count == 0)
            {
                MessageBox.Show("체크할 IP 정보가 없습니다.", "알림",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Timer.Enabled = false;
            }
            else
            {
                for (int i = 0; i < this.lvStatus.Items.Count; i++)
                {
                    PingReply reply = nc.PingReply(staticForm.lvStatus.Items[i].SubItems[0].Text);

                    for (int column = 2; column < 7; column++)
                    {
                        if (reply.Status == IPStatus.Success)
                        {
                            staticForm.lvStatus.Items[i].BackColor = Color.Yellow;
                            string[] PingResult = new string[] {DateTime.Now.ToString(), reply.Buffer.Length.ToString() + " Bytes",
                                reply.RoundtripTime.ToString() + " ms", reply.Options.Ttl.ToString() };
                            if (column < 6)
                                staticForm.lvStatus.Items[i].SubItems[column].Text = PingResult[column - 2];
                            else
                                staticForm.lvStatus.Items[i].SubItems[column].Text = "성공";
                        }
                        else
                        {
                            if (column < 6)
                                staticForm.lvStatus.Items[i].SubItems[column].Text = (0).ToString();
                            else
                                staticForm.lvStatus.Items[i].SubItems[column].Text = "실패";
                            staticForm.lvStatus.Items[i].BackColor = Color.Red;
                            SoundPlayThread = new Thread(SoundPlayGo);
                            SoundPlayThread.Start();
                        }
                    }
                }
                staticForm.lvStatus.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                staticForm.lvStatus.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            }
        }
        private void SoundPlayGo()
        {
            SoundPlay.PlaySoundStart(Application.StartupPath + @"\Sound\ping.wav", new System.IntPtr(), SoundPlay.PlaySoundFlags.SND_SYNC);
            SoundPlayThread.Abort();
        }
    }
}
