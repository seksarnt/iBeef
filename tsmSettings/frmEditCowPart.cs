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
    public partial class frmEditCowPart : Form
    {
        public frmEditCowPart(bool pIsNewMode)
        {
            InitializeComponent();

            _isNewMode = pIsNewMode;
        }





        #region Variable

            private bool _isModify = false;
            private bool _isNewMode = true;
        #endregion


        #region Function

        private void enableSave()
        {
            this.tsbSave.Enabled = _isModify;
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
            _isModify = false;
            enableSave();
        }

        private void tsbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion


    }
}
