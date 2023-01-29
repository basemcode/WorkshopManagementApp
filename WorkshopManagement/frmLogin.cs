﻿using DataAccess.Data;
using DataAccess.DbAccess;
using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorkshopManagement;

public partial class frmLogin : Form
{
    BackgroundWorker _populateWorker = new BackgroundWorker();
    public frmLogin()
    {
        InitializeComponent();
        
        _populateWorker.DoWork += new DoWorkEventHandler(_populateWorker_DoWork);
        _populateWorker.RunWorkerAsync();

    }
    
    
    private void _populateWorker_DoWork(object? sender, DoWorkEventArgs e)
    {
        if (SqlDataAccess.IsServerConnected("Default"))
        {
            lblConnecting.Invoke((MethodInvoker)delegate {
                // Running on the UI thread
                lblConnecting.Visible = false;
            });
            lblError.Invoke((MethodInvoker)delegate {
                lblConnectionError.Visible = false;
            });
            btnLogin.Invoke((MethodInvoker)delegate {
                btnLogin.Enabled = true;
            });


        }
        else
        {
            lblConnecting.Invoke((MethodInvoker)delegate {
                // Running on the UI thread
                lblConnecting.Visible = false;
            });
            lblError.Invoke((MethodInvoker)delegate {
                // Running on the UI thread
                lblConnectionError.Visible = true;
            });
            btnLogin.Invoke((MethodInvoker)delegate {
                // Running on the UI thread
                btnLogin.Enabled = false;
            });
           /* MessageBox.Show("Не удалось подключиться к серверу!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);*/
        }
    }

    private void btnClose_Click(object sender, EventArgs e)
    {
        this.Close();
    }

    private void btnLogin_Click(object sender, EventArgs e)
    {
        try
        {
        if (txtUsername.Text!=string.Empty||txtPassword.Text!=string.Empty)
        {
            UserModel? loggedUser = UserData.Login(txtUsername.Text, txtPassword.Text);
            if (loggedUser == null)
            {
                lblError.Text = "Неверный логин или пароль!";
            }
            else
            {
                SessionHelper.loggedUser = loggedUser;
                frmMain frmMain = new frmMain();
                this.Hide();
                frmMain.ShowDialog();
                this.Close();
            }
        }
        else
        {
            lblError.Text = "Введите логин и пароль пожалуйста!";
        }
        }
        catch (Exception ee)
        {

            MessageBox.Show(ee.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void txtUsername_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyValue == 13)
        {
            txtPassword.Focus();
        }
    }

    private void txtPassword_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyValue == 13)
        {
            if (btnLogin.Enabled==true)
            {
                btnLogin_Click(sender, e);
            }
        }
    }

    private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
    {
        txtPassword.UseSystemPasswordChar = !chkShowPassword.Checked;
    }

    private void frmLogin_Load(object sender, EventArgs e)
    {
        
    }

   

    private void lblConnectionError_Click(object sender, EventArgs e)
    {
        _populateWorker.RunWorkerAsync();
    }
}
