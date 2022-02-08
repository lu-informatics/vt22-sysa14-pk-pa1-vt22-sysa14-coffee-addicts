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

          
            dataGridView1.DataSource = dataAccessLayer.GetTable("Beans").Tables[0];
            //dataAccessLayer.InsertRowTest();


        }
        catch (SqlException ex)
        {
            MessageBox.Show(ex.Message);
        }
        
    }

    private void OnInsertButton(object sender, EventArgs e)
    {
        try {
            string ean = eanBox.Text;
            string name = nameBox.Text;
            var bean = new string[] { name, ean };
            dataAccessLayer.InsertRow(bean, "Beans");
            dataGridView1.DataSource = dataAccessLayer.GetTable("Beans").Tables[0];
        }
        catch(SqlException ex)
        {
            label1.Text= ex.Message;
        }
        
        
    }

    private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
        
    }

    private void label1_Click(object sender, EventArgs e)
    {

    }

    private void groupBox1_Enter(object sender, EventArgs e)
    {

    }

    private void errorBox_TextChanged(object sender, EventArgs e)
    {

    }
}
