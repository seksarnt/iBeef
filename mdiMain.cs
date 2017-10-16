using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BSSoft.iBeef.tsmFile;
using BSSoft.iBeef.tsmMember;
using BSSoft.iBeef.Static;
using BSSoft.iBeef.tsmStaff;
using BSSoft.iBeef.tsmSettings;
using BSSoft.iBeef.tsmCowList;

namespace BSSoft.iBeef
{
    public partial class mdiMain : Form
    {
        public mdiMain()
        {
            InitializeComponent();
        }




        #region Function

        private void organizationSettings()
        {
            frmMOrgaization frmOrg = new frmMOrgaization();
            frmOrg.ShowDialog();
            frmOrg.Dispose();
            frmOrg = null;
        }

        private void databaseSettings()
        {
            frmDBSettings frmDBSettings = new frmDBSettings();
            frmDBSettings.ShowDialog();
            frmDBSettings.Dispose();
            frmDBSettings = null;
        }

        private void exitApp()
        {
            this.Close();
        }


        private void openChildren(PageNo pPageNo)
        {

            Type targetFormType = typeof(frmCowPart);

            if (pPageNo == PageNo.ManageStaff)
            {
                targetFormType = typeof(frmStaff);
            }
            else if (pPageNo == PageNo.ManageMember)
            {
                targetFormType = typeof(frmMember);
            }
            else if (pPageNo == PageNo.CowType)
            {
                targetFormType = typeof(frmCowType);
            }
            else if (pPageNo == PageNo.CowPart)
            {
                targetFormType = typeof(frmCowPart);
            }
            else if (pPageNo == PageNo.StaffTimeStamp)
            {
                targetFormType = typeof(frmStaffTimeStamp);
            }
            else if (pPageNo == PageNo.CowList)
            {
                targetFormType = typeof(frmCowList);
            }

            bool isExist = false;
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == targetFormType)
                {
                    f.WindowState = FormWindowState.Maximized;
                    f.Activate();
                    isExist = true;
                    break;
                }
            }

            if (!isExist)
            {

                Form targetForm = null;

                if (pPageNo == PageNo.ManageStaff)
                {
                    targetForm = new frmStaff();
                }
                else if (pPageNo == PageNo.ManageMember)
                {
                    targetForm = new frmMember();
                }
                else if (pPageNo == PageNo.CowType)
                {
                    targetForm = new frmCowType();
                }
                else if (pPageNo == PageNo.CowPart)
                {
                    targetForm = new frmCowPart();
                }
                else if (pPageNo == PageNo.StaffTimeStamp)
                {
                    targetForm = new frmStaffTimeStamp(); ;
                }
                else if (pPageNo == PageNo.CowList)
                {
                    targetForm = new frmCowList();
                }

                targetForm.MdiParent = this;
                targetForm.WindowState = FormWindowState.Maximized;
                targetForm.Show();
            }
        }

        #endregion














        #region Event

        private void mnuOrganization_Click(object sender, EventArgs e)
        {
            organizationSettings();
        }

        private void mnuDBSettings_Click(object sender, EventArgs e)
        {
            databaseSettings();
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            exitApp();
        }
        #endregion

        private void mnuStaff_Click(object sender, EventArgs e)
        {
            openChildren(pPageNo: PageNo.ManageStaff);
        }

        private void mnuMember_Click(object sender, EventArgs e)
        {
            openChildren(pPageNo: PageNo.ManageMember);
        }

        private void mnuSettingCowType_Click(object sender, EventArgs e)
        {
            openChildren(pPageNo: PageNo.CowType);
        }

        private void mnuSettingCowPart_Click(object sender, EventArgs e)
        {
            openChildren(pPageNo: PageNo.CowPart);
        }

        private void mnuOntime_Click(object sender, EventArgs e)
        {
            openChildren(pPageNo: PageNo.StaffTimeStamp);
        }

        private void tsmCowList_Click(object sender, EventArgs e)
        {
            openChildren(pPageNo: PageNo.CowList);
        }




    }
}
