using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
namespace ProgrammingAssignment1;

public partial class Form1 : Form
{
    private DataAccessLayer dataAccessLayer = new DataAccessLayer();
    

    public Form1()
    {
        InitializeComponent();          
        try
        {
       
        
            //Populating DataGridViews
            DataTable beansDataTable = dataAccessLayer.GetTable("Beans").Tables[0];
            beansDataGridView.DataSource = beansDataTable;
            beansDataGridView.Columns[0].ReadOnly = true;
            DataTable waterDataTable = dataAccessLayer.GetTable("Water").Tables[0];

            DataTable coffeeDataTable = dataAccessLayer.GetTable("Coffee").Tables[0];
            coffeeDataGridView.DataSource = coffeeDataTable;


            //Populating comboboxes 
            beanComboBox.DataSource = beansDataTable;
            beansDataTable.Columns.Add("FullString",
                typeof(string),
                "EAN + ' ' + roast");
            beanComboBox.DisplayMember = "FullString";
            beanComboBox.BindingContext = this.BindingContext;
            
            waterComboBox.DataSource = waterDataTable;
            waterComboBox.DisplayMember = "Size";
            waterComboBox.BindingContext = this.BindingContext;
            

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
            int.TryParse(coffeeTab_grindSizeTextBox.Text, out int grindSizeResult); //b�r l�gga till liten koll s� man skriver in en int!
            int.TryParse(coffeeTab_beanWeightTextBox.Text, out int beanWeightResult);
            var waterSize = (waterComboBox.SelectedItem as DataRowView)[0];
            var beanEan = (beanComboBox.SelectedItem as DataRowView)[0];
            var coffee = new object[] {beanEan, waterSize, grindSizeResult, beanWeightResult };     
            dataAccessLayer.InsertRow(coffee, "Coffee");
            
            coffeeDataGridView.DataSource = dataAccessLayer.GetTable("Coffee").Tables[0];





        }
        catch (Exception ex)
        {
            label1.Text = ex.Message;
        }
    }
}
