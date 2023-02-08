using DataAccess.Data;
using DataAccess.DbAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorkshopManagement.Forms
{
    public partial class frmDatabaseOperations : Form
    {
        DataTable rawExcelData;
        DataTable finalExcelData;
        public frmDatabaseOperations()
        {
            InitializeComponent();
        }

        private void btnChooseFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog() { Filter = "Excel Workbook|*.xlsx|Excel 97-2003 Workbook|*.xls" })
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string CurrentFilePath = Path.GetFullPath(openFileDialog.FileName);
                    rawExcelData = ExcelDataAccess.GetExcelData(CurrentFilePath, "Sheet1", out string error);
                    Console.WriteLine(error);
                    
                    finalExcelData = rawExcelData.Clone();
                    foreach (DataRow item in rawExcelData.Rows)
                    {
                        if (item["Barcode"] != ""&& item["Barcode"] != null)
                        {
                            if (item["Quantity"] == "" || item["Quantity"] == null || item["Quantity"] == DBNull.Value)
                            {
                                item["Quantity"] = 0;
                            }
                            if (item["BoxesQuantity"] == "" || item["BoxesQuantity"] == null || item["BoxesQuantity"] == DBNull.Value)
                            {
                                item["BoxesQuantity"] = 0;
                            }
                            finalExcelData.ImportRow(item);
                        }
                    }
                    dgvExcelDataToAdd.DataSource = finalExcelData;
                    txtRowsNum.Text=finalExcelData.Rows.Count.ToString();
                }
                
            }
        }

        private void btnSaveValuesToDatabase_Click(object sender, EventArgs e)
        {
            if (finalExcelData!=null)
            {
                foreach (DataRow item in finalExcelData.Rows)
                {
                    ItemData.SetInitialQuantity(item["Barcode"].ToString()
                        , Convert.ToInt32(item["Quantity"])
                        , Convert.ToInt32(item["BoxesQuantity"])
                        , Convert.ToInt32(cboPeriodID.SelectedItem));
                }
            }
           
            
        }

        private void frmDatabaseOperations_Load(object sender, EventArgs e)
        {
            dgvExcelDataToAdd.AutoGenerateColumns = false;
        }

        private void btnDeployInitialQuantity_Click(object sender, EventArgs e)
        {
            ItemData.DeployAllInitialQuantity(Convert.ToInt32(cboPeriodID.Text));
        }
    }
}
