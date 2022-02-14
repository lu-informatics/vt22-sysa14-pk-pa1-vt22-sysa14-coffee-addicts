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
       
            //DataGridViewColumn column = new DataGridViewTextBoxColumn();
            //column.DataPropertyName = "EAN";
            var column2 = new DataGridViewComboBoxColumn();
            column2.DataPropertyName = "EAN";

            column2.HeaderText = "EAN";
            
            //beansDataGridView.Columns.Add(column);
            beansDataGridView.Columns.Add(column2);
            
            
            
            //Populating DataGridViews
            DataTable beansDataTable = dataAccessLayer.GetTable("Beans").Tables[0];
            var comboList = new List<object>();
            var comboList2 = new List<object>();
            foreach(DataRow row in beansDataTable.Rows)
            {
                comboList.Add(row[0]);

            }

            column2.DataSource = comboList;

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
            label1.Text = ex.Message;
        }
    }

    private void coffeeDataGridView_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
    {

    }
}
