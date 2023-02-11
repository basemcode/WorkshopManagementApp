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

public partial class frmStockOutDetails : Form
{
    int NewStockOutID = 1;
    List<StockOutDetailModel> ToAddStockOutDetailsList = new List<StockOutDetailModel>();
    DataTable ToAddStockOutDetailsTable = new DataTable();
    IEnumerable<string> BarcodesDataTable;
    public frmStockOutDetails()
    {
        InitializeComponent();
    }

    private void frmStockOutDetails_Load(object sender, EventArgs e)
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

        ToAddStockOutDetailsTable.Columns.AddRange(new DataColumn[]
        {   new DataColumn { ColumnName = "StockOutID",DataType =typeof(Int32)},
        new DataColumn { ColumnName = "ItemID" ,DataType =typeof(Int32)},
        new DataColumn { ColumnName = "ItemCodeWithColor",DataType =typeof(string) },
        new DataColumn { ColumnName = "ProductName" ,DataType =typeof(string)},
        new DataColumn { ColumnName = "Barcode" ,DataType =typeof(string)},
        new DataColumn { ColumnName = "Quantity" ,DataType =typeof(Int32)},
        new DataColumn { ColumnName = "BoxesQuantity" ,DataType =typeof(Int32)},
        new DataColumn { ColumnName = "Category" ,DataType =typeof(string)}
        });
        dgvStockOutDetails.DataSource = ToAddStockOutDetailsTable;

        //lock columns so the barcode reader doesn't edit them suddenly
        dgvStockOutDetails.Columns["StockOutID"].Visible = false;
        
        dgvStockOutDetails.Columns["ItemID"].ReadOnly = true;
        dgvStockOutDetails.Columns["ItemCodeWithColor"].ReadOnly = true;
        dgvStockOutDetails.Columns["ProductName"].ReadOnly = true;
        dgvStockOutDetails.Columns["Category"].ReadOnly = true;

        //changing the header text of the columns
        dgvStockOutDetails.Columns["ProductName"].HeaderText = "Наименование изделия";
        dgvStockOutDetails.Columns["StockOutID"].HeaderText = "ID расхода";
        dgvStockOutDetails.Columns["ItemID"].HeaderText = "ID товара";
        dgvStockOutDetails.Columns["ItemCodeWithColor"].HeaderText = "Артикул цвета";
        dgvStockOutDetails.Columns["Barcode"].HeaderText = "Баркод";
        dgvStockOutDetails.Columns["Quantity"].HeaderText = "Количество";
        dgvStockOutDetails.Columns["BoxesQuantity"].HeaderText = "Количество коробок";
        dgvStockOutDetails.Columns["Category"].HeaderText = "Раздел";
        //show user name
        txtLoggedUser.Text = $"{SessionHelper.loggedUser?.FirstName} {SessionHelper.loggedUser?.MiddleName}";
        txtSearchItemName.Text = string.Empty;
        picSearchItemPhoto.Image = null;
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
            int amountOfTheItemToAdd = 0;
            int amountOfBoxesToAdd = 0;
            bool founded = false;
            int rowIndex = -1;
            txtItemID.Text = itemToAdd.ItemID.ToString();
            txtItemName.Text = itemToAdd.ProductName;
            picItemPhoto.Image = displayImage((byte[])itemToAdd.Image);
            //check if the item already  exists in the table
            foreach (DataGridViewRow item in dgvStockOutDetails.Rows)
            {
                if (Convert.ToInt32(item.Cells["ItemID"].Value) == itemToAdd.ItemID)
                {
                    founded = true;
                    rowIndex = item.Index;
                    
                }
            }
            //if we found add to current amounts in the existing row
            if (founded)
            {
                //if the textbox of item quantity have value we use it and if not we add 1 more to quantity
                if (int.TryParse(txtQuantity.Text, out int quantity))
                {
                    amountOfTheItemToAdd =  quantity;
                    dgvStockOutDetails.Rows[rowIndex].Cells["Quantity"].Value = amountOfTheItemToAdd;
                    txtQuantity.Text = String.Empty;
                }
                else
                {
                    amountOfTheItemToAdd = Convert.ToInt32(dgvStockOutDetails.Rows[rowIndex].Cells["Quantity"].Value) + 1;
                    dgvStockOutDetails.Rows[rowIndex].Cells["Quantity"].Value = amountOfTheItemToAdd;
                }
                //if the textbox of boxes quantity have value we use it 
                if (int.TryParse(txtBoxesQuantity.Text, out int result) && txtBoxesQuantity.Text != "0")
                {
                    amountOfBoxesToAdd = result;
                    dgvStockOutDetails.Rows[rowIndex].Cells["BoxesQuantity"].Value = result;
                }
            }
            //if we don't find the item in the list we add new row
            else
            {
                txtBoxesQuantity.Text = "0";
                DataRow newRow = ToAddStockOutDetailsTable.NewRow();
                newRow["StockOutID"] = NewStockOutID;
                newRow["ItemID"] = itemToAdd.ItemID;
                newRow["ItemCodeWithColor"] = itemToAdd.ItemCodeWithColor;
                newRow["ProductName"] = itemToAdd.ProductName;
                newRow["Barcode"] = itemToAdd.Barcode;
                newRow["Category"] = itemToAdd.Category;
                newRow["Quantity"] = 1;
                //if the textbox of item quantity have value we use it and ...
                if (int.TryParse(txtQuantity.Text, out int quantity))
                {
                    newRow["Quantity"] = quantity;
                    txtQuantity.Text = String.Empty;
                }
                //if not we add 1 more to quantity
                else
                {
                    newRow["Quantity"] = 1;
                }
                //
                if (int.TryParse(txtBoxesQuantity.Text, out int result)&& txtBoxesQuantity.Text!="0")
                {
                    amountOfBoxesToAdd = result;
                    newRow["BoxesQuantity"] = result;
                }
                else
                {
                    newRow["BoxesQuantity"] =0;
                }
                //add the item to the list to add to database
                ToAddStockOutDetailsTable.Rows.InsertAt(newRow,0);
                amountOfTheItemToAdd = Convert.ToInt32(newRow["Quantity"]);
                //get the index of the added row
                rowIndex = ToAddStockOutDetailsTable.Rows.IndexOf(newRow);
                //empty the quantity box
                txtBoxesQuantity.Text = "";
            }
            //check the amount in the warehouse if enough 
            if (itemToAdd.QuantityInStock-amountOfTheItemToAdd<0)
            {
                MessageBox.Show("Недостаточное количество товара на складе!");
                dgvStockOutDetails.Rows[rowIndex].Cells["Quantity"].Style.BackColor = Color.Red;
                dgvStockOutDetails.Rows[rowIndex].Cells["Quantity"].Value = itemToAdd.QuantityInStock;
            }
            else
            {
                dgvStockOutDetails.Rows[rowIndex].Cells["Quantity"].Style.BackColor = Color.LightGreen;
            }

