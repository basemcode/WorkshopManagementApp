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
using WorkshopManagement.Helpers;

namespace WorkshopManagement.Forms
{
    public partial class frmReportOfWarehouse : Form
    {
        public static DataTable itemsTable = new DataTable();
        
        public frmReportOfWarehouse()
        {
            InitializeComponent();
            this.Activated += (s, args) => frmReportOfWarehouse_Load(s, args);
        }

        public void frmReportOfWarehouse_Load(object sender, EventArgs e)
        {
            
            dgvItemsTable.AutoGenerateColumns = false;
            itemsTable = DataHelper.ToDataTable(ItemData.GetAllItems());
            for (int i = 0; i < itemsTable.Rows.Count; i++)
            {
                byte[] a = (byte[])itemsTable.Rows[i]["Image"];
                if (a.Length==0 )
                {
                    itemsTable.Rows[i]["Image"] = Utilities.newBytes;
                }
            }
            itemsTable.Columns.Add("DifferenceFromReserve", typeof(int));
            for (int i = 0; i < itemsTable.Rows.Count; i++)
            {
                itemsTable.Rows[i]["DifferenceFromReserve"] = (int)itemsTable.Rows[i]["QuantityInStock"] - (int)itemsTable.Rows[i][columnName: "MinimumQuantity"];
            }
            itemsTable.DefaultView.Sort = "DifferenceFromReserve ASC";
            dgvItemsTable.DataSource = itemsTable; 
            
            ColorTheRows();
        }

        private void ColorTheRows()
        {
            foreach (DataGridViewRow item in dgvItemsTable.Rows)
            {
                int QuantityInStock = Convert.ToInt32(item.Cells["QuantityInStock"].Value);
                int MinimumQuantity = Convert.ToInt32(item.Cells["MinimumQuantity"].Value);
                if (QuantityInStock <= MinimumQuantity + 5)
                {
                    item.Cells["QuantityInStock"].Style.BackColor = Color.Yellow;
                }
                if (QuantityInStock < MinimumQuantity)
                {
                    item.Cells["QuantityInStock"].Style.BackColor = Color.Red;
                }
                if (QuantityInStock > MinimumQuantity+5)
                {
                    item.Cells["QuantityInStock"].Style.BackColor = Color.LightGreen;
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
