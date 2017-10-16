namespace BSSoft.iBeef
{
    partial class mdiMain
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
            this.mnsMain = new System.Windows.Forms.MenuStrip();
            this.tsmFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOrganization = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuDBSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSettingCowType = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSettingCowPart = new System.Windows.Forms.ToolStripMenuItem();
            this.พนกงานToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuStaff = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOntime = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmMember = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMember = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCustomer = new System.Windows.Forms.ToolStripMenuItem();
            this.ทะเบยนโคToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmCowList = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmCowQue = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSalesList = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSell = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmReport = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRPTMember = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRPTMemberList = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRPTMemberIncome = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRPTCustomer = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRPTCustomerList = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRPTCow = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRPTCowList = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRPTCowQue = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRPTCowProducted = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRPTSell = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRPTSellByPart = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRPTSellByCustomer = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmWindows = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuSettingsDepartment = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSettingsFaction = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnsMain
            // 
            this.mnsMain.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmFile,
            this.tsmSettings,
            this.พนกงานToolStripMenuItem,
            this.tsmMember,
            this.ทะเบยนโคToolStripMenuItem,
            this.tsmSalesList,
            this.tsmReport,
            this.tsmWindows});
            this.mnsMain.Location = new System.Drawing.Point(0, 0);
            this.mnsMain.Name = "mnsMain";
            this.mnsMain.Padding = new System.Windows.Forms.Padding(9, 2, 0, 2);
            this.mnsMain.Size = new System.Drawing.Size(881, 28);
            this.mnsMain.TabIndex = 0;
            this.mnsMain.Text = "menuStrip1";
            // 
            // tsmFile
            // 
            this.tsmFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuOrganization,
            this.toolStripSeparator6,
            this.mnuDBSettings,
            this.toolStripSeparator2,
            this.mnuExit});
            this.tsmFile.Name = "tsmFile";
            this.tsmFile.Size = new System.Drawing.Size(45, 24);
            this.tsmFile.Text = "ไฟล์";
            // 
            // mnuOrganization
            // 
            this.mnuOrganization.Name = "mnuOrganization";
            this.mnuOrganization.Size = new System.Drawing.Size(198, 24);
            this.mnuOrganization.Text = "ข้อมูลองค์กร";
            this.mnuOrganization.Click += new System.EventHandler(this.mnuOrganization_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(195, 6);
            // 
            // mnuDBSettings
            // 
            this.mnuDBSettings.Name = "mnuDBSettings";
            this.mnuDBSettings.Size = new System.Drawing.Size(198, 24);
            this.mnuDBSettings.Text = "การเชื่อมต่อฐานข้อมูล";
            this.mnuDBSettings.Click += new System.EventHandler(this.mnuDBSettings_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(195, 6);
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(198, 24);
            this.mnuExit.Text = "ออกจากระบบ";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // tsmSettings
            // 
            this.tsmSettings.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSettingCowType,
            this.mnuSettingCowPart,
            this.toolStripSeparator3,
            this.mnuSettingsDepartment,
            this.mnuSettingsFaction});
            this.tsmSettings.Name = "tsmSettings";
            this.tsmSettings.Size = new System.Drawing.Size(49, 24);
            this.tsmSettings.Text = "ตั้งค่า";
            // 
            // mnuSettingCowType
            // 
            this.mnuSettingCowType.Name = "mnuSettingCowType";
            this.mnuSettingCowType.Size = new System.Drawing.Size(202, 24);
            this.mnuSettingCowType.Text = "ตั้งค่าประเภทโค";
            this.mnuSettingCowType.Click += new System.EventHandler(this.mnuSettingCowType_Click);
            // 
            // mnuSettingCowPart
            // 
            this.mnuSettingCowPart.Name = "mnuSettingCowPart";
            this.mnuSettingCowPart.Size = new System.Drawing.Size(202, 24);
            this.mnuSettingCowPart.Text = "ตั้งค่าชิ้นส่วนโค(สินค้า)";
            this.mnuSettingCowPart.Click += new System.EventHandler(this.mnuSettingCowPart_Click);
            // 
            // พนกงานToolStripMenuItem
            // 
            this.พนกงานToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuStaff,
            this.mnuOntime});
            this.พนกงานToolStripMenuItem.Name = "พนกงานToolStripMenuItem";
            this.พนกงานToolStripMenuItem.Size = new System.Drawing.Size(69, 24);
            this.พนกงานToolStripMenuItem.Text = "พนักงาน";
            // 
            // mnuStaff
            // 
            this.mnuStaff.Name = "mnuStaff";
            this.mnuStaff.Size = new System.Drawing.Size(169, 24);
            this.mnuStaff.Text = "รายชื่อพนักงาน";
            this.mnuStaff.Click += new System.EventHandler(this.mnuStaff_Click);
            // 
            // mnuOntime
            // 
            this.mnuOntime.Name = "mnuOntime";
            this.mnuOntime.Size = new System.Drawing.Size(169, 24);
            this.mnuOntime.Text = "ลงเวลาเข้าทำงาน";
            this.mnuOntime.Click += new System.EventHandler(this.mnuOntime_Click);
            // 
            // tsmMember
            // 
            this.tsmMember.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuMember,
            this.mnuCustomer});
            this.tsmMember.Name = "tsmMember";
            this.tsmMember.Size = new System.Drawing.Size(93, 24);
            this.tsmMember.Text = "สมาชิก/ลูกค้า";
            // 
            // mnuMember
            // 
            this.mnuMember.Name = "mnuMember";
            this.mnuMember.Size = new System.Drawing.Size(154, 24);
            this.mnuMember.Text = "รายชื่อสมาชิก";
            this.mnuMember.Click += new System.EventHandler(this.mnuMember_Click);
            // 
            // mnuCustomer
            // 
            this.mnuCustomer.Name = "mnuCustomer";
            this.mnuCustomer.Size = new System.Drawing.Size(154, 24);
            this.mnuCustomer.Text = "รายชื่อลูกค้า";
            // 
            // ทะเบยนโคToolStripMenuItem
            // 
            this.ทะเบยนโคToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmCowList,
            this.tsmCowQue});
            this.ทะเบยนโคToolStripMenuItem.Name = "ทะเบยนโคToolStripMenuItem";
            this.ทะเบยนโคToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.ทะเบยนโคToolStripMenuItem.Text = "ทะเบียนโค";
            // 
            // tsmCowList
            // 
            this.tsmCowList.Name = "tsmCowList";
            this.tsmCowList.Size = new System.Drawing.Size(150, 24);
            this.tsmCowList.Text = "รายการโค";
            this.tsmCowList.Click += new System.EventHandler(this.tsmCowList_Click);
            // 
            // tsmCowQue
            // 
            this.tsmCowQue.Name = "tsmCowQue";
            this.tsmCowQue.Size = new System.Drawing.Size(150, 24);
            this.tsmCowQue.Text = "จัดคิวเชือดโค";
            // 
            // tsmSalesList
            // 
            this.tsmSalesList.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSell});
            this.tsmSalesList.Name = "tsmSalesList";
            this.tsmSalesList.Size = new System.Drawing.Size(64, 24);
            this.tsmSalesList.Text = "การขาย";
            // 
            // mnuSell
            // 
            this.mnuSell.Name = "mnuSell";
            this.mnuSell.Size = new System.Drawing.Size(156, 24);
            this.mnuSell.Text = "บันทึกการขาย";
            // 
            // tsmReport
            // 
            this.tsmReport.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuRPTMember,
            this.mnuRPTCustomer,
            this.mnuRPTCow,
            this.mnuRPTSell});
            this.tsmReport.Name = "tsmReport";
            this.tsmReport.Size = new System.Drawing.Size(63, 24);
            this.tsmReport.Text = "รายงาน";
            // 
            // mnuRPTMember
            // 
            this.mnuRPTMember.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuRPTMemberList,
            this.mnuRPTMemberIncome});
            this.mnuRPTMember.Name = "mnuRPTMember";
            this.mnuRPTMember.Size = new System.Drawing.Size(175, 24);
            this.mnuRPTMember.Text = "1.รายงานสมาชิก";
            // 
            // mnuRPTMemberList
            // 
            this.mnuRPTMemberList.Name = "mnuRPTMemberList";
            this.mnuRPTMemberList.Size = new System.Drawing.Size(243, 24);
            this.mnuRPTMemberList.Text = "1.1 รายงานรายชื่อลูกค้า";
            // 
            // mnuRPTMemberIncome
            // 
            this.mnuRPTMemberIncome.Name = "mnuRPTMemberIncome";
            this.mnuRPTMemberIncome.Size = new System.Drawing.Size(243, 24);
            this.mnuRPTMemberIncome.Text = "1.2 รายงานสรุปรายได้สมาชิก";
            // 
            // mnuRPTCustomer
            // 
            this.mnuRPTCustomer.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuRPTCustomerList});
            this.mnuRPTCustomer.Name = "mnuRPTCustomer";
            this.mnuRPTCustomer.Size = new System.Drawing.Size(175, 24);
            this.mnuRPTCustomer.Text = "2.รายงานลูกค้า";
            // 
            // mnuRPTCustomerList
            // 
            this.mnuRPTCustomerList.Name = "mnuRPTCustomerList";
            this.mnuRPTCustomerList.Size = new System.Drawing.Size(210, 24);
            this.mnuRPTCustomerList.Text = "2.1 รายงานรายชื่อลูกค้า";
            // 
            // mnuRPTCow
            // 
            this.mnuRPTCow.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuRPTCowList,
            this.mnuRPTCowQue,
            this.mnuRPTCowProducted});
            this.mnuRPTCow.Name = "mnuRPTCow";
            this.mnuRPTCow.Size = new System.Drawing.Size(175, 24);
            this.mnuRPTCow.Text = "3. รายงานโค";
            // 
            // mnuRPTCowList
            // 
            this.mnuRPTCowList.Name = "mnuRPTCowList";
            this.mnuRPTCowList.Size = new System.Drawing.Size(207, 24);
            this.mnuRPTCowList.Text = "3.1 รายงานทะเบียนโค";
            // 
            // mnuRPTCowQue
            // 
            this.mnuRPTCowQue.Name = "mnuRPTCowQue";
            this.mnuRPTCowQue.Size = new System.Drawing.Size(207, 24);
            this.mnuRPTCowQue.Text = "3.2 รายงานคิวเชือดโค";
            // 
            // mnuRPTCowProducted
            // 
            this.mnuRPTCowProducted.Name = "mnuRPTCowProducted";
            this.mnuRPTCowProducted.Size = new System.Drawing.Size(207, 24);
            this.mnuRPTCowProducted.Text = "3.3 รายงานการเชือดโค";
            // 
            // mnuRPTSell
            // 
            this.mnuRPTSell.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuRPTSellByPart,
            this.mnuRPTSellByCustomer});
            this.mnuRPTSell.Name = "mnuRPTSell";
            this.mnuRPTSell.Size = new System.Drawing.Size(175, 24);
            this.mnuRPTSell.Text = "4.รายงานการขาย";
            // 
            // mnuRPTSellByPart
            // 
            this.mnuRPTSellByPart.Name = "mnuRPTSellByPart";
            this.mnuRPTSellByPart.Size = new System.Drawing.Size(275, 24);
            this.mnuRPTSellByPart.Text = "4.1 รายงานสรุปการขายตามชิ้นส่วน";
            // 
            // mnuRPTSellByCustomer
            // 
            this.mnuRPTSellByCustomer.Name = "mnuRPTSellByCustomer";
            this.mnuRPTSellByCustomer.Size = new System.Drawing.Size(275, 24);
            this.mnuRPTSellByCustomer.Text = "4.2 รายงานสรุปการขายตามลูกค้า";
            // 
            // tsmWindows
            // 
            this.tsmWindows.Name = "tsmWindows";
            this.tsmWindows.Size = new System.Drawing.Size(65, 24);
            this.tsmWindows.Text = "หน้าต่าง";
            this.tsmWindows.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.tsmWindows_DropDownItemClicked);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(199, 6);
            // 
            // mnuSettingsDepartment
            // 
            this.mnuSettingsDepartment.Name = "mnuSettingsDepartment";
            this.mnuSettingsDepartment.Size = new System.Drawing.Size(202, 24);
            this.mnuSettingsDepartment.Text = "ตั้งค่าแผนก";
            this.mnuSettingsDepartment.Click += new System.EventHandler(this.mnuSettingsDepartment_Click);
            // 
            // mnuSettingsFaction
            // 
            this.mnuSettingsFaction.Name = "mnuSettingsFaction";
            this.mnuSettingsFaction.Size = new System.Drawing.Size(202, 24);
            this.mnuSettingsFaction.Text = "ตั้งค่าฝ่าย";
            this.mnuSettingsFaction.Click += new System.EventHandler(this.mnuSettingsFaction_Click);
            // 
            // mdiMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 569);
            this.Controls.Add(this.mnsMain);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mnsMain;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "mdiMain";
            this.Text = "iBeef";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.mnsMain.ResumeLayout(false);
            this.mnsMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnsMain;
        private System.Windows.Forms.ToolStripMenuItem tsmFile;
        private System.Windows.Forms.ToolStripMenuItem mnuDBSettings;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ToolStripMenuItem tsmMember;
        private System.Windows.Forms.ToolStripMenuItem tsmReport;
        private System.Windows.Forms.ToolStripMenuItem tsmWindows;
        private System.Windows.Forms.ToolStripMenuItem mnuMember;
        private System.Windows.Forms.ToolStripMenuItem mnuCustomer;
        private System.Windows.Forms.ToolStripMenuItem tsmSalesList;
        private System.Windows.Forms.ToolStripMenuItem mnuSell;
        private System.Windows.Forms.ToolStripMenuItem mnuRPTMember;
        private System.Windows.Forms.ToolStripMenuItem mnuRPTMemberList;
        private System.Windows.Forms.ToolStripMenuItem mnuRPTCustomer;
        private System.Windows.Forms.ToolStripMenuItem mnuRPTSell;
        private System.Windows.Forms.ToolStripMenuItem mnuOrganization;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem พนกงานToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuStaff;
        private System.Windows.Forms.ToolStripMenuItem mnuOntime;
        private System.Windows.Forms.ToolStripMenuItem mnuRPTMemberIncome;
        private System.Windows.Forms.ToolStripMenuItem mnuRPTCustomerList;
        private System.Windows.Forms.ToolStripMenuItem mnuRPTCow;
        private System.Windows.Forms.ToolStripMenuItem mnuRPTCowList;
        private System.Windows.Forms.ToolStripMenuItem mnuRPTCowQue;
        private System.Windows.Forms.ToolStripMenuItem mnuRPTCowProducted;
        private System.Windows.Forms.ToolStripMenuItem mnuRPTSellByPart;
        private System.Windows.Forms.ToolStripMenuItem mnuRPTSellByCustomer;
        private System.Windows.Forms.ToolStripMenuItem tsmSettings;
        private System.Windows.Forms.ToolStripMenuItem mnuSettingCowType;
        private System.Windows.Forms.ToolStripMenuItem mnuSettingCowPart;
        private System.Windows.Forms.ToolStripMenuItem ทะเบยนโคToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmCowList;
        private System.Windows.Forms.ToolStripMenuItem tsmCowQue;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem mnuSettingsDepartment;
        private System.Windows.Forms.ToolStripMenuItem mnuSettingsFaction;
    }
}

