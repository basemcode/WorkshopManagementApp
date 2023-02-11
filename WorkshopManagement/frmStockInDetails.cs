using DataAccess.Data;
using DataAccess.Models;
using DataAccess.DbAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel.DataAnnotations;

namespace WorkshopManagement;

public partial class frmStockInDetails : Form
{
    int NewStockInID = 1;
    List<StockInDetailModel> ToAddStockInDetailsList = new List<StockInDetailModel>();
    DataTable ToAddStockInDetailsTable= new DataTable();
    IEnumerable<string> BarcodesDataTable;

    public frmStockInDetails()
    {
        InitializeComponent();
        dgvStockInDetails.AutoGenerateColumns = false;
    }

    private void frmStockIn_Load(object sender, EventArgs e)
    {
        BarcodesDataTable = ItemData.GetAllBarcodes();
        AutoCompleteStringCollection autoCompleteStringCollection = new AutoCompleteStringCollection();

        foreach (var item in BarcodesDataTable)
        {
            autoCompleteStringCollection.Add(item);
        }
        txtBarcode.AutoCompleteCustomSource = autoCompleteStringCollection;
        cboBarcode.DataSource = autoCompleteStringCollection;
        cboBarcode.Text = string.Empty;
         
        ToAddStockInDetailsTable.Columns.AddRange(new DataColumn[] 
        {   new DataColumn { ColumnName = "StockInID",DataType =typeof(Int32)},
            new DataColumn { ColumnName = "ItemID" ,DataType =typeof(Int32)},
            new DataColumn { ColumnName = "ItemCodeWithColor",DataType =typeof(string) },
            new DataColumn { ColumnName = "ProductName" ,DataType =typeof(string)},
            new DataColumn { ColumnName = "Barcode" ,DataType =typeof(string)},
            new DataColumn { ColumnName = "Quantity" ,DataType =typeof(Int32)},
            new DataColumn { ColumnName = "BoxesQuantity" ,DataType =typeof(Int32)},
            new DataColumn { ColumnName = "Category" ,DataType =typeof(string)}
        });
        dgvStockInDetails.DataSource = ToAddStockInDetailsTable;
        //lock columns so the barcode reader doesn't edit them suddenly
        /*dgvStockInDetails.Columns["StockInID"].Visible=false;
        dgvStockInDetails.Columns["ItemID"].ReadOnly = true;
        dgvStockInDetails.Columns["ItemCodeWithColor"].ReadOnly = true;
        dgvStockInDetails.Columns["ProductName"].ReadOnly = true;
        dgvStockInDetails.Columns["Category"].ReadOnly = true;*/
        //dgvStockInDetails.Columns["Quantity"].ReadOnly = true;
        /*dgvStockInDetails.Columns["BoxesQuantity"].ReadOnly = true;*/

        //changing the header text of the columns
        /*dgvStockInDetails.Columns["ProductName"].HeaderText = "Наименование изделия";
        dgvStockInDetails.Columns["StockInID"].HeaderText = "ID прихода";
        dgvStockInDetails.Columns["ItemID"].HeaderText = "ID товара";
        dgvStockInDetails.Columns["ItemCodeWithColor"].HeaderText = "Артикул цвета";
        dgvStockInDetails.Columns["Barcode"].HeaderText = "Баркод";
        dgvStockInDetails.Columns["Quantity"].HeaderText = "Количество";
        dgvStockInDetails.Columns["BoxesQuantity"].HeaderText = "Количество коробок";
        dgvStockInDetails.Columns["Category"].HeaderText = "Раздел";*/
        
        //show user name
        txtLoggedUser.Text = $"{SessionHelper.loggedUser?.FirstName} {SessionHelper.loggedUser?.MiddleName}";
        txtSearchItemName.Text = string.Empty;
        picSearchItemPhoto.Image= null;
    }

