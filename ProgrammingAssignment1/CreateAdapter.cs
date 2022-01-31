
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;

public class CreateAdapter
{
    public static SqlDataAdapter CreateAdapterManager(SqlConnection connection, string tableName)
    {

        DataAccessLayer dataAccessLayer = new DataAccessLayer();

        DataSet dataSet = dataAccessLayer.GetMetaData(tableName);

        SqlDataAdapter adapter = new SqlDataAdapter();
        SqlCommand command = new SqlCommand();

        string insert = $"INSERT INTO {tableName} VALUES(";

        //string delete = $"DELETE FROM {tableName} WHERE {dataSet.GetString()}";

        //Create the InsertCommand

        foreach (DataRow row in dataSet.Tables[0].Rows)
        {
            insert += "@" + row.ItemArray[3] + ","; //ItemArray lägger var värde från MetaDatan in i en array, [3] är COLUMN_NAME
        }
        insert = insert.Remove(insert.Length - 1, 1);
        insert += ")";
        command = new SqlCommand(insert, connection);

        //Adding the parameters based on the MetaData
        foreach (DataRow row in dataSet.Tables[0].Rows)
        {
            // insert += "@" + row.ItemArray[3] + ",";
            SqlDbType dbType = new SqlDbType();
            var length = row.ItemArray[8]; //[8] = length,  Length kanske inte fungerar när det är en int, den kanske returnerar Null isf?? Inte testat detta.
            var type = row.ItemArray[7]; //   [7] = type,  
            var name = row.ItemArray[3] as string; //[3] är COLUMN_NAME,

            if (type.Equals("varchar"))
            {
                dbType = SqlDbType.VarChar;
            }
            else if (type.Equals("int"))
            {
                dbType = SqlDbType.Int;
                length = 0;
            }
            command.Parameters.Add("@" + name, dbType, (int)length, name);
        }


        adapter.InsertCommand = command;

        //Create DeleteCommand
        //command = new SqlCommand("DELETE FROM Beans WHERE EAN = @EAN", connection);
        //parameter = command.Parameters.Add("@EAN", SqlDbType.VarChar, 255, "EAN");
        //parameter.SourceVersion = DataRowVersion.Original;
        //adapter.DeleteCommand = command;

        return adapter;

    }
    public static SqlDataAdapter CreateAdapterUpdateCommand(SqlConnection connection, string tableName)
    {
        DataAccessLayer dataAccessLayer = new DataAccessLayer();

        DataSet metaData = dataAccessLayer.GetMetaData(tableName);
        DataSet keyData = dataAccessLayer.GetKeys(tableName);

        SqlDataAdapter adapter = new SqlDataAdapter();


        string update = $"UPDATE {tableName} SET ";
        string where = " WHERE ";

        //Create the UpdateCommand

        foreach (DataRow row in metaData.Tables[0].Rows)
        {
            update += row.ItemArray[3] + " = @" + row.ItemArray[3] + ","; //ItemArray lägger var värde från MetaDatan in i en array, [3] är COLUMN_NAME
        }
        Debug.Write(update);
        update = update.Remove(update.Length - 1, 1);

        foreach (DataRow row in keyData.Tables[0].Rows)
        {
            where += row.ItemArray[0] + " = @" + row.ItemArray[0] + ",";
        }
        where = where.Remove(where.Length - 1, 1);

        string query = update + where;
        var command = new SqlCommand(query, connection);
        Debug.Write(query);
        //Adding the parameters based on the MetaData
        foreach (DataRow row in metaData.Tables[0].Rows)
        {
            SqlDbType dbType = new SqlDbType();
            var length = row.ItemArray[8]; //[8] = length,  Length kanske inte fungerar när det är en int, den kanske returnerar Null isf?? Inte testat detta.
            var type = row.ItemArray[7]; //   [7] = type,  
            var name = row.ItemArray[3] as string; //[3] är COLUMN_NAME,

            if (type.Equals("varchar"))
            {
                dbType = SqlDbType.VarChar;
            }
            else if (type.Equals("int"))
            {
                dbType = SqlDbType.Int;
                length = 0;
            }
            command.Parameters.Add("@" + name, dbType, (int)length, name);
        }


        adapter.UpdateCommand = command;

        return adapter;
    }
    /*public static SqlDataAdapter CreateAdapterDeleteCommand(SqlConnection connection, string tableName)
    {
        DataAccessLayer dataAccessLayer = new DataAccessLayer();

        DataSet dataSet = dataAccessLayer.GetMetaData(tableName);

        SqlDataAdapter adapter = new SqlDataAdapter();
        SqlCommand command = new SqlCommand();

        string delete = $"DELETE {tableName} SET ";

        //Create the UpdateCommand

        command = new SqlCommand("DELETE Beans WHERE roast = @roast " +
            "WHERE EAN = @oldEAN", connection);

        //Add parameters for UpdateCommand
        command.Parameters.Add("@roast", SqlDbType.VarChar, 255, "roast");
        command.Parameters.Add("@EAN", SqlDbType.VarChar, 255, "EAN");
        SqlParameter parameter = command.Parameters.Add("@oldEAN", SqlDbType.VarChar, 255, "EAN");

        parameter.SourceVersion = DataRowVersion.Original;

        adapter.UpdateCommand = command;


        return adapter;
    
    }
    */



}
