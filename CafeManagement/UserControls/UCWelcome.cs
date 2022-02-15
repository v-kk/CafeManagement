using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeManagement.UserControls
{
    public partial class UCWelcome : UserControl
    {
        public UCWelcome()
        {
            InitializeComponent();
        }

        int num = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (num == 0)
            {
                lblCafe.ForeColor = Color.CornflowerBlue;
                num++;
            }
            else if (num == 1)
            {
                lblCafe.ForeColor = Color.Orange;
                num++;
            }
            else if (num == 2)
            {
                lblCafe.ForeColor = Color.IndianRed;
                num++;
            }
            else if (num == 3)
            {
                lblCafe.ForeColor = Color.DarkViolet;
                num++;
            }
            else if (num == 4)
            {
                lblCafe.ForeColor = Color.GreenYellow;
                num = 0;
            }
        }

        private void UCWelcome_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