    private void txtBarcode_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyValue == 13)
        {
            AddItemToDataGridView(txtBarcode.Text);
            System.Media.SystemSounds.Beep.Play();              
        } 
        else
        {
           
        }
    }

    void AddItemToDataGridView(string Barcode)
    {
        ItemModel itemToAdd = ItemData.GetItemByBarcode(Barcode);
        if (itemToAdd != null)
        {
            bool founded = false;
            int rowIndex = -1;
            txtItemID.Text = itemToAdd.ItemID.ToString();
            txtItemName.Text = itemToAdd.ProductName;
            picItemPhoto.Image= displayImage((byte[])itemToAdd.Image);
            foreach (DataGridViewRow item in dgvStockInDetails.Rows)
            {
                if (Convert.ToInt32(item.Cells["ItemID"].Value) == itemToAdd.ItemID)
                {
                    founded = true;
                    rowIndex = item.Index;
                }
            }
            if (founded)
            { 
                if (int.TryParse(txtQuantity.Text,out int quantity))
                {
                    if (quantity>=0)
                    {
                        dgvStockInDetails.Rows[rowIndex].Cells["Quantity"].Value = quantity;
                       
                    }
                    txtQuantity.Text = String.Empty;
                }
                else
                {
                    dgvStockInDetails.Rows[rowIndex].Cells["Quantity"].Value = Convert.ToInt32(dgvStockInDetails.Rows[rowIndex].Cells["Quantity"].Value) + 1;
                }

                if (int.TryParse(txtBoxesQuantity.Text, out int result))
                {
                    if (result>=0)
                    {
                        dgvStockInDetails.Rows[rowIndex].Cells["BoxesQuantity"].Value = result;
                    }
                   
                }
                
            }
            else
            {
                txtBoxesQuantity.Text = "0";
                DataRow newRow = ToAddStockInDetailsTable.NewRow();
                newRow["StockInID"] = NewStockInID;
                newRow["ItemID"] = itemToAdd.ItemID;
                newRow["ItemCodeWithColor"] = itemToAdd.ItemCodeWithColor;
                newRow["ProductName"] = itemToAdd.ProductName;
                newRow["Barcode"] = itemToAdd.Barcode;
                newRow["Category"] = itemToAdd.Category;
                newRow["Quantity"] = 1;
                
                if (int.TryParse(txtQuantity.Text, out int quantity))
                {
                    if (quantity >= 0)
                    {
                        newRow["Quantity"] = quantity;
                    }
                    txtQuantity.Text = String.Empty;
                }
                else
                {
                    txtQuantity.Text = String.Empty;
                }
                if (int.TryParse(txtBoxesQuantity.Text, out int result))
                {
                    if (result>=0)
                    {
                        newRow["BoxesQuantity"] = result;
                    }
                    
                }
                else
                {
                    newRow["BoxesQuantity"] = 0;
                }  
                ToAddStockInDetailsTable.Rows.InsertAt(newRow,0);
                
            }
            CheckBoxesQuantityInDGV();
        }
        else
        {
            MessageBox.Show("Такого товара нет в базе данных!");
        }
    }
    private void CheckBoxesQuantityInDGV()
    {
        foreach (DataGridViewRow item in dgvStockInDetails.Rows)
        {
            if ((int)item.Cells["BoxesQuantity"].Value == 0)
            {
                item.Cells["BoxesQuantity"].Style.BackColor = Color.Yellow;
            }
            else
            {
                item.Cells["BoxesQuantity"].Style.BackColor = item.DefaultCellStyle.BackColor;
            }
        }
    }
    private void cboBarcode_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyValue == 13)
        {
            
                IEnumerable<string> NewDataTable = new List<string>();
                NewDataTable = BarcodesDataTable.Where((item) => item.Contains(cboBarcode.Text)).ToList<string>();
                AutoCompleteStringCollection autoCompleteStringCollection = new AutoCompleteStringCollection();
                for (int i = 0; i < NewDataTable.Count(); i++)
                {
                    autoCompleteStringCollection.Add(NewDataTable.ToList<string>()[i]);
                }
                cboBarcode.DataSource = autoCompleteStringCollection;
            
            if (cboBarcode.Items.Count == 1)
            {
                AddItemToDataGridView(cboBarcode.Text);
                //txtBarcode.Focus();
            }

            if (cboBarcode.Items.Count>1)
            {
                cboBarcode.BackColor = Color.Yellow;
            }
            else
            {
                cboBarcode.BackColor = Color.White;
            }
        }
    }

   
    private void btnShowItem_Click(object sender, EventArgs e)
    {
        AddItemToDataGridView(cboBarcode.Text);
        txtBarcode.Focus();
    }

    private void txtQuantity_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyValue == 13)
        {
            txtBarcode.Focus();
            System.Media.SystemSounds.Beep.Play();
        }
    }

    private void btnSave_Click(object sender, EventArgs e)
    {
        try
        {
            if (dgvStockInDetails.Rows.Count == 0)
            {
                return;
            }
            int newStockInID=StockInData.InsertStockIn(new() { Date = DateTime.Now, UserID = SessionHelper.loggedUser.UserID ,Note=txtNote.Text});
            foreach (DataGridViewRow row in dgvStockInDetails.Rows)
            {
                StockInDetailData.InsertStockInDetail(new() { ItemID = (int)row.Cells["ItemID"].Value, StockInID = newStockInID, Quantity = (int)row.Cells["Quantity"].Value, BoxesQuantity = (int)row.Cells["BoxesQuantity"].Value });
            }
            MessageBox.Show("Успешно!");
            this.Close();
            
        }
        catch (Exception addingStockinDetailsError)
        {
            MessageBox.Show($"Ошибка {addingStockinDetailsError.Message}");
        }
        

    }

    private void btnCancel_Click(object sender, EventArgs e)
    {
        this.Close();
    }
    public Image displayImage(byte[]? photo)
    {
        if (photo != null)
        {
            try
            {
                MemoryStream ms = new MemoryStream(photo);
                return System.Drawing.Image.FromStream(ms);
            }
            catch (Exception)
            {
                return null;
            }
        }
        return null;
    }

    private void dgvStockInDetails_DataError(object sender, DataGridViewDataErrorEventArgs e)
    {
        dgvStockInDetails.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = global::WorkshopManagement.Properties.Resources.download;

    }

    private void btnAddItemToDGV_Click(object sender, EventArgs e)
    {
        AddItemToDataGridView(txtBarcode.Text);
        txtBarcode.Focus();
    }

    private void dgvStockInDetails_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.ColumnIndex == dgvStockInDetails.Columns["plusBtnCol"].Index & e.RowIndex >= 0)
        {
            int newValue = Convert.ToInt32(dgvStockInDetails.Rows[e.RowIndex].Cells["Quantity"].Value);
            dgvStockInDetails.Rows[e.RowIndex].Cells["Quantity"].Value = newValue + 1;
        }
        if (e.ColumnIndex == dgvStockInDetails.Columns["minusBtnCol"].Index & e.RowIndex >= 0)
        {
            int newValue = Convert.ToInt32(dgvStockInDetails.Rows[e.RowIndex].Cells["Quantity"].Value);
            dgvStockInDetails.Rows[e.RowIndex].Cells["Quantity"].Value = newValue - 1;
        }
    }

    private void cboBarcode_SelectedIndexChanged(object sender, EventArgs e)
    {
        ItemModel itemToAdd = ItemData.GetItemByBarcode(cboBarcode.Text);
        txtSearchItemName.Text = itemToAdd.ProductName;
        picSearchItemPhoto.Image = displayImage((byte[])itemToAdd.Image);
    }
}
