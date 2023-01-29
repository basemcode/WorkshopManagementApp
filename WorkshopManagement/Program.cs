using DataAccess.Data;
using WorkshopManagement.Forms;

namespace WorkshopManagement;

internal static class Program
{
    public static string loggedInUser;
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        ApplicationConfiguration.Initialize();
        //SessionHelper.loggedUser = new DataAccess.Models.UserModel {UserID=1, Username="basem123",FirstName="Basem",MiddleName="user"};
        Application.Run(new frmLogin());
        //Application.Run(new frmExcelOperations());
        //Application.Run(new frmMain());
    }
}