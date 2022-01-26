
using System.Data.SqlClient;
using System.Data;
public class CreateAdapter
{
    public static SqlDataAdapter CreateBeansAdapter(SqlConnection connection, string tableName)
    {

        DataAccessLayer dataAccessLayer = new DataAccessLayer();
        List <string> columnNames = dataAccessLayer.GetMetaData(tableName,"COLUMN_NAME");
        List <string> types =   dataAccessLayer.GetMetaData(tableName,"DATA_TYPE");
        string insert = "INSERT INTO ";
        string update = "UPDATE ";
        string delete = "DELETE FROM ";
        
        
        /*
        switch (tableName)
        {
            case == "Beans" :
                insert = "INSERT INTO ? (?, ?) " +
                    "VALUES("@?", @EAN)";
                update = "UPDATE Beans SET roast = @roast " + 
                     "WHERE EAN = @oldEAN";
                delete = "DELETE FROM Beans WHERE EAN = @EAN";
                break;
            case == "Beverage": //
                insert = "INSERT INTO Beverage (proccessMilkType) ";
            case == "Coffee" :
                insert = "INSERT INTO Coffee ( grindSize, beansEAN, waterSize, beanWeightGram) " +
                    " @grindSize, @beansEAN, @waterSize, @beanWeightGram";
                update = "UPDATE Coffee SET grindSize = @grindSize, beanWeightGram = @beanWeightGram " + 
                    "WHERE beansEAN = @beansEAN AND waterSize = @waterSize";
                delete = "DELETE FROM Coffee WHERE beansEAN = @beansEAN AND waterSize = @waterSize";
                break;
            case == "Milk" :
                insert = "INSERT INTO Milk (type, name, brand) " + 
                    "VALUES (@type, @name, @brand)";
                update = "UPDATE Milk SET name = @name, brand = @brand " + 
                    "WHERE type = @type";
                delete = "DELETE FROM Milk WHERE type = @type";
                break;
            case == "Modifier" :
                insert = "INSERT INTO Modifier (temperature, foam, name) " + 
                    "WHERE name = @name";
                update = "UPDATE Modifier";

        }
        */



        
        SqlDataAdapter adapter = new SqlDataAdapter();
        SqlCommand command = new SqlCommand();


        //Create the InsertCommand
        command = new SqlCommand("INSERT INTO Beans (roast, EAN) " +
            "VALUES(@roast, @EAN)", connection);
        
        //Adding the parameters for InsertCommand
        command.Parameters.Add("@roast", SqlDbType.VarChar, 255, "roast");
        command.Parameters.Add("@EAN", SqlDbType.VarChar, 255, "EAN");

        adapter.InsertCommand = command;

        //Create the UpdateCommand
        command = new SqlCommand("UPDATE Beans SET roast = @roast " + 
            "WHERE EAN = @oldEAN", connection);
        
        //Add parameters for UpdateCommand
        command.Parameters.Add("@roast", SqlDbType.VarChar, 255, "roast");
        command.Parameters.Add("@EAN", SqlDbType.VarChar, 255, "EAN");
        SqlParameter parameter = command.Parameters.Add("@oldEAN", SqlDbType.VarChar, 255, "EAN");
       
        parameter.SourceVersion = DataRowVersion.Original;

        adapter.UpdateCommand = command;
        
        //Create DeleteCommand
        command = new SqlCommand("DELETE FROM Beans WHERE EAN = @EAN", connection);
        parameter = command.Parameters.Add("@EAN", SqlDbType.VarChar, 255, "EAN");
        parameter.SourceVersion = DataRowVersion.Original;
        
        adapter.DeleteCommand = command;

        return adapter;

    }


}
