using DataAccess.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorkshopManagement
{
    public partial class frmReportOfWarehouse : Form
    {
        DataTable itemsTable = new DataTable();
        public frmReportOfWarehouse()
        {
            InitializeComponent();
        }

        private void frmReportOfWarehouse_Load(object sender, EventArgs e)
        {
            dgvItemsTable.AutoGenerateColumns = false;
            itemsTable = DataHelper.ToDataTable(ItemData.GetAllItems());
            dgvItemsTable.DataSource = itemsTable;                  
            ColorTheRows();
        }

        private void ColorTheRows()
        {
            foreach (DataGridViewRow item in dgvItemsTable.Rows)
            {
                int QuantityInStock = Convert.ToInt32(item.Cells["QuantityInStock"].Value);
                int MinimumQuantity = Convert.ToInt32(item.Cells["MinimumQuantity"].Value);
                if (QuantityInStock < MinimumQuantity + 5)
                {
                    item.Cells["QuantityInStock"].Style.BackColor = Color.Yellow;
                }
                if (QuantityInStock < MinimumQuantity)
                {
                    item.Cells["QuantityInStock"].Style.BackColor = Color.Red;
                }
            }
            dgvItemsTable.ClearSelection();
        }

        private void dgvItemsTable_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show(e.Exception.Message);
        }

        private void dgvItemsTable_SelectionChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ColorTheRows();
        }
    }
}
