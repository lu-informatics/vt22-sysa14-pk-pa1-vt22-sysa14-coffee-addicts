using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;

namespace ProgrammingAssignment1;

public partial class Form1 : Form
{
    private DataAccessLayer dataAccessLayer = new DataAccessLayer();

    private DataTable beansDataTable;
    private DataTable waterDataTable;
    private DataTable coffeeDataTable;
    private DataTable foamDataTable;
    private DataTable milkDataTable;
    private DataTable beverageDataTable;


    public Form1()
    {
        InitializeComponent();

        UpdateAll();
        
        
    }

    private void UpdateTables()
    {
         beansDataTable = dataAccessLayer.GetTable("Beans");
         waterDataTable = dataAccessLayer.GetTable("Water");
         coffeeDataTable = dataAccessLayer.GetTable("CoffeeView");
         foamDataTable = dataAccessLayer.GetTable("Foam");
         milkDataTable = dataAccessLayer.GetTable("Milk");
         beverageDataTable = dataAccessLayer.GetTable("BeverageView");


        beansDataGridView.DataSource = beansDataTable;
        waterDataGridView.DataSource = waterDataTable;
        milkDataGridView.DataSource = milkDataTable;
        foamDataGridView.DataSource = foamDataTable;
        beverageDataGridView.DataSource = beverageDataTable;
        coffeeDataGridView.DataSource = coffeeDataTable;


    }
    public void UpdateAll()
    {
        try
        {


            beverageCoffeeNameColumn.ValueMember = "name";
            beverageFoamTypeColumn.ValueMember = "type";
            beverageMilkVarietyColumn.ValueMember = "variety";
            coffeeBeanEANColumn.ValueMember = "EAN";
            coffeeWaterSizeColumn.ValueMember = "size";



            beverageCoffeeNameColumn.DisplayMember = "name";            
            beverageFoamTypeColumn.DisplayMember = "type";
            beverageMilkVarietyColumn.DisplayMember = "variety";
            coffeeBeanEANColumn.DisplayMember = "EAN";
            coffeeWaterSizeColumn.DisplayMember = "size";

            coffeeBeanEANColumn.ValueType = typeof(string);


    

            //beansDataTable.Columns.Add("FullString",
            //    typeof(string),
            //    "EAN + ' | ' + roast");
            //beansDataGridView.Columns["FullString"].Visible = false;
            //beanComboBox.DisplayMember = "FullString";
            beanComboBox.DisplayMember= "EAN";
            beanComboBox.BindingContext = this.BindingContext;

            
            waterComboBox.DisplayMember = "Size";
            waterComboBox.BindingContext = this.BindingContext;
   

            beverageCoffeeComboBox.DisplayMember = "name";
            beverageCoffeeComboBox.BindingContext = this.BindingContext;

            beverageFoamComboBox.DisplayMember = "type";
            beverageFoamComboBox.BindingContext = this.BindingContext;

            beverageMilkComboBox.DisplayMember = "variety";
            beverageMilkComboBox.BindingContext = this.BindingContext;





            beansDataTable = dataAccessLayer.GetTable("Beans");
            waterDataTable = dataAccessLayer.GetTable("Water");
            coffeeDataTable = dataAccessLayer.GetTable("CoffeeView");
            foamDataTable = dataAccessLayer.GetTable("Foam");
            milkDataTable = dataAccessLayer.GetTable("Milk");
            beverageDataTable = dataAccessLayer.GetTable("BeverageView"); 

            coffeeBeanEANColumn.DataSource = beansDataTable;
            coffeeWaterSizeColumn.DataSource = waterDataTable;
            beverageCoffeeComboBox.DataSource = coffeeDataTable;
            beverageFoamTypeColumn.DataSource = foamDataTable;
            beverageMilkComboBox.DataSource = milkDataTable;

            beanComboBox.DataSource = beansDataTable;
            beverageFoamComboBox.DataSource = foamDataTable;
            beverageMilkComboBox.DataSource = milkDataTable;
            waterComboBox.DataSource = waterDataTable;
            beverageCoffeeComboBox.DataSource = coffeeDataTable;
            beverageCoffeeComboBox.DataSource = coffeeDataTable;

            beansDataGridView.DataSource = beansDataTable;
            waterDataGridView.DataSource = waterDataTable;
            milkDataGridView.DataSource = milkDataTable;
            foamDataGridView.DataSource = foamDataTable;
            beverageDataGridView.DataSource = beverageDataTable;
            coffeeDataGridView.DataSource = coffeeDataTable;





        }
        catch (SqlException ex)
        {
            MessageBox.Show(ex.Message);
        }
    }


    private void OnAddBeansButton(object sender, EventArgs e)
    {
        try {
            string ean = beansEANTextBox.Text;
            string roast = beansRoastTextBox.Text;
            var bean = new string[] { ean, roast };
            dataAccessLayer.InsertRow(bean, "Beans");
         
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
             //bör lägga till liten koll så man skriver in en int!
           
            var name = coffeeNameTextBox.Text;
            var waterSize = (waterComboBox.SelectedItem as DataRowView)[0];
            var beanEan = (beanComboBox.SelectedItem as DataRowView)[0];
            int grindSize = Convert.ToInt32(Math.Round(coffeeGrindSizeNumUpDown.Value, 0));
            int beanWeight = Convert.ToInt32(Math.Round(coffeeBeanWeightNumUpDown.Value, 0));
            var coffee = new object[] {name,beanEan, beanWeight, grindSize, waterSize };     
            dataAccessLayer.InsertRow(coffee, "Coffee");

          
        }
        catch (Exception ex)
        {
            lblUserMessage.Text = ex.Message;
        }
    }

    private void OnCellEdit(object sender, DataGridViewCellValidatingEventArgs e)
    {

        UpdateCellValue(beansDataGridView, e, "Beans");
       
        //UpdateAll();
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
                dataAccessLayer.UpdateRow(parameterArray, tableName);

                //UpdateAll();
            }


        }
        catch (Exception ex)
        {
            lblUserMessage.Text = ex.Message;
        }
    }

    private void OnAddWaterButton(object sender, EventArgs e)
    {
        string size = waterSizeTextBox.Text;
        int volume = Convert.ToInt32(Math.Round(waterVolumeMlNumUpDown.Value, 0));
        var water = new object[] { size, volume };
        dataAccessLayer.InsertRow(water, "water");
       

    }

    private void OnAddMilkButton(object sender, EventArgs e)
    {
        string variety = milkVarietyTextBox.Text;
        string brand = milkBrandTextBox.Text;
        var milk = new object[] { variety, brand };
        dataAccessLayer.InsertRow(milk, "milk");
        

    }

    private void UpdateValidated(object sender, DataGridViewCellEventArgs e) //DETTA LÖSTE DATA VALUE ERRORT, när jag lade in denna på CellValueChangedPropertyn
    {
        UpdateAll();
    }

    private void coffeeTab_Click(object sender, EventArgs e)
    {
        
        //UpdateAll();
    }
}
