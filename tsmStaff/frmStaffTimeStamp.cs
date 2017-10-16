using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BSSoft.iBeef.tsmStaff
{
    public partial class frmStaffTimeStamp : Form
    {
        public frmStaffTimeStamp()
        {
            InitializeComponent();
        }

        #region Variable

        private FarPoint.Win.Spread.CellType.ComboBoxCellType _fpsStampType = new FarPoint.Win.Spread.CellType.ComboBoxCellType();

        const int _col_code = 0;
        const int _col_name = 1;
        const int _col_department = 2;
        const int _col_faction = 3;
        const int _col_stamptype = 4;
        const int _col_lateminutes = 5;
        const int _col_remark = 6;

        #endregion



        #region Function

        private void initData()
        {
            _fpsStampType.ItemData = new string[] { "1","2","3","4","5","6"};
            _fpsStampType.Items = new string[] { "ปกติ", "ขาด", "สาย","ลาป่วย","ลากิจ","อื่นๆ"};
            _fpsStampType.EditorValue = FarPoint.Win.Spread.CellType.EditorValue.ItemData;

            this.fpsStaffList_Sheet1.Columns.Get(_col_stamptype).CellType = _fpsStampType;


            this.fpsStaffList_Sheet1.Cells.Get(0, _col_stamptype).Value = "1";
            this.fpsStaffList_Sheet1.Cells.Get(1, _col_stamptype).Value = "3";
            this.fpsStaffList_Sheet1.Cells.Get(2, _col_stamptype).Value = "4";
        }

        #endregion




        #region Event

        private void frmStaffTimeStamp_Load(object sender, EventArgs e)
        {
            initData();
        }

        private void tsbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        private void fpsStaffList_ComboCloseUp(object sender, FarPoint.Win.Spread.EditorNotifyEventArgs e)
        {
            if (this.fpsStaffList_Sheet1.Cells.Get(e.Row, _col_stamptype).Value.ToString() == "3")
            {
                this.fpsStaffList_Sheet1.Cells.Get(e.Row, _col_lateminutes).Locked = false;
                this.fpsStaffList_Sheet1.Cells.Get(e.Row, _col_lateminutes).BackColor = Color.Gainsboro;
                this.fpsStaffList_Sheet1.Cells.Get(e.Row, _col_lateminutes).Border = new FarPoint.Win.BevelBorder(FarPoint.Win.BevelBorderType.Lowered);
                this.fpsStaffList_Sheet1.SetActiveCell(e.Row, _col_lateminutes);
              }
            else
            {
                this.fpsStaffList_Sheet1.Cells.Get(e.Row, _col_lateminutes).Locked = true;
                this.fpsStaffList_Sheet1.Cells.Get(e.Row, _col_lateminutes).ResetBackColor();
                this.fpsStaffList_Sheet1.Cells.Get(e.Row, _col_lateminutes).ResetBorder();
            }
        }

    }
}
