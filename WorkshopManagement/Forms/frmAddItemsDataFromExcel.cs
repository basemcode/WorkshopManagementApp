using DataAccess.Data;
using DataAccess.DbAccess;
using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorkshopManagement.Forms;

public partial class frmAddItemsDataFromExcel : Form
{
    DataTable excelData;
    DataTable finalExcelData;
    public frmAddItemsDataFromExcel()
    {
        InitializeComponent();
        dgvExcelDataToAdd.AutoGenerateColumns = false;
    }

    private void btnChooseFile_Click(object sender, EventArgs e)
    {
        using (OpenFileDialog openFileDialog = new OpenFileDialog() { Filter = "Excel Workbook|*.xlsx|Excel 97-2003 Workbook|*.xls" })
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string CurrentFilePath = Path.GetFullPath(openFileDialog.FileName);
                excelData = ExcelDataAccess.GetExcelData(CurrentFilePath,cbCategory.Text,out string error);
                MessageBox.Show(error);
                //finalExcelData = PrepareFinalExcelData();
                /*try
                {
                    foreach (DataRow itemFromExcel in excelData.Rows)
                    {
                        DataRow InFinalExcelData = finalExcelData.NewRow();
                        foreach (string s in columnsNames)
                        {
                            InFinalExcelData[s] = itemFromExcel[s];

                        }
                        finalExcelData.Rows.Add(InFinalExcelData);
                    }

                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);

                }*/
                dgvExcelDataToAdd.DataSource = excelData;
            }
        }
    }

    private void btnAddToDataBase_Click(object sender, EventArgs e)
    {
        List<ItemModel> newData= new List<ItemModel>(); 
        foreach (DataGridViewRow item in dgvExcelDataToAdd.Rows)
        {
            ItemModel newItem = new ItemModel();
            newItem.Category = cbCategory.Text;
            newItem.ItemCode = item.Cells["ItemCode"].Value.ToString();
            newItem.ItemCodeWithColor = item.Cells["ItemCodeWithColor"].Value.ToString();
            newItem.Barcode = item.Cells["Barcode"].Value.ToString().Substring(1);
            newItem.ItemNumberOnWB = item.Cells["ItemNumberOnWB"].Value.ToString();
            newItem.InternalCode = item.Cells["InternalCode"].Value.ToString();
            newItem.ProductName = item.Cells["ProductName"].Value.ToString();
            newItem.Color = item.Cells["Color"].Value.ToString();
            newItem.HardboardBoxNumber = item.Cells["HardboardBoxNumber"].Value.ToString();
            newItem.GofferNumber = item.Cells["GofferNumber"].Value.ToString();
            Int32.TryParse(item.Cells["Barcode"].Value.ToString(), out int convertedBarcode);
            //newItem.Barcode = Int32.Parse(item.Cells["Barcode"].Value.ToString());
            if(Int32.TryParse(item.Cells["MinimumQuantity"].Value?.ToString(),out int convertedMinimumQuantity));
                newItem.MinimumQuantity = convertedMinimumQuantity;
            
            newData.Add(newItem);
            if (chkAddToDatabase.Checked)
            {
                ItemData.InsertItem(newItem);
            }


        }
        finalExcelData=DataHelper.ToDataTable(newData);
        dgvResults.DataSource = finalExcelData;
    }
}
