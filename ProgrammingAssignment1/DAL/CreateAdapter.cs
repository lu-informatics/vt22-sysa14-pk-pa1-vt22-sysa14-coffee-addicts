using System.Data;
using System.Data.SqlClient;

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
            insert += "@" + row.ItemArray[3] + ","; //ItemArray adds var value from MetaData to an array, [3] is "COLUMN_NAME"
        }
        insert = insert.Remove(insert.Length - 1, 1); //Removes last ","
        insert += ")";
        command = new SqlCommand(insert, connection);

        //Adding the parameters based on the MetaData
        foreach (DataRow row in dataSet.Tables[0].Rows)
        {
            SqlDbType dbType = new SqlDbType();
            var length = row.ItemArray[8]; //[8] = length
            var type = row.ItemArray[7]; //   [7] = type  
            var name = row.ItemArray[3] as string; //[3] is "COLUMN_NAME"

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
            delete += row.ItemArray[0] + " = @" + row.ItemArray[0] + " AND "; //ItemArray adds var value from KeyData into an array, [0] is "Primary Key"
        }
        delete = delete.Remove(delete.Length - 5, 5);
        command = new SqlCommand(delete, connection);

        foreach (DataRow row in keyData.Tables[0].Rows)
        {
            string name = row.ItemArray[0] as string;
            command.Parameters.Add("@" + name, SqlDbType.VarChar, 255, name);
        }
        adapter.DeleteCommand = command;
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

        //Create the SQL Command
        foreach (DataRow row in metaData.Tables[0].Rows)
        {
            update += row.ItemArray[3] + " = @" + row.ItemArray[3] + ",";
        }

        update = update.Remove(update.Length - 1, 1); //Removes last ","

        foreach (DataRow row in keyData.Tables[0].Rows)
        {
            where += row.ItemArray[0] + " = @old" + row.ItemArray[0] + ",";
        }
        where = where.Remove(where.Length - 1, 1); //Removes last ","

        string query = update + where;
        command = new SqlCommand(query, connection);

        //Adding the parameters based on the MetaData
        foreach (DataRow row in metaData.Tables[0].Rows)
        {
            SqlDbType dbType = new SqlDbType();
            var length = row.ItemArray[8]; //[8] = length
            var type = row.ItemArray[7]; //   [7] = type
            var name = row.ItemArray[3] as string; //[3] is "COLUMN_NAME"

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
        //Adds the old values for "Primary Keys"
        for (int i = 0; i < keyData.Tables[0].Rows.Count; i++)
        {
            DataRow metaDataRow = metaData.Tables[0].Rows[i];
            DataRow row = keyData.Tables[0].Rows[i];
            SqlDbType dbType = new SqlDbType();
            var length = metaDataRow.ItemArray[8];//[8] = length
            var type = metaDataRow.ItemArray[7]; //[7] = type
            var name = metaDataRow.ItemArray[3] as string; //[3] is "COLUMN_NAME"

            if (type.Equals("varchar"))
            {
                dbType = SqlDbType.VarChar;
            }
            else if (type.Equals("int"))
            {
                dbType = SqlDbType.Int;
                length = 0;
            }
            SqlParameter parameter2 = command.Parameters.Add($"old{row.ItemArray[0]}", dbType, (int)length, name);
            parameter2.SourceVersion = DataRowVersion.Original;
        }
        adapter.UpdateCommand = command;
        return adapter;
    }
}