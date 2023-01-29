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

namespace WorkshopManagement
{
    public partial class frmUsers : Form
    {
        DataTable UsersTable=new DataTable();
        bool canAdd = false;
        public frmUsers()
        {
            InitializeComponent();
        }
        private void frmUsers_Load(object sender, EventArgs e)
        {
           /* UsersTable.Columns.AddRange(new DataColumn[]
           {   
            new DataColumn { ColumnName = "UserID",DataType =typeof(Int32),Caption="ID пользователя"},
            new DataColumn { ColumnName = "FirstName" ,DataType =typeof(string),Caption="Имя"},
            new DataColumn { ColumnName = "MiddleName",DataType =typeof(string),Caption="Отчество" },
            new DataColumn { ColumnName = "LastName" ,DataType =typeof(string),Caption="Фамилия"},
            new DataColumn { ColumnName = "Username" ,DataType =typeof(string),Caption="Логин"},
            new DataColumn { ColumnName = "Password" ,DataType =typeof(string),Caption="Пароль"},
            new DataColumn { ColumnName = "privileges" ,DataType =typeof(string),Caption="Привилегии"}
           });*/
            dgvUsers.DataSource = UsersTable;
            
            LoadDataToDGV();
            dgvUsers.ClearSelection() ;
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text== txtPasswordRepeat.Text)
            {
                UserModel newUser = new UserModel();
                newUser.FirstName = txtFirstName.Text;
                newUser.MiddleName = txtMiddleName.Text;
                newUser.LastName = txtLastName.Text;
                newUser.Username = txtUsername.Text;
                newUser.Password = txtPassword.Text;
                newUser.Privileges = cmbPrivilege.Text;
                UserData.InsertUser(newUser);
                ClearControlsValues();
            }
            else
            {
                MessageBox.Show("Пароли не совпадают!");
            }

            LoadDataToDGV();
            //ClearControlsValues();
        }

        private void LoadDataToDGV()
        {
            UsersTable = DataHelper.ToDataTable<UserModel>(UserData.GetUsers());
            dgvUsers.AutoGenerateColumns = false;
            dgvUsers.DataSource = UsersTable;
            /*dgvUsers.Columns["UserID"].HeaderText = "ID пользователя";
            dgvUsers.Columns["FirstName"].HeaderText = "Имя";
            dgvUsers.Columns["MiddleName"].HeaderText = "Отчество";
            dgvUsers.Columns["LastName"].HeaderText = "Фамилия";
            dgvUsers.Columns["Username"].HeaderText = "Логин";
            dgvUsers.Columns["Password"].HeaderText = "Пароль";
            dgvUsers.Columns["Password"].DefaultCellStyle.BackColor = Color.Black;
            dgvUsers.Columns["Password"].DefaultCellStyle.SelectionForeColor = SystemColors.Highlight;
            dgvUsers.Columns["privileges"].HeaderText = "Привилегии";*/
        }
        private DataGridViewCellEventArgs mouseLocation;
        private void dgvUsers_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            mouseLocation = e;
        }
        private void EditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvUsers.SelectedRows.Count != 0 && dgvUsers.SelectedRows[0].Cells["UserID"].Value != null)
                {
                    txtID.Text = dgvUsers.Rows[mouseLocation.RowIndex].Cells["UserID"].Value.ToString();
                    txtFirstName.Text = dgvUsers.Rows[mouseLocation.RowIndex].Cells["FirstName"].Value.ToString();
                    txtMiddleName.Text = dgvUsers.Rows[mouseLocation.RowIndex].Cells["MiddleName"].Value.ToString();
                    txtLastName.Text = dgvUsers.Rows[mouseLocation.RowIndex].Cells["LastName"].Value.ToString();
                    txtUsername.Text = dgvUsers.Rows[mouseLocation.RowIndex].Cells["Username"].Value.ToString();
                    txtPassword.Text = dgvUsers.Rows[mouseLocation.RowIndex].Cells["Password"].Value.ToString();
                    txtPasswordRepeat.Text = dgvUsers.Rows[mouseLocation.RowIndex].Cells["Password"].Value.ToString();
                    cmbPrivilege.Text = dgvUsers.Rows[mouseLocation.RowIndex].Cells["privileges"].Value.ToString();
                }
            }
            catch (Exception)
            {


            }
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {

            string message = $"Вы хотите удалить пользователя с ID: {dgvUsers.SelectedRows[0].Cells["UserID"].Value} и именем: {dgvUsers.SelectedRows[0].Cells["FirstName"].Value}?";
            string title = "Удалить пользователя";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                UserData.DeleteUser(Convert.ToInt32( dgvUsers.SelectedRows[0].Cells["UserID"].Value));
                MessageBox.Show("Пользователь успешно удален!");
                LoadDataToDGV();
            }
            else
            {
                // Do something  
            }
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            if (UserData.GetUserByUserName(txtUsername.Text) is not null || String.IsNullOrEmpty(txtUsername.Text))
            {
                toolStripStatusLabel1.Text = String.IsNullOrEmpty(txtUsername.Text) ? "неверный логин!" : "Этот пользователь уже существует!";
                txtUsername.BackColor = Color.Red;
                btnAddUser.Enabled = false;
                
            }
            else
            {
                toolStripStatusLabel1.Text = "";
                txtUsername.BackColor = Color.LightGreen;
                btnAddUser.Enabled = true; 
            }
        }

        private void btnUpdateUser_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text == txtPasswordRepeat.Text)
            {

                if (txtID.Text != String.Empty)
                {
                    UserModel updatedUser = new UserModel();
                    updatedUser.UserID = Convert.ToInt32(txtID.Text);
                    updatedUser.FirstName = txtFirstName.Text;
                    updatedUser.MiddleName = txtMiddleName.Text;
                    updatedUser.LastName = txtLastName.Text;
                    updatedUser.Username = txtUsername.Text;
                    updatedUser.Password = txtPassword.Text;
                    updatedUser.Privileges = cmbPrivilege.Text;

                    UserData.UpdateUser(updatedUser);
                    ClearControlsValues();
                    LoadDataToDGV();
                }
                else
                {
                    MessageBox.Show("Выберите пользователя, пожалуйста!");
                }
            }
            else
            {
                MessageBox.Show("Пароли не совпадают!");
            }
        }
        private void ClearControlsValues()
        {
            txtID.Text=String.Empty;
            txtFirstName.Text = String.Empty;
            txtMiddleName.Text = String.Empty;
            txtLastName.Text = String.Empty;
            txtUsername.Text = String.Empty;
            txtPassword.Text = String.Empty;
            txtPasswordRepeat.Text = String.Empty;
            cmbPrivilege.Text = String.Empty;
        }
    }
}
