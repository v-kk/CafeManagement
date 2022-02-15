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
    public partial class UCUpdateItems : UserControl
    {
        Function fn = new Function();
        string query;

        public UCUpdateItems()
        {
            InitializeComponent();
        }

        // method to load data from database
        public void LoadData()
        {
            query = "select * from items";
            DataSet ds = fn.GetData(query);
            gunaDataGridView1.DataSource = ds.Tables[0];
        }

        private void UCUpdateItems_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        // search item by entering name
        private void txtUISearch_TextChanged(object sender, EventArgs e)
        {
            query = "select * from items where iName like '" + txtUISearch.Text + "%'";
            DataSet ds = fn.GetData(query);
            gunaDataGridView1.DataSource = ds.Tables[0];
        }

        // select item from the list to delete
        int id;
        private void gunaDataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                id = int.Parse(gunaDataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                txtUICategory.Text = gunaDataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtUIItemName.Text = gunaDataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtUIPrice.Text = gunaDataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Select an item to update","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            
        }

        // update database upon click of Update Item button.
        private void btnUIUpdateItems_Click(object sender, EventArgs e)
        {
            query = "update items set iName='" + txtUIItemName.Text + "',iCategory='" + txtUICategory.Text + "',iPrice=" + txtUIPrice.Text + " where iID=" + id + "";
            fn.SetData(query);
            LoadData();

            txtUIItemName.Clear();
            txtUICategory.Clear();
            txtUIPrice.Clear();
            txtUISearch.Clear();
        }
    }
}
