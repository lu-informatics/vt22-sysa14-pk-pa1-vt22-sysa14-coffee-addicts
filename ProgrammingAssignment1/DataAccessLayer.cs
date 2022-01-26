using System.Data;
using System.Data.SqlClient;
using System.Collections;
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

    public DataSet GetMetaData(string tableName)
    { 
        using (SqlConnection sqlConnection = new SqlConnection(connectionString))
        {
            using (SqlCommand sqlCommand = new SqlCommand($"SELECT * FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = '{tableName}'", sqlConnection))
            {
                DataSet dataSet = new DataSet();
                using(SqlDataAdapter adapter = new SqlDataAdapter())
                {
                    adapter.SelectCommand = sqlCommand;
                    adapter.Fill(dataSet);

                    return dataSet;
                }
                

                /*
                 * sqlConnection.Open();
                SqlDataReader reader = sqlCommand.ExecuteReader();
                /*
                List<string> rows = new List<string>();
                while (reader.Read())
                {
                    rows.Add(reader.GetString(columnName));
                }
                
                return reader;
                */
            }
        }
    }

    public DataSet GetTable(string tableName) { 
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
    
    public void InsertRowTest()
    {   
        
        
        

        
        using (SqlConnection sqlConnection = new SqlConnection(connectionString))
        {
            using(SqlDataAdapter adapter = CreateAdapter.CreateAdapterManager(sqlConnection, "Beans"))
            {
                adapter.InsertCommand.Parameters[0].Value = "Medium";
                adapter.InsertCommand.Parameters[1].Value = "828";
                sqlConnection.Open();
                adapter.InsertCommand.ExecuteNonQuery();
              
            }
        }
  
    }

    public void CreateRow (object o)
    {
        string table = "";
        string values = "";
        SqlParameter param1 = new SqlParameter();
        SqlParameter param2 = new SqlParameter();


        if (o is Beans)
        {
            Beans bean = (Beans) o;
            values = "@roast,@EAN";
            param1 = new SqlParameter("@roast", SqlDbType.VarChar, 255);
            param2 = new SqlParameter("@EAN", SqlDbType.VarChar, 255);
            param1.Value = bean.Roast;
            param2.Value = bean.EAN1;
            
            
        }

        using (SqlConnection sqlConnection = new SqlConnection(connectionString))
        {
            using (SqlCommand sqlCommand = new SqlCommand($"INSERT INTO {table} VALUES({values});", sqlConnection))
            {
                if(table == "Beans")
                {
                    sqlCommand.Parameters.Add(param1);
                    sqlCommand.Parameters.Add(param2);
                    sqlCommand.Prepare();
                    sqlCommand.ExecuteNonQuery();

                    sqlCommand.Parameters[0].Value = "Dark";
                    sqlCommand.Parameters[1].Value = "324";
                    sqlCommand.ExecuteNonQuery();
                }
            }
        }
    }
    
    public void UpdateRow(Object o)
    {

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