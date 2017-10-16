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

namespace BSSoft.iBeef.tsmSettings
{
    public partial class frmDepartment: Form
    {
        public frmDepartment()
        {
            InitializeComponent();
        }

        #region Function

        private void initData()
        {
            this.Text += " : " + this.Name;
        }

        #endregion



        #region Event

        private void tsbAddNew_Click(object sender, EventArgs e)
        {
            frmEditDepartment frmEditType = new frmEditDepartment(pIsNewMode: true);
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

        private void frmDepartment_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainFunction.AddOrRemaveChildName(pMdiParent: (mdiMain)this.MdiParent,
                pChildName: this.Name,
                pChildText: this.Text,
                pIsAdd: false);
        }
      #endregion

        private void frmDepartment_Load(object sender, EventArgs e)
        {
            initData();
        }

    }
}
