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
            dataGridView1.DataSource = dataAccessLayer.GetTable("Beans").Tables[0];
        }
        catch (SqlException ex)
        {
            MessageBox.Show(ex.Message);
        }
        
    }

    private void button1_Click(object sender, EventArgs e)
    {
        
    }

    private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
        
    }
}
