using Dapper;
using System.Data;
using System.Data.SqlClient;
using System.Xml.Linq;
namespace DataAccess.DbAccess;

public class SqlDataAccess 
{
    public static IEnumerable<T> LoadData<T, U>(
        string storedProcedure,
        U parameters,
        string connectionId = "Default")
    {
        using IDbConnection connection = new SqlConnection(Helper.SqlCnnVal(connectionId));

        return  connection.Query<T>(storedProcedure, parameters,
            commandType: CommandType.StoredProcedure);
    }

    public static int SaveData<T>(
        string storedProcedure,
        T parameters,
        string connectionId = "Default")
    {
        using IDbConnection connection = new SqlConnection(Helper.SqlCnnVal(connectionId));

        return connection.Execute(storedProcedure, parameters,
            commandType: CommandType.StoredProcedure);
    }

    public static int SaveDataAndReturnLastID<T>(
         string storedProcedure,
         T parameters,
         string connectionId = "Default")
    {
        using IDbConnection connection = new SqlConnection(Helper.SqlCnnVal(connectionId));

        return (int)connection.ExecuteScalar(storedProcedure, parameters,
            commandType: CommandType.StoredProcedure);
    }
    /// <summary>
     /// Test that the server is connected
     /// </summary>
     /// <param name="connectionString">The connection string</param>
     /// <returns>true if the connection is opened</returns>
    public static bool IsServerConnected(string connectionId)
    {
        using (SqlConnection connection = new SqlConnection(Helper.SqlCnnVal(connectionId)))
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (SqlException)
            {
                return false;
            }
        }
    }
}
