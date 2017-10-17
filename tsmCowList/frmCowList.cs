using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BSSoft.iBeef.Static;
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
        const int _col_moreinfo = 2;
        const int _col_name = 3;
        const int _col_stall = 4;
        const int _col_location = 5;
        const int _col_breed_color = 6;
        const int _col_registdate = 7;
        const int _col_state = 8;
        const int _col_grade = 9;
        const int _col_cowcount = 10;
        const int _col_cowproducted = 11;
        const int _col_cowwait = 12;
        const int _col_remark = 13;


        FarPoint.Win.Spread.CellType.ComboBoxCellType _cboCowState = new FarPoint.Win.Spread.CellType.ComboBoxCellType();
        FarPoint.Win.Spread.CellType.ComboBoxCellType _cboCowGrade = new FarPoint.Win.Spread.CellType.ComboBoxCellType();
        #endregion




        #region Function

        private void initData()
        {
            this.Text += " : " + this.Name;

            _cboCowState.ItemData = new string[] { "1", "2", "3", "4", "5" };
            _cboCowState.Items = new string[] { "ทั้งหมด", "ยังไม่ได้เชือด/ไม่ได้อยู่ในคิว", "ยังไม่ได้เชือด/อยู่ในคิว", "เชือดแล้ว", "ตาย/อื่นๆ" };
            _cboCowState.EditorValue = FarPoint.Win.Spread.CellType.EditorValue.ItemData;
            this.fpsSearchResult_Sheet1.Columns.Get(_col_state).CellType = _cboCowState;

            _cboCowGrade.ItemData = new string[] { "1", "2", "3", "4" };
            _cboCowGrade.Items = new string[] { "A", "B", "C", "D" };
            _cboCowGrade.EditorValue = FarPoint.Win.Spread.CellType.EditorValue.ItemData;
            this.fpsSearchResult_Sheet1.Columns.Get(_col_grade).CellType = _cboCowGrade;

        }

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

        private void frmCowList_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainFunction.AddOrRemaveChildName(pMdiParent: (mdiMain)this.MdiParent,
               pChildName: this.Name,
               pChildText: this.Text,
               pIsAdd: false);
        }

        private void frmCowList_Load(object sender, EventArgs e)
        {
            initData();
        }




    }
}
