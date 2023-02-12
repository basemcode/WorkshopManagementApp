using System.ComponentModel;
using System.Data;
using DataAccess.Data;
using DataAccess.Models;

namespace WorkshopManagement;

public partial class frmStockIns : Form
{
    public DataTable stockInsTable=new DataTable();
    public DataTable stockInDetailsTable=new DataTable();
    
    public frmStockIns()
    {
        InitializeComponent();
    }
    
    public void LoadDataToDGV()
    {
        stockInsTable = DataHelper.ToDataTable<StockInModel>(StockInData.GetAllStockIns());
        dgvStockIns.DataSource = stockInsTable;
        dgvStockIns.Sort(dgvStockIns.Columns["StockInID"], ListSortDirection.Descending);

    }
    private void frmStockIns_Load(object sender, EventArgs e)
    {
        dgvStockIns.AutoGenerateColumns = false;
        dgvStockInDetails.AutoGenerateColumns = false;
        LoadDataToDGV();
    }

    private void btnAddStockIn_Click(object sender, EventArgs e)
    {
        frmStockInDetails frmStockIn = new frmStockInDetails();
        frmStockIn.MdiParent = this.MdiParent;
        frmStockIn.FormClosed += (s, args) => LoadDataToDGV();
        frmStockIn.Show();
        LoadDataToDGV();
    }

    private void btnDeleteStockIn_Click(object sender, EventArgs e)
    {
        if (dgvStockIns.Rows.Count<=0)
            return;
        
        if (dgvStockIns.SelectedRows[0] != null)
        {
            string message = $"Вы хотите удалить поставку с ID: {dgvStockIns.SelectedRows[0].Cells["StockInID"].Value} и дата: {dgvStockIns.SelectedRows[0].Cells["Date"].Value}?";
            string title = "Удалить поставки";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult messageBoxResult = MessageBox.Show(message, title, buttons);
            if (messageBoxResult == DialogResult.Yes)
            {
                int result = StockInData.DeleteStockIn(Convert.ToInt32(dgvStockIns.SelectedRows[0].Cells["StockInID"].Value));
                MessageBox.Show("Успешно!, " + result.ToString());
                LoadDataToDGV();
                if (dgvStockIns.Rows.Count == 0)
                    dgvStockInDetails.DataSource = null;
            }
            else
            {
                // Do something  
            }
        }
    }

    private void btnUpdateStockIn_Click(object sender, EventArgs e)
    {
        if (dgvStockIns.Rows.Count <= 0)
            return;
        if (dgvStockIns.SelectedRows[0] != null)
        {
            int StockInToEdit = Convert.ToInt32(dgvStockIns.SelectedRows[0].Cells["StockInID"].Value);
            //StockInData.UpdateStockIn(new StockInModel() { StockInID = 2, Note = "new note", UserID = 2, Date = DateTime.Parse("5-5-2022") });
            frmStockInDetails frmStockIn = new frmStockInDetails();
            frmStockIn.MdiParent = this.MdiParent;
            frmStockIn.editMode = true;
            frmStockIn.StockInID = StockInToEdit;
            frmStockIn.FormClosed += (s, args) => LoadDataToDGV();
            frmStockIn.Show();
        }
        
        
    }

    private void btnCancel_Click(object sender, EventArgs e)
    {
        this.Close();
    }

    private void dgvStockIns_SelectionChanged(object sender, EventArgs e)
    {
        if (dgvStockIns.Rows.Count > 0)
        {
            if (dgvStockIns.SelectedRows.Count != 0)
            {
                int selectedRow = Convert.ToInt32(dgvStockIns.SelectedRows[0].Cells["StockInID"].Value);
                stockInDetailsTable.Clear()
;                    stockInDetailsTable = DataHelper.ToDataTable<StockInDetailModel>(
                    StockInDetailData.GetAllDetailsOfStockIn(selectedRow));
                dgvStockInDetails.DataSource = stockInDetailsTable;
            }
        }

    }

    private void dgvStockInDetails_DataError(object sender, DataGridViewDataErrorEventArgs e)
    {
        dgvStockInDetails.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = global::WorkshopManagement.Properties.Resources.download;

    }
}
