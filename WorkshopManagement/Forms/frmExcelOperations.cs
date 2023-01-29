using DataAccess.DbAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorkshopManagement.Forms
{
    public partial class frmExcelOperations : Form
    {
        private DataTable excelData;

        public frmExcelOperations()
        {
            InitializeComponent();
        }

        private void btnLoadDataFromExcel_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog() { Filter = "Excel Workbook|*.xlsx|Excel 97-2003 Workbook|*.xls" })
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string CurrentFilePath = Path.GetFullPath(openFileDialog.FileName);
                    excelData = ExcelDataAccess.GetExcelData(CurrentFilePath, cmbSheetName.Text, out string error);
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
                    dgvDataFromExcel.DataSource = excelData;
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog() { Filter = "Excel Workbook|*.xlsx|Excel 97-2003 Workbook|*.xls" })
            {      
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string CurrentFilePath = Path.GetFullPath(saveFileDialog.FileName);
                    using (OleDbConnection conn = new OleDbConnection(Helper.OleCnnVal("ExcelFile", CurrentFilePath)))
                    {
                        try
                        {
                            conn.Open();
                            OleDbCommand cmd = new OleDbCommand();
                            cmd.Connection = conn;
                            foreach (DataGridViewRow item in dgvDataFromExcel.Rows)
                            {
                                if (item.Cells["barcode"].Value != DBNull.Value && item.Cells["amount"].Value != DBNull.Value&& item.Cells["barcode"].Value != null && item.Cells["amount"].Value != null)
                                {
                                    int amount = Convert.ToInt32(item.Cells["amount"].Value);
                                    string barcode = item.Cells["barcode"].Value?.ToString();
                                    //ExcelDataAccess.UpdateExcelData(CurrentFilePath, barcode, amount, out string error);
                                    //MessageBox.Show("step " + item.Cells["barcode"].Value.ToString());
                                    cmd.CommandText = $"UPDATE [Сводная$] SET amount = {amount} WHERE [Баркод] = '{barcode}';";
                                    cmd.ExecuteNonQuery();
                                }
                            }
                            
                           

                        }
                        catch (Exception ex)
                        {
                           
                        }
                    }
                    
                    
                    MessageBox.Show("Done!");
                }
            }
        }
    }
}
