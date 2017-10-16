﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BSSoft.iBeef.tsmSettings
{
    public partial class frmCowType : Form
    {
        public frmCowType()
        {
            InitializeComponent();
        }

        #region Variable

        const int _col_check = 0;
        const int _col_inactive = 1;
        const int _col_code = 2;
        const int _col_name = 3;
        const int _col_remark = 4;
        
        #endregion




        #region Event

        private void tsbAddNew_Click(object sender, EventArgs e)
        {
            frmEditCowType frmEditType = new frmEditCowType(pIsNewMode: true);
            if (frmEditType.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.fpsCowType_Sheet1.RowCount += 1;
                int rowIndex = this.fpsCowType_Sheet1.RowCount - 1;

                this.fpsCowType_Sheet1.Cells.Get(rowIndex, _col_check).Value = false;
                this.fpsCowType_Sheet1.Cells.Get(rowIndex, _col_code).Text = frmEditType.CowTypeCode;
                this.fpsCowType_Sheet1.Cells.Get(rowIndex, _col_name).Text = frmEditType.CowTypeName;
                this.fpsCowType_Sheet1.Cells.Get(rowIndex, _col_remark).Text = frmEditType.Remark;

                if (frmEditType.InActive == true)
                {
                    this.fpsCowType_Sheet1.Rows.Get(rowIndex).ForeColor = Color.Red;
                    this.fpsCowType_Sheet1.Cells.Get(rowIndex, _col_inactive).Text = "ยกเลิกใช้งาน";
                }
                else
                {
                    this.fpsCowType_Sheet1.Rows.Get(rowIndex).ForeColor = Color.FromKnownColor(KnownColor.ControlText);
                    this.fpsCowType_Sheet1.Cells.Get(rowIndex, _col_inactive).Text = "ใช้งาน";
                }
            }
            frmEditType.Dispose();
            frmEditType = null;
        }

        private void tsbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fpsCowType_CellDoubleClick(object sender, FarPoint.Win.Spread.CellClickEventArgs e)
        {

            frmEditCowType frmEditType = new frmEditCowType(pIsNewMode: false);
            frmEditType.CowTypeCode = this.fpsCowType_Sheet1.Cells.Get(e.Row, _col_code).Text;
            frmEditType.CowTypeName = this.fpsCowType_Sheet1.Cells.Get(e.Row, _col_name).Text;
            frmEditType.Remark = this.fpsCowType_Sheet1.Cells.Get(e.Row, _col_remark).Text;
            frmEditType.InActive = (this.fpsCowType_Sheet1.Cells.Get(e.Row, _col_inactive).Text == "ใช้งาน" ? false : true);

            if (frmEditType.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.fpsCowType_Sheet1.RowCount += 1;
                int rowIndex = this.fpsCowType_Sheet1.RowCount - 1;

                this.fpsCowType_Sheet1.Cells.Get(rowIndex, _col_check).Value = false;
                this.fpsCowType_Sheet1.Cells.Get(rowIndex, _col_code).Text = frmEditType.CowTypeCode;
                this.fpsCowType_Sheet1.Cells.Get(rowIndex, _col_name).Text = frmEditType.CowTypeName;
                this.fpsCowType_Sheet1.Cells.Get(rowIndex, _col_remark).Text = frmEditType.Remark;

                if (frmEditType.InActive == true)
                {
                    this.fpsCowType_Sheet1.Rows.Get(rowIndex).ForeColor = Color.Red;
                    this.fpsCowType_Sheet1.Cells.Get(rowIndex, _col_inactive).Text = "ยกเลิกใช้งาน";
                }
                else
                {
                    this.fpsCowType_Sheet1.Rows.Get(rowIndex).ForeColor = Color.FromKnownColor(KnownColor.ControlText);
                    this.fpsCowType_Sheet1.Cells.Get(rowIndex, _col_inactive).Text = "ใช้งาน";
                }
            }
            frmEditType.Dispose();
            frmEditType = null;
        }

        #endregion




    }
}