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

            List<string> list = new List<string>();
            list.Add("1");
            list.Add("2");
            DataTable beansDataTable = dataAccessLayer.GetTable("Beans").Tables[0];
            beansDataGridView.DataSource = beansDataTable;
            beansDataGridView.Columns[0].ReadOnly = true;
            DataTable waterDataTable = dataAccessLayer.GetTable("Water").Tables[0];

            DataTable coffeeDataTable = dataAccessLayer.GetTable("Coffee").Tables[0];
            coffeeDataGridView.DataSource = coffeeDataTable;

            foreach (DataRow row in beansDataTable.Rows)
            {
                beanComboBox.Items.Add($"EAN: {row[0]}, Roast: {row[1]}");
            }
            foreach (DataRow row in waterDataTable.Rows)
            {
                waterComboBox.Items.Add(row[0]);
            }
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
            beansDataGridView.DataSource = dataAccessLayer.GetTable("Beans").Tables[0];
        }
        catch(SqlException ex)
        {
            label1.Text = ex.Message;
        }
        
        
    }

    public void beanCellEdit(object sender, EventArgs e)
    {

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

    private void searchTextBox_TextChanged(object sender, EventArgs e)
    {
        (beansDataGridView.DataSource as DataTable).DefaultView.RowFilter = string.Format($"EAN LIKE '%{searchTextBox.Text}%' OR roast LIKE '%{searchTextBox.Text}%' " );
    }

    private void OnDeleteButtonBeans_Click(object sender, EventArgs e)
    {
        try
        {
            var ean = beansDataGridView.CurrentRow.Cells[0].Value;
            var primaryKey = new object[] { ean };
            dataAccessLayer.DeleteRow(primaryKey, "Beans");
            beansDataGridView.DataSource = dataAccessLayer.GetTable("Beans").Tables[0];
        }
        catch(SqlException ex)
        {
            label1.Text=ex.Message;
        }

    }

    private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
    {
        try
        {
            var row = beansDataGridView.CurrentRow;
            var ean = row.Cells[0].Value;
            var roast = row.Cells[1].Value;
            var bean = new object[] { ean, roast };
            dataAccessLayer.UpdateRow(bean, "Beans");
        }catch(SqlException ex)
        {
            label1.Text = ex.Message;
        }
    }

    private void button2_Click(object sender, EventArgs e)
    {
        try
        {
            var grindSize = int.TryParse(coffeeTab_grindSizeTextBox.Text, out int grindSizeResult);
            var beanWeight = int.TryParse(coffeeTab_beanWeightTextBox.Text, out int beanWeightResult);
            var water = waterComboBox.SelectedItem as string;  
            var bean = beanComboBox.SelectedItem as string;
            var beanEan = (bean.Split(',')[0]).Split(": ")[1];
            var coffee = new object[] {beanEan, water, grindSize, beanWeight };
            dataAccessLayer.InsertRow(coffee, "Coffee");
            coffeeDataGridView.DataSource = dataAccessLayer.GetTable("Coffee").Tables[0];


            /* vi måste fixa en snyggare lösning på att spliten ovan */


        }
        catch (Exception ex)
        {
            label1.Text = ex.Message;
        }
    }
}
