using System;
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
    public partial class frmEditCowType : Form
    {
        public frmEditCowType(bool pIsNewMode)
        {
            InitializeComponent();

            _isNewMode = pIsNewMode;
        }

        #region Properties

        public string CowTypeCode { get; set; }
        public string CowTypeName { get; set; }
        public string Remark { get; set; }
        public bool InActive { get; set; }

        #endregion




        #region Variable

        private bool _isModify = false;
        private bool _isNewMode = true;
        #endregion


        #region Function

        private void initData()
        {
            if (!_isNewMode)
            {
                this.Load -= this.frmEditCowType_Load;

                this.txtCowTypeCode.Text = this.CowTypeCode;
                this.txtCowTypeName.Text = this.CowTypeName;
                this.txtRemark.Text = this.Remark;
                this.chkInActive.Checked = this.InActive;

                this.Text = "แก้ไขประเภทโค";
                this.txtCowTypeCode.ReadOnly = true;

                this.Load += new System.EventHandler(this.frmEditCowType_Load);
            }
            else
            {
                this.Text = "เพิ่มประเภทโค";
                this.txtCowTypeCode.ReadOnly = false;
            }
        }

        private void enableSave()
        {
            this.tsbSave.Enabled = _isModify;
        }


        private bool saveData()
        {
            this.CowTypeCode = this.txtCowTypeCode.Text.Trim();
            this.CowTypeName = this.txtCowTypeName.Text.Trim();
            this.Remark = this.txtRemark.Text.Trim();
            this.InActive = this.chkInActive.Checked;


            return true;
        }
        #endregion



        #region Event

        private void txtAll_TextChanged(object sender, EventArgs e)
        {
            _isModify = true;
            enableSave();
        }

        private void chkInActive_CheckedChanged(object sender, EventArgs e)
        {
            _isModify = true;
            enableSave();
        }

        private void frmEditCowType_Load(object sender, EventArgs e)
        {
            initData();

            _isModify = false;
            enableSave();
        }

        private void tsbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        private void tsbSave_Click(object sender, EventArgs e)
        {
            if (saveData())
            {
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                this.Close();
            }
        }


    }
}
