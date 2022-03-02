using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using WebService3;
public class DataAccessLayer
{
    private string connectionString;
    private string connectionStringCronus;
    private Utils utils = new Utils();

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

    public DataTable GetColumnNames(string tableName)
    {
        using (SqlConnection sqlConnection = new SqlConnection(connectionString))
        {
            using (SqlCommand sqlCommand = new SqlCommand($"SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = '{tableName}'", sqlConnection))
            {
                DataTable dataTable = new DataTable();
                using (SqlDataAdapter adapter = new SqlDataAdapter())
                {
                    adapter.SelectCommand = sqlCommand;
                    adapter.Fill(dataTable);
                    return dataTable;
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

    public void CreateEmployee(CRONUS_Sverige_AB_Employee employee)
    {
        using (CronusEntities cronusEntities = new CronusEntities())
        {
            employee = utils.FillDefaultValues(employee);
            cronusEntities.CRONUS_Sverige_AB_Employee.Add(employee);
            cronusEntities.SaveChanges();
        }
    }

    public List<CRONUS_Sverige_AB_Employee_Relative> GetEmployeeRelatives(string primaryKey)
    {
        using (CronusEntities cronus = new CronusEntities())
        {
            return cronus.CRONUS_Sverige_AB_Employee_Relative.ToList().Where(r => r.Employee_No_ == primaryKey).ToList();
        }
    }

    public List<CRONUS_Sverige_AB_Employee_Absence> GetEmployeeAbsence(string primaryKey)
    {
        using (CronusEntities cronus = new CronusEntities())
        {
            return cronus.CRONUS_Sverige_AB_Employee_Absence.ToList().Where(a => a.Employee_No_ == primaryKey).ToList();
        }
    }

    public List<CRONUS_Sverige_AB_Employee_Qualification> GetEmployeeQualifications(string primaryKey)
    {
        using (CronusEntities cronus = new CronusEntities())
        {
            return cronus.CRONUS_Sverige_AB_Employee_Qualification.ToList().Where(q => q.Employee_No_ == primaryKey).ToList();
        }
    }

    public void UpdateEmployee(CRONUS_Sverige_AB_Employee employee)
    {
        using (CronusEntities cronusEntities = new CronusEntities())
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
                foreach (object o in objects)
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
            using (SqlCommand sqlCommand = new SqlCommand(utils.SelectCronusQuery(methodName), sqlConnection))
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
}