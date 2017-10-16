namespace BSSoft.iBeef.tsmStaff
{
    partial class frmStaff
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStaff));
            FarPoint.Win.Spread.DefaultScrollBarRenderer defaultScrollBarRenderer3 = new FarPoint.Win.Spread.DefaultScrollBarRenderer();
            FarPoint.Win.Spread.DefaultScrollBarRenderer defaultScrollBarRenderer4 = new FarPoint.Win.Spread.DefaultScrollBarRenderer();
            FarPoint.Win.Spread.CellType.CheckBoxCellType checkBoxCellType2 = new FarPoint.Win.Spread.CellType.CheckBoxCellType();
            FarPoint.Win.Spread.CellType.TextCellType textCellType9 = new FarPoint.Win.Spread.CellType.TextCellType();
            FarPoint.Win.Spread.CellType.TextCellType textCellType10 = new FarPoint.Win.Spread.CellType.TextCellType();
            FarPoint.Win.Spread.CellType.TextCellType textCellType11 = new FarPoint.Win.Spread.CellType.TextCellType();
            FarPoint.Win.Spread.CellType.TextCellType textCellType12 = new FarPoint.Win.Spread.CellType.TextCellType();
            FarPoint.Win.Spread.CellType.TextCellType textCellType13 = new FarPoint.Win.Spread.CellType.TextCellType();
            FarPoint.Win.Spread.CellType.TextCellType textCellType14 = new FarPoint.Win.Spread.CellType.TextCellType();
            FarPoint.Win.Spread.CellType.TextCellType textCellType15 = new FarPoint.Win.Spread.CellType.TextCellType();
            FarPoint.Win.Spread.CellType.TextCellType textCellType16 = new FarPoint.Win.Spread.CellType.TextCellType();
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
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMemberCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
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
            this.toolStrip1.Size = new System.Drawing.Size(963, 48);
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
            this.tsbAddNew.Size = new System.Drawing.Size(55, 45);
            this.tsbAddNew.Text = "เพิ่มใหม่";
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
            this.grbSearch.Controls.Add(this.checkBox1);
            this.grbSearch.Controls.Add(this.label3);
            this.grbSearch.Controls.Add(this.label2);
            this.grbSearch.Controls.Add(this.comboBox2);
            this.grbSearch.Controls.Add(this.comboBox1);
            this.grbSearch.Controls.Add(this.label6);
            this.grbSearch.Controls.Add(this.txtMemberCode);
            this.grbSearch.Controls.Add(this.label1);
            this.grbSearch.Controls.Add(this.txtName);
            this.grbSearch.Location = new System.Drawing.Point(8, 66);
            this.grbSearch.Margin = new System.Windows.Forms.Padding(4);
            this.grbSearch.Name = "grbSearch";
            this.grbSearch.Padding = new System.Windows.Forms.Padding(4);
            this.grbSearch.Size = new System.Drawing.Size(945, 106);
            this.grbSearch.TabIndex = 0;
            this.grbSearch.TabStop = false;
            this.grbSearch.Text = "ค้นหา";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(111, 81);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(166, 20);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "แสดงเฉพาะที่ยกเลิกใช้งานแล้ว";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(399, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "ฝ่าย:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "แผนก:";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(501, 51);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(227, 24);
            this.comboBox2.TabIndex = 4;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(111, 51);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(227, 24);
            this.comboBox1.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 27);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "รหัสพนักงาน:";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(397, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "ชื่อ-สกุล:";
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
            this.fpsSearchResult.AccessibleDescription = "fpsSearchResult, Sheet1";
            this.fpsSearchResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fpsSearchResult.BackColor = System.Drawing.SystemColors.Control;
            this.fpsSearchResult.FocusRenderer = ((FarPoint.Win.Spread.IFocusIndicatorRenderer)(resources.GetObject("fpsSearchResult.FocusRenderer")));
            this.fpsSearchResult.HorizontalScrollBar.Buttons = new FarPoint.Win.Spread.FpScrollBarButtonCollection("BackwardLineButton,ThumbTrack,ForwardLineButton");
            this.fpsSearchResult.HorizontalScrollBar.Name = "";
            this.fpsSearchResult.HorizontalScrollBar.Renderer = defaultScrollBarRenderer3;
            this.fpsSearchResult.HorizontalScrollBar.TabIndex = 17;
            this.fpsSearchResult.HorizontalScrollBarPolicy = FarPoint.Win.Spread.ScrollBarPolicy.AsNeeded;
            this.fpsSearchResult.Location = new System.Drawing.Point(8, 180);
            this.fpsSearchResult.Margin = new System.Windows.Forms.Padding(4);
            this.fpsSearchResult.Name = "fpsSearchResult";
            this.fpsSearchResult.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fpsSearchResult.Sheets.AddRange(new FarPoint.Win.Spread.SheetView[] {
            this.fpsSearchResult_Sheet1});
            this.fpsSearchResult.Size = new System.Drawing.Size(945, 252);
            this.fpsSearchResult.Skin = FarPoint.Win.Spread.DefaultSpreadSkins.Classic;
            this.fpsSearchResult.TabIndex = 6;
            this.fpsSearchResult.VerticalScrollBar.Buttons = new FarPoint.Win.Spread.FpScrollBarButtonCollection("BackwardLineButton,ThumbTrack,ForwardLineButton");
            this.fpsSearchResult.VerticalScrollBar.Name = "";
            this.fpsSearchResult.VerticalScrollBar.Renderer = defaultScrollBarRenderer4;
            this.fpsSearchResult.VerticalScrollBar.TabIndex = 18;
            this.fpsSearchResult.ButtonClicked += new FarPoint.Win.Spread.EditorNotifyEventHandler(this.fpsSearchResult_ButtonClicked);
            this.fpsSearchResult.DoubleClick += new System.EventHandler(this.fpsSearchResult_DoubleClick);
            // 
            // fpsSearchResult_Sheet1
            // 
            this.fpsSearchResult_Sheet1.Reset();
            this.fpsSearchResult_Sheet1.SheetName = "Sheet1";
            // Formulas and custom names must be loaded with R1C1 reference style
            this.fpsSearchResult_Sheet1.ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.R1C1;
            this.fpsSearchResult_Sheet1.ColumnCount = 9;
            this.fpsSearchResult_Sheet1.ColumnHeader.RowCount = 2;
            this.fpsSearchResult_Sheet1.RowCount = 0;
            this.fpsSearchResult_Sheet1.ColumnHeader.Cells.Get(0, 0).RowSpan = 2;
            this.fpsSearchResult_Sheet1.ColumnHeader.Cells.Get(0, 0).Value = "...";
            this.fpsSearchResult_Sheet1.ColumnHeader.Cells.Get(0, 1).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.General;
            this.fpsSearchResult_Sheet1.ColumnHeader.Cells.Get(0, 1).RowSpan = 2;
            this.fpsSearchResult_Sheet1.ColumnHeader.Cells.Get(0, 1).Value = "สถานะ";
            this.fpsSearchResult_Sheet1.ColumnHeader.Cells.Get(0, 2).RowSpan = 2;
            this.fpsSearchResult_Sheet1.ColumnHeader.Cells.Get(0, 2).Value = "รหัสพนักงาน";
            this.fpsSearchResult_Sheet1.ColumnHeader.Cells.Get(0, 3).RowSpan = 2;
            this.fpsSearchResult_Sheet1.ColumnHeader.Cells.Get(0, 3).Value = "ชื่อ-สกุล";
            this.fpsSearchResult_Sheet1.ColumnHeader.Cells.Get(0, 4).RowSpan = 2;
            this.fpsSearchResult_Sheet1.ColumnHeader.Cells.Get(0, 4).Value = "แผนก";
            this.fpsSearchResult_Sheet1.ColumnHeader.Cells.Get(0, 5).RowSpan = 2;
            this.fpsSearchResult_Sheet1.ColumnHeader.Cells.Get(0, 5).Value = "ฝ่าย";
            this.fpsSearchResult_Sheet1.ColumnHeader.Cells.Get(0, 6).ColumnSpan = 3;
            this.fpsSearchResult_Sheet1.ColumnHeader.Cells.Get(0, 6).Value = "สิทธิ์ใช้งานโปรแกรม";
            this.fpsSearchResult_Sheet1.ColumnHeader.Cells.Get(1, 6).Value = "มีสิทธิ์ใช้งาน";
            this.fpsSearchResult_Sheet1.ColumnHeader.Cells.Get(1, 7).Value = "User Name";
            this.fpsSearchResult_Sheet1.ColumnHeader.Cells.Get(1, 8).Value = "รหัสผ่าน";
            this.fpsSearchResult_Sheet1.ColumnHeader.DefaultStyle.Parent = "HeaderDefault";
            this.fpsSearchResult_Sheet1.Columns.Get(0).CellType = checkBoxCellType2;
            this.fpsSearchResult_Sheet1.Columns.Get(0).Resizable = false;
            this.fpsSearchResult_Sheet1.Columns.Get(0).Width = 25F;
            this.fpsSearchResult_Sheet1.Columns.Get(1).CellType = textCellType9;
            this.fpsSearchResult_Sheet1.Columns.Get(1).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center;
            this.fpsSearchResult_Sheet1.Columns.Get(1).Locked = true;
            this.fpsSearchResult_Sheet1.Columns.Get(1).Width = 105F;
            this.fpsSearchResult_Sheet1.Columns.Get(2).CellType = textCellType10;
            this.fpsSearchResult_Sheet1.Columns.Get(2).Locked = true;
            this.fpsSearchResult_Sheet1.Columns.Get(2).Width = 99F;
            this.fpsSearchResult_Sheet1.Columns.Get(3).CellType = textCellType11;
            this.fpsSearchResult_Sheet1.Columns.Get(3).Locked = true;
            this.fpsSearchResult_Sheet1.Columns.Get(3).Width = 166F;
            this.fpsSearchResult_Sheet1.Columns.Get(4).CellType = textCellType12;
            this.fpsSearchResult_Sheet1.Columns.Get(4).Locked = true;
            this.fpsSearchResult_Sheet1.Columns.Get(4).Width = 123F;
            this.fpsSearchResult_Sheet1.Columns.Get(5).CellType = textCellType13;
            this.fpsSearchResult_Sheet1.Columns.Get(5).Locked = true;
            this.fpsSearchResult_Sheet1.Columns.Get(5).Width = 116F;
            this.fpsSearchResult_Sheet1.Columns.Get(6).CellType = textCellType14;
            this.fpsSearchResult_Sheet1.Columns.Get(6).Label = "มีสิทธิ์ใช้งาน";
            this.fpsSearchResult_Sheet1.Columns.Get(6).Locked = true;
            this.fpsSearchResult_Sheet1.Columns.Get(6).Width = 100F;
            this.fpsSearchResult_Sheet1.Columns.Get(7).CellType = textCellType15;
            this.fpsSearchResult_Sheet1.Columns.Get(7).Label = "User Name";
            this.fpsSearchResult_Sheet1.Columns.Get(7).Locked = true;
            this.fpsSearchResult_Sheet1.Columns.Get(7).Width = 100F;
            textCellType16.PasswordChar = '*';
            this.fpsSearchResult_Sheet1.Columns.Get(8).CellType = textCellType16;
            this.fpsSearchResult_Sheet1.Columns.Get(8).Label = "รหัสผ่าน";
            this.fpsSearchResult_Sheet1.Columns.Get(8).Locked = true;
            this.fpsSearchResult_Sheet1.Columns.Get(8).Width = 100F;
            this.fpsSearchResult_Sheet1.RowHeader.Columns.Default.Resizable = true;
            this.fpsSearchResult_Sheet1.RowHeader.DefaultStyle.Parent = "RowHeaderDefault";
            this.fpsSearchResult_Sheet1.SheetCornerStyle.Parent = "CornerDefault";
            this.fpsSearchResult_Sheet1.RowChanged += new FarPoint.Win.Spread.SheetViewEventHandler(this.fpsSearchResult_Sheet1_RowChanged);
            this.fpsSearchResult_Sheet1.ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.A1;
            this.fpsSearchResult.SetActiveViewport(0, 1, 0);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssSearchCount});
            this.statusStrip1.Location = new System.Drawing.Point(0, 442);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(963, 22);
            this.statusStrip1.TabIndex = 19;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tssSearchCount
            // 
            this.tssSearchCount.Name = "tssSearchCount";
            this.tssSearchCount.Size = new System.Drawing.Size(114, 17);
            this.tssSearchCount.Text = "ผลการค้นหา 0 รายการ";
            // 
            // frmStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 464);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.fpsSearchResult);
            this.Controls.Add(this.grbSearch);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmStaff";
            this.Text = "รายชื่อพนักงาน";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmStaff_FormClosed);
            this.Load += new System.EventHandler(this.frmStaff_Load);
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
        private System.Windows.Forms.Label label1;
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}