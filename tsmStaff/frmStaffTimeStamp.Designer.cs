namespace BSSoft.iBeef.tsmStaff
{
    partial class frmStaffTimeStamp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStaffTimeStamp));
            FarPoint.Win.Spread.DefaultScrollBarRenderer defaultScrollBarRenderer1 = new FarPoint.Win.Spread.DefaultScrollBarRenderer();
            FarPoint.Win.Spread.DefaultScrollBarRenderer defaultScrollBarRenderer2 = new FarPoint.Win.Spread.DefaultScrollBarRenderer();
            FarPoint.Win.Spread.CellType.TextCellType textCellType1 = new FarPoint.Win.Spread.CellType.TextCellType();
            FarPoint.Win.Spread.CellType.TextCellType textCellType2 = new FarPoint.Win.Spread.CellType.TextCellType();
            FarPoint.Win.Spread.CellType.TextCellType textCellType3 = new FarPoint.Win.Spread.CellType.TextCellType();
            FarPoint.Win.Spread.CellType.TextCellType textCellType4 = new FarPoint.Win.Spread.CellType.TextCellType();
            FarPoint.Win.Spread.CellType.ComboBoxCellType comboBoxCellType1 = new FarPoint.Win.Spread.CellType.ComboBoxCellType();
            FarPoint.Win.Spread.CellType.NumberCellType numberCellType1 = new FarPoint.Win.Spread.CellType.NumberCellType();
            FarPoint.Win.Spread.CellType.TextCellType textCellType5 = new FarPoint.Win.Spread.CellType.TextCellType();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbRefresh = new System.Windows.Forms.ToolStripButton();
            this.tsbSave = new System.Windows.Forms.ToolStripButton();
            this.tsbPrint = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbClose = new System.Windows.Forms.ToolStripButton();
            this.grbCriteria = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.fpsStaffList = new FarPoint.Win.Spread.FpSpread();
            this.fpsStaffList_Sheet1 = new FarPoint.Win.Spread.SheetView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1.SuspendLayout();
            this.grbCriteria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fpsStaffList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fpsStaffList_Sheet1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbRefresh,
            this.tsbSave,
            this.tsbPrint,
            this.toolStripSeparator1,
            this.tsbClose});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1085, 48);
            this.toolStrip1.TabIndex = 18;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbRefresh
            // 
            this.tsbRefresh.AutoSize = false;
            this.tsbRefresh.Image = global::BSSoft.iBeef.Properties.Resources.reload;
            this.tsbRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRefresh.Name = "tsbRefresh";
            this.tsbRefresh.Size = new System.Drawing.Size(55, 45);
            this.tsbRefresh.Text = "รีเฟรช";
            this.tsbRefresh.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsbRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // tsbSave
            // 
            this.tsbSave.AutoSize = false;
            this.tsbSave.Enabled = false;
            this.tsbSave.Image = global::BSSoft.iBeef.Properties.Resources.savedisk;
            this.tsbSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSave.Name = "tsbSave";
            this.tsbSave.Size = new System.Drawing.Size(55, 45);
            this.tsbSave.Text = "บันทึก";
            this.tsbSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsbSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
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
            // grbCriteria
            // 
            this.grbCriteria.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbCriteria.Controls.Add(this.label3);
            this.grbCriteria.Controls.Add(this.label2);
            this.grbCriteria.Controls.Add(this.label1);
            this.grbCriteria.Controls.Add(this.comboBox2);
            this.grbCriteria.Controls.Add(this.comboBox1);
            this.grbCriteria.Controls.Add(this.dateTimePicker1);
            this.grbCriteria.Location = new System.Drawing.Point(8, 66);
            this.grbCriteria.Margin = new System.Windows.Forms.Padding(4);
            this.grbCriteria.Name = "grbCriteria";
            this.grbCriteria.Padding = new System.Windows.Forms.Padding(4);
            this.grbCriteria.Size = new System.Drawing.Size(1069, 95);
            this.grbCriteria.TabIndex = 19;
            this.grbCriteria.TabStop = false;
            this.grbCriteria.Text = "เงื่อนไข";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(374, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "ฝ่าย:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "แผนก:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "วันที่:";
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(437, 50);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(184, 24);
            this.comboBox2.TabIndex = 2;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(129, 50);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(184, 24);
            this.comboBox1.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(129, 22);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(184, 22);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // fpsStaffList
            // 
            this.fpsStaffList.About = "4.0.2001.2005";
            this.fpsStaffList.AccessibleDescription = "fpsStaffList, Sheet1, Row 0, Column 0, EMP001";
            this.fpsStaffList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fpsStaffList.BackColor = System.Drawing.SystemColors.Control;
            this.fpsStaffList.FocusRenderer = ((FarPoint.Win.Spread.IFocusIndicatorRenderer)(resources.GetObject("fpsStaffList.FocusRenderer")));
            this.fpsStaffList.HorizontalScrollBar.Buttons = new FarPoint.Win.Spread.FpScrollBarButtonCollection("BackwardLineButton,ThumbTrack,ForwardLineButton");
            this.fpsStaffList.HorizontalScrollBar.Name = "";
            this.fpsStaffList.HorizontalScrollBar.Renderer = defaultScrollBarRenderer1;
            this.fpsStaffList.HorizontalScrollBar.TabIndex = 11;
            this.fpsStaffList.HorizontalScrollBarPolicy = FarPoint.Win.Spread.ScrollBarPolicy.AsNeeded;
            this.fpsStaffList.Location = new System.Drawing.Point(8, 168);
            this.fpsStaffList.Name = "fpsStaffList";
            this.fpsStaffList.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fpsStaffList.Sheets.AddRange(new FarPoint.Win.Spread.SheetView[] {
            this.fpsStaffList_Sheet1});
            this.fpsStaffList.Size = new System.Drawing.Size(1069, 284);
            this.fpsStaffList.Skin = FarPoint.Win.Spread.DefaultSpreadSkins.Classic;
            this.fpsStaffList.TabIndex = 20;
            this.fpsStaffList.VerticalScrollBar.Buttons = new FarPoint.Win.Spread.FpScrollBarButtonCollection("BackwardLineButton,ThumbTrack,ForwardLineButton");
            this.fpsStaffList.VerticalScrollBar.Name = "";
            this.fpsStaffList.VerticalScrollBar.Renderer = defaultScrollBarRenderer2;
            this.fpsStaffList.VerticalScrollBar.TabIndex = 12;
            this.fpsStaffList.ComboCloseUp += new FarPoint.Win.Spread.EditorNotifyEventHandler(this.fpsStaffList_ComboCloseUp);
            this.fpsStaffList.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.fpsStaffList_KeyPress);
            // 
            // fpsStaffList_Sheet1
            // 
            this.fpsStaffList_Sheet1.Reset();
            this.fpsStaffList_Sheet1.SheetName = "Sheet1";
            // Formulas and custom names must be loaded with R1C1 reference style
            this.fpsStaffList_Sheet1.ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.R1C1;
            this.fpsStaffList_Sheet1.ColumnCount = 7;
            this.fpsStaffList_Sheet1.ColumnHeader.RowCount = 2;
            this.fpsStaffList_Sheet1.RowCount = 3;
            this.fpsStaffList_Sheet1.Cells.Get(0, 0).Value = "EMP001";
            this.fpsStaffList_Sheet1.Cells.Get(0, 1).Value = "นายทดสอบ สุขเกษม";
            this.fpsStaffList_Sheet1.Cells.Get(0, 2).Value = "บัญชี";
            this.fpsStaffList_Sheet1.Cells.Get(0, 3).Value = "จัดซื้อ";
            this.fpsStaffList_Sheet1.Cells.Get(1, 0).Value = "EMP002";
            this.fpsStaffList_Sheet1.Cells.Get(1, 1).Value = "นายทดลอง ร่ำรวย";
            this.fpsStaffList_Sheet1.Cells.Get(1, 2).Value = "บัญชี";
            this.fpsStaffList_Sheet1.Cells.Get(1, 3).Value = "จัดซื้อ";
            this.fpsStaffList_Sheet1.Cells.Get(2, 0).Value = "EMP003";
            this.fpsStaffList_Sheet1.Cells.Get(2, 1).Value = "นายสมมุติ ใจดี";
            this.fpsStaffList_Sheet1.Cells.Get(2, 2).Value = "บัญชี";
            this.fpsStaffList_Sheet1.Cells.Get(2, 3).Value = "บุคคล";
            this.fpsStaffList_Sheet1.Cells.Get(2, 6).Value = "เป็นไข้หวัดใหญ่";
            this.fpsStaffList_Sheet1.ColumnHeader.Cells.Get(0, 0).RowSpan = 2;
            this.fpsStaffList_Sheet1.ColumnHeader.Cells.Get(0, 0).Value = "รหัสพนักงาน";
            this.fpsStaffList_Sheet1.ColumnHeader.Cells.Get(0, 1).RowSpan = 2;
            this.fpsStaffList_Sheet1.ColumnHeader.Cells.Get(0, 1).Value = "ชื่อ-สกุล";
            this.fpsStaffList_Sheet1.ColumnHeader.Cells.Get(0, 2).ColumnSpan = 2;
            this.fpsStaffList_Sheet1.ColumnHeader.Cells.Get(0, 2).Value = "สังกัด";
            this.fpsStaffList_Sheet1.ColumnHeader.Cells.Get(0, 4).RowSpan = 2;
            this.fpsStaffList_Sheet1.ColumnHeader.Cells.Get(0, 4).Value = "ประเภทการลงเวลา";
            this.fpsStaffList_Sheet1.ColumnHeader.Cells.Get(0, 5).RowSpan = 2;
            this.fpsStaffList_Sheet1.ColumnHeader.Cells.Get(0, 5).Value = "เวลาที่สาย(นาที)";
            this.fpsStaffList_Sheet1.ColumnHeader.Cells.Get(0, 6).RowSpan = 2;
            this.fpsStaffList_Sheet1.ColumnHeader.Cells.Get(0, 6).Value = "หมายเหตุ";
            this.fpsStaffList_Sheet1.ColumnHeader.Cells.Get(1, 2).Value = "แผนก";
            this.fpsStaffList_Sheet1.ColumnHeader.Cells.Get(1, 3).Value = "ฝ่าย";
            this.fpsStaffList_Sheet1.ColumnHeader.Cells.Get(1, 5).Value = "เวลาที่สาย(นาที)";
            this.fpsStaffList_Sheet1.ColumnHeader.DefaultStyle.Parent = "HeaderDefault";
            this.fpsStaffList_Sheet1.Columns.Get(0).CellType = textCellType1;
            this.fpsStaffList_Sheet1.Columns.Get(0).Locked = true;
            this.fpsStaffList_Sheet1.Columns.Get(0).Width = 119F;
            this.fpsStaffList_Sheet1.Columns.Get(1).CellType = textCellType2;
            this.fpsStaffList_Sheet1.Columns.Get(1).Locked = true;
            this.fpsStaffList_Sheet1.Columns.Get(1).Width = 181F;
            this.fpsStaffList_Sheet1.Columns.Get(2).CellType = textCellType3;
            this.fpsStaffList_Sheet1.Columns.Get(2).Label = "แผนก";
            this.fpsStaffList_Sheet1.Columns.Get(2).Locked = true;
            this.fpsStaffList_Sheet1.Columns.Get(2).Width = 125F;
            this.fpsStaffList_Sheet1.Columns.Get(3).CellType = textCellType4;
            this.fpsStaffList_Sheet1.Columns.Get(3).Label = "ฝ่าย";
            this.fpsStaffList_Sheet1.Columns.Get(3).Locked = true;
            this.fpsStaffList_Sheet1.Columns.Get(3).Width = 135F;
            comboBoxCellType1.ButtonAlign = FarPoint.Win.ButtonAlign.Right;
            this.fpsStaffList_Sheet1.Columns.Get(4).CellType = comboBoxCellType1;
            this.fpsStaffList_Sheet1.Columns.Get(4).Width = 123F;
            numberCellType1.DecimalPlaces = 0;
            numberCellType1.MaximumValue = 1440D;
            numberCellType1.MinimumValue = 1D;
            this.fpsStaffList_Sheet1.Columns.Get(5).CellType = numberCellType1;
            this.fpsStaffList_Sheet1.Columns.Get(5).Label = "เวลาที่สาย(นาที)";
            this.fpsStaffList_Sheet1.Columns.Get(5).Locked = true;
            this.fpsStaffList_Sheet1.Columns.Get(5).Width = 70F;
            this.fpsStaffList_Sheet1.Columns.Get(6).CellType = textCellType5;
            this.fpsStaffList_Sheet1.Columns.Get(6).Locked = true;
            this.fpsStaffList_Sheet1.Columns.Get(6).Width = 236F;
            this.fpsStaffList_Sheet1.RowHeader.Columns.Default.Resizable = true;
            this.fpsStaffList_Sheet1.RowHeader.DefaultStyle.Parent = "RowHeaderDefault";
            this.fpsStaffList_Sheet1.SheetCornerStyle.Parent = "CornerDefault";
            this.fpsStaffList_Sheet1.ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.A1;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 455);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1085, 22);
            this.statusStrip1.TabIndex = 21;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(89, 17);
            this.toolStripStatusLabel1.Text = "จำนวน 0 รายการ";
            // 
            // frmStaffTimeStamp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 477);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.fpsStaffList);
            this.Controls.Add(this.grbCriteria);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmStaffTimeStamp";
            this.Text = "ลงเวลาทำงาน";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmStaffTimeStamp_FormClosed);
            this.Load += new System.EventHandler(this.frmStaffTimeStamp_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.grbCriteria.ResumeLayout(false);
            this.grbCriteria.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fpsStaffList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fpsStaffList_Sheet1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbRefresh;
        private System.Windows.Forms.ToolStripButton tsbPrint;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbClose;
        private System.Windows.Forms.GroupBox grbCriteria;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private FarPoint.Win.Spread.SheetView fpsStaffList_Sheet1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private FarPoint.Win.Spread.FpSpread fpsStaffList;
        private System.Windows.Forms.ToolStripButton tsbSave;
    }
}