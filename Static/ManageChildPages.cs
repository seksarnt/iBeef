using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BSSoft.iBeef.Static
{
    /// <summary>
    /// คลาสส่วนกลาง เก็บฟังก์ชั่นสาธาณณะต่างๆ
    /// </summary>
    public static class MainFunction
    {
        /// <summary>
        /// ฟังก์ชั่นสำหรับเพิ่ม/ลดเมนูในแถบเมนูหน้าต่าง
        /// </summary>
        /// <param name="pMdiParent">หน้าจอหลัก</param>
        /// <param name="pChildName">ชื่อเมนู/ชื่อฟอร์ม</param>
        /// <param name="pChildText">Titleเมนู/Titleฟอร์ม</param>
        /// <param name="pIsAdd">เป็นารเพิ่มเมนู</param>
        public static void AddOrRemaveChildName(mdiMain pMdiParent, string pChildName, string pChildText, bool pIsAdd)
        {
            if (pIsAdd)
            {
                //bool isExists = false;
                //foreach (Form child in pMdiParent.MdiChildren)
                //{
                //    if (child.Name.ToLower() == pChildName.ToLower())
                //    {
                //        isExists = true;
                //        break;
                //    }
                //}

                //if (!isExists)
                //{
                pMdiParent.WindowMenu.DropDownItems.Add(
                    new ToolStripMenuItem()
                    {
                        Name = pChildName,
                        Text = pChildText
                    });
                //}
            }
            else
            {
                foreach (ToolStripMenuItem menu in pMdiParent.WindowMenu.DropDownItems)
                {
                    if (menu.Name == pChildName)
                    {
                       pMdiParent.WindowMenu.DropDownItems.Remove(menu);
                        break;
                    }
                }
            }
        }
    }
}
