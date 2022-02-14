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

            DataTable beansDataTable = dataAccessLayer.GetTable("Beans").Tables[0];
            var column2 = new DataGridViewComboBoxColumn();
            column2.DataPropertyName = beansDataTable.Columns[0].ColumnName;

            column2.HeaderText = beansDataTable.Columns[0].ColumnName;
            beansDataGridView.Columns.Add(column2);
            
            
            
            //Populating DataGridViews          
            column2.DataSource = beansDataTable;
            column2.DisplayMember = beansDataTable.Columns[0].ColumnName;            
            beansDataGridView.DataSource = beansDataTable;
            

            //column.Data
            //beansDataGridView.Columns[0].ReadOnly = true;
            DataTable waterDataTable = dataAccessLayer.GetTable("Water").Tables[0];


            DataTable coffeeDataTable = dataAccessLayer.GetTable("Coffee").Tables[0];
            coffeeDataGridView.DataSource = coffeeDataTable;

           
            /*

            //Populating comboboxes 
            beanComboBox.DataSource = beansDataTable;
            beansDataTable.Columns.Add("FullString",
                typeof(string),
                "EAN + ' | ' + roast");
            beansDataGridView.Columns["FullString"].Visible = false;
            beanComboBox.DisplayMember = "FullString";
            beanComboBox.BindingContext = this.BindingContext;
            
            waterComboBox.DataSource = waterDataTable;
            waterComboBox.DisplayMember = "Size";
            waterComboBox.BindingContext = this.BindingContext;
            
            */
           
        }
        catch (SqlException ex)
        {
            MessageBox.Show(ex.Message);
        }

        
        
    }

    private void OnInsertButton(object sender, EventArgs e)
    {
        try {
            string ean = beansEANTextBox.Text;
            string roast = beansRoastTextBox.Text;
            var bean = new string[] { roast, ean };
            dataAccessLayer.InsertRow(bean, "Beans");
            beansDataGridView.DataSource = dataAccessLayer.GetTable("Beans").Tables[0];
        }
        catch(SqlException ex)
        {
            lblUserMessage.Text = ex.Message;
        }          
    }
    private void OnBeansSearchInput(object sender, EventArgs e)
    {
        (beansDataGridView.DataSource as DataTable).DefaultView.RowFilter = string.Format($"EAN LIKE '%{beansSearchBox.Text}%' OR roast LIKE '%{beansSearchBox.Text}%' " );
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
            lblUserMessage.Text=ex.Message;
        }

    }

    private void OnAddCoffee(object sender, EventArgs e)
    {
        try
        {
            int.TryParse(beanGrindSizeTextBox.Text, out int grindSizeResult); //bör lägga till liten koll så man skriver in en int!
            int.TryParse(beanWeightTextBox.Text, out int beanWeightResult);
            var waterSize = (waterComboBox.SelectedItem as DataRowView)[0];
            var beanEan = (beanComboBox.SelectedItem as DataRowView)[0];
            var coffee = new object[] {beanEan, waterSize, grindSizeResult, beanWeightResult };     
            dataAccessLayer.InsertRow(coffee, "Coffee");
         
            coffeeDataGridView.DataSource = dataAccessLayer.GetTable("Coffee").Tables[0];
        }
        catch (Exception ex)
        {
            lblUserMessage.Text = ex.Message;
        }
    }

    private void OnCellEdit(object sender, DataGridViewCellValidatingEventArgs e)
    {
        
           

    }

    public void UpdateCellValue(DataGridView gridView, DataGridViewCellValidatingEventArgs e, string tableName)
    {
        try
        {
            var oldValue = gridView[e.ColumnIndex, e.RowIndex].Value;
            var newValue = e.FormattedValue;
            
         
            
            if (!(newValue.Equals(oldValue)) || newValue != oldValue) //Only happens on new cell value!
            {
                var oldRow = gridView.Rows[e.RowIndex];
                var metaDataCount = dataAccessLayer.GetMetaData(tableName).Tables[0].Rows.Count;
                var keyDataCount = dataAccessLayer.GetKeys(tableName).Tables[0].Columns.Count;
                int count = metaDataCount + keyDataCount;
                var parameterArray = new object[count];
                parameterArray[e.ColumnIndex] = newValue;
                for(int i = 0; i < metaDataCount; i++)
                {
                    if (i != e.ColumnIndex)
                    {
                        parameterArray[i] = oldRow.Cells[i].Value;
                    } 
                }
                for ( int i = 0; i < keyDataCount; i++)
                {
                    parameterArray[metaDataCount + i] = oldRow.Cells[i].Value;
                }
            }

        }
        catch (Exception ex)
        {
            lblUserMessage.Text = ex.Message;
        }
    }

   
}
