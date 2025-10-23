using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MapsManagerApp.InitilizeFirstTime
{
    public static class InitDatabase
    {
        public static bool CreateIfNeed()
        {
            string connectionString = "Server=.\\SQLExpress;Integrated Security=true;";
            //string connectionString = "Server=.;Integrated Security=true;";
            
            string databaseName = "MapsDatabase";

            using (var connection = new SqlConnection(connectionString))
            {
                string checkDatabaseQuery = $"SELECT database_id FROM sys.databases WHERE name = '{databaseName}'";
                SqlCommand checkDatabaseCommand = new SqlCommand(checkDatabaseQuery, connection);

                object result = -1;
                try
                {
                    connection.Open();
                    result = checkDatabaseCommand.ExecuteScalar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return false;
                }

                if (result == null)
                {
                    MessageBox.Show("برنامه دیتابیس را تشخیص نداد , در حال ساخت دیتابیس ...");

                    string createDatabaseQuery = $"CREATE DATABASE {databaseName};";
                    SqlCommand createDatabaseCommand = new SqlCommand(createDatabaseQuery, connection);
                    createDatabaseCommand.ExecuteNonQuery();
                    Thread.Sleep(1500);
                    MessageBox.Show("دیتابیس ساخته شد");

                    connection.ChangeDatabase(databaseName);

                    string createTableQuery =
                        @"
                            CREATE TABLE Department(
	                            ID int NOT NULL PRIMARY KEY,
	                            Name nvarchar(50) NOT NULL,
	                            Description nvarchar(500) NOT NULL);

                            CREATE TABLE RingBinder(
	                            ID int NOT NULL PRIMARY KEY,
	                            Name nvarchar(50) NOT NULL,
	                            ShelfNumber int NOT NULL,
	                            RowNumber int NOT NULL,
	                            DepartmentID int NOT NULL FOREIGN KEY(DepartmentID) REFERENCES Department (ID));

                            CREATE TABLE Map(
	                            ID int NOT NULL PRIMARY KEY,
	                            Name nvarchar(50) NOT NULL,
	                            RingBinderID int NOT NULL FOREIGN KEY(RingBinderID) REFERENCES RingBinder (ID));";

                    SqlCommand createTableCommand = new SqlCommand(createTableQuery, connection);
                    createTableCommand.ExecuteNonQuery();
                    return true;
                }
                else
                {
                    MessageBox.Show("خوش آمدید");
                    return true;
                }
            }
        }
    }
}
