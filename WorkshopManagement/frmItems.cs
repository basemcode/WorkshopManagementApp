using DataAccess.Data;
using DataAccess.DbAccess;
using DataAccess.Models;
using System.Data;
using System.Drawing.Imaging;
using System.Net;
using System.Windows.Forms;
using WorkshopManagement.Helpers;

namespace WorkshopManagement
{
    public partial class frmItems : Form
    {
        //List<ItemModel> ItemsList = new List<ItemModel>();
        static DataTable ItemsTable = DataHelper.ToDataTable(ItemData.GetAllItems());
        static string[] subGroups = ItemData.GetSubGroups().ToArray();
        
        public frmItems()
        {
            InitializeComponent();
        }

        private void frmItems_Load(object sender, EventArgs e)
        {
            dgvItemsTable.AutoGenerateColumns = false;
            dgvItemsTable.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            // or even better, use .DisableResizing. Most time consuming enum is DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders

            // set it to false if not needed
            dgvItemsTable.RowHeadersVisible = false;
            cbCategory.SelectedIndex = 0;

            LoadDataToDGV(cbCategory.Text);
            
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
            ItemsTable.DefaultView.RowFilter = "[Category] = '" + cbCategory.Text + "'";
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

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
                MessageBox.Show("Enter key pressed!!");
            /*else
            {
                MessageBox.Show(e.KeyValue.ToString()); 
            }*/
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog() { Filter = "Image|*.jpg;*.png;*.jpeg" })
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string CurrentFilePath = Path.GetFullPath(openFileDialog.FileName);
                    try
                    {
                        pbItemImage.Image = ImageData.GetImage(CurrentFilePath);
                    }
                    catch (Exception error)
                    {
                        MessageBox.Show(error.Message);
                    }
                }
            }
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            if (tbBarcode.Text != String.Empty)
            {
                if (canAdd)
                {
                    ItemModel newItem = new ItemModel();
                    newItem.ItemCode = tbItemCode.Text;
                    newItem.ItemCodeWithColor = tbItemCodeWithColor.Text;
                    newItem.Barcode = tbBarcode.Text;
                    newItem.Image = SaveImage(pbItemImage);
                    newItem.ItemNumberOnWB = tbItemNumberOnWB.Text;
                    newItem.InternalCode = tbInternalCode.Text;
                    newItem.ProductName = tbProductName.Text;
                    newItem.SubGroup = cboSubGroup.Text;
                    newItem.Color = tbColor.Text;
                    newItem.HardboardBoxNumber = tbHardboardBoxNumber.Text;
                    newItem.PackagingAndDimensions = tbPackagingAndDimensions.Text;
                    newItem.GofferNumber = tbGofferNumber.Text;
                    newItem.Category = cbCategory.Text;
                    newItem.Note = tbNote.Text;
                    newItem.QuantityInStock = 0;
                    newItem.MinimumQuantity = 0;
                    newItem.BoxesQuantity = 0;
                    ItemData.InsertItem(newItem);
                    LoadDataToDGV(cbCategory.Text);
                    ClearControlsValues();
                    SelectRow(newItem.Barcode);
                    
                }
                else
                {
                    MessageBox.Show("Баркод уже есть в базе данных.");
                }
            }
            else
            {
                MessageBox.Show("Баркод недействителен.");
            }
        }

        /// <summary>
        /// select a row in the DataGridView
        /// </summary>
        /// <param name="barcode"></param>
        private void SelectRow(string barcode)
        {
            int rowIndex = -1;
            var rows = dgvItemsTable.Rows
                .Cast<DataGridViewRow>()
                .Where(r => r.Cells["Barcode"].Value.ToString().Contains(barcode));
            if (rows.Count()>0)
            {
                var row=rows.First();
                rowIndex = row.Index;
                dgvItemsTable.FirstDisplayedScrollingRowIndex = rowIndex;
                dgvItemsTable.Rows[rowIndex].Selected = true;
            }  
        }

        public static byte[] SaveImage(PictureBox pb)
        {
            try
            {
                MemoryStream ms = new MemoryStream();
                if (pb.Image != null)
                {
                    pb.Image.Save(ms, ImageFormat.Jpeg);
                }
                return ms.GetBuffer();
            }
            catch (Exception)
            {
                return null;
            }

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

        private void btnAddImageFromWB_Click(object sender, EventArgs e)
        {
            DownloadDataCompletedEventHandler WhenDownloadComplete = new DownloadDataCompletedEventHandler(ShowImage);
            InternetAccess.GetImageFromInternet(tbItemNumberOnWB.Text, WhenDownloadComplete);
            WhenDownloadComplete.Invoke(this, null);
            ShowImage(null, null);
        }

        private void ShowImage(object sender, DownloadDataCompletedEventArgs e)
        {
            string path = @"Data\img\big\" + tbItemNumberOnWB.Text.ToString() + "-1.jpg";
            pbItemImage.Invoke((MethodInvoker)delegate
            {
                pbItemImage.Image = ImageData.GetImage(path);
            });
            pbItemImage.Image = ImageData.GetImage(path);
        }

        private void btnDeleteItem_Click(object sender, EventArgs e)
        {
            string message = $"Вы хотите удалить товар с ID: {dgvItemsTable.SelectedRows[0].Cells["ItemID"].Value} ?";
            string title = "Удалить товара";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                if (dgvItemsTable.SelectedRows.Count != 0 && dgvItemsTable.SelectedRows[0].Cells["ItemID"].Value != null)
                {
                    if (dgvItemsTable.SelectedRows[0].Cells["ItemID"].Value != null)
                        ItemData.DeleteItem(Convert.ToInt32(dgvItemsTable.SelectedRows[0].Cells["ItemID"].Value));
                    LoadDataToDGV(cbCategory.Text);
                    ClearControlsValues();
                }
            }
            else
            {
                // Do something  
            }



        }
        //update the item values in the database
        private void btnUpdateItem_Click(object sender, EventArgs e)
        {
            if (tbItemID.Text != String.Empty)
            {
                btnAddItem.Enabled = true;
                ItemModel newItem = new ItemModel();
                newItem.ItemID = Convert.ToInt32(tbItemID.Text);
                newItem.ItemCode = tbItemCode.Text;
                newItem.ItemCodeWithColor = tbItemCodeWithColor.Text;
                newItem.Barcode = tbBarcode.Text;
                newItem.Image = SaveImage(pbItemImage);
                newItem.ItemNumberOnWB = tbItemNumberOnWB.Text;
                newItem.InternalCode = tbInternalCode.Text;
                newItem.ProductName = tbProductName.Text;
                newItem.SubGroup = cboSubGroup.Text;
                newItem.Color = tbColor.Text;
                newItem.HardboardBoxNumber = tbHardboardBoxNumber.Text;
                newItem.PackagingAndDimensions = tbPackagingAndDimensions.Text;
                newItem.GofferNumber = tbGofferNumber.Text;
                newItem.Category = cbCategory.Text;
                newItem.Note = tbNote.Text;
                ItemData.UpdateItem(newItem);
                LoadDataToDGV(cbCategory.Text);
                SelectRow(newItem.Barcode);
            }
            else
            {
                MessageBox.Show("Выберите артикул пожалуйста!");
            }

        }

        //clear the content of all controls of the group item
        private void ClearControlsValues()
        {
            tbItemID.Text = string.Empty;
            tbItemCode.Text = string.Empty;
            tbItemCodeWithColor.Text = string.Empty;
            tbBarcode.Text = string.Empty;
            pbItemImage.Image = displayImage(null);
            tbItemNumberOnWB.Text = string.Empty;
            tbInternalCode.Text = string.Empty;
            tbProductName.Text = string.Empty;
            tbColor.Text = string.Empty;
            tbHardboardBoxNumber.Text = string.Empty;
            tbPackagingAndDimensions.Text = string.Empty;
            tbGofferNumber.Text = string.Empty;
            tbNote.Text = string.Empty;
            cboSubGroup.Text=string.Empty;
        }

        //change the category
        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            ItemsTable.DefaultView.RowFilter = "[Category] = '" + cbCategory.Text + "'";
            tbWarehouseCategoryQuantity.Text = ItemsTable.DefaultView.Count.ToString();
            /*dataView = ItemsTable.DefaultView;
            string category= cbCategory.Text;
            if (!string.IsNullOrEmpty(category))
            {
                dataView.RowFilter = "[Category] = '" + category + "'";
            }*/
            //dgvItemsTable.DataSource =dataView ;
            //LoadDataToDGV(cbCategory.Text);
        }

        //button function to clear the content of all controls in item group
        private void btnClearControlsValues_Click(object sender, EventArgs e)
        {
            ClearControlsValues();
            btnAddItem.Enabled = true;
        }
        //row number and column index of the clicked cell 
        private DataGridViewCellEventArgs mouseLocation = new DataGridViewCellEventArgs(-1, -1);
        private bool canAdd = false;

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvItemsTable.SelectedRows.Count != 0 && dgvItemsTable.SelectedRows[0].Cells["ItemID"].Value != null)
                {
                    btnAddItem.Enabled = false;
                    //tbWarehouseCategoryQuantity.Text = dgvItemsTable.RowCount.ToString();
                    tbItemID.Text = dgvItemsTable.Rows[mouseLocation.RowIndex].Cells["ItemID"].Value.ToString();
                    tbItemCode.Text = dgvItemsTable.Rows[mouseLocation.RowIndex].Cells["ItemCode"].Value.ToString();
                    tbItemCodeWithColor.Text = dgvItemsTable.Rows[mouseLocation.RowIndex].Cells["ItemCodeWithColor"].Value.ToString();
                    tbBarcode.Text = dgvItemsTable.Rows[mouseLocation.RowIndex].Cells["Barcode"].Value.ToString();

                    tbItemNumberOnWB.Text = dgvItemsTable.Rows[mouseLocation.RowIndex].Cells["ItemNumberOnWB"].Value.ToString();
                    tbInternalCode.Text = dgvItemsTable.Rows[mouseLocation.RowIndex].Cells["InternalCode"].Value.ToString();
                    tbProductName.Text = dgvItemsTable.Rows[mouseLocation.RowIndex].Cells["ProductNameCol"].Value.ToString();
                    cboSubGroup.Text = dgvItemsTable.Rows[mouseLocation.RowIndex].Cells["SubGroup"].Value.ToString();
                    tbColor.Text = dgvItemsTable.Rows[mouseLocation.RowIndex].Cells["Color"].Value?.ToString();
                    tbHardboardBoxNumber.Text = dgvItemsTable.Rows[mouseLocation.RowIndex].Cells["HardboardBoxNumber"].Value.ToString();
                    tbPackagingAndDimensions.Text = dgvItemsTable.Rows[mouseLocation.RowIndex].Cells["PackagingAndDimensions"].Value.ToString();
                    tbGofferNumber.Text = dgvItemsTable.Rows[mouseLocation.RowIndex].Cells["GofferNumber"].Value.ToString();
                    tbNote.Text = dgvItemsTable.Rows[mouseLocation.RowIndex].Cells["Note"].Value.ToString();
                    pbItemImage.Image = displayImage((byte[])dgvItemsTable.Rows[mouseLocation.RowIndex].Cells["ItemImage"].Value);
                }
            }
            catch (Exception e2)
            {
                MessageBox.Show(e2.Message);

            }
        }
        //this function only get the cell coordinate where the mouse is located to use it when the click is happening
        private void dgvItemsTable_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            mouseLocation = e;
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            try
            {
                //check if the click is inside the table content
                if (mouseLocation.ColumnIndex >= 0 && mouseLocation.RowIndex >= 0)
                {
                    //get the cell value
                    string? choice = dgvItemsTable.Rows[mouseLocation.RowIndex].Cells[mouseLocation.ColumnIndex].Value.ToString();
                    if (choice != null)
                    {
                        switch (mouseLocation.ColumnIndex)
                        {
                            case 1:
                                tbItemCode.Text = choice;
                                break;
                            case 2:
                                tbItemCodeWithColor.Text = choice;
                                break;
                            case 3:
                                tbBarcode.Text = choice;
                                break;
                            case 4:
                                pbItemImage.Image = displayImage((byte[])dgvItemsTable.Rows[mouseLocation.RowIndex].Cells[mouseLocation.ColumnIndex].Value);
                                break;
                            case 5:
                                tbItemNumberOnWB.Text = choice;
                                break;
                            case 6:
                                tbInternalCode.Text = choice;
                                break;
                            case 7:
                                tbProductName.Text = choice;
                                break;
                            case 8:
                                cboSubGroup.Text = choice;
                                break;
                            case 9:
                                tbColor.Text = choice;
                                break;
                            case 10:
                                tbHardboardBoxNumber.Text = choice;
                                break;
                            case 11:
                                tbPackagingAndDimensions.Text = choice;
                                break;
                            case 12:
                                tbGofferNumber.Text = choice;
                                break;
                            case 14:
                                tbNote.Text = choice;
                                break;
                        }
                    }
                }
            }
            catch (Exception ex4)
            {
                MessageBox.Show(ex4.Message);
            }
        }

        private void tbBarcode_TextChanged(object sender, EventArgs e)
        {
            var itemToCheck = ItemData.GetItemByBarcode(tbBarcode.Text);
            if (itemToCheck == null)
            {
                tbBarcode.BackColor = System.Drawing.Color.White;
                canAdd = true;
            }
            else
            {
                tbBarcode.BackColor = System.Drawing.Color.Red;
                canAdd = false;
            }
        }

        private void dgvItemsTable_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            dgvItemsTable.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = global::WorkshopManagement.Properties.Resources.download;
        }

        private void btnUpdateAllImages_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in dgvItemsTable.Rows)
            {
                DownloadDataCompletedEventHandler WhenDownloadComplete = new DownloadDataCompletedEventHandler(ShowImageFromFile);
                InternetAccess.GetImageFromInternet(item.Cells["ItemNumberOnWB"].Value?.ToString(), WhenDownloadComplete);

                //creating new item
                ItemModel newItem = new ItemModel();
                newItem.ItemID = (int)item.Cells["ItemID"].Value;

                //processing the image
                string path = @"Data\img\big\" + item.Cells["ItemNumberOnWB"].Value?.ToString() + "-1.jpg";
                MemoryStream ms = new MemoryStream();
                if (ImageData.GetImage(path) != null)
                {
                    ImageData.GetImage(path).Save(ms, ImageFormat.Jpeg);
                }
                newItem.Image = ms.GetBuffer();
                ItemData.UpdateItemImage(newItem);

            }
        }

        private void ShowImageFromFile(object sender, DownloadDataCompletedEventArgs e)
        {

        }

        private void tbSearchByBarcode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue==13)
            {
                ItemsTable.DefaultView.RowFilter = "[Barcode] like '%" + tbSearchByBarcode.Text + "%'";
            }
        }

        private void tbSearchByBarcode_TextChanged(object sender, EventArgs e)
        {
            SelectRow(tbSearchByBarcode.Text);
            //ItemsTable.DefaultView.RowFilter = "[Barcode] like '%" + tbSearchByBarcode.Text + "%'";
        }
    }
}
