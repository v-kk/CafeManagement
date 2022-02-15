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
    public partial class UCRemoveItems : UserControl
    {
        Function fn = new Function();
        string query;
        public UCRemoveItems()
        {
            InitializeComponent();
        }

        // method to load data from the database
        public void LoadData()
        {
            query = "select * from items";
            DataSet ds = fn.GetData(query);
            gunaDataGridView1.DataSource = ds.Tables[0];
        }

        // on form load
        private void UCRemoveItems_Load(object sender, EventArgs e)
        {
            lblHint.Text = "How to delete items ?";
            lblHint.ForeColor = Color.DarkSlateBlue;

            LoadData();
        }

        // search by entering item name
        private void gunaTextBox1_TextChanged(object sender, EventArgs e)
        {
            query = "select * from items where iName like '" + txtRISearch.Text + "%'";
            DataSet ds = fn.GetData(query);
            gunaDataGridView1.DataSource = ds.Tables[0];
        }

        // delete item from the list
        private void gunaDataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(MessageBox.Show("Are you sure\nyou want to delete\nthe item permanently ?", "Important", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)==DialogResult.OK)
            {
                int id = int.Parse(gunaDataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                query = "delete from items where iID=" + id + "";
                fn.SetData(query);
                LoadData();
            }
        }

        // display hint 
        private void lblHint_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lblHint.Text = "Select an item from the list to delete.";
            lblHint.ForeColor = Color.IndianRed;
        }

        private void UCRemoveItems_Enter(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
