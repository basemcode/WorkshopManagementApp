using DataAccess.Data;
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

namespace WorkshopManagement;

public partial class frmStockOuts : Form
{
    public DataTable stockOutsTable = new DataTable();
    public DataTable stockOutDetailsTable = new DataTable();

    public frmStockOuts()
    {
        InitializeComponent();
    }

    public void LoadDataToDGV()
    {
        stockOutsTable = DataHelper.ToDataTable<StockOutModel>(StockOutData.GetAllStockOuts());
        dgvStockOuts.DataSource = stockOutsTable;
        dgvStockOuts.Sort(dgvStockOuts.Columns["StockOutID"], ListSortDirection.Descending);

    }
    private void frmStockOuts_Load(object sender, EventArgs e)
    {
        dgvStockOuts.AutoGenerateColumns = false;
        dgvStockOutDetails.AutoGenerateColumns = false;
        LoadDataToDGV();
    }

    private void btnAddStockOut_Click(object sender, EventArgs e)
    {
        frmStockOutDetails frmStockOut = new frmStockOutDetails();
        frmStockOut.MdiParent = this.MdiParent;
        frmStockOut.FormClosed += (s, args) => LoadDataToDGV();
        frmStockOut.Show();
        LoadDataToDGV();
    }

    private void btnDeleteStockOut_Click(object sender, EventArgs e)
    {
        if (dgvStockOuts.Rows.Count <= 0)
        { return; }
        
        if (dgvStockOuts.SelectedRows[0] != null)
        {
            
            string message = $"Вы хотите удалить отгрузку с ID: {dgvStockOuts.SelectedRows[0].Cells["StockOutID"].Value} и дата: {dgvStockOuts.SelectedRows[0].Cells["Date"].Value}?";
            string title = "Удалить отгрузки";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult messageBoxResult = MessageBox.Show(message, title, buttons);
            if (messageBoxResult == DialogResult.Yes)
            {
                int result = StockOutData.DeleteStockOut(Convert.ToInt32(dgvStockOuts.SelectedRows[0].Cells["StockOutID"].Value));
                MessageBox.Show("Успешно!, " + result.ToString());
                LoadDataToDGV();
                if (dgvStockOuts.Rows.Count == 0)
                    dgvStockOutDetails.DataSource = null;
            }
            else
            {
                // Do something  
            }
        }
    }

    private void btnUpdateStockOut_Click(object sender, EventArgs e)
    {
        //StockOutData.UpdateStockOut(new StockOutModel() { StockOutID = 2, Note = "new note", UserID = 2, Date = DateTime.Parse("5-5-2022") });
        //stockOutsTable = DataHelper.ToDataTable<StockOutModel>(StockOutData.GetAllStockOuts());
        if (dgvStockOuts.Rows.Count <= 0)
            return;
        if (dgvStockOuts.SelectedRows[0] != null)
        {
            int StockOutToEdit = Convert.ToInt32(dgvStockOuts.SelectedRows[0].Cells["StockOutID"].Value);
            //StockInData.UpdateStockIn(new StockInModel() { StockInID = 2, Note = "new note", UserID = 2, Date = DateTime.Parse("5-5-2022") });
            frmStockOutDetails frmStockOutDetails = new frmStockOutDetails();
            frmStockOutDetails.MdiParent = this.MdiParent;
            frmStockOutDetails.editMode = true;
            frmStockOutDetails.StockOutID = StockOutToEdit;
            frmStockOutDetails.FormClosed += (s, args) => LoadDataToDGV();
            frmStockOutDetails.Show();
        }
        //LoadDataToDGV();
    }

    private void btnCancel_Click(object sender, EventArgs e)
    {
        this.Close();
    }

    private void dgvStockOuts_SelectionChanged(object sender, EventArgs e)
    {
        if (dgvStockOuts.Rows.Count > 0)
        {
            if (dgvStockOuts.SelectedRows.Count != 0)
            {
                int selectedRowID = Convert.ToInt32(dgvStockOuts.SelectedRows[0].Cells["StockOutID"].Value);
                stockOutDetailsTable.Clear(); 
                stockOutDetailsTable = DataHelper.ToDataTable<StockOutDetailModel>(
                StockOutDetailData.GetAllDetailsOfStockOut(selectedRowID));
                dgvStockOutDetails.DataSource = stockOutDetailsTable;
            }
        }

    }

    private void dgvStockOutDetails_DataError(object sender, DataGridViewDataErrorEventArgs e)
    {
        dgvStockOutDetails.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = global::WorkshopManagement.Properties.Resources.download;

    }
}