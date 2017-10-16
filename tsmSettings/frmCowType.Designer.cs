namespace BSSoft.iBeef.tsmSettings
{
    partial class frmCowType
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCowType));
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.fpsCowType = new FarPoint.Win.Spread.FpSpread();
            this.fpsCowType_Sheet1 = new FarPoint.Win.Spread.SheetView();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fpsCowType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fpsCowType_Sheet1)).BeginInit();
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
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(8, 66);
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
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "ชื่อประเภทโค:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "รหัสประเภทโค:";
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
            // fpsCowType
            // 
            this.fpsCowType.About = "4.0.2001.2005";
            this.fpsCowType.AccessibleDescription = "fpsCowType, Sheet1, Row 0, Column 0, ";
            this.fpsCowType.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fpsCowType.BackColor = System.Drawing.SystemColors.Control;
            this.fpsCowType.FocusRenderer = ((FarPoint.Win.Spread.IFocusIndicatorRenderer)(resources.GetObject("fpsCowType.FocusRenderer")));
            this.fpsCowType.HorizontalScrollBar.Buttons = new FarPoint.Win.Spread.FpScrollBarButtonCollection("BackwardLineButton,ThumbTrack,ForwardLineButton");
            this.fpsCowType.HorizontalScrollBar.Name = "";
            this.fpsCowType.HorizontalScrollBar.Renderer = defaultScrollBarRenderer1;
            this.fpsCowType.HorizontalScrollBar.TabIndex = 9;
            this.fpsCowType.HorizontalScrollBarPolicy = FarPoint.Win.Spread.ScrollBarPolicy.AsNeeded;
            this.fpsCowType.Location = new System.Drawing.Point(8, 153);
            this.fpsCowType.Name = "fpsCowType";
            this.fpsCowType.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fpsCowType.Sheets.AddRange(new FarPoint.Win.Spread.SheetView[] {
            this.fpsCowType_Sheet1});
            this.fpsCowType.Size = new System.Drawing.Size(848, 263);
            this.fpsCowType.Skin = FarPoint.Win.Spread.DefaultSpreadSkins.Classic;
            this.fpsCowType.TabIndex = 21;
            this.fpsCowType.VerticalScrollBar.Buttons = new FarPoint.Win.Spread.FpScrollBarButtonCollection("BackwardLineButton,ThumbTrack,ForwardLineButton");
            this.fpsCowType.VerticalScrollBar.Name = "";
            this.fpsCowType.VerticalScrollBar.Renderer = defaultScrollBarRenderer2;
            this.fpsCowType.VerticalScrollBar.TabIndex = 10;
            this.fpsCowType.CellDoubleClick += new FarPoint.Win.Spread.CellClickEventHandler(this.fpsCowType_CellDoubleClick);
            // 
            // fpsCowType_Sheet1
            // 
            this.fpsCowType_Sheet1.Reset();
            this.fpsCowType_Sheet1.SheetName = "Sheet1";
            // Formulas and custom names must be loaded with R1C1 reference style
            this.fpsCowType_Sheet1.ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.R1C1;
            this.fpsCowType_Sheet1.ColumnCount = 5;
            this.fpsCowType_Sheet1.RowCount = 3;
            this.fpsCowType_Sheet1.Cells.Get(0, 1).Value = "ใช้งาน";
            this.fpsCowType_Sheet1.Cells.Get(0, 2).Value = "001";
            this.fpsCowType_Sheet1.Cells.Get(0, 3).Value = "โคต้นน้ำ";
            this.fpsCowType_Sheet1.Cells.Get(1, 1).Value = "ใช้งาน";
            this.fpsCowType_Sheet1.Cells.Get(1, 2).Value = "002";
            this.fpsCowType_Sheet1.Cells.Get(1, 3).Value = "โคกลางน้ำ";
            this.fpsCowType_Sheet1.Cells.Get(2, 1).Value = "ยกเลิกใช้งาน";
            this.fpsCowType_Sheet1.Cells.Get(2, 2).Value = "003";
            this.fpsCowType_Sheet1.Cells.Get(2, 3).Value = "โคปลายน้ำ";
            this.fpsCowType_Sheet1.Cells.Get(2, 4).Value = "ระงับการเลี้ยงชั่วคราว";
            this.fpsCowType_Sheet1.ColumnHeader.Cells.Get(0, 0).Value = "...";
            this.fpsCowType_Sheet1.ColumnHeader.Cells.Get(0, 1).Value = "สถานะ";
            this.fpsCowType_Sheet1.ColumnHeader.Cells.Get(0, 2).Value = "รหัสประเภทโค";
            this.fpsCowType_Sheet1.ColumnHeader.Cells.Get(0, 3).Value = "ชื่อประเภทโค";
            this.fpsCowType_Sheet1.ColumnHeader.Cells.Get(0, 4).Value = "หมายเหตุ";
            this.fpsCowType_Sheet1.ColumnHeader.DefaultStyle.Parent = "HeaderDefault";
            this.fpsCowType_Sheet1.Columns.Get(0).CellType = checkBoxCellType1;
            this.fpsCowType_Sheet1.Columns.Get(0).Label = "...";
            this.fpsCowType_Sheet1.Columns.Get(0).Resizable = false;
            this.fpsCowType_Sheet1.Columns.Get(0).Width = 25F;
            this.fpsCowType_Sheet1.Columns.Get(1).CellType = textCellType1;
            this.fpsCowType_Sheet1.Columns.Get(1).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center;
            this.fpsCowType_Sheet1.Columns.Get(1).Label = "สถานะ";
            this.fpsCowType_Sheet1.Columns.Get(1).Locked = true;
            this.fpsCowType_Sheet1.Columns.Get(1).Width = 120F;
            this.fpsCowType_Sheet1.Columns.Get(2).CellType = textCellType2;
            this.fpsCowType_Sheet1.Columns.Get(2).Label = "รหัสประเภทโค";
            this.fpsCowType_Sheet1.Columns.Get(2).Locked = true;
            this.fpsCowType_Sheet1.Columns.Get(2).Width = 200F;
            this.fpsCowType_Sheet1.Columns.Get(3).CellType = textCellType3;
            this.fpsCowType_Sheet1.Columns.Get(3).Label = "ชื่อประเภทโค";
            this.fpsCowType_Sheet1.Columns.Get(3).Locked = true;
            this.fpsCowType_Sheet1.Columns.Get(3).Width = 220F;
            this.fpsCowType_Sheet1.Columns.Get(4).CellType = textCellType4;
            this.fpsCowType_Sheet1.Columns.Get(4).Label = "หมายเหตุ";
            this.fpsCowType_Sheet1.Columns.Get(4).Locked = true;
            this.fpsCowType_Sheet1.Columns.Get(4).Width = 250F;
            this.fpsCowType_Sheet1.RowHeader.Columns.Default.Resizable = false;
            this.fpsCowType_Sheet1.RowHeader.DefaultStyle.Parent = "RowHeaderDefault";
            this.fpsCowType_Sheet1.Rows.Get(2).ForeColor = System.Drawing.Color.Red;
            this.fpsCowType_Sheet1.SheetCornerStyle.Parent = "CornerDefault";
            this.fpsCowType_Sheet1.ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.A1;
            // 
            // frmCowType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 441);
            this.Controls.Add(this.fpsCowType);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmCowType";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCowType";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fpsCowType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fpsCowType_Sheet1)).EndInit();
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
        private FarPoint.Win.Spread.FpSpread fpsCowType;
        private FarPoint.Win.Spread.SheetView fpsCowType_Sheet1;
    }
}