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
            //beansDataGridView.Columns[0].ReadOnly = true;
            DataTable waterDataTable = dataAccessLayer.GetTable("Water").Tables[0];

            DataTable coffeeDataTable = dataAccessLayer.GetTable("Coffee").Tables[0];
            coffeeDataGridView.DataSource = coffeeDataTable;


            //Populating comboboxes 
            beanComboBox.DataSource = beansDataTable;
            beansDataTable.Columns.Add("FullString",
                typeof(string),
                "EAN + ' ' + roast");
            beansDataGridView.Columns["FullString"].Visible = false;
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
    private void OnBeansSearchInput(object sender, EventArgs e)
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

    private void OnAddCoffee(object sender, EventArgs e)
    {
        try
        {
            int.TryParse(coffeeTab_grindSizeTextBox.Text, out int grindSizeResult); //bör lägga till liten koll så man skriver in en int!
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

    private void OnBeansCellEdit(object sender, DataGridViewCellValidatingEventArgs e)
    {

        try
        {
            var oldValue = beansDataGridView[e.ColumnIndex, e.RowIndex].Value;
            var newValue = e.FormattedValue;
            if (!(newValue.Equals( oldValue))) //Only happens on new cell value!
            {
                var bean = new object[3];
                var oldRow = beansDataGridView.Rows[e.RowIndex];
                bean[2] = oldRow.Cells[0].Value; //adds the old Primary Key
                bean[e.ColumnIndex] = newValue; //adds the new cellvalue at the correct index as we have the datagridview in the same order as our database
                if (e.ColumnIndex != 1) //adds the non updated cellvalue to the bean array, as to not remove the nonchanged value.
                {
                    bean[1] = oldRow.Cells[1].Value;
                }
                else
                {
                    bean[0] = oldRow.Cells[0].Value;
                }

                dataAccessLayer.UpdateRow(bean, "Beans");
                label1.Text = "Row was updated";
                coffeeDataGridView.DataSource = dataAccessLayer.GetTable("Coffee").Tables[0];
            }

        }catch (Exception ex)
        {
            label1.Text=ex.Message;
        }
        

    }
}
