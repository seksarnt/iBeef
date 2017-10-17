using System;
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


        public ToolStripMenuItem WindowMenu
        {
            get
            {
                return this.tsmWindows;
            }
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
            else if (pPageNo == PageNo.Department)
            {
                targetFormType = typeof(frmDepartment);
            }
            else if (pPageNo == PageNo.Faction)
            {
                targetFormType = typeof(frmFaction);
            }

            // tsmMainData
            else if (pPageNo == PageNo.CowBreed)
            {
                targetFormType = typeof(frmCowBreed);
            }
            else if (pPageNo == PageNo.CowHorn)
            {
                targetFormType = typeof(frmCowHorn);
            }
            else if (pPageNo == PageNo.CowPurpose)
            {
                targetFormType = typeof(frmCowPurpose);
            }
            else if (pPageNo == PageNo.CowStatus)
            {
                targetFormType = typeof(frmCowStatus);
            }
            else if (pPageNo == PageNo.CowGrowUpLevel)
            {
                targetFormType = typeof(frmCowGrowLevel);
            }
            else if (pPageNo == PageNo.CowColor)
            {
                targetFormType = typeof(frmCowColor);
            }
            else if (pPageNo == PageNo.CowStall)
            {
                targetFormType = typeof(frmCowStall);
            }
            else if (pPageNo == PageNo.CowLocation)
            {
                targetFormType = typeof(frmCowLocation);
            }

            bool isExist = false;
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == targetFormType)
                {
                    f.Activate();
                    if (f.WindowState != FormWindowState.Maximized)
                    {
                        f.WindowState = FormWindowState.Maximized;
                    }
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
                else if (pPageNo == PageNo.Department)
                {
                    targetForm = new frmDepartment();
                }
                else if (pPageNo == PageNo.Faction)
                {
                    targetForm = new frmFaction();
                }

                    // tsmMainData
                else if (pPageNo == PageNo.CowBreed)
                {
                    targetForm = new frmCowBreed();
                }
                else if (pPageNo == PageNo.CowHorn)
                {
                    targetForm = new frmCowHorn();
                }
                else if (pPageNo == PageNo.CowPurpose)
                {
                    targetForm = new frmCowPurpose();
                }
                else if (pPageNo == PageNo.CowStatus)
                {
                    targetForm = new frmCowStatus();
                }
                else if (pPageNo == PageNo.CowGrowUpLevel)
                {
                    targetForm = new frmCowGrowLevel();
                }
                else if (pPageNo == PageNo.CowColor)
                {
                    targetForm = new frmCowColor();
                }
                else if (pPageNo == PageNo.CowStall)
                {
                    targetForm = new frmCowStall();
                }
                else if (pPageNo == PageNo.CowLocation)
                {
                    targetForm = new frmCowLocation();
                }

                targetForm.MdiParent = this;
                targetForm.Show();
                targetForm.WindowState = FormWindowState.Maximized;

                MainFunction.AddOrRemaveChildName(pMdiParent: this,
                    pChildName: targetForm.Name,
                    pChildText: targetForm.Text,
                    pIsAdd: true);
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


        #region TsmMainDataEvent

        private void mnuSettingCowPart_Click(object sender, EventArgs e)
        {
            openChildren(pPageNo: PageNo.CowPart);
        }

        private void mnuCowBreed_Click(object sender, EventArgs e)
        {
            openChildren(pPageNo: PageNo.CowBreed);
        }

        private void mnuCowHorn_Click(object sender, EventArgs e)
        {
            openChildren(pPageNo: PageNo.CowHorn);
        }

        private void mnuCowPurpose_Click(object sender, EventArgs e)
        {
            openChildren(pPageNo: PageNo.CowPurpose);
        }

        private void mnuCowStatus_Click(object sender, EventArgs e)
        {
            openChildren(pPageNo: PageNo.CowStatus);
        }

        private void mnuCowGrowUp_Click(object sender, EventArgs e)
        {
            openChildren(pPageNo: PageNo.CowGrowUpLevel);
        }

        private void mnuCowColor_Click(object sender, EventArgs e)
        {
            openChildren(pPageNo: PageNo.CowColor);
        }

        private void mnuCowStall_Click(object sender, EventArgs e)
        {
            openChildren(pPageNo: PageNo.CowStall);
        }

        private void mnuCowLocation_Click(object sender, EventArgs e)
        {
            openChildren(pPageNo: PageNo.CowLocation);
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

        private void mnuOntime_Click(object sender, EventArgs e)
        {
            openChildren(pPageNo: PageNo.StaffTimeStamp);
        }

        private void tsmCowList_Click(object sender, EventArgs e)
        {
            openChildren(pPageNo: PageNo.CowList);
        }

        private void mnuSettingsDepartment_Click(object sender, EventArgs e)
        {
            openChildren(pPageNo: PageNo.Department);
        }

        private void mnuSettingsFaction_Click(object sender, EventArgs e)
        {
            openChildren(pPageNo: PageNo.Faction);
        }

        private void tsmWindows_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            foreach (Form child in this.MdiChildren)
            {
                if (child.Name.ToLower() == e.ClickedItem.Name.ToLower())
                {
                    child.Activate();
                    break;
                }
            }
        }






    }
}
