using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlsLib
{
    public partial class WPump : UserControl
    {
        public WPump()
        {
            InitializeComponent();
        }
        private bool isRun = false;
        public bool IsRun
        {
            get { return isRun; }
            set
            {
                isRun = value;
                if (value)
                {
                    this.panel1.BackgroundImage = Properties.Resources.PumpOff;
                }
                else
                {
                    this.panel1.BackgroundImage = Properties.Resources.PumpOn;
                }
            }
        }
    }
}
