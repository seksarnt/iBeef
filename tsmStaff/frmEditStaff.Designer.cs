namespace BSSoft.iBeef.tsmStaff
{
    partial class frmEditStaff
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbClose = new System.Windows.Forms.ToolStripButton();
            this.cboTitleName = new System.Windows.Forms.ComboBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.dtBirthDate = new System.Windows.Forms.DateTimePicker();
            this.numAgeYear = new System.Windows.Forms.NumericUpDown();
            this.txtIDCardNo = new System.Windows.Forms.MaskedTextBox();
            this.txtStaffCode = new System.Windows.Forms.TextBox();
            this.rodMale = new System.Windows.Forms.RadioButton();
            this.rdoFemale = new System.Windows.Forms.RadioButton();
            this.cboDepartment = new System.Windows.Forms.ComboBox();
            this.cboFaction = new System.Windows.Forms.ComboBox();
            this.lblStaffCode = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblBirstDate = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblIDCardNo = new System.Windows.Forms.Label();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.lblFaction = new System.Windows.Forms.Label();
            this.grbAddress = new System.Windows.Forms.GroupBox();
            this.cboTumbon = new System.Windows.Forms.ComboBox();
            this.cboProvince = new System.Windows.Forms.ComboBox();
            this.cboAmphur = new System.Windows.Forms.ComboBox();
            this.txtPostCode = new System.Windows.Forms.TextBox();
            this.txtAddrSoi = new System.Windows.Forms.TextBox();
            this.txtAddrRoad = new System.Windows.Forms.TextBox();
            this.txtAddrMoo = new System.Windows.Forms.TextBox();
            this.txtAddrNo = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lblSex = new System.Windows.Forms.Label();
            this.grbIsUseSystem = new System.Windows.Forms.GroupBox();
            this.cboIsUseSystem = new System.Windows.Forms.CheckBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtPassword2 = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.lblPassword2 = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblTelNo = new System.Windows.Forms.Label();
            this.txtTelNo = new System.Windows.Forms.MaskedTextBox();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAgeYear)).BeginInit();
            this.grbAddress.SuspendLayout();
            this.grbIsUseSystem.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbSave,
            this.toolStripSeparator1,
            this.tsbClose});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(741, 48);
            this.toolStrip1.TabIndex = 26;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbSave
            // 
            this.tsbSave.AutoSize = false;
            this.tsbSave.Enabled = false;
            this.tsbSave.Image = global::BSSoft.iBeef.Properties.Resources.download;
            this.tsbSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSave.Name = "tsbSave";
            this.tsbSave.Size = new System.Drawing.Size(55, 45);
            this.tsbSave.Text = "บันทึก";
            this.tsbSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsbSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 48);
            // 
            // tsbClose
            // 
            this.tsbClose.AutoSize = false;
            this.tsbClose.Image = global::BSSoft.iBeef.Properties.Resources.close;
            this.tsbClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbClose.Name = "tsbClose";
            this.tsbClose.Size = new System.Drawing.Size(55, 45);
            this.tsbClose.Text = "ปิด";
            this.tsbClose.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsbClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbClose.Click += new System.EventHandler(this.tsbClose_Click);
            // 
            // cboTitleName
            // 
            this.cboTitleName.FormattingEnabled = true;
            this.cboTitleName.Location = new System.Drawing.Point(133, 108);
            this.cboTitleName.Margin = new System.Windows.Forms.Padding(4);
            this.cboTitleName.Name = "cboTitleName";
            this.cboTitleName.Size = new System.Drawing.Size(74, 24);
            this.cboTitleName.TabIndex = 3;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(215, 108);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(4);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(128, 22);
            this.txtFirstName.TabIndex = 4;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(499, 108);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(4);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(187, 22);
            this.txtLastName.TabIndex = 5;
            // 
            // dtBirthDate
            // 
            this.dtBirthDate.Location = new System.Drawing.Point(133, 136);
            this.dtBirthDate.Margin = new System.Windows.Forms.Padding(4);
            this.dtBirthDate.Name = "dtBirthDate";
            this.dtBirthDate.Size = new System.Drawing.Size(210, 22);
            this.dtBirthDate.TabIndex = 6;
            // 
            // numAgeYear
            // 
            this.numAgeYear.Location = new System.Drawing.Point(499, 139);
            this.numAgeYear.Margin = new System.Windows.Forms.Padding(4);
            this.numAgeYear.Name = "numAgeYear";
            this.numAgeYear.Size = new System.Drawing.Size(53, 22);
            this.numAgeYear.TabIndex = 7;
            // 
            // txtIDCardNo
            // 
            this.txtIDCardNo.Location = new System.Drawing.Point(133, 163);
            this.txtIDCardNo.Margin = new System.Windows.Forms.Padding(4);
            this.txtIDCardNo.Name = "txtIDCardNo";
            this.txtIDCardNo.Size = new System.Drawing.Size(210, 22);
            this.txtIDCardNo.TabIndex = 8;
            // 
            // txtStaffCode
            // 
            this.txtStaffCode.Location = new System.Drawing.Point(133, 55);
            this.txtStaffCode.Margin = new System.Windows.Forms.Padding(4);
            this.txtStaffCode.Name = "txtStaffCode";
            this.txtStaffCode.Size = new System.Drawing.Size(210, 22);
            this.txtStaffCode.TabIndex = 0;
            // 
            // rodMale
            // 
            this.rodMale.AutoSize = true;
            this.rodMale.Location = new System.Drawing.Point(133, 82);
            this.rodMale.Margin = new System.Windows.Forms.Padding(4);
            this.rodMale.Name = "rodMale";
            this.rodMale.Size = new System.Drawing.Size(44, 20);
            this.rodMale.TabIndex = 1;
            this.rodMale.TabStop = true;
            this.rodMale.Text = "ชาย";
            this.rodMale.UseVisualStyleBackColor = true;
            // 
            // rdoFemale
            // 
            this.rdoFemale.AutoSize = true;
            this.rdoFemale.Location = new System.Drawing.Point(219, 82);
            this.rdoFemale.Margin = new System.Windows.Forms.Padding(4);
            this.rdoFemale.Name = "rdoFemale";
            this.rdoFemale.Size = new System.Drawing.Size(49, 20);
            this.rdoFemale.TabIndex = 2;
            this.rdoFemale.TabStop = true;
            this.rdoFemale.Text = "หญิง";
            this.rdoFemale.UseVisualStyleBackColor = true;
            // 
            // cboDepartment
            // 
            this.cboDepartment.FormattingEnabled = true;
            this.cboDepartment.Location = new System.Drawing.Point(133, 191);
            this.cboDepartment.Margin = new System.Windows.Forms.Padding(4);
            this.cboDepartment.Name = "cboDepartment";
            this.cboDepartment.Size = new System.Drawing.Size(210, 24);
            this.cboDepartment.TabIndex = 10;
            // 
            // cboFaction
            // 
            this.cboFaction.FormattingEnabled = true;
            this.cboFaction.Location = new System.Drawing.Point(499, 191);
            this.cboFaction.Margin = new System.Windows.Forms.Padding(4);
            this.cboFaction.Name = "cboFaction";
            this.cboFaction.Size = new System.Drawing.Size(187, 24);
            this.cboFaction.TabIndex = 11;
            // 
            // lblStaffCode
            // 
            this.lblStaffCode.AutoSize = true;
            this.lblStaffCode.ForeColor = System.Drawing.Color.Blue;
            this.lblStaffCode.Location = new System.Drawing.Point(29, 58);
            this.lblStaffCode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStaffCode.Name = "lblStaffCode";
            this.lblStaffCode.Size = new System.Drawing.Size(71, 16);
            this.lblStaffCode.TabIndex = 31;
            this.lblStaffCode.Text = "รหัสพนักงาน:";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.ForeColor = System.Drawing.Color.Blue;
            this.lblFirstName.Location = new System.Drawing.Point(29, 112);
            this.lblFirstName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(24, 16);
            this.lblFirstName.TabIndex = 32;
            this.lblFirstName.Text = "ชื่อ:";
            // 
            // lblBirstDate
            // 
            this.lblBirstDate.AutoSize = true;
            this.lblBirstDate.Location = new System.Drawing.Point(29, 138);
            this.lblBirstDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBirstDate.Name = "lblBirstDate";
            this.lblBirstDate.Size = new System.Drawing.Size(40, 16);
            this.lblBirstDate.TabIndex = 33;
            this.lblBirstDate.Text = "วันเกิด:";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(408, 112);
            this.lblLastName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(30, 16);
            this.lblLastName.TabIndex = 34;
            this.lblLastName.Text = "สกุล:";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(408, 141);
            this.lblAge.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(28, 16);
            this.lblAge.TabIndex = 35;
            this.lblAge.Text = "อายุ:";
            // 
            // lblIDCardNo
            // 
            this.lblIDCardNo.AutoSize = true;
            this.lblIDCardNo.Location = new System.Drawing.Point(29, 166);
            this.lblIDCardNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIDCardNo.Name = "lblIDCardNo";
            this.lblIDCardNo.Size = new System.Drawing.Size(79, 16);
            this.lblIDCardNo.TabIndex = 36;
            this.lblIDCardNo.Text = "รหัสบัตร ปชช.:";
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Location = new System.Drawing.Point(29, 194);
            this.lblDepartment.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(37, 16);
            this.lblDepartment.TabIndex = 37;
            this.lblDepartment.Text = "แผนก:";
            // 
            // lblFaction
            // 
            this.lblFaction.AutoSize = true;
            this.lblFaction.Location = new System.Drawing.Point(408, 194);
            this.lblFaction.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFaction.Name = "lblFaction";
            this.lblFaction.Size = new System.Drawing.Size(29, 16);
            this.lblFaction.TabIndex = 38;
            this.lblFaction.Text = "ฝ่าย:";
            // 
            // grbAddress
            // 
            this.grbAddress.Controls.Add(this.cboTumbon);
            this.grbAddress.Controls.Add(this.cboProvince);
            this.grbAddress.Controls.Add(this.cboAmphur);
            this.grbAddress.Controls.Add(this.txtPostCode);
            this.grbAddress.Controls.Add(this.txtAddrSoi);
            this.grbAddress.Controls.Add(this.txtAddrRoad);
            this.grbAddress.Controls.Add(this.txtAddrMoo);
            this.grbAddress.Controls.Add(this.txtAddrNo);
            this.grbAddress.Controls.Add(this.label11);
            this.grbAddress.Controls.Add(this.label10);
            this.grbAddress.Controls.Add(this.label9);
            this.grbAddress.Controls.Add(this.label12);
            this.grbAddress.Controls.Add(this.label13);
            this.grbAddress.Controls.Add(this.label14);
            this.grbAddress.Controls.Add(this.label15);
            this.grbAddress.Controls.Add(this.label16);
            this.grbAddress.Location = new System.Drawing.Point(12, 226);
            this.grbAddress.Name = "grbAddress";
            this.grbAddress.Size = new System.Drawing.Size(714, 139);
            this.grbAddress.TabIndex = 12;
            this.grbAddress.TabStop = false;
            this.grbAddress.Text = "ที่อยู่";
            // 
            // cboTumbon
            // 
            this.cboTumbon.FormattingEnabled = true;
            this.cboTumbon.Location = new System.Drawing.Point(121, 102);
            this.cboTumbon.Name = "cboTumbon";
            this.cboTumbon.Size = new System.Drawing.Size(210, 24);
            this.cboTumbon.TabIndex = 19;
            // 
            // cboProvince
            // 
            this.cboProvince.FormattingEnabled = true;
            this.cboProvince.Location = new System.Drawing.Point(121, 73);
            this.cboProvince.Name = "cboProvince";
            this.cboProvince.Size = new System.Drawing.Size(210, 24);
            this.cboProvince.TabIndex = 17;
            // 
            // cboAmphur
            // 
            this.cboAmphur.FormattingEnabled = true;
            this.cboAmphur.Location = new System.Drawing.Point(487, 75);
            this.cboAmphur.Name = "cboAmphur";
            this.cboAmphur.Size = new System.Drawing.Size(187, 24);
            this.cboAmphur.TabIndex = 18;
            // 
            // txtPostCode
            // 
            this.txtPostCode.Location = new System.Drawing.Point(487, 104);
            this.txtPostCode.MaxLength = 5;
            this.txtPostCode.Name = "txtPostCode";
            this.txtPostCode.Size = new System.Drawing.Size(187, 22);
            this.txtPostCode.TabIndex = 20;
            // 
            // txtAddrSoi
            // 
            this.txtAddrSoi.Location = new System.Drawing.Point(121, 45);
            this.txtAddrSoi.MaxLength = 50;
            this.txtAddrSoi.Name = "txtAddrSoi";
            this.txtAddrSoi.Size = new System.Drawing.Size(210, 22);
            this.txtAddrSoi.TabIndex = 15;
            // 
            // txtAddrRoad
            // 
            this.txtAddrRoad.Location = new System.Drawing.Point(487, 47);
            this.txtAddrRoad.MaxLength = 50;
            this.txtAddrRoad.Name = "txtAddrRoad";
            this.txtAddrRoad.Size = new System.Drawing.Size(187, 22);
            this.txtAddrRoad.TabIndex = 16;
            // 
            // txtAddrMoo
            // 
            this.txtAddrMoo.Location = new System.Drawing.Point(487, 19);
            this.txtAddrMoo.MaxLength = 50;
            this.txtAddrMoo.Name = "txtAddrMoo";
            this.txtAddrMoo.Size = new System.Drawing.Size(187, 22);
            this.txtAddrMoo.TabIndex = 14;
            // 
            // txtAddrNo
            // 
            this.txtAddrNo.Location = new System.Drawing.Point(121, 19);
            this.txtAddrNo.MaxLength = 50;
            this.txtAddrNo.Name = "txtAddrNo";
            this.txtAddrNo.Size = new System.Drawing.Size(210, 22);
            this.txtAddrNo.TabIndex = 13;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(396, 107);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 16);
            this.label11.TabIndex = 12;
            this.label11.Text = "รหัสไปรษณีย์:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(19, 107);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 16);
            this.label10.TabIndex = 11;
            this.label10.Text = "ตำบล:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(396, 78);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 16);
            this.label9.TabIndex = 10;
            this.label9.Text = "อำเภอ:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(19, 78);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 16);
            this.label12.TabIndex = 9;
            this.label12.Text = "จังหวัด:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(396, 48);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(31, 16);
            this.label13.TabIndex = 8;
            this.label13.Text = "ถนน:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(19, 48);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(30, 16);
            this.label14.TabIndex = 7;
            this.label14.Text = "ซอย:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(396, 22);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(64, 16);
            this.label15.TabIndex = 6;
            this.label15.Text = "หมู่/หมู่บ้าน:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(19, 22);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(35, 16);
            this.label16.TabIndex = 5;
            this.label16.Text = "เลขที:";
            // 
            // lblSex
            // 
            this.lblSex.AutoSize = true;
            this.lblSex.ForeColor = System.Drawing.Color.Blue;
            this.lblSex.Location = new System.Drawing.Point(29, 84);
            this.lblSex.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(29, 16);
            this.lblSex.TabIndex = 40;
            this.lblSex.Text = "เพศ:";
            // 
            // grbIsUseSystem
            // 
            this.grbIsUseSystem.Controls.Add(this.cboIsUseSystem);
            this.grbIsUseSystem.Controls.Add(this.txtPassword);
            this.grbIsUseSystem.Controls.Add(this.txtPassword2);
            this.grbIsUseSystem.Controls.Add(this.txtUserName);
            this.grbIsUseSystem.Controls.Add(this.lblPassword2);
            this.grbIsUseSystem.Controls.Add(this.lblPassword);
            this.grbIsUseSystem.Controls.Add(this.lblUserName);
            this.grbIsUseSystem.Location = new System.Drawing.Point(12, 371);
            this.grbIsUseSystem.Name = "grbIsUseSystem";
            this.grbIsUseSystem.Size = new System.Drawing.Size(714, 131);
            this.grbIsUseSystem.TabIndex = 21;
            this.grbIsUseSystem.TabStop = false;
            this.grbIsUseSystem.Text = "สิทธิการใช้งานโปรแกรม";
            // 
            // cboIsUseSystem
            // 
            this.cboIsUseSystem.AutoSize = true;
            this.cboIsUseSystem.Location = new System.Drawing.Point(121, 21);
            this.cboIsUseSystem.Name = "cboIsUseSystem";
            this.cboIsUseSystem.Size = new System.Drawing.Size(128, 20);
            this.cboIsUseSystem.TabIndex = 22;
            this.cboIsUseSystem.Text = "มีสิทธิใช้งานโปรแกรม";
            this.cboIsUseSystem.UseVisualStyleBackColor = true;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(121, 74);
            this.txtPassword.MaxLength = 50;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(210, 22);
            this.txtPassword.TabIndex = 24;
            // 
            // txtPassword2
            // 
            this.txtPassword2.Location = new System.Drawing.Point(121, 102);
            this.txtPassword2.MaxLength = 50;
            this.txtPassword2.Name = "txtPassword2";
            this.txtPassword2.Size = new System.Drawing.Size(210, 22);
            this.txtPassword2.TabIndex = 25;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(121, 48);
            this.txtUserName.MaxLength = 50;
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(210, 22);
            this.txtUserName.TabIndex = 23;
            // 
            // lblPassword2
            // 
            this.lblPassword2.AutoSize = true;
            this.lblPassword2.ForeColor = System.Drawing.Color.Blue;
            this.lblPassword2.Location = new System.Drawing.Point(19, 105);
            this.lblPassword2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPassword2.Name = "lblPassword2";
            this.lblPassword2.Size = new System.Drawing.Size(77, 16);
            this.lblPassword2.TabIndex = 8;
            this.lblPassword2.Text = "ยืนยันรหัสผ่าน:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.ForeColor = System.Drawing.Color.Blue;
            this.lblPassword.Location = new System.Drawing.Point(19, 77);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(51, 16);
            this.lblPassword.TabIndex = 7;
            this.lblPassword.Text = "รหัสผ่าน:";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.ForeColor = System.Drawing.Color.Blue;
            this.lblUserName.Location = new System.Drawing.Point(19, 51);
            this.lblUserName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(69, 16);
            this.lblUserName.TabIndex = 5;
            this.lblUserName.Text = "ชื่อผู้ใช้ระบบ:";
            // 
            // lblTelNo
            // 
            this.lblTelNo.AutoSize = true;
            this.lblTelNo.Location = new System.Drawing.Point(408, 166);
            this.lblTelNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTelNo.Name = "lblTelNo";
            this.lblTelNo.Size = new System.Drawing.Size(53, 16);
            this.lblTelNo.TabIndex = 43;
            this.lblTelNo.Text = "โทรศัพท์:";
            // 
            // txtTelNo
            // 
            this.txtTelNo.Location = new System.Drawing.Point(499, 163);
            this.txtTelNo.Margin = new System.Windows.Forms.Padding(4);
            this.txtTelNo.Name = "txtTelNo";
            this.txtTelNo.Size = new System.Drawing.Size(187, 22);
            this.txtTelNo.TabIndex = 9;
            // 
            // frmEditStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 512);
            this.Controls.Add(this.lblTelNo);
            this.Controls.Add(this.txtTelNo);
            this.Controls.Add(this.grbIsUseSystem);
            this.Controls.Add(this.lblSex);
            this.Controls.Add(this.grbAddress);
            this.Controls.Add(this.lblFaction);
            this.Controls.Add(this.lblDepartment);
            this.Controls.Add(this.lblIDCardNo);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblBirstDate);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblStaffCode);
            this.Controls.Add(this.cboFaction);
            this.Controls.Add(this.cboDepartment);
            this.Controls.Add(this.rdoFemale);
            this.Controls.Add(this.rodMale);
            this.Controls.Add(this.txtStaffCode);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtIDCardNo);
            this.Controls.Add(this.numAgeYear);
            this.Controls.Add(this.dtBirthDate);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.cboTitleName);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmEditStaff";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "เพิ่มข้อมูลพนักงาน";
            this.Load += new System.EventHandler(this.frmEditStaff_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAgeYear)).EndInit();
            this.grbAddress.ResumeLayout(false);
            this.grbAddress.PerformLayout();
            this.grbIsUseSystem.ResumeLayout(false);
            this.grbIsUseSystem.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbSave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbClose;
        private System.Windows.Forms.ComboBox cboTitleName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.DateTimePicker dtBirthDate;
        private System.Windows.Forms.NumericUpDown numAgeYear;
        private System.Windows.Forms.MaskedTextBox txtIDCardNo;
        private System.Windows.Forms.TextBox txtStaffCode;
        private System.Windows.Forms.RadioButton rodMale;
        private System.Windows.Forms.RadioButton rdoFemale;
        private System.Windows.Forms.ComboBox cboDepartment;
        private System.Windows.Forms.ComboBox cboFaction;
        private System.Windows.Forms.Label lblStaffCode;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblBirstDate;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblIDCardNo;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.Label lblFaction;
        private System.Windows.Forms.GroupBox grbAddress;
        private System.Windows.Forms.ComboBox cboTumbon;
        private System.Windows.Forms.ComboBox cboProvince;
        private System.Windows.Forms.ComboBox cboAmphur;
        private System.Windows.Forms.TextBox txtPostCode;
        private System.Windows.Forms.TextBox txtAddrSoi;
        private System.Windows.Forms.TextBox txtAddrRoad;
        private System.Windows.Forms.TextBox txtAddrMoo;
        private System.Windows.Forms.TextBox txtAddrNo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lblSex;
        private System.Windows.Forms.GroupBox grbIsUseSystem;
        private System.Windows.Forms.CheckBox cboIsUseSystem;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtPassword2;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label lblPassword2;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblTelNo;
        private System.Windows.Forms.MaskedTextBox txtTelNo;
    }
}