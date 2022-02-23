using System.Data;
using System.Data.SqlClient;
using WebService3;
using System.Collections.Generic;
using System.Linq;
public class DataAccessLayer
{
    private string connectionString;

    public DataAccessLayer()
    {
        connectionString = "Server = tcp:testservercoffeaddicts.database.windows.net,1433; Initial Catalog = CoffeeAddicts; Persist Security Info = False; User ID = coffeaddicts; Password =HzbPvJEn7VVTNEJx3Naf; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30";
    }

    public DataSet GetKeys(string tableName)
    {
        using (SqlConnection sqlConnection = new SqlConnection(connectionString))
        {
            using (SqlCommand sqlCommand = new SqlCommand($"SELECT Col.Column_Name from INFORMATION_SCHEMA.TABLE_CONSTRAINTS Tab, INFORMATION_SCHEMA.CONSTRAINT_COLUMN_USAGE Col WHERE Col.Constraint_Name = Tab.Constraint_Name AND Col.Table_Name = Tab.Table_Name AND Constraint_Type = 'PRIMARY KEY' AND Col.Table_Name = '{tableName}'", sqlConnection))
            {
                DataSet dataSet = new DataSet();
                using (SqlDataAdapter adapter = new SqlDataAdapter())
                {
                    adapter.SelectCommand = sqlCommand;
                    adapter.Fill(dataSet);

                    return dataSet;
                }
            }
        }
    }

    public DataSet GetTableNames()
    {
        using (SqlConnection sqlConnection = new SqlConnection(connectionString))
        {
            using (SqlCommand sqlCommand = new SqlCommand($"SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_TYPE = 'BASE TABLE'", sqlConnection))
            {
                DataSet dataset = new DataSet();
                

                using (SqlDataAdapter adapter = new SqlDataAdapter())
                {
                    adapter.SelectCommand = sqlCommand;

                    adapter.Fill(dataset);
                   
                    return dataset;
                }
                
            }
        }
    }

    public DataSet GetMetaData(string tableName)
    {
        using (SqlConnection sqlConnection = new SqlConnection(connectionString))
        {
            using (SqlCommand sqlCommand = new SqlCommand($"SELECT * FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = '{tableName}'", sqlConnection))
            {
                DataSet dataSet = new DataSet();
                using (SqlDataAdapter adapter = new SqlDataAdapter())
                {
                    adapter.SelectCommand = sqlCommand;
                    adapter.Fill(dataSet);

                    return dataSet;
                }
            }
        }
    }
    public List<CRONUS_Sverige_AB_Employee> GetEmployees()
    {
        using (CronusEntities cronusEntities = new CronusEntities())
        {
            List<CRONUS_Sverige_AB_Employee> employees = cronusEntities.CRONUS_Sverige_AB_Employee.ToList();
            return employees;
        }
    }

    public void SetEmployee(CRONUS_Sverige_AB_Employee employee)
    {
        using(CronusEntities cronusEntities = new CronusEntities())
        {
            cronusEntities.CRONUS_Sverige_AB_Employee.Add(employee);
            cronusEntities.SaveChanges();
           
        }
    }
    public DataTable GetTable(string tableName)
    {
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                using (SqlCommand sqlCommand = new SqlCommand($"SELECT * FROM {tableName}", sqlConnection))
                {
                    DataTable dataTable = new DataTable();

                    using (SqlDataAdapter adapter = new SqlDataAdapter())
                    {
                        adapter.SelectCommand = sqlCommand;
                        adapter.Fill(dataTable);
                    }
                    return dataTable;
                }
            }
        }
    }

    public void InsertRow(object[] objects, string tableName)
    {
        using (SqlConnection sqlConnection = new SqlConnection(connectionString))
        {
            using (SqlDataAdapter adapter = CreateAdapter.CreateAdapterManager(sqlConnection, tableName))
            {
                sqlConnection.Open();
                int i = 0;
                foreach(object o in objects)
                {
                    adapter.InsertCommand.Parameters[i].Value = o;
                    i++;
                }
                adapter.InsertCommand.ExecuteNonQuery();
            }
        }
    }
    
    public void UpdateRow(object[] objects, string tableName)
    {
        using (SqlConnection sqlConnection = new SqlConnection(connectionString))
        {
            using (SqlDataAdapter adapter = CreateAdapter.CreateAdapterUpdateCommand(sqlConnection, tableName))
            {
                sqlConnection.Open();
                int i = 0;
                foreach (object o in objects)
                {
                    adapter.UpdateCommand.Parameters[i].Value = o;
                    i++;
                }
                adapter.UpdateCommand.ExecuteNonQuery();
            }
        }
    }

    public void DeleteRow(object[] objects, string tableName)
    {
        using (SqlConnection sqlConnection = new SqlConnection(connectionString))
        {
            using (SqlDataAdapter adapter = CreateAdapter.CreateAdapterDeleteCommand(sqlConnection, tableName))
            {
                sqlConnection.Open();
                int i = 0;
                foreach (object o in objects)
                {
                    adapter.DeleteCommand.Parameters[i].Value = o;
                    i++;
                }
                adapter.DeleteCommand.ExecuteNonQuery();
            }
        }
    }

    public bool IsServerConnected()
    {
        using (SqlConnection connection = new SqlConnection(connectionString))
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