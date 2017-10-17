namespace BSSoft.iBeef.tsmSettings
{
    partial class frmCowStatus
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCowStatus));
            FarPoint.Win.Spread.DefaultScrollBarRenderer defaultScrollBarRenderer1 = new FarPoint.Win.Spread.DefaultScrollBarRenderer();
            FarPoint.Win.Spread.DefaultScrollBarRenderer defaultScrollBarRenderer2 = new FarPoint.Win.Spread.DefaultScrollBarRenderer();
            FarPoint.Win.Spread.CellType.CheckBoxCellType checkBoxCellType1 = new FarPoint.Win.Spread.CellType.CheckBoxCellType();
            FarPoint.Win.Spread.CellType.TextCellType textCellType1 = new FarPoint.Win.Spread.CellType.TextCellType();
            FarPoint.Win.Spread.CellType.TextCellType textCellType2 = new FarPoint.Win.Spread.CellType.TextCellType();
            FarPoint.Win.Spread.CellType.TextCellType textCellType3 = new FarPoint.Win.Spread.CellType.TextCellType();
            FarPoint.Win.Spread.CellType.TextCellType textCellType4 = new FarPoint.Win.Spread.CellType.TextCellType();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbSearch = new System.Windows.Forms.ToolStripButton();
            this.tsbAddNew = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbPrint = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbClose = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.fpsData = new FarPoint.Win.Spread.FpSpread();
            this.fpsData_Sheet1 = new FarPoint.Win.Spread.SheetView();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fpsData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fpsData_Sheet1)).BeginInit();
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
            this.tsbClose,
            this.toolStripLabel1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(864, 48);
            this.toolStrip1.TabIndex = 18;
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
            // toolStripLabel1
            // 
            this.toolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel1.Font = new System.Drawing.Font("Segoe UI", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel1.ForeColor = System.Drawing.Color.Silver;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(135, 45);
            this.toolStripLabel1.Text = "สถานะโค";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(8, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(848, 81);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ค้นหา";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(107, 49);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(166, 20);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "แสดงเฉพาะที่ยกเลิกใช้งานแล้ว";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(318, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "ชื่อสถานะ:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "รหัสสถานะ:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(397, 21);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(170, 22);
            this.textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(107, 21);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(170, 22);
            this.textBox1.TabIndex = 0;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 419);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(864, 22);
            this.statusStrip1.TabIndex = 20;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(114, 17);
            this.toolStripStatusLabel1.Text = "ผลการค้นหา 0 รายการ";
            // 
            // fpsData
            // 
            this.fpsData.About = "4.0.2001.2005";
            this.fpsData.AccessibleDescription = "fpsCowType, Sheet1";
            this.fpsData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fpsData.BackColor = System.Drawing.SystemColors.Control;
            this.fpsData.FocusRenderer = ((FarPoint.Win.Spread.IFocusIndicatorRenderer)(resources.GetObject("fpsData.FocusRenderer")));
            this.fpsData.HorizontalScrollBar.Buttons = new FarPoint.Win.Spread.FpScrollBarButtonCollection("BackwardLineButton,ThumbTrack,ForwardLineButton");
            this.fpsData.HorizontalScrollBar.Name = "";
            this.fpsData.HorizontalScrollBar.Renderer = defaultScrollBarRenderer1;
            this.fpsData.HorizontalScrollBar.TabIndex = 13;
            this.fpsData.HorizontalScrollBarPolicy = FarPoint.Win.Spread.ScrollBarPolicy.AsNeeded;
            this.fpsData.Location = new System.Drawing.Point(8, 142);
            this.fpsData.Name = "fpsData";
            this.fpsData.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fpsData.Sheets.AddRange(new FarPoint.Win.Spread.SheetView[] {
            this.fpsData_Sheet1});
            this.fpsData.Size = new System.Drawing.Size(848, 274);
            this.fpsData.Skin = FarPoint.Win.Spread.DefaultSpreadSkins.Classic;
            this.fpsData.TabIndex = 21;
            this.fpsData.VerticalScrollBar.Buttons = new FarPoint.Win.Spread.FpScrollBarButtonCollection("BackwardLineButton,ThumbTrack,ForwardLineButton");
            this.fpsData.VerticalScrollBar.Name = "";
            this.fpsData.VerticalScrollBar.Renderer = defaultScrollBarRenderer2;
            this.fpsData.VerticalScrollBar.TabIndex = 14;
            this.fpsData.CellDoubleClick += new FarPoint.Win.Spread.CellClickEventHandler(this.fpsCowType_CellDoubleClick);
            // 
            // fpsData_Sheet1
            // 
            this.fpsData_Sheet1.Reset();
            this.fpsData_Sheet1.SheetName = "Sheet1";
            // Formulas and custom names must be loaded with R1C1 reference style
            this.fpsData_Sheet1.ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.R1C1;
            this.fpsData_Sheet1.ColumnCount = 5;
            this.fpsData_Sheet1.RowCount = 0;
            this.fpsData_Sheet1.ColumnHeader.Cells.Get(0, 0).Value = "...";
            this.fpsData_Sheet1.ColumnHeader.Cells.Get(0, 1).Value = "สถานะ";
            this.fpsData_Sheet1.ColumnHeader.Cells.Get(0, 2).Value = "รหัสสถานะ";
            this.fpsData_Sheet1.ColumnHeader.Cells.Get(0, 3).Value = "ชื่อสถานะ";
            this.fpsData_Sheet1.ColumnHeader.Cells.Get(0, 4).Value = "หมายเหตุ";
            this.fpsData_Sheet1.ColumnHeader.DefaultStyle.Parent = "HeaderDefault";
            this.fpsData_Sheet1.Columns.Get(0).CellType = checkBoxCellType1;
            this.fpsData_Sheet1.Columns.Get(0).Label = "...";
            this.fpsData_Sheet1.Columns.Get(0).Resizable = false;
            this.fpsData_Sheet1.Columns.Get(0).Width = 25F;
            this.fpsData_Sheet1.Columns.Get(1).CellType = textCellType1;
            this.fpsData_Sheet1.Columns.Get(1).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center;
            this.fpsData_Sheet1.Columns.Get(1).Label = "สถานะ";
            this.fpsData_Sheet1.Columns.Get(1).Locked = true;
            this.fpsData_Sheet1.Columns.Get(1).Width = 120F;
            this.fpsData_Sheet1.Columns.Get(2).CellType = textCellType2;
            this.fpsData_Sheet1.Columns.Get(2).Label = "รหัสสถานะ";
            this.fpsData_Sheet1.Columns.Get(2).Locked = true;
            this.fpsData_Sheet1.Columns.Get(2).Width = 200F;
            this.fpsData_Sheet1.Columns.Get(3).CellType = textCellType3;
            this.fpsData_Sheet1.Columns.Get(3).Label = "ชื่อสถานะ";
            this.fpsData_Sheet1.Columns.Get(3).Locked = true;
            this.fpsData_Sheet1.Columns.Get(3).Width = 220F;
            this.fpsData_Sheet1.Columns.Get(4).CellType = textCellType4;
            this.fpsData_Sheet1.Columns.Get(4).Label = "หมายเหตุ";
            this.fpsData_Sheet1.Columns.Get(4).Locked = true;
            this.fpsData_Sheet1.Columns.Get(4).Width = 250F;
            this.fpsData_Sheet1.RowHeader.Columns.Default.Resizable = false;
            this.fpsData_Sheet1.RowHeader.DefaultStyle.Parent = "RowHeaderDefault";
            this.fpsData_Sheet1.SheetCornerStyle.Parent = "CornerDefault";
            this.fpsData_Sheet1.ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.A1;
            this.fpsData.SetActiveViewport(0, 1, 0);
            // 
            // frmCowStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 441);
            this.Controls.Add(this.fpsData);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmCowStatus";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "สถานะโค";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmCowType_FormClosed);
            this.Load += new System.EventHandler(this.frmCowType_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fpsData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fpsData_Sheet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbSearch;
        private System.Windows.Forms.ToolStripButton tsbAddNew;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsbDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tsbPrint;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbClose;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.CheckBox checkBox1;
        private FarPoint.Win.Spread.SheetView fpsData_Sheet1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private FarPoint.Win.Spread.FpSpread fpsData;
    }
}