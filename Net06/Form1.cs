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

namespace Net06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string OrgNICName = "";
        string OrgIPAdress = "";
        string OrgSubnet = "";
        string OrgGateway = "";

        IPChange ip = new IPChange();

        private void Form1_Load(object sender, EventArgs e)
        {
            OrgNICName = ConfigurationManager.AppSettings["NICName"];
            OrgIPAdress = ConfigurationManager.AppSettings["IPAdress"];
            OrgSubnet = ConfigurationManager.AppSettings["Subnet"];
            OrgGateway = ConfigurationManager.AppSettings["Gateway"];
        }

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
    }
}
