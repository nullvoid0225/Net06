namespace Net06
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblIp = new System.Windows.Forms.Label();
            this.lblSubnet = new System.Windows.Forms.Label();
            this.lblGateway = new System.Windows.Forms.Label();
            this.txtIp = new System.Windows.Forms.TextBox();
            this.txtSubnet = new System.Windows.Forms.TextBox();
            this.txtGateway = new System.Windows.Forms.TextBox();
            this.btnChange = new System.Windows.Forms.Button();
            this.btnRestore = new System.Windows.Forms.Button();
            this.btnDHCP = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lvAP = new System.Windows.Forms.ListView();
            this.chSSID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chQuality = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chEnabled = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chChanel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chAlgorithm = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chAuth = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chMAC = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvStatus = new System.Windows.Forms.ListView();
            this.Host = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Description = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SendTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SentByte = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RoundTripTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TTL = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Result = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.tlsBar = new System.Windows.Forms.ToolStrip();
            this.tsbtnAddHost = new System.Windows.Forms.ToolStripButton();
            this.tsbtnStart = new System.Windows.Forms.ToolStripButton();
            this.tsbtnStop = new System.Windows.Forms.ToolStripButton();
            this.tslcbTime = new System.Windows.Forms.ToolStripComboBox();
            this.stsBar = new System.Windows.Forms.StatusStrip();
            this.tsslblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1.SuspendLayout();
            this.tlsBar.SuspendLayout();
            this.stsBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblIp
            // 
            this.lblIp.AutoSize = true;
            this.lblIp.Location = new System.Drawing.Point(22, 24);
            this.lblIp.Name = "lblIp";
            this.lblIp.Size = new System.Drawing.Size(20, 15);
            this.lblIp.TabIndex = 0;
            this.lblIp.Text = "IP";
            // 
            // lblSubnet
            // 
            this.lblSubnet.AutoSize = true;
            this.lblSubnet.Location = new System.Drawing.Point(22, 53);
            this.lblSubnet.Name = "lblSubnet";
            this.lblSubnet.Size = new System.Drawing.Size(53, 15);
            this.lblSubnet.TabIndex = 0;
            this.lblSubnet.Text = "Subnet";
            // 
            // lblGateway
            // 
            this.lblGateway.AutoSize = true;
            this.lblGateway.Location = new System.Drawing.Point(22, 82);
            this.lblGateway.Name = "lblGateway";
            this.lblGateway.Size = new System.Drawing.Size(68, 15);
            this.lblGateway.TabIndex = 0;
            this.lblGateway.Text = "GateWay";
            // 
            // txtIp
            // 
            this.txtIp.Location = new System.Drawing.Point(101, 14);
            this.txtIp.Name = "txtIp";
            this.txtIp.Size = new System.Drawing.Size(198, 25);
            this.txtIp.TabIndex = 1;
            // 
            // txtSubnet
            // 
            this.txtSubnet.Location = new System.Drawing.Point(101, 43);
            this.txtSubnet.Name = "txtSubnet";
            this.txtSubnet.Size = new System.Drawing.Size(198, 25);
            this.txtSubnet.TabIndex = 1;
            // 
            // txtGateway
            // 
            this.txtGateway.Location = new System.Drawing.Point(101, 72);
            this.txtGateway.Name = "txtGateway";
            this.txtGateway.Size = new System.Drawing.Size(198, 25);
            this.txtGateway.TabIndex = 1;
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(314, 15);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(87, 23);
            this.btnChange.TabIndex = 2;
            this.btnChange.Text = "변경";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // btnRestore
            // 
            this.btnRestore.Location = new System.Drawing.Point(314, 45);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(87, 23);
            this.btnRestore.TabIndex = 2;
            this.btnRestore.Text = "복원";
            this.btnRestore.UseVisualStyleBackColor = true;
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // btnDHCP
            // 
            this.btnDHCP.Location = new System.Drawing.Point(314, 74);
            this.btnDHCP.Name = "btnDHCP";
            this.btnDHCP.Size = new System.Drawing.Size(87, 23);
            this.btnDHCP.TabIndex = 2;
            this.btnDHCP.Text = "자동";
            this.btnDHCP.UseVisualStyleBackColor = true;
            this.btnDHCP.Click += new System.EventHandler(this.btnDHCP_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDHCP);
            this.groupBox1.Controls.Add(this.btnRestore);
            this.groupBox1.Controls.Add(this.btnChange);
            this.groupBox1.Controls.Add(this.txtGateway);
            this.groupBox1.Controls.Add(this.txtSubnet);
            this.groupBox1.Controls.Add(this.txtIp);
            this.groupBox1.Controls.Add(this.lblGateway);
            this.groupBox1.Controls.Add(this.lblSubnet);
            this.groupBox1.Controls.Add(this.lblIp);
            this.groupBox1.Location = new System.Drawing.Point(16, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(427, 111);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "IP Change";
            // 
            // lvAP
            // 
            this.lvAP.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chSSID,
            this.chQuality,
            this.chEnabled,
            this.chChanel,
            this.chAlgorithm,
            this.chAuth,
            this.chMAC});
            this.lvAP.FullRowSelect = true;
            this.lvAP.GridLines = true;
            this.lvAP.Location = new System.Drawing.Point(12, 156);
            this.lvAP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lvAP.Name = "lvAP";
            this.lvAP.Size = new System.Drawing.Size(571, 181);
            this.lvAP.TabIndex = 5;
            this.lvAP.UseCompatibleStateImageBehavior = false;
            this.lvAP.View = System.Windows.Forms.View.Details;
            // 
            // chSSID
            // 
            this.chSSID.Text = "이름";
            this.chSSID.Width = 100;
            // 
            // chQuality
            // 
            this.chQuality.Text = "신호강도";
            // 
            // chEnabled
            // 
            this.chEnabled.Text = "암호화";
            // 
            // chChanel
            // 
            this.chChanel.Text = "채널";
            this.chChanel.Width = 58;
            // 
            // chAlgorithm
            // 
            this.chAlgorithm.Text = "암호방식";
            // 
            // chAuth
            // 
            this.chAuth.Text = "인증방식";
            this.chAuth.Width = 100;
            // 
            // chMAC
            // 
            this.chMAC.Text = "MAC";
            this.chMAC.Width = 174;
            // 
            // lvStatus
            // 
            this.lvStatus.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Host,
            this.Description,
            this.SendTime,
            this.SentByte,
            this.RoundTripTime,
            this.TTL,
            this.Result});
            this.lvStatus.FullRowSelect = true;
            this.lvStatus.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvStatus.Location = new System.Drawing.Point(12, 345);
            this.lvStatus.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lvStatus.MultiSelect = false;
            this.lvStatus.Name = "lvStatus";
            this.lvStatus.Size = new System.Drawing.Size(571, 192);
            this.lvStatus.TabIndex = 7;
            this.lvStatus.UseCompatibleStateImageBehavior = false;
            this.lvStatus.View = System.Windows.Forms.View.Details;
            // 
            // Host
            // 
            this.Host.Text = "호스트";
            this.Host.Width = 75;
            // 
            // Description
            // 
            this.Description.Text = "설명";
            this.Description.Width = 75;
            // 
            // SendTime
            // 
            this.SendTime.Text = "보낸시간";
            this.SendTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.SendTime.Width = 77;
            // 
            // SentByte
            // 
            this.SentByte.Text = "Byte";
            this.SentByte.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.SentByte.Width = 80;
            // 
            // RoundTripTime
            // 
            this.RoundTripTime.Text = "시간";
            this.RoundTripTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.RoundTripTime.Width = 100;
            // 
            // TTL
            // 
            this.TTL.Text = "TTL";
            this.TTL.Width = 50;
            // 
            // Result
            // 
            this.Result.Text = "결과";
            this.Result.Width = 50;
            // 
            // Timer
            // 
            this.Timer.Interval = 5000;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // tlsBar
            // 
            this.tlsBar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tlsBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnAddHost,
            this.tsbtnStart,
            this.tsbtnStop,
            this.tslcbTime});
            this.tlsBar.Location = new System.Drawing.Point(0, 0);
            this.tlsBar.Name = "tlsBar";
            this.tlsBar.Size = new System.Drawing.Size(939, 31);
            this.tlsBar.TabIndex = 8;
            this.tlsBar.Text = "toolStrip1";
            this.tlsBar.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.tlsBar_ItemClicked);
            // 
            // tsbtnAddHost
            // 
            this.tsbtnAddHost.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnAddHost.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnAddHost.Image")));
            this.tsbtnAddHost.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnAddHost.Name = "tsbtnAddHost";
            this.tsbtnAddHost.Size = new System.Drawing.Size(24, 28);
            this.tsbtnAddHost.Text = "AddHost";
            // 
            // tsbtnStart
            // 
            this.tsbtnStart.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnStart.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnStart.Image")));
            this.tsbtnStart.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnStart.Name = "tsbtnStart";
            this.tsbtnStart.Size = new System.Drawing.Size(24, 28);
            this.tsbtnStart.Text = "Start";
            // 
            // tsbtnStop
            // 
            this.tsbtnStop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnStop.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnStop.Image")));
            this.tsbtnStop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnStop.Name = "tsbtnStop";
            this.tsbtnStop.Size = new System.Drawing.Size(24, 28);
            this.tsbtnStop.Text = "Stop";
            // 
            // tslcbTime
            // 
            this.tslcbTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tslcbTime.Items.AddRange(new object[] {
            "5 초",
            "10 초",
            "15 초",
            "20 초",
            "30 초"});
            this.tslcbTime.Name = "tslcbTime";
            this.tslcbTime.Size = new System.Drawing.Size(85, 31);
            this.tslcbTime.Click += new System.EventHandler(this.tslcbTime_Click);
            // 
            // stsBar
            // 
            this.stsBar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.stsBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslblStatus});
            this.stsBar.Location = new System.Drawing.Point(0, 598);
            this.stsBar.Name = "stsBar";
            this.stsBar.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.stsBar.Size = new System.Drawing.Size(939, 28);
            this.stsBar.TabIndex = 9;
            this.stsBar.Text = "statusStrip1";
            // 
            // tsslblStatus
            // 
            this.tsslblStatus.Name = "tsslblStatus";
            this.tsslblStatus.Size = new System.Drawing.Size(94, 23);
            this.tsslblStatus.Text = "상태 : 정지";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 626);
            this.Controls.Add(this.stsBar);
            this.Controls.Add(this.tlsBar);
            this.Controls.Add(this.lvStatus);
            this.Controls.Add(this.lvAP);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Net 06";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tlsBar.ResumeLayout(false);
            this.tlsBar.PerformLayout();
            this.stsBar.ResumeLayout(false);
            this.stsBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIp;
        private System.Windows.Forms.Label lblSubnet;
        private System.Windows.Forms.Label lblGateway;
        private System.Windows.Forms.TextBox txtIp;
        private System.Windows.Forms.TextBox txtSubnet;
        private System.Windows.Forms.TextBox txtGateway;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Button btnRestore;
        private System.Windows.Forms.Button btnDHCP;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView lvAP;
        private System.Windows.Forms.ColumnHeader chSSID;
        private System.Windows.Forms.ColumnHeader chQuality;
        private System.Windows.Forms.ColumnHeader chEnabled;
        private System.Windows.Forms.ColumnHeader chChanel;
        private System.Windows.Forms.ColumnHeader chAlgorithm;
        private System.Windows.Forms.ColumnHeader chAuth;
        private System.Windows.Forms.ColumnHeader chMAC;
        private System.Windows.Forms.ListView lvStatus;
        private System.Windows.Forms.ColumnHeader Host;
        private System.Windows.Forms.ColumnHeader Description;
        private System.Windows.Forms.ColumnHeader SendTime;
        private System.Windows.Forms.ColumnHeader SentByte;
        private System.Windows.Forms.ColumnHeader RoundTripTime;
        private System.Windows.Forms.ColumnHeader TTL;
        private System.Windows.Forms.ColumnHeader Result;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.ToolStrip tlsBar;
        private System.Windows.Forms.ToolStripButton tsbtnAddHost;
        private System.Windows.Forms.ToolStripButton tsbtnStart;
        private System.Windows.Forms.ToolStripButton tsbtnStop;
        private System.Windows.Forms.ToolStripComboBox tslcbTime;
        private System.Windows.Forms.StatusStrip stsBar;
        private System.Windows.Forms.ToolStripStatusLabel tsslblStatus;
    }
}

