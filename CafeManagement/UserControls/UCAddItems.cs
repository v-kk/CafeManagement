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
    public partial class UCAddItems : UserControl
    {
        Function fn = new Function();
        string query;

        public UCAddItems()
        {
            InitializeComponent();
        }

        // add the item to database
        private void btnAIAddItem_Click(object sender, EventArgs e)
        {
            query = "insert into items (iName,iCategory,iPrice) values('" + txtAIItemName.Text + "','" + cmbAICategory.Text + "'," + txtAIPrice.Text + ")";
            fn.SetData(query);
            ClearAll();
        }

        // method to clear the fields
        public void ClearAll()
        {
            cmbAICategory.SelectedIndex = -1;
            txtAIItemName.Clear();
            txtAIPrice.Clear();
        }

        private void UCAddItems_Leave(object sender, EventArgs e)
        {
            ClearAll();
        }
    }
}
