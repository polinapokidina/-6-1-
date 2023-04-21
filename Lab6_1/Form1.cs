using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab6_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tmr_Tick(object sender, EventArgs e)
        {
            if (pct.Left + pct.Width > this.Size.Width)
            {
                tmr.Stop();
            }

            else
            {
                pct.Left = pct.Left + 20;
            }
            
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (!tmr.Enabled)
            {
                pct.Location = new Point(12, 12); 
                tmr.Enabled = true;
                tmr.Interval = 50;
                btnStart.Text = "Стоп";
            }
            
            else
            {
                tmr.Enabled = false;
                btnStart.Text = "Старт";
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
