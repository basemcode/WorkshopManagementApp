using DataAccess.Data;
using System.Threading;
using WorkshopManagement.Forms;

namespace WorkshopManagement;

internal static class Program
{
    //a mutual exclusion to allow only one instance of the app
    private static Mutex mutex = null;
    [STAThread]
    static void Main()
    {
        const string appName = "WorkshopManegment";
        bool createdNew;

        mutex = new Mutex(true, appName, out createdNew);

        if (!createdNew)
        {
            MessageBox.Show("Программа уже открыта!");
            //app is already running! Exiting the application
            return;
        }
        ApplicationConfiguration.Initialize();
        Application.Run(new frmLogin());
        
    }
}

// To customize application configuration such as set high DPI settings or default font,
// see https://aka.ms/applicationconfiguration.