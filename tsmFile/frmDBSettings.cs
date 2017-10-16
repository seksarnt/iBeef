using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BSSoft.iBeef.tsmFile
{
    public partial class frmDBSettings : Form
    {
        public frmDBSettings()
        {
            InitializeComponent();
        }

        private bool _isModify = false;


        #region Function

        private void setEnable()
        {
            this.tsbSave.Enabled = _isModify;
        }

        private void loadServer()
        {

        }


        #endregion





        #region Event

        private void frmDBSettings_Load(object sender, EventArgs e)
        {
            this.cboAuthenType.SelectedIndex = 0;

            _isModify = false;
            setEnable();
        }


        private void tsbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cboAuthenType_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool isEnable = this.cboAuthenType.SelectedIndex == 1;
            this.txtUserName.ReadOnly = !isEnable;
            this.txtpassword.ReadOnly = !isEnable;

            if (isEnable)
            {
                this.txtUserName.Focus();
                this.txtUserName.SelectAll();
            }

            _isModify = true;
            setEnable();
        }

        private void txtpassword_TextChanged(object sender, EventArgs e)
        {
            _isModify = true;
            setEnable();
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {
            _isModify = true;
            setEnable();
        }

        private void cboServer_SelectedIndexChanged(object sender, EventArgs e)
        {
            _isModify = true;
            setEnable();
        }

        private void cboServer_TextChanged(object sender, EventArgs e)
        {
            _isModify = true;
            setEnable();
        }

        private void cboDatabase_TextChanged(object sender, EventArgs e)
        {
            _isModify = true;
            setEnable();
        }

        private void cboServer_DropDown(object sender, EventArgs e)
        {
            if (this.cboServer.Items.Count == 0)
            {
                loadServer();
            }
        }

        private void btnTestConnection_Click(object sender, EventArgs e)
        {

        }

        #endregion


    }
}
