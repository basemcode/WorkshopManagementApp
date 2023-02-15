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

namespace WorkshopManagement.Forms;

public partial class frmItemsList : Form
{
    DataTable ItemsTable;
    static string[] subGroups;
    public frmItemsList()
    {
        InitializeComponent();
    }
    private void LoadDataToDGV(string category)
    {
        //dgvItemsTable.Rows.Clear();
        //dgvItemsTable.AutoGenerateColumns=true;
        //ItemsTable = DataHelper.ToDataTable(ItemData.GetItemsOfCategory(category));
        ItemsTable = DataHelper.ToDataTable(ItemData.GetAllItems());
        subGroups = ItemData.GetSubGroups().ToArray();
        for (int i = 0; i < ItemsTable.Rows.Count; i++)
        {
            object a = ItemsTable.Rows[i]["Image"];
            if (ItemsTable.Rows[i]["Image"] == DBNull.Value)
            {


                ItemsTable.Rows[i]["Image"] = Utilities.newBytes;
            }
        }
        ItemsTable.DefaultView.Sort = "SubGroup Desc";
        try
        {
            dgvItemsTable.DataSource = ItemsTable;
            DataView dataView = ItemsTable.DefaultView;
        }
        catch (Exception e3)
        {
            MessageBox.Show(e3.Message);
        }
        ItemsTable.DefaultView.RowFilter = "[Category] = '" + cboCategory.Text + "'";
        tbWarehouseCategoryQuantity.Text = ItemsTable.DefaultView.Count.ToString();
        tbWarehouseAllQuantity.Text = ItemsTable.Rows.Count.ToString();
        cboSubGroup.Items.Clear();

        if (subGroups.Length > 0)
        {
            foreach (var item in subGroups)
            {
                if (item != null)
                {
                    cboSubGroup.Items.Add(item);
                }

            }
        }

    }

    private void frmItemsList_Load(object sender, EventArgs e)
    {
        LoadDataToDGV(cboCategory.Text);
    }

    private void cboCategory_SelectedIndexChanged(object sender, EventArgs e)
    {
        ItemsTable.DefaultView.RowFilter = "[Category] = '" + cboCategory.Text + "'";
        tbWarehouseCategoryQuantity.Text = ItemsTable.DefaultView.Count.ToString();
    }

    private void dgvItemsTable_DataError(object sender, DataGridViewDataErrorEventArgs e)
    {
        dgvItemsTable.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = global::WorkshopManagement.Properties.Resources.download;
    }
}
