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
    public partial class frmMOrgaization : Form
    {
        public frmMOrgaization()
        {
            InitializeComponent();
        }

        #region Variable
        private bool _isModify = false;
        #endregion





        #region Function

        private void enableSave()
        {
            this.tsbSave.Enabled = _isModify;
        }

        #endregion






        #region Event

        private void tsbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void allControl_TextChanged(object sender, EventArgs e)
        {
            _isModify = true;
            enableSave();
        }

        #endregion
    }
}
