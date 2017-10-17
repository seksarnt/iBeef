namespace BSSoft.iBeef.tsmCowList
{
    partial class frmCowList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCowList));
            FarPoint.Win.Spread.DefaultScrollBarRenderer defaultScrollBarRenderer1 = new FarPoint.Win.Spread.DefaultScrollBarRenderer();
            FarPoint.Win.Spread.DefaultScrollBarRenderer defaultScrollBarRenderer2 = new FarPoint.Win.Spread.DefaultScrollBarRenderer();
            FarPoint.Win.Spread.CellType.CheckBoxCellType checkBoxCellType1 = new FarPoint.Win.Spread.CellType.CheckBoxCellType();
            FarPoint.Win.Spread.CellType.TextCellType textCellType1 = new FarPoint.Win.Spread.CellType.TextCellType();
            FarPoint.Win.Spread.CellType.ButtonCellType buttonCellType1 = new FarPoint.Win.Spread.CellType.ButtonCellType();
            FarPoint.Win.Spread.CellType.TextCellType textCellType2 = new FarPoint.Win.Spread.CellType.TextCellType();
            FarPoint.Win.Spread.CellType.TextCellType textCellType3 = new FarPoint.Win.Spread.CellType.TextCellType();
            FarPoint.Win.Spread.CellType.TextCellType textCellType4 = new FarPoint.Win.Spread.CellType.TextCellType();
            FarPoint.Win.Spread.CellType.TextCellType textCellType5 = new FarPoint.Win.Spread.CellType.TextCellType();
            FarPoint.Win.Spread.CellType.TextCellType textCellType6 = new FarPoint.Win.Spread.CellType.TextCellType();
            FarPoint.Win.Spread.CellType.TextCellType textCellType7 = new FarPoint.Win.Spread.CellType.TextCellType();
            FarPoint.Win.Spread.CellType.TextCellType textCellType8 = new FarPoint.Win.Spread.CellType.TextCellType();
            FarPoint.Win.Spread.CellType.TextCellType textCellType9 = new FarPoint.Win.Spread.CellType.TextCellType();
            FarPoint.Win.Spread.CellType.TextCellType textCellType10 = new FarPoint.Win.Spread.CellType.TextCellType();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbSearch = new System.Windows.Forms.ToolStripButton();
            this.tsbAddNew = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbPrint = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbClose = new System.Windows.Forms.ToolStripButton();
            this.grbSearch = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMemberCode = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboTumbon = new System.Windows.Forms.ComboBox();
            this.cboAmphur = new System.Windows.Forms.ComboBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.fpsSearchResult = new FarPoint.Win.Spread.FpSpread();
            this.fpsSearchResult_Sheet1 = new FarPoint.Win.Spread.SheetView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tssSearchCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1.SuspendLayout();
            this.grbSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fpsSearchResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fpsSearchResult_Sheet1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbSearch,
            this.tsbAddNew,
            this.toolStripSeparator2,
            this.tsbDelete,
            this.toolStripSeparator3,
            this.tsbPrint,
            this.toolStripSeparator1,
            this.tsbClose});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1159, 48);
            this.toolStrip1.TabIndex = 17;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbSearch
            // 
            this.tsbSearch.AutoSize = false;
            this.tsbSearch.Image = global::BSSoft.iBeef.Properties.Resources.magnifying_glass;
            this.tsbSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSearch.Name = "tsbSearch";
            this.tsbSearch.Size = new System.Drawing.Size(55, 45);
            this.tsbSearch.Text = "ค้นหา";
            this.tsbSearch.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsbSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // tsbAddNew
            // 
            this.tsbAddNew.AutoSize = false;
            this.tsbAddNew.Image = global::BSSoft.iBeef.Properties.Resources.add_button;
            this.tsbAddNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAddNew.Name = "tsbAddNew";
            this.tsbAddNew.Size = new System.Drawing.Size(75, 45);
            this.tsbAddNew.Text = "ลงทะเบียนโค";
            this.tsbAddNew.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsbAddNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbAddNew.Click += new System.EventHandler(this.tsbAddNew_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 48);
            // 
            // tsbDelete
            // 
            this.tsbDelete.AutoSize = false;
            this.tsbDelete.Enabled = false;
            this.tsbDelete.Image = global::BSSoft.iBeef.Properties.Resources.garbage;
            this.tsbDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDelete.Name = "tsbDelete";
            this.tsbDelete.Size = new System.Drawing.Size(55, 45);
            this.tsbDelete.Text = "ลบ";
            this.tsbDelete.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsbDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 48);
            // 
            // tsbPrint
            // 
            this.tsbPrint.AutoSize = false;
            this.tsbPrint.Enabled = false;
            this.tsbPrint.Image = global::BSSoft.iBeef.Properties.Resources.printer;
            this.tsbPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbPrint.Name = "tsbPrint";
            this.tsbPrint.Size = new System.Drawing.Size(55, 45);
            this.tsbPrint.Text = "พิมพ์";
            this.tsbPrint.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsbPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
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
            // grbSearch
            // 
            this.grbSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbSearch.Controls.Add(this.label5);
            this.grbSearch.Controls.Add(this.comboBox1);
            this.grbSearch.Controls.Add(this.label6);
            this.grbSearch.Controls.Add(this.txtMemberCode);
            this.grbSearch.Controls.Add(this.label4);
            this.grbSearch.Controls.Add(this.label3);
            this.grbSearch.Controls.Add(this.label1);
            this.grbSearch.Controls.Add(this.cboTumbon);
            this.grbSearch.Controls.Add(this.cboAmphur);
            this.grbSearch.Controls.Add(this.txtName);
            this.grbSearch.Location = new System.Drawing.Point(8, 66);
            this.grbSearch.Margin = new System.Windows.Forms.Padding(4);
            this.grbSearch.Name = "grbSearch";
            this.grbSearch.Padding = new System.Windows.Forms.Padding(4);
            this.grbSearch.Size = new System.Drawing.Size(1141, 109);
            this.grbSearch.TabIndex = 0;
            this.grbSearch.TabStop = false;
            this.grbSearch.Text = "ค้นหา";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 80);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "สถานะ:";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "ทั้งหมด",
            "ยังไม่ได้เชือด/ไม่ได้อยู่ในคิว",
            "ยังไม่ได้เชือด/อยู่ในคิว",
            "เชือดแล้ว",
            "ตาย/อื่นๆ"});
            this.comboBox1.Location = new System.Drawing.Point(111, 77);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(227, 24);
            this.comboBox1.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 27);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "รหัสโค:";
            // 
            // txtMemberCode
            // 
            this.txtMemberCode.Location = new System.Drawing.Point(111, 24);
            this.txtMemberCode.Margin = new System.Windows.Forms.Padding(4);
            this.txtMemberCode.MaxLength = 50;
            this.txtMemberCode.Name = "txtMemberCode";
            this.txtMemberCode.Size = new System.Drawing.Size(227, 22);
            this.txtMemberCode.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(397, 52);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "สถานที่เลี้ยง:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 52);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "คอก:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(397, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "ชื่อ-สกุลเจ้าของ:";
            // 
            // cboTumbon
            // 
            this.cboTumbon.FormattingEnabled = true;
            this.cboTumbon.Location = new System.Drawing.Point(501, 49);
            this.cboTumbon.Margin = new System.Windows.Forms.Padding(4);
            this.cboTumbon.Name = "cboTumbon";
            this.cboTumbon.Size = new System.Drawing.Size(227, 24);
            this.cboTumbon.TabIndex = 5;
            // 
            // cboAmphur
            // 
            this.cboAmphur.FormattingEnabled = true;
            this.cboAmphur.Location = new System.Drawing.Point(111, 49);
            this.cboAmphur.Margin = new System.Windows.Forms.Padding(4);
            this.cboAmphur.Name = "cboAmphur";
            this.cboAmphur.Size = new System.Drawing.Size(227, 24);
            this.cboAmphur.TabIndex = 4;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(501, 24);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.MaxLength = 50;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(227, 22);
            this.txtName.TabIndex = 2;
            // 
            // fpsSearchResult
            // 
            this.fpsSearchResult.About = "4.0.2001.2005";
            this.fpsSearchResult.AccessibleDescription = "fpsSearchResult, Sheet1, Row 0, Column 0, ";
            this.fpsSearchResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fpsSearchResult.BackColor = System.Drawing.SystemColors.Control;
            this.fpsSearchResult.FocusRenderer = ((FarPoint.Win.Spread.IFocusIndicatorRenderer)(resources.GetObject("fpsSearchResult.FocusRenderer")));
            this.fpsSearchResult.HorizontalScrollBar.Buttons = new FarPoint.Win.Spread.FpScrollBarButtonCollection("BackwardLineButton,ThumbTrack,ForwardLineButton");
            this.fpsSearchResult.HorizontalScrollBar.Name = "";
            this.fpsSearchResult.HorizontalScrollBar.Renderer = defaultScrollBarRenderer1;
            this.fpsSearchResult.HorizontalScrollBar.TabIndex = 29;
            this.fpsSearchResult.HorizontalScrollBarPolicy = FarPoint.Win.Spread.ScrollBarPolicy.AsNeeded;
            this.fpsSearchResult.Location = new System.Drawing.Point(8, 183);
            this.fpsSearchResult.Margin = new System.Windows.Forms.Padding(4);
            this.fpsSearchResult.Name = "fpsSearchResult";
            this.fpsSearchResult.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fpsSearchResult.Sheets.AddRange(new FarPoint.Win.Spread.SheetView[] {
            this.fpsSearchResult_Sheet1});
            this.fpsSearchResult.Size = new System.Drawing.Size(1141, 249);
            this.fpsSearchResult.Skin = FarPoint.Win.Spread.DefaultSpreadSkins.Classic;
            this.fpsSearchResult.TabIndex = 7;
            this.fpsSearchResult.VerticalScrollBar.Buttons = new FarPoint.Win.Spread.FpScrollBarButtonCollection("BackwardLineButton,ThumbTrack,ForwardLineButton");
            this.fpsSearchResult.VerticalScrollBar.Name = "";
            this.fpsSearchResult.VerticalScrollBar.Renderer = defaultScrollBarRenderer2;
            this.fpsSearchResult.VerticalScrollBar.TabIndex = 30;
            this.fpsSearchResult.ButtonClicked += new FarPoint.Win.Spread.EditorNotifyEventHandler(this.fpsSearchResult_ButtonClicked);
            this.fpsSearchResult.DoubleClick += new System.EventHandler(this.fpsSearchResult_DoubleClick);
            // 
            // fpsSearchResult_Sheet1
            // 
            this.fpsSearchResult_Sheet1.Reset();
            this.fpsSearchResult_Sheet1.SheetName = "Sheet1";
            // Formulas and custom names must be loaded with R1C1 reference style
            this.fpsSearchResult_Sheet1.ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.R1C1;
            this.fpsSearchResult_Sheet1.ColumnCount = 13;
            this.fpsSearchResult_Sheet1.RowCount = 2;
            this.fpsSearchResult_Sheet1.Cells.Get(0, 1).Value = "10011022147-1";
            this.fpsSearchResult_Sheet1.Cells.Get(0, 3).Value = "นายมีใช้ อยู่สุขสบาย";
            this.fpsSearchResult_Sheet1.Cells.Get(0, 4).Value = "Stall1";
            this.fpsSearchResult_Sheet1.Cells.Get(0, 5).Value = "Farm1";
            this.fpsSearchResult_Sheet1.Cells.Get(0, 6).Value = "บราห์มัน/น้ำตาลเข้ม";
            this.fpsSearchResult_Sheet1.Cells.Get(0, 7).Value = "15/04/2560";
            this.fpsSearchResult_Sheet1.Cells.Get(1, 1).Value = "10011022147-2";
            this.fpsSearchResult_Sheet1.Cells.Get(1, 3).Value = "นายมีใช้ อยู่สุขสบาย";
            this.fpsSearchResult_Sheet1.Cells.Get(1, 4).Value = "Stall1";
            this.fpsSearchResult_Sheet1.Cells.Get(1, 5).Value = "Farm1";
            this.fpsSearchResult_Sheet1.Cells.Get(1, 6).Value = "บราห์มัน/น้ำตาลเข้ม";
            this.fpsSearchResult_Sheet1.Cells.Get(1, 7).Value = "15/04/2560";
            this.fpsSearchResult_Sheet1.ColumnHeader.Cells.Get(0, 0).Value = "...";
            this.fpsSearchResult_Sheet1.ColumnHeader.Cells.Get(0, 1).ColumnSpan = 2;
            this.fpsSearchResult_Sheet1.ColumnHeader.Cells.Get(0, 1).Value = "รหัสโค";
            this.fpsSearchResult_Sheet1.ColumnHeader.Cells.Get(0, 3).Value = "ชื่อ-สกุลเจ้าของ";
            this.fpsSearchResult_Sheet1.ColumnHeader.Cells.Get(0, 4).Value = "คอก";
            this.fpsSearchResult_Sheet1.ColumnHeader.Cells.Get(0, 5).Value = "สถานที่เลี้ยง";
            this.fpsSearchResult_Sheet1.ColumnHeader.Cells.Get(0, 6).Value = "พันธุ์/สี";
            this.fpsSearchResult_Sheet1.ColumnHeader.Cells.Get(0, 7).Value = "วันที่ลงทะเบียน";
            this.fpsSearchResult_Sheet1.ColumnHeader.Cells.Get(0, 8).Value = "สถานะ";
            this.fpsSearchResult_Sheet1.ColumnHeader.Cells.Get(0, 9).Value = "เกรด";
            this.fpsSearchResult_Sheet1.ColumnHeader.Cells.Get(0, 10).Value = "น้ำหนัก(kg.)";
            this.fpsSearchResult_Sheet1.ColumnHeader.Cells.Get(0, 11).Value = "ราคา(บาทต่อ kg.)";
            this.fpsSearchResult_Sheet1.ColumnHeader.Cells.Get(0, 12).Value = "ราคาสุทธิ(บาท)";
            this.fpsSearchResult_Sheet1.ColumnHeader.DefaultStyle.Parent = "HeaderDefault";
            this.fpsSearchResult_Sheet1.Columns.Get(0).CellType = checkBoxCellType1;
            this.fpsSearchResult_Sheet1.Columns.Get(0).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center;
            this.fpsSearchResult_Sheet1.Columns.Get(0).Label = "...";
            this.fpsSearchResult_Sheet1.Columns.Get(0).Resizable = false;
            this.fpsSearchResult_Sheet1.Columns.Get(0).Width = 25F;
            this.fpsSearchResult_Sheet1.Columns.Get(1).CellType = textCellType1;
            this.fpsSearchResult_Sheet1.Columns.Get(1).Label = "รหัสโค";
            this.fpsSearchResult_Sheet1.Columns.Get(1).Locked = true;
            this.fpsSearchResult_Sheet1.Columns.Get(1).Width = 110F;
            buttonCellType1.ButtonColor2 = System.Drawing.SystemColors.ButtonFace;
            buttonCellType1.Picture = ((System.Drawing.Image)(resources.GetObject("buttonCellType1.Picture")));
            this.fpsSearchResult_Sheet1.Columns.Get(2).CellType = buttonCellType1;
            this.fpsSearchResult_Sheet1.Columns.Get(2).Resizable = false;
            this.fpsSearchResult_Sheet1.Columns.Get(2).Width = 31F;
            this.fpsSearchResult_Sheet1.Columns.Get(3).CellType = textCellType2;
            this.fpsSearchResult_Sheet1.Columns.Get(3).Label = "ชื่อ-สกุลเจ้าของ";
            this.fpsSearchResult_Sheet1.Columns.Get(3).Locked = true;
            this.fpsSearchResult_Sheet1.Columns.Get(3).Width = 154F;
            this.fpsSearchResult_Sheet1.Columns.Get(4).CellType = textCellType3;
            this.fpsSearchResult_Sheet1.Columns.Get(4).Label = "คอก";
            this.fpsSearchResult_Sheet1.Columns.Get(4).Locked = true;
            this.fpsSearchResult_Sheet1.Columns.Get(4).Width = 100F;
            this.fpsSearchResult_Sheet1.Columns.Get(5).Label = "สถานที่เลี้ยง";
            this.fpsSearchResult_Sheet1.Columns.Get(5).Locked = true;
            this.fpsSearchResult_Sheet1.Columns.Get(5).Width = 100F;
            this.fpsSearchResult_Sheet1.Columns.Get(6).CellType = textCellType4;
            this.fpsSearchResult_Sheet1.Columns.Get(6).Label = "พันธุ์/สี";
            this.fpsSearchResult_Sheet1.Columns.Get(6).Locked = true;
            this.fpsSearchResult_Sheet1.Columns.Get(6).Width = 126F;
            this.fpsSearchResult_Sheet1.Columns.Get(7).CellType = textCellType5;
            this.fpsSearchResult_Sheet1.Columns.Get(7).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center;
            this.fpsSearchResult_Sheet1.Columns.Get(7).Label = "วันที่ลงทะเบียน";
            this.fpsSearchResult_Sheet1.Columns.Get(7).Locked = true;
            this.fpsSearchResult_Sheet1.Columns.Get(7).Width = 97F;
            this.fpsSearchResult_Sheet1.Columns.Get(8).CellType = textCellType6;
            this.fpsSearchResult_Sheet1.Columns.Get(8).Label = "สถานะ";
            this.fpsSearchResult_Sheet1.Columns.Get(8).Locked = true;
            this.fpsSearchResult_Sheet1.Columns.Get(8).Width = 98F;
            this.fpsSearchResult_Sheet1.Columns.Get(9).CellType = textCellType7;
            this.fpsSearchResult_Sheet1.Columns.Get(9).Label = "เกรด";
            this.fpsSearchResult_Sheet1.Columns.Get(9).Locked = true;
            this.fpsSearchResult_Sheet1.Columns.Get(9).Width = 70F;
            this.fpsSearchResult_Sheet1.Columns.Get(10).CellType = textCellType8;
            this.fpsSearchResult_Sheet1.Columns.Get(10).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center;
            this.fpsSearchResult_Sheet1.Columns.Get(10).Label = "น้ำหนัก(kg.)";
            this.fpsSearchResult_Sheet1.Columns.Get(10).Locked = true;
            this.fpsSearchResult_Sheet1.Columns.Get(10).Width = 80F;
            this.fpsSearchResult_Sheet1.Columns.Get(11).CellType = textCellType9;
            this.fpsSearchResult_Sheet1.Columns.Get(11).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center;
            this.fpsSearchResult_Sheet1.Columns.Get(11).Label = "ราคา(บาทต่อ kg.)";
            this.fpsSearchResult_Sheet1.Columns.Get(11).Locked = true;
            this.fpsSearchResult_Sheet1.Columns.Get(11).Width = 100F;
            this.fpsSearchResult_Sheet1.Columns.Get(12).CellType = textCellType10;
            this.fpsSearchResult_Sheet1.Columns.Get(12).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Right;
            this.fpsSearchResult_Sheet1.Columns.Get(12).Label = "ราคาสุทธิ(บาท)";
            this.fpsSearchResult_Sheet1.Columns.Get(12).Locked = true;
            this.fpsSearchResult_Sheet1.Columns.Get(12).Width = 100F;
            this.fpsSearchResult_Sheet1.RowHeader.Columns.Default.Resizable = true;
            this.fpsSearchResult_Sheet1.RowHeader.DefaultStyle.Parent = "RowHeaderDefault";
            this.fpsSearchResult_Sheet1.SheetCornerStyle.Parent = "CornerDefault";
            this.fpsSearchResult_Sheet1.RowChanged += new FarPoint.Win.Spread.SheetViewEventHandler(this.fpsSearchResult_Sheet1_RowChanged);
            this.fpsSearchResult_Sheet1.ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.A1;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssSearchCount});
            this.statusStrip1.Location = new System.Drawing.Point(0, 442);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1159, 22);
            this.statusStrip1.TabIndex = 19;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tssSearchCount
            // 
            this.tssSearchCount.Name = "tssSearchCount";
            this.tssSearchCount.Size = new System.Drawing.Size(114, 17);
            this.tssSearchCount.Text = "ผลการค้นหา 0 รายการ";
            // 
            // frmCowList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1159, 464);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.fpsSearchResult);
            this.Controls.Add(this.grbSearch);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmCowList";
            this.Text = "รายการโคทั้งหมด";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmCowList_FormClosed);
            this.Load += new System.EventHandler(this.frmCowList_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.grbSearch.ResumeLayout(false);
            this.grbSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fpsSearchResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fpsSearchResult_Sheet1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbSearch;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbClose;
        private System.Windows.Forms.ToolStripButton tsbAddNew;
        private System.Windows.Forms.GroupBox grbSearch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboTumbon;
        private System.Windows.Forms.ComboBox cboAmphur;
        private System.Windows.Forms.TextBox txtName;
        private FarPoint.Win.Spread.FpSpread fpsSearchResult;
        private FarPoint.Win.Spread.SheetView fpsSearchResult_Sheet1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tssSearchCount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMemberCode;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsbDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tsbPrint;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}