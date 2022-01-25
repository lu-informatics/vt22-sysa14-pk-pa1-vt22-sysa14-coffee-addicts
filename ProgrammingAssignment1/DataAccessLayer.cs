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
    public void CreateRow (Object o)
    {
        string table = "";
        string values = "";
        SqlParameter param1;
        SqlParameter param2;


        if (o.GetType() == typeof(Beans))
        {
            table = "Beans";
            values = "VALUES(@roast,@EAN)";
            param1 = new SqlParameter("@roast", SqlDbType.Text, 255);
            //param1.Value = o.
            
        }
        else if(o.GetType() == typeof(Coffee))
        {
            table = "Coffee";
            values = "VALUES(?,?,?,?,?)";
        }

        using (SqlConnection sqlConnection = new SqlConnection(connectionString))
        {
            using (SqlCommand sqlCommand = new SqlCommand($"INSERT INTO {table} {values};", sqlConnection))
            {

            }
        }
    }
    
    public void UpdateRow(Object o)
    {

    }
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