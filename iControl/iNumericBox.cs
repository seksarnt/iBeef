using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BSSoft.iBeef.iControl
{
    public partial class iNumericBox : NumericUpDown
    {
        public iNumericBox()
        {
            InitializeComponent();
            Controls[0].Visible = false;
            this.UpDownAlign = LeftRightAlignment.Left;
            this.DecimalPlaces = 2;
            this.InterceptArrowKeys = false;
            this.TextAlign = HorizontalAlignment.Right;
            this.ThousandsSeparator = false;
            this.Width = 100;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.Clear(SystemColors.Window);
            base.OnPaint(e);
        }
    }
}
