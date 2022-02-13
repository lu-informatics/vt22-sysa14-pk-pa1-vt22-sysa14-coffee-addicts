
using System.Data.SqlClient;
using System.Data;
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
            } else if (type.Equals("int"))
            {
                dbType = SqlDbType.Int;
                length = 0;
            }         
            command.Parameters.Add("@" + name, dbType, (int)length , name);
        }


        adapter.InsertCommand = command;

        return adapter;

    }
    public static SqlDataAdapter CreateAdapterUpdateCommand(SqlConnection connection, string tableName)
    {
        DataAccessLayer dataAccessLayer = new DataAccessLayer();

        DataSet metaData = dataAccessLayer.GetMetaData(tableName);
        DataSet keyData = dataAccessLayer.GetKeys(tableName);

        SqlDataAdapter adapter = new SqlDataAdapter();
        SqlCommand command = new SqlCommand();

        string update = $"UPDATE {tableName} SET ";
        string where = " WHERE ";

        //Create the UpdateCommand


        foreach(DataRow row in metaData.Tables[0].Rows)
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
        command = new SqlCommand(query, connection);

        Debug.WriteLine(query);


        //Adding the parameters based on the MetaData
        foreach (DataRow row in metaData.Tables[0].Rows)
        {
           // insert += "@" + row.ItemArray[3] + ",";
            SqlDbType dbType = new SqlDbType();
            var length = row.ItemArray[8]; //[8] = length,  Length kanske inte fungerar när det är en int, den kanske returnerar Null isf?? Inte testat detta.
            var type = row.ItemArray[7]; //   [7] = type,  
            var name = row.ItemArray[3] as string; //[3] är COLUMN_NAME,

            if (type.Equals("varchar")) 
            { 
                dbType = SqlDbType.VarChar; 
            } else if (type.Equals("int"))
            {
                dbType = SqlDbType.Int;
                length = 0;
            }         
            command.Parameters.Add("@" + name, dbType, (int)length , name);
        }


        //command = new SqlCommand("UPDATE Beans SET roast = @roast " +
        //    "WHERE EAN = @oldEAN", connection);

        //Add parameters for UpdateCommand
        //command.Parameters.Add("@roast", SqlDbType.VarChar, 255, "roast");
        //command.Parameters.Add("@EAN", SqlDbType.VarChar, 255, "EAN");
        //SqlParameter parameter = command.Parameters.Add("@oldEAN", SqlDbType.VarChar, 255, "EAN");

        //parameter.SourceVersion = DataRowVersion.Original;

        adapter.UpdateCommand = command;

        return adapter;
    }
    public static SqlDataAdapter CreateAdapterDeleteCommand(SqlConnection connection, string tableName)
    {
        DataAccessLayer dataAccessLayer = new DataAccessLayer();

        DataSet keyData = dataAccessLayer.GetKeys(tableName);

        SqlDataAdapter adapter = new SqlDataAdapter();
        SqlCommand command = new SqlCommand();

        string delete = $"DELETE {tableName} WHERE ";

        foreach (DataRow row in keyData.Tables[0].Rows)
        {
            delete += row.ItemArray[0] + " = @" + row.ItemArray[0] + " AND "; //ItemArray lägger var värde från KeyDatan in i en array, [0] är Primary Key
        }

        delete = delete.Remove(delete.Length - 5, 5);
        Debug.WriteLine(delete);
        command = new SqlCommand(delete, connection);
        
        foreach (DataRow row in keyData.Tables[0].Rows)
        {
            string name = row.ItemArray[0] as string;
            command.Parameters.Add("@" + name, SqlDbType.VarChar, 255, name);
        }


        adapter.DeleteCommand = command;


        return adapter;
    
    }






}
