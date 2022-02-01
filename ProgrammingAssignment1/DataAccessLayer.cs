using System.Data;
using System.Data.SqlClient;
public class DataAccessLayer
{
    private string connectionString;

    public DataAccessLayer()
    {
        SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
        builder.DataSource = "localhost";
        builder.InitialCatalog = "COFFEEADDICTS";
        builder.IntegratedSecurity = false; //Needed?
        builder.UserID = "user1";
        builder.Password = "1234";

        connectionString = builder.ConnectionString;
    }

    public DataSet GetKeys(string tableName)
    {
        using (SqlConnection sqlConnection = new SqlConnection(connectionString))
        {
            using (SqlCommand sqlCommand = new SqlCommand($"SELECT Col.Column_Name from INFORMATION_SCHEMA.TABLE_CONSTRAINTS Tab, INFORMATION_SCHEMA.CONSTRAINT_COLUMN_USAGE Col WHERE Col.Constraint_Name = Tab.Constraint_Name AND Col.Table_Name = Tab.Table_Name AND Constraint_Type = 'PRIMARY KEY' AND Col.Table_Name = '{tableName}'"
, sqlConnection))
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

    public DataSet GetTable(string tableName)
    {
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                using (SqlCommand sqlCommand = new SqlCommand($"SELECT * FROM {tableName}", sqlConnection))
                {
                    DataSet dataSet = new DataSet();

                    using (SqlDataAdapter adapter = new SqlDataAdapter())
                    {
                        adapter.SelectCommand = sqlCommand;
                        adapter.Fill(dataSet);
                    }
                    return dataSet;
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