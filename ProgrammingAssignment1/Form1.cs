using System.Data;
using System.Data.SqlClient;
namespace ProgrammingAssignment1;

public partial class Form1 : Form
{
    private DataAccessLayer dataAccessLayer = new DataAccessLayer();
    
    public Form1()
    {
        InitializeComponent();
       

        // Test from Filip! Latest test 22-01-24.
        //hejj
        //hejhej
      
        try
        {
            //Beans beans = new Beans("Light", "235");

            var objects = new object[2] {"6969", "Stor"};
            dataAccessLayer.DeleteRow(objects, "Coffee");
            dataGridView1.DataSource = dataAccessLayer.GetTable("Coffee").Tables[0];
            //dataAccessLayer.InsertRowTest();


        }
        catch (SqlException ex)
        {
            MessageBox.Show(ex.Message);
        }
        
    }

    private void button1_Click(object sender, EventArgs e)
    {
        //dataAccessLayer.InsertRowTest();

    }

    private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
        
    }
}
