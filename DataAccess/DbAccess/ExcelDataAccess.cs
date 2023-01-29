using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Runtime.InteropServices;

namespace DataAccess.DbAccess;

public class ExcelDataAccess
{
    public static DataTable GetExcelData(string FilePath, string Category, out string error)
    {
        if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
        {
            using (OleDbConnection connection = new OleDbConnection(Helper.OleCnnVal("ExcelFile", FilePath)))
            {
                try
                {
                    string Query = $"Select * FROM [{Category}$]";
                    //open connection to get data to adapter
                    connection.Open();
                    OleDbDataAdapter oda = new OleDbDataAdapter(Query, connection);
                    connection.Close();
                    //fill dataset with results
                    DataSet ds = new DataSet();
                    oda.Fill(ds);
                    DataTable output = ds.Tables[0];
                    error = "All Done!";
                    return output;
                }
                catch (Exception ex)
                {
                    error = ex.Message;
                    return null;

                }

            }
        }
        else
        {
            error = "access denied!";
            return null;
        }
    }
    public static void UpdateExcelData(string FilePath, string barcode,int amount,out string error)
    {
        if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
        {
            using (OleDbConnection conn = new OleDbConnection(Helper.OleCnnVal("ExcelFile", FilePath)))
            {
                try
                {
                    conn.Open();
                    OleDbCommand cmd = new OleDbCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = $"UPDATE [Сводная$] SET amount = {amount} WHERE [Баркод] = '{barcode}';";
                    cmd.ExecuteNonQuery();
                    error = "good";

                }
                catch (Exception ex)
                {
                    error = ex.Message;
                }
            }
        }
        else
        {
            error = "access denied!";
        }
    }
}
