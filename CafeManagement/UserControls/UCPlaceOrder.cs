using DGVPrinterHelper;
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
    public partial class UCPlaceOrder : UserControl
    {
        Function fn = new Function();
        string query;

        public UCPlaceOrder()
        {
            InitializeComponent();
        }
        
        // method to load data onto the listbox
        private void getItemList(string query)
        {
            listBox1.Items.Clear();
            DataSet ds = fn.GetData(query);

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                listBox1.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }
        }

        // load data onto listbox based on selected category
        private void cmbPOCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            //string category = cmbPOCategory.Text;
            query = "select iName from items where iCategory='" + cmbPOCategory.Text + "'";
            getItemList(query);
        }

        //populate listbox based on the search
        private void txtPOSearch_TextChanged(object sender, EventArgs e)
        {
            //string category = cmbPOCategory.Text;
            query = "select iName from items where iCategory='" + cmbPOCategory.Text + "' and iName like '"+txtPOSearch.Text+"%'";
            getItemList(query);
        }

        // load the details of the item selected from listboxon to item name and price.
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            numPOQuantity.ResetText();
            lblTotPrice.Text = "000";

            string text = listBox1.GetItemText(listBox1.SelectedItem);
            lblItemName.Text = text;
            query = "select iPrice from items where iName='" + text + "'";
            DataSet ds = fn.GetData(query);

            try
            {
                lblUnitPrice.Text = ds.Tables[0].Rows[0][0].ToString();
            }
            catch { }
        }
        
        // calculate the total price of selected item based on quantity 
        private void numPOQuantity_ValueChanged(object sender, EventArgs e)
        {
            Int64 quant = Int64.Parse(numPOQuantity.Value.ToString());
            Int64 price = Int64.Parse(lblUnitPrice.Text);
            lblTotPrice.Text = (quant * price).ToString();
        }
  
        // select the amount of the selected item 
        int amount;
        private void gunaDataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                amount = int.Parse(gunaDataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString());
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // remove items from cart/bag
        protected int n, tot = 0;

        private void btnPORemove_Click(object sender, EventArgs e)
        {
            try
            {
                gunaDataGridView1.Rows.RemoveAt(this.gunaDataGridView1.SelectedRows[0].Index);
            }
            catch { }

            tot -= amount;
            lblTotal.Text = "Rs." + tot;

            lblTotPrice.Text = "000.00";
            numPOQuantity.ResetText();
        }

        // print invoice 
        private void btnPOPrint_Click(object sender, EventArgs e)
        {
            DGVPrinter print = new DGVPrinter();
            print.Title = "Invoice/nCustomer Copy";
            print.SubTitle = string.Format("{0}",DateTime.Now.Date);
            print.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            print.PageNumbers = true;
            print.PageNumberInHeader = false;
            print.PorportionalColumns = true;
            print.HeaderCellAlignment = StringAlignment.Near;
            print.Footer = "Total payable amount: " + lblTotal.Text;
            print.FooterSpacing = 25;
            print.PrintDataGridView(gunaDataGridView1);

            tot = 0;
            gunaDataGridView1.Rows.Clear();
            lblTotal.Text = "Rs. " + tot;
        }

        // add item to cart/bag 
        private void btnPOAddtobag_Click(object sender, EventArgs e)
        {
            if(lblTotPrice.Text!="000.00")
            {
                n = gunaDataGridView1.Rows.Add();
                gunaDataGridView1.Rows[n].Cells[0].Value = lblItemName.Text;
                gunaDataGridView1.Rows[n].Cells[1].Value = lblUnitPrice.Text;
                gunaDataGridView1.Rows[n].Cells[2].Value = numPOQuantity.Value;
                gunaDataGridView1.Rows[n].Cells[3].Value = lblTotPrice.Text;

                tot += int.Parse(lblTotPrice.Text);
                lblTotal.Text = "Rs. " + tot;

                txtPOSearch.Clear();
            }
            else
            {
                MessageBox.Show("Minimum quantity must be 1", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void Clearall()
        {
            cmbPOCategory.SelectedIndex = -1;
            txtPOSearch.Clear();
            listBox1.Items.Clear();
            lblItemName.Text = " ";
            lblUnitPrice.Text = "000";
            lblTotPrice.Text = "000.00";
            numPOQuantity.ResetText();
            gunaDataGridView1.DataSource = "";
        }
    }
}
