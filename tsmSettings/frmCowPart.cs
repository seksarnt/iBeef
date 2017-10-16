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
    public partial class frmCowPart : Form
    {
        public frmCowPart()
        {
            InitializeComponent();
        }





        #region Event

        private void tsbAddNew_Click(object sender, EventArgs e)
        {
            frmEditCowPart frmEditType = new frmEditCowPart(pIsNewMode: true);
            if (frmEditType.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {

            }
            frmEditType.Dispose();
            frmEditType = null;
        }

        private void tsbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion


    }
}
