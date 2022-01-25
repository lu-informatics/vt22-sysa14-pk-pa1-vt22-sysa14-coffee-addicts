using System.Data.SqlClient;
using System.Data;
public class CreateAdapter
{
    public static SqlDataAdapter CreateBeansAdapter(SqlConnection connection)
    {
     
        SqlDataAdapter adapter = new SqlDataAdapter();
        SqlCommand command = new SqlCommand("SELECT * FROM Beans", connection);

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

        command = new SqlCommand("DELETE FROM Beans WHERE EAN = @EAN", connection);
        parameter = command.Parameters.Add("@EAN", SqlDbType.VarChar, 255, "EAN");
        parameter.SourceVersion = DataRowVersion.Original;
        
        adapter.DeleteCommand = command;

        return adapter;
    }


}
