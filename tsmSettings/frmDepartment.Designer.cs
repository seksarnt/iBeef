namespace BSSoft.iBeef.tsmSettings
{
    partial class frmDepartment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDepartment));
            FarPoint.Win.Spread.DefaultScrollBarRenderer defaultScrollBarRenderer1 = new FarPoint.Win.Spread.DefaultScrollBarRenderer();
            FarPoint.Win.Spread.DefaultScrollBarRenderer defaultScrollBarRenderer2 = new FarPoint.Win.Spread.DefaultScrollBarRenderer();
            FarPoint.Win.Spread.CellType.CheckBoxCellType checkBoxCellType3 = new FarPoint.Win.Spread.CellType.CheckBoxCellType();
            FarPoint.Win.Spread.CellType.TextCellType textCellType7 = new FarPoint.Win.Spread.CellType.TextCellType();
            FarPoint.Win.Spread.CellType.TextCellType textCellType8 = new FarPoint.Win.Spread.CellType.TextCellType();
            FarPoint.Win.Spread.CellType.TextCellType textCellType9 = new FarPoint.Win.Spread.CellType.TextCellType();
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
            this.chkOnlyInActive = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearchName = new System.Windows.Forms.TextBox();
            this.txtSearchCode = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.fpsCowPart = new FarPoint.Win.Spread.FpSpread();
            this.fpsCowPart_Sheet1 = new FarPoint.Win.Spread.SheetView();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fpsCowPart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fpsCowPart_Sheet1)).BeginInit();
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
            this.toolStrip1.Size = new System.Drawing.Size(739, 48);
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
            this.groupBox1.Controls.Add(this.chkOnlyInActive);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtSearchName);
            this.groupBox1.Controls.Add(this.txtSearchCode);
            this.groupBox1.Location = new System.Drawing.Point(8, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(723, 81);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ค้นหา";
            // 
            // chkOnlyInActive
            // 
            this.chkOnlyInActive.AutoSize = true;
            this.chkOnlyInActive.Location = new System.Drawing.Point(107, 49);
            this.chkOnlyInActive.Name = "chkOnlyInActive";
            this.chkOnlyInActive.Size = new System.Drawing.Size(166, 20);
            this.chkOnlyInActive.TabIndex = 6;
            this.chkOnlyInActive.Text = "แสดงเฉพาะที่ยกเลิกใช้งานแล้ว";
            this.chkOnlyInActive.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(318, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "ชื่อแผนก:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "รหัสแผนก:";
            // 
            // txtSearchName
            // 
            this.txtSearchName.Location = new System.Drawing.Point(397, 21);
            this.txtSearchName.Name = "txtSearchName";
            this.txtSearchName.Size = new System.Drawing.Size(170, 22);
            this.txtSearchName.TabIndex = 1;
            // 
            // txtSearchCode
            // 
            this.txtSearchCode.Location = new System.Drawing.Point(107, 21);
            this.txtSearchCode.Name = "txtSearchCode";
            this.txtSearchCode.Size = new System.Drawing.Size(170, 22);
            this.txtSearchCode.TabIndex = 0;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 419);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(739, 22);
            this.statusStrip1.TabIndex = 20;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(114, 17);
            this.toolStripStatusLabel1.Text = "ผลการค้นหา 0 รายการ";
            // 
            // fpsCowPart
            // 
            this.fpsCowPart.About = "4.0.2001.2005";
            this.fpsCowPart.AccessibleDescription = "fpsCowType, Sheet1";
            this.fpsCowPart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fpsCowPart.BackColor = System.Drawing.SystemColors.Control;
            this.fpsCowPart.FocusRenderer = ((FarPoint.Win.Spread.IFocusIndicatorRenderer)(resources.GetObject("fpsCowPart.FocusRenderer")));
            this.fpsCowPart.HorizontalScrollBar.Buttons = new FarPoint.Win.Spread.FpScrollBarButtonCollection("BackwardLineButton,ThumbTrack,ForwardLineButton");
            this.fpsCowPart.HorizontalScrollBar.Name = "";
            this.fpsCowPart.HorizontalScrollBar.Renderer = defaultScrollBarRenderer1;
            this.fpsCowPart.HorizontalScrollBar.TabIndex = 7;
            this.fpsCowPart.HorizontalScrollBarPolicy = FarPoint.Win.Spread.ScrollBarPolicy.AsNeeded;
            this.fpsCowPart.Location = new System.Drawing.Point(8, 153);
            this.fpsCowPart.Name = "fpsCowPart";
            this.fpsCowPart.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fpsCowPart.Sheets.AddRange(new FarPoint.Win.Spread.SheetView[] {
            this.fpsCowPart_Sheet1});
            this.fpsCowPart.Size = new System.Drawing.Size(723, 263);
            this.fpsCowPart.Skin = FarPoint.Win.Spread.DefaultSpreadSkins.Classic;
            this.fpsCowPart.TabIndex = 21;
            this.fpsCowPart.VerticalScrollBar.Buttons = new FarPoint.Win.Spread.FpScrollBarButtonCollection("BackwardLineButton,ThumbTrack,ForwardLineButton");
            this.fpsCowPart.VerticalScrollBar.Name = "";
            this.fpsCowPart.VerticalScrollBar.Renderer = defaultScrollBarRenderer2;
            this.fpsCowPart.VerticalScrollBar.TabIndex = 8;
            // 
            // fpsCowPart_Sheet1
            // 
            this.fpsCowPart_Sheet1.Reset();
            this.fpsCowPart_Sheet1.SheetName = "Sheet1";
            // Formulas and custom names must be loaded with R1C1 reference style
            this.fpsCowPart_Sheet1.ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.R1C1;
            this.fpsCowPart_Sheet1.ColumnCount = 5;
            this.fpsCowPart_Sheet1.RowCount = 0;
            this.fpsCowPart_Sheet1.ColumnHeader.Cells.Get(0, 0).Value = "...";
            this.fpsCowPart_Sheet1.ColumnHeader.Cells.Get(0, 1).Value = "สถานะ";
            this.fpsCowPart_Sheet1.ColumnHeader.Cells.Get(0, 2).Value = "รหัสแผนก";
            this.fpsCowPart_Sheet1.ColumnHeader.Cells.Get(0, 3).Value = "ชื่อแผนก";
            this.fpsCowPart_Sheet1.ColumnHeader.Cells.Get(0, 4).Value = "หมายเหตุ";
            this.fpsCowPart_Sheet1.ColumnHeader.DefaultStyle.Parent = "HeaderDefault";
            this.fpsCowPart_Sheet1.Columns.Get(0).CellType = checkBoxCellType3;
            this.fpsCowPart_Sheet1.Columns.Get(0).Label = "...";
            this.fpsCowPart_Sheet1.Columns.Get(0).Resizable = false;
            this.fpsCowPart_Sheet1.Columns.Get(0).Width = 25F;
            this.fpsCowPart_Sheet1.Columns.Get(1).CellType = textCellType7;
            this.fpsCowPart_Sheet1.Columns.Get(1).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center;
            this.fpsCowPart_Sheet1.Columns.Get(1).Label = "สถานะ";
            this.fpsCowPart_Sheet1.Columns.Get(1).Locked = true;
            this.fpsCowPart_Sheet1.Columns.Get(1).Width = 120F;
            this.fpsCowPart_Sheet1.Columns.Get(2).CellType = textCellType8;
            this.fpsCowPart_Sheet1.Columns.Get(2).Label = "รหัสแผนก";
            this.fpsCowPart_Sheet1.Columns.Get(2).Locked = true;
            this.fpsCowPart_Sheet1.Columns.Get(2).Width = 200F;
            this.fpsCowPart_Sheet1.Columns.Get(3).CellType = textCellType9;
            this.fpsCowPart_Sheet1.Columns.Get(3).Label = "ชื่อแผนก";
            this.fpsCowPart_Sheet1.Columns.Get(3).Locked = true;
            this.fpsCowPart_Sheet1.Columns.Get(3).Width = 220F;
            this.fpsCowPart_Sheet1.Columns.Get(4).Label = "หมายเหตุ";
            this.fpsCowPart_Sheet1.Columns.Get(4).Locked = true;
            this.fpsCowPart_Sheet1.Columns.Get(4).Width = 250F;
            this.fpsCowPart_Sheet1.RowHeader.Columns.Default.Resizable = false;
            this.fpsCowPart_Sheet1.RowHeader.DefaultStyle.Parent = "RowHeaderDefault";
            this.fpsCowPart_Sheet1.SheetCornerStyle.Parent = "CornerDefault";
            this.fpsCowPart_Sheet1.ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.A1;
            this.fpsCowPart.SetActiveViewport(0, 1, 0);
            // 
            // frmDepartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 441);
            this.Controls.Add(this.fpsCowPart);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmDepartment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ตั้งค่าแผนก";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmDepartment_FormClosed);
            this.Load += new System.EventHandler(this.frmDepartment_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fpsCowPart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fpsCowPart_Sheet1)).EndInit();
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
        private System.Windows.Forms.TextBox txtSearchName;
        private System.Windows.Forms.TextBox txtSearchCode;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.CheckBox chkOnlyInActive;
        private FarPoint.Win.Spread.SheetView fpsCowPart_Sheet1;
        private FarPoint.Win.Spread.FpSpread fpsCowPart;
    }
}