            //check the zero boxes amount
            CheckBoxesQuantityInDGV();

            //check the amount of boxes in the warehouse if enough 
            if (itemToAdd.BoxesQuantity - amountOfBoxesToAdd < 0)
            {
                dgvStockOutDetails.Rows[rowIndex].Cells["BoxesQuantity"].Style.BackColor = Color.Red;
                dgvStockOutDetails.Rows[rowIndex].Cells["BoxesQuantity"].Value = itemToAdd.BoxesQuantity;
            }
            else
            {
                dgvStockOutDetails.Rows[rowIndex].Cells["BoxesQuantity"].Style.BackColor = Color.LightGreen;
            }
            txtSumOfAllProducts.Text= GetSumOfQuantity().ToString();
        }
        else
        {
            MessageBox.Show("Такого товара нет в базе данных!");
        }
    }
    private void cboBarcode_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyValue == 13)
        {
            IEnumerable<string> NewDataTable = new List<string>();
            NewDataTable = BarcodesDataTable.Where((item) => item.Contains(cboBarcode.Text)).ToList<string>();
            //cboBarcode.DataSource = NewDataTable;
            AutoCompleteStringCollection autoCompleteStringCollection = new AutoCompleteStringCollection();
            /*foreach (var row in NewDataTable)
            {

            }*/
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
            if (cboBarcode.Items.Count > 1)
            {
                cboBarcode.BackColor = Color.Yellow;
            }
            else
            {
                cboBarcode.BackColor = Color.White;
            }
        }
    }
    private void CheckBoxesQuantityInDGV()
    {
        foreach (DataGridViewRow item in dgvStockOutDetails.Rows)
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
    private void btnShowItem_Click(object sender, EventArgs e)
    {
        AddItemToDataGridView(cboBarcode.Text);
        txtBarcode.Focus();
    }

    private void txtQuantity_txtBoxesQuantity_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyValue == 13)
        {
            txtBarcode.Focus();
            System.Media.SystemSounds.Beep.Play();
        }
    }
    private int GetSumOfQuantity()
    {
        int sum = 0;
        for (int i = 0; i < dgvStockOutDetails.Rows.Count; ++i)
        {
            sum += Convert.ToInt32(dgvStockOutDetails.Rows[i].Cells["Quantity"].Value);
        }
        return sum;
    }
    private void btnSave_Click(object sender, EventArgs e)
    {
        try
        {
            
            if (dgvStockOutDetails.Rows.Count == 0 || GetSumOfQuantity()== 0)
            {
                return;
            }
            int newStockOutID = StockOutData.InsertStockOut(new() { Date = DateTime.Now, UserID = SessionHelper.loggedUser.UserID, Note = txtNote.Text });

            foreach (DataGridViewRow row in dgvStockOutDetails.Rows)
            {
                if ((int)row.Cells["Quantity"].Value>0 || (int)row.Cells["BoxesQuantity"].Value>0)
                {
                    StockOutDetailData.InsertStockOutDetail(new() { ItemID = (int)row.Cells["ItemID"].Value, StockOutID = newStockOutID, Quantity = (int)row.Cells["Quantity"].Value, BoxesQuantity = (int)row.Cells["BoxesQuantity"].Value });
                }
            }
            
            MessageBox.Show("Успешно!");
            this.Close();
        }
        catch (Exception addingStockOutDetailsError)
        {
            MessageBox.Show($"Ошибка: {addingStockOutDetailsError.Message}");
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

    private void cboBarcode_SelectedIndexChanged(object sender, EventArgs e)
    {
        ItemModel itemToAdd = ItemData.GetItemByBarcode(cboBarcode.Text);
        txtSearchItemName.Text = itemToAdd.ProductName;
        picSearchItemPhoto.Image = displayImage((byte[])itemToAdd.Image);
    }

    private void btnAddItemToDGV_Click(object sender, EventArgs e)
    {
        AddItemToDataGridView(txtBarcode.Text);
        txtBarcode.Focus();
    }
}
