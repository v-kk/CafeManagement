using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeManagement
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        public Dashboard(string user)
        {
            InitializeComponent();

            if (user == "Guest")
            {
                btnAddItems.Hide();
                btnUpdateItems.Hide();
                btnRemoveItems.Hide();
            }
            else
            {
                btnAddItems.Show();
                btnPlaceOrder.Show();
                btnRemoveItems.Show();
                btnUpdateItems.Show();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAddItems_Click(object sender, EventArgs e)
        {
            ucWelcome1.SendToBack();
            gunaTransition1.ShowSync(ucAddItems1);
            ucAddItems1.Visible = true;
            ucPlaceOrder1.Visible = false;
            ucUpdateItems1.Visible = false;
            ucRemoveItems1.Visible = false;
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            ucWelcome1.Visible = true;
            ucWelcome1.BringToFront();
            ucAddItems1.Visible = false;
            ucPlaceOrder1.Visible = false;
            ucUpdateItems1.Visible = false;
            ucRemoveItems1.Visible = false;
        }

        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            ucWelcome1.SendToBack();
            gunaTransition2.ShowSync(ucPlaceOrder1);
            ucPlaceOrder1.Visible = true;
            ucUpdateItems1.Visible = false;
            ucRemoveItems1.Visible = false;
            ucAddItems1.Visible = false;
        }

        private void btnUpdateItems_Click(object sender, EventArgs e)
        {
            ucWelcome1.SendToBack();
            gunaTransition3.ShowSync(ucUpdateItems1);
            ucUpdateItems1.Visible = true;
            ucRemoveItems1.Visible = false;
            ucAddItems1.Visible = false;
            ucPlaceOrder1.Visible = false;
        }

        private void btnRemoveItems_Click(object sender, EventArgs e)
        {
            ucWelcome1.SendToBack();
            gunaTransition4.ShowSync(ucRemoveItems1);
            ucRemoveItems1.Visible = true;
            ucAddItems1.Visible = false;
            ucPlaceOrder1.Visible = false;
            ucUpdateItems1.Visible = false;
        }

        private void gunaButton5_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            this.Hide();
            lg.Show();
        }
    }
}
