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
    


    /*
 private static void SqlCommandPrepareEx(string connectionString)
{
    using (SqlConnection connection = new SqlConnection(connectionString))
    {
        connection.Open();
        SqlCommand command = new SqlCommand(null, connection);

        // Create and prepare an SQL statement.
        command.CommandText =
            "INSERT INTO Region (RegionID, RegionDescription) " +
            "VALUES (@id, @desc)";
        SqlParameter idParam = new SqlParameter("@id", SqlDbType.Int, 0);
        SqlParameter descParam =
            new SqlParameter("@desc", SqlDbType.Text, 100);
        idParam.Value = 20;
        descParam.Value = "First Region";
        command.Parameters.Add(idParam);
        command.Parameters.Add(descParam);

        // Call Prepare after setting the Commandtext and Parameters.
        command.Prepare();
        command.ExecuteNonQuery();

        // Change parameter values and call ExecuteNonQuery.
        command.Parameters[0].Value = 21;
        command.Parameters[1].Value = "Second Region";
        command.ExecuteNonQuery();
    }
}
    */


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