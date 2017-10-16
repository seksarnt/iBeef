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
    public partial class frmEditFaction : Form
    {
        public frmEditFaction(bool pIsNewMode)
        {
            InitializeComponent();

            _isNewMode = pIsNewMode;
        }

        #region Properties

        public string FactionCode { get; set; }
        public string FactionName { get; set; }
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
                this.Load -= this.frmEditFaction_Load;

                this.txtCode.Text = this.FactionCode;
                this.txtName.Text = this.FactionName;
                this.txtRemark.Text = this.Remark;
                this.chkInActive.Checked = this.InActive;

                this.Text = "แก้ไขฝ่าย";
                this.txtCode.ReadOnly = true;

                this.Load += new System.EventHandler(this.frmEditFaction_Load);
            }
            else
            {
                this.Text = "เพิ่มฝ่าย";
                this.txtCode.ReadOnly = false;
            }
        }

        private void enableSave()
        {
            this.tsbSave.Enabled = _isModify;
        }


        private bool saveData()
        {
            this.FactionCode = this.txtCode.Text.Trim();
            this.FactionName = this.txtName.Text.Trim();
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

        private void frmEditFaction_Load(object sender, EventArgs e)
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
