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

    public DataSet GetBeans() { 
    {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                using (SqlCommand sqlCommand = new SqlCommand("SELECT * FROM Beans", sqlConnection))
                {
                    DataSet dataSetBeans = new DataSet();

                    using (SqlDataAdapter adapter = new SqlDataAdapter())
                    {
                        adapter.SelectCommand = sqlCommand;
                        adapter.Fill(dataSetBeans, "Beans");

                    }

                    return dataSetBeans;
                }
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