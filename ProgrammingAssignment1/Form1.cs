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
        dataGridView1 = new DataGridView();
        try
        {
            dataGridView1.DataSource = dataAccessLayer.GetBeans().Tables[0];
        }
        catch (SqlException ex)
        {
            MessageBox.Show(ex.Message);
        }
        
    }

    private void button1_Click(object sender, EventArgs e)
    {
        //dataGridView1.DataSource = null;
        //DataSet mySet = new DataSet();
        //dataGridView1 = new DataGridView();
        try
        {
            dataGridView1.DataSource = dataAccessLayer.GetBeans().Tables[0];
        }
        catch (SqlException ex)
        {
            MessageBox.Show(ex.Message);
        }
    }

    private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {

    }
}
