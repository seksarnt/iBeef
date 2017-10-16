using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BSSoft.iBeef.tsmStaff;

namespace BSSoft.iBeef.tsmCowList
{
    public partial class frmCowList : Form
    {
        public frmCowList()
        {
            InitializeComponent();
        }



        #region Variable

        const int _col_check = 0;
        const int _col_code = 1;
        const int _col_name = 2;
        const int _col_province = 3;
        const int _col_amphur = 4;
        const int _col_tumbon = 5;
        const int _col_tel = 6;
        const int _col_cowcount = 7;
        const int _col_cowproducted = 8;
        const int _col_cowwait = 9;
        const int _col_remark = 10;

        #endregion




        #region Function

        /// <summary>
        /// สำหรับเปิด/ปิดปุ่มลบ เมื่อมีการเลือกหรือไม่เลือกแถว
        /// </summary>
        private void enableDelete()
        {
            bool isSelected = false;

            for (int rowIndex = 0; rowIndex <= this.fpsSearchResult_Sheet1.RowCount - 1; rowIndex++)
            {
                if ((bool)this.fpsSearchResult_Sheet1.Cells.Get(rowIndex, _col_check).Value == true)
                {
                    isSelected = true;
                    break;
                }
            }

            this.tsbDelete.Enabled = isSelected;
        }

        private void editCow(bool pIsNewMode)
        {
            if (pIsNewMode)
            {
                frmEditStaff frmStaff = new frmEditStaff();
                if (frmStaff.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {

                }
                frmStaff.Dispose();
                frmStaff = null;
            }
            else
            {
                string memberCode = this.fpsSearchResult_Sheet1.Cells.Get(row: this.fpsSearchResult_Sheet1.ActiveRowIndex, column: _col_code).Text;
                frmEditStaff frmStaff = new frmEditStaff();
                if (frmStaff.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {

                }
                frmStaff.Dispose();
                frmStaff = null;
            }
        }

        #endregion







        #region Event

        private void tsbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fpsSearchResult_ButtonClicked(object sender, FarPoint.Win.Spread.EditorNotifyEventArgs e)
        {
            if (e.Column == _col_check)
            {

            }
        }

        private void fpsSearchResult_Sheet1_RowChanged(object sender, FarPoint.Win.Spread.SheetViewEventArgs e)
        {
            this.tsbPrint.Enabled = (this.fpsSearchResult_Sheet1.RowCount > 0);
        }
        #endregion

        private void tsbAddNew_Click(object sender, EventArgs e)
        {
            editCow(pIsNewMode: true);
        }

        private void fpsSearchResult_DoubleClick(object sender, EventArgs e)
        {
            editCow(pIsNewMode: false);
        }




    }
}
