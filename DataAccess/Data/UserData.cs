using DataAccess.DbAccess;
using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Data;

public class UserData
{
    public static IEnumerable<UserModel> GetUsers() =>
        SqlDataAccess.LoadData<UserModel, dynamic>("dbo.spUsers_Select", new {  });
    
    public static UserModel? GetUserByID(int UserID)
    {
        var results = SqlDataAccess.LoadData<UserModel, dynamic>(
            "dbo.spUsers_Select",
            new { UserID = UserID });
        return results.FirstOrDefault();
    }

    public static UserModel? GetUserByUserName(string Username)
    {
        var results = SqlDataAccess.LoadData<UserModel, dynamic>(
            "dbo.spUsers_Select",
            new { Username = Username });
        return results.FirstOrDefault();
    }
    public static UserModel? Login(string Username,string password)
    {
        var results = SqlDataAccess.LoadData<UserModel, dynamic>(
            "dbo.spUsers_Login",
            new { Username = Username,Password=password });
        return results.FirstOrDefault();
    }
    public static void InsertUser(UserModel User) =>
        SqlDataAccess.SaveData("dbo.spUsers_Insert", new
        {
            User.FirstName,
            User.MiddleName,
            User.LastName,
            User.Username,
            User.Password,
            User.Privileges
        });

    public static void UpdateUser(UserModel User) =>
        SqlDataAccess.SaveData("dbo.spUsers_Update", User);

    public static void DeleteUser(int UserID) =>
        SqlDataAccess.SaveData("dbo.spUsers_Delete", new { UserID = UserID });
}
