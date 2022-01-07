
namespace Axxounting.App
{
    partial class Form1
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.btnEditLogin = new System.Windows.Forms.ToolStripDropDownButton();
            this.btnEditUser = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.btnCustomer = new System.Windows.Forms.ToolStripButton();
            this.btnNewAccounting = new System.Windows.Forms.ToolStripButton();
            this.btnReport = new System.Windows.Forms.ToolStripButton();
            this.btnReportRecive = new System.Windows.Forms.ToolStripButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblDate = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.stiPrint = new Stimulsoft.Report.StiReport();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.recive = new System.Windows.Forms.Label();
            this.pay = new System.Windows.Forms.Label();
            this.AccountBallance = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.btnEditLogin});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(725, 31);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(64, 28);
            this.toolStripLabel1.Text = "تنظیمات";
            this.toolStripLabel1.Click += new System.EventHandler(this.toolStripLabel1_Click);
            // 
            // btnEditLogin
            // 
            this.btnEditLogin.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnEditLogin.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnEditUser});
            this.btnEditLogin.Image = global::Axxounting.App.Properties.Resources.Users;
            this.btnEditLogin.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEditLogin.Name = "btnEditLogin";
            this.btnEditLogin.Size = new System.Drawing.Size(34, 28);
            this.btnEditLogin.Text = "toolStripDropDownButton1";
            this.btnEditLogin.Click += new System.EventHandler(this.btnEditLogin_Click);
            // 
            // btnEditUser
            // 
            this.btnEditUser.Name = "btnEditUser";
            this.btnEditUser.Size = new System.Drawing.Size(180, 26);
            this.btnEditUser.Text = "تنظیمات ورود";
            this.btnEditUser.Click += new System.EventHandler(this.تنظیماتورودToolStripMenuItem_Click);
            // 
            // toolStrip2
            // 
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCustomer,
            this.btnNewAccounting,
            this.btnReport,
            this.btnReportRecive});
            this.toolStrip2.Location = new System.Drawing.Point(0, 31);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(725, 67);
            this.toolStrip2.TabIndex = 1;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // btnCustomer
            // 
            this.btnCustomer.Image = global::Axxounting.App.Properties.Resources._1371476468_preferences_contact_list;
            this.btnCustomer.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnCustomer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(90, 64);
            this.btnCustomer.Text = "طرف حساب";
            this.btnCustomer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // btnNewAccounting
            // 
            this.btnNewAccounting.Image = global::Axxounting.App.Properties.Resources._1371476499_todo_list;
            this.btnNewAccounting.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnNewAccounting.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNewAccounting.Name = "btnNewAccounting";
            this.btnNewAccounting.Size = new System.Drawing.Size(92, 64);
            this.btnNewAccounting.Text = "تراکنش جدید";
            this.btnNewAccounting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnNewAccounting.Click += new System.EventHandler(this.btnNewAccounting_Click);
            // 
            // btnReport
            // 
            this.btnReport.Image = global::Axxounting.App.Properties.Resources.servicesCosts;
            this.btnReport.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnReport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(164, 64);
            this.btnReport.Text = "گزارش پرداختی ها";
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // btnReportRecive
            // 
            this.btnReportRecive.Image = global::Axxounting.App.Properties.Resources._1371476120_fingerprint_reader;
            this.btnReportRecive.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnReportRecive.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnReportRecive.Name = "btnReportRecive";
            this.btnReportRecive.Size = new System.Drawing.Size(165, 64);
            this.btnReportRecive.Text = "گزارش دریافتی ها";
            this.btnReportRecive.Click += new System.EventHandler(this.btnReportRecive_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Axxounting.App.Properties.Resources.Untitled_1;
            this.pictureBox1.Location = new System.Drawing.Point(21, 283);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(258, 194);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblDate,
            this.lblTime});
            this.statusStrip1.Location = new System.Drawing.Point(0, 493);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(725, 26);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblDate
            // 
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(151, 20);
            this.lblDate.Text = "toolStripStatusLabel1";
            // 
            // lblTime
            // 
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(151, 20);
            this.lblTime.Text = "toolStripStatusLabel2";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // stiPrint
            // 
            this.stiPrint.CookieContainer = null;
            this.stiPrint.EngineVersion = Stimulsoft.Report.Engine.StiEngineVersion.EngineV2;
            this.stiPrint.ReferencedAssemblies = new string[] {
        "System.Dll",
        "System.Drawing.Dll",
        "System.Windows.Forms.Dll",
        "System.Data.Dll",
        "System.Xml.Dll",
        "Stimulsoft.Controls.Dll",
        "Stimulsoft.Base.Dll",
        "Stimulsoft.Report.Dll"};
            this.stiPrint.ReportAlias = "Report";
            this.stiPrint.ReportGuid = "9f02cea9b2be4e7a9defe301b6766b63";
            this.stiPrint.ReportName = "Report";
            this.stiPrint.ReportSource = null;
            this.stiPrint.ReportUnit = Stimulsoft.Report.StiReportUnitType.Inches;
            this.stiPrint.ScriptLanguage = Stimulsoft.Report.StiReportLanguageType.CSharp;
            this.stiPrint.UseProgressInThread = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRefresh);
            this.groupBox1.Controls.Add(this.AccountBallance);
            this.groupBox1.Controls.Add(this.pay);
            this.groupBox1.Controls.Add(this.recive);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(467, 118);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(246, 160);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "گزارش این ماه";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(187, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "دریافتی";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(184, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "پرداختی";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(187, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "مانده";
            // 
            // recive
            // 
            this.recive.Location = new System.Drawing.Point(23, 23);
            this.recive.Name = "recive";
            this.recive.Size = new System.Drawing.Size(121, 17);
            this.recive.TabIndex = 3;
            this.recive.Text = "0";
            // 
            // pay
            // 
            this.pay.Location = new System.Drawing.Point(23, 60);
            this.pay.Name = "pay";
            this.pay.Size = new System.Drawing.Size(121, 17);
            this.pay.TabIndex = 4;
            this.pay.Text = "0";
            // 
            // AccountBallance
            // 
            this.AccountBallance.Location = new System.Drawing.Point(23, 96);
            this.AccountBallance.Name = "AccountBallance";
            this.AccountBallance.Size = new System.Drawing.Size(121, 17);
            this.AccountBallance.TabIndex = 5;
            this.AccountBallance.Text = "0";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(6, 123);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(125, 28);
            this.btnRefresh.TabIndex = 6;
            this.btnRefresh.Text = "به روز رسانی";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 519);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "حسابداری شخصی من";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton btnCustomer;
        private System.Windows.Forms.ToolStripButton btnNewAccounting;
        private System.Windows.Forms.ToolStripButton btnReport;
        private System.Windows.Forms.ToolStripButton btnReportRecive;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblDate;
        private System.Windows.Forms.ToolStripStatusLabel lblTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripDropDownButton btnEditLogin;
        private System.Windows.Forms.ToolStripMenuItem btnEditUser;
        private Stimulsoft.Report.StiReport stiPrint;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label AccountBallance;
        private System.Windows.Forms.Label pay;
        private System.Windows.Forms.Label recive;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRefresh;
    }
}

