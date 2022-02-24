using System.Data;
using System.Data.SqlClient;
using WebService3;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;
public class DataAccessLayer
{
    private string connectionString;
    private string connectionStringCronus;
    public DataAccessLayer()
    {
        connectionString = "Server = tcp:testservercoffeaddicts.database.windows.net,1433; Initial Catalog = CoffeeAddicts; Persist Security Info = False; User ID = coffeaddicts; Password =HzbPvJEn7VVTNEJx3Naf; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30";
        connectionStringCronus = "Server=tcp:testservercoffeaddicts.database.windows.net,1433;Initial Catalog=Cronus AB;Persist Security Info=False;User ID=coffeaddicts;Password=HzbPvJEn7VVTNEJx3Naf;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
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
    public List<object> GetCronusTable(string tableName)
    {
        using (CronusEntities cronusEntities = new CronusEntities())
        {
            switch (tableName)
            {
                case "Relative":
                    break;
            }
            List<CRONUS_Sverige_AB_Employee> employees = cronusEntities.CRONUS_Sverige_AB_Employee.ToList();
            return null;
        }
    }
    public void CreateEmployee(CRONUS_Sverige_AB_Employee employee)
    {
        using(CronusEntities cronusEntities = new CronusEntities())
        {
            cronusEntities.CRONUS_Sverige_AB_Employee.Add(employee);
            cronusEntities.SaveChanges();
           
        }
    }

    public void UpdateEmployee(CRONUS_Sverige_AB_Employee employee)
    {
        using(CronusEntities cronusEntities = new CronusEntities())
        {
            CRONUS_Sverige_AB_Employee tmpEmployee = cronusEntities.CRONUS_Sverige_AB_Employee.Where(e => e.No_ == employee.No_).First();
            tmpEmployee.First_Name = employee.First_Name;
            tmpEmployee.Last_Name = employee.Last_Name;
            tmpEmployee.Job_Title = employee.Job_Title;
            tmpEmployee.Phone_No_ = employee.Phone_No_;
            tmpEmployee.City = employee.City;
          
            cronusEntities.SaveChanges();

        }
    }
    public void DeleteEmployee(string pk)
    {
        using (CronusEntities cronusEntities = new CronusEntities())
        {
            CRONUS_Sverige_AB_Employee tmpEmp = cronusEntities.CRONUS_Sverige_AB_Employee.Where(e => e.No_.Equals(pk)).First();
            cronusEntities.CRONUS_Sverige_AB_Employee.Remove(tmpEmp);
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
        using (SqlConnection connection = new SqlConnection(connectionStringCronus))
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

    public DataSet GetCronusData(string methodName)
    {
        using (SqlConnection sqlConnection = new SqlConnection(connectionStringCronus))
        {
            using (SqlCommand sqlCommand = new SqlCommand(SelectCronusQuery(methodName), sqlConnection))
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
    public string SelectCronusQuery(string methodName)
    {
        string query = "";
        switch (methodName)
        {
            case "All keys":
                query = "SELECT * FROM INFORMATION_SCHEMA.TABLE_CONSTRAINTS WHERE CONSTRAINT_TYPE LIKE '%KEY'";
                return query;
            case "All indexes":
                query = "SELECT * FROM sys.indexes";
                return query;
            case "All table_constraints":
                query = "SELECT * FROM INFORMATION_SCHEMA.TABLE_CONSTRAINTS";
                return query;

            case "All tables #1":
                query = "SELECT * FROM INFORMATION_SCHEMA.TABLES";
                return query;

            case "All tables #2":
                query = "SELECT * FROM sys.tables";
                return query;

            case "All employee columns #1":
                query = "SELECT * FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME LIKE 'CRONUS Sverige AB$Employee'";
                return query;

            case "All employee columns #2":
                query = "SELECT * FROM sys.columns WHERE object_id = OBJECT_ID('dbo.CRONUS Sverige AB$Employee')";
                return query;

            case "Absentee": //Are spaces needed in query?
                query = "SELECT e.[First Name] " +
                        "FROM [CRONUS Sverige AB$Employee] e " +
                        "WHERE e.[No_] IN " +
                        "( SELECT subquery.[Employee No_] " +
                        "FROM " +
                        "( SELECT TOP 1 [Employee No_], SUM([Quantity (Base)]) AS 'Absence Hours' " +
                        "FROM [CRONUS Sverige AB$Employee Absence] " +
                        "GROUP BY [Employee No_] " +
                        "ORDER BY 'Absence Hours' DESC " +
                        ") subquery) ";
                return query;

            case "Sickness":
                query = "SELECT [First Name], [Last Name], [Job Title],[Phone No_], [City] FROM [CRONUS Sverige AB$Employee] " +
                        "WHERE No_ IN " +
                            "( SELECT [Employee No_] FROM [CRONUS Sverige AB$Employee Absence] " +
                            "WHERE [Cause of Absence Code] LIKE 'SJUK' AND [From Date] BETWEEN " +
                            "CONVERT(datetime, '2004-01-01') AND CONVERT(datetime, '2004-12-31') " +
                            "GROUP BY [Employee No_] " +
                            ") ";
                return query;

            case "Employees and relatives":
                query = "SELECT e.[First Name] as 'Employee First Name', e.[Last Name] as 'Employee Last Name', er.[Relative Code] as 'Relative Relation', er.[First Name] as 'Relative First Name', er.[Last Name] as 'Relative Last Name' " +
                        "FROM [CRONUS Sverige AB$Employee] e " +
                        "JOIN [CRONUS Sverige AB$Employee Relative] er " +
                        "ON er.[Employee No_] = e.No_ ";
                return query;

            case "All Employee Tables Metadata":
                query = "SELECT TABLE_NAME, COLUMN_NAME, IS_NULLABLE, DATA_TYPE, CHARACTER_MAXIMUM_LENGTH "+
                        "FROM INFORMATION_SCHEMA.COLUMNS "+
                        "WHERE TABLE_NAME LIKE 'CRONUS Sverige AB$Employee%' ";
                return query;

                default: return null;
        }
        

        
    }
}