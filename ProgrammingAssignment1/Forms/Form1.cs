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

        Debug.WriteLine(dataAccessLayer.IsServerConnected());
        Debug.WriteLine(coffeeDataGridView.Columns[4].GetType().Name);


    }



    private void OnBeansSearchInput(object sender, EventArgs e)
    {
        (beansDataGridView.DataSource as DataTable).DefaultView.RowFilter = string.Format($"EAN LIKE '%{beansSearchBox.Text}%' OR roast LIKE '%{beansSearchBox.Text}%' ");
    }
    private void OnMilkSearchInput(object sender, EventArgs e)
    {
        (milkDataGridView.DataSource as DataTable).DefaultView.RowFilter = string.Format($"variety LIKE '%{milkSearchBox.Text}%' OR brand LIKE '%{milkSearchBox.Text}%' ");

    }
    private void coffeeSearchBox_TextChanged(object sender, EventArgs e)
    {
        (coffeeDataGridView.DataSource as DataTable).DefaultView.RowFilter = string.Format($"name LIKE '%{coffeeSearchBox.Text}%' OR EAN LIKE '%{coffeeSearchBox.Text}%' OR beanWeightGram LIKE '%{coffeeSearchBox.Text}%' OR grindSize LIKE '%{coffeeSearchBox.Text}%' OR size LIKE '%{coffeeSearchBox.Text}%'");

    }
    private void OnWaterSearchInput(object sender, EventArgs e)
    {
        (waterDataGridView.DataSource as DataTable).DefaultView.RowFilter = string.Format($"Size LIKE '%{waterSearchBox.Text}%' OR volumeML LIKE '%{waterSearchBox.Text}%' ");

    }

    private void OnFoamSearchInput(object sender, EventArgs e)
    {
        (foamDataGridView.DataSource as DataTable).DefaultView.RowFilter = string.Format($"name LIKE '%{foamSearchBox.Text}%' OR temperature LIKE '%{foamSearchBox.Text}%' OR time LIKE '%{foamSearchBox.Text}%");

    }
    private void OnBeansAddButton(object sender, EventArgs e)
    {
        try
        {
            string ean = beansEANTextBox.Text;
            string roast = beansRoastTextBox.Text;
            var bean = new string[] { ean, roast };
            dataAccessLayer.InsertRow(bean, "Beans");
            //UpdateAll();
        }
        catch (SqlException ex)
        {
            lblUserMessage.Text = ex.Message;
        }
    }


    private void OnBeansDeleteButton(object sender, EventArgs e)
    {
        try
        {
            var ean = beansDataGridView.CurrentRow.Cells[0].Value;
            var primaryKey = new object[] { ean };
            dataAccessLayer.DeleteRow(primaryKey, "Beans");
            UpdateAll();

        }
        catch (SqlException ex)
        {
            lblUserMessage.Text = ex.Message;
        }

    }

    private void OnCoffeeAddButton(object sender, EventArgs e)
    {
        try
        {
            //b�r l�gga till liten koll s� man skriver in en int!

            var name = coffeeNameTextBox.Text;
            var waterSize = (waterComboBox.SelectedItem as DataRowView)[0];
            var beanEan = (beanComboBox.SelectedItem as DataRowView)[0];
            int grindSize = Convert.ToInt32(Math.Round(coffeeGrindSizeNumUpDown.Value, 0));
            int beanWeight = Convert.ToInt32(Math.Round(coffeeBeanWeightNumUpDown.Value, 0));
            var coffee = new object[] { name, beanEan, beanWeight, grindSize, waterSize };
            dataAccessLayer.InsertRow(coffee, "Coffee");
            UpdateAll();
            Debug.WriteLine(coffeeDataGridView.Columns[4].GetType().Name);

        }
        catch (Exception ex)
        {
            lblUserMessage.Text = ex.Message;
        }
    }

    private void OnFoamAddButton(object sender, EventArgs e)
    {
        int temperature = Convert.ToInt32(Math.Round(foamTemperatureNumUpDown.Value, 0));
        int time = Convert.ToInt32(Math.Round(foamTimeNumUpDown.Value, 0));
        string name = foamNameTextBox.Text;

        var foam = new object[] { name, temperature, time };
        dataAccessLayer.InsertRow(foam, "Foam");
        //UpdateAll();
    }

    private void OnFoamDeleteButton(object sender, EventArgs e)
    {
        var name = foamDataGridView.CurrentRow.Cells[0].Value;
        var primaryKeys = new object[] { name };
        dataAccessLayer.DeleteRow(primaryKeys, "Foam");
    }





    private void OnAddWaterButton(object sender, EventArgs e)
    {
        string size = waterSizeTextBox.Text;
        int volume = Convert.ToInt32(Math.Round(waterVolumeMlNumUpDown.Value, 0));
        var water = new object[] { size, volume };
        dataAccessLayer.InsertRow(water, "water");
        UpdateAll();
        Debug.WriteLine(coffeeDataGridView.Columns[4].GetType().Name);

    }

    private void OnWaterDeleteButton(object sender, EventArgs e)
    {
        var size = waterDataGridView.CurrentRow.Cells[0].Value;
        var primaryKey = new object[] { size };
        dataAccessLayer.DeleteRow(primaryKey, "Water");
        UpdateAll();
    }
    private void OnAddMilkButton(object sender, EventArgs e)
    {
        string variety = milkVarietyTextBox.Text;
        string brand = milkBrandTextBox.Text;
        var milk = new object[] { variety, brand };
        dataAccessLayer.InsertRow(milk, "milk");
        //UpdateAll();


    }
    private void OnMilkDeleteButton(object sender, EventArgs e)
    {
        var variety = milkDataGridView.CurrentRow.Cells[0].Value;
        var primaryKeys = new object[] { variety };
        dataAccessLayer.DeleteRow(primaryKeys, "Milk");
        UpdateAll();
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
                for (int i = 0; i < metaDataCount; i++)
                {
                    if (i != e.ColumnIndex)
                    {
                        parameterArray[i] = oldRow.Cells[i].Value;
                    }
                }
                for (int i = 0; i < keyDataCount; i++)
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

    private void UpdateAllOnCellChangedValue(object sender, DataGridViewCellEventArgs e) //DETTA L�STE DATA VALUE ERRORT, n�r jag lade in denna p� CellValueChangedPropertyn
    {
        UpdateAll();
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



            //coffeeBeanEANColumn.ValueType = typeof(string);




            //beansDataTable.Columns.Add("FullString",
            //    typeof(string),
            //    "EAN + ' | ' + roast");
            //beansDataGridView.Columns["FullString"].Visible = false;
            //beanComboBox.DisplayMember = "FullString";
            beanComboBox.DisplayMember = "EAN";
            beanComboBox.BindingContext = this.BindingContext;


            waterComboBox.DisplayMember = "Size";
            waterComboBox.BindingContext = this.BindingContext;


            beverageCoffeeComboBox.DisplayMember = "name";
            beverageCoffeeComboBox.BindingContext = this.BindingContext;

            beverageFoamComboBox.DisplayMember = "type";
            beverageFoamComboBox.BindingContext = this.BindingContext;

            beverageMilkComboBox.DisplayMember = "variety";
            beverageMilkComboBox.BindingContext = this.BindingContext;





            //beansDataTable = dataAccessLayer.GetTable("Beans");
            //waterDataTable = dataAccessLayer.GetTable("Water");
            //coffeeDataTable = dataAccessLayer.GetTable("CoffeeView");
            //foamDataTable = dataAccessLayer.GetTable("Foam");
            //milkDataTable = dataAccessLayer.GetTable("Milk");
            //beverageDataTable = dataAccessLayer.GetTable("BeverageView");

            DataSet coffeeAddicts = new DataSet("CoffeeAddicts");
            coffeeAddicts.Tables.Add(dataAccessLayer.GetTable("Beans"));
            coffeeAddicts.Tables.Add(dataAccessLayer.GetTable("Water"));
            coffeeAddicts.Tables.Add(dataAccessLayer.GetTable("Milk"));
            coffeeAddicts.Tables.Add(dataAccessLayer.GetTable("Foam"));
            coffeeAddicts.Tables.Add(dataAccessLayer.GetTable("CoffeeView"));

            coffeeAddicts.Tables.Add(dataAccessLayer.GetTable("BeverageView"));



            coffeeBeanEANColumn.DataSource = coffeeAddicts.Tables[0];
            coffeeWaterSizeColumn.DataSource = coffeeAddicts.Tables[1];
            beverageCoffeeNameColumn.DataSource = coffeeAddicts.Tables[4];
            beverageFoamTypeColumn.DataSource = coffeeAddicts.Tables[3];
            beverageMilkVarietyColumn.DataSource = coffeeAddicts.Tables[2];

            beanComboBox.DataSource = coffeeAddicts.Tables[0];
            waterComboBox.DataSource = coffeeAddicts.Tables[1];
            beverageFoamComboBox.DataSource = coffeeAddicts.Tables[3];
            beverageMilkComboBox.DataSource = coffeeAddicts.Tables[2];
            beverageCoffeeComboBox.DataSource = coffeeAddicts.Tables[4];


            beansDataGridView.DataSource = coffeeAddicts.Tables[0];
            waterDataGridView.DataSource = coffeeAddicts.Tables[1];
            milkDataGridView.DataSource = coffeeAddicts.Tables[2];
            foamDataGridView.DataSource = coffeeAddicts.Tables[3];
            coffeeDataGridView.DataSource = coffeeAddicts.Tables[4];
            beverageDataGridView.DataSource = coffeeAddicts.Tables[5];

            Debug.WriteLine(coffeeDataGridView.Columns[4].ToString());
        }
        catch (SqlException ex)
        {
            MessageBox.Show(ex.Message);
        }
    }





    private void OnCellEdit(object sender, DataGridViewCellValidatingEventArgs e)
    {
        DataGridView dataGridView = sender as DataGridView;
        string tableName = dataGridView.Name;
        tableName = tableName.Remove(tableName.Length - 12, 12);
        UpdateCellValue(dataGridView, e, tableName);
    }

    private void OnCoffeeDeleteButton(object sender, EventArgs e)
    {
        var primaryKey = coffeeDataGridView.CurrentRow.Cells[0].Value;
        var primaryKeys = new object[] { primaryKey };
        dataAccessLayer.DeleteRow(primaryKeys, "Coffee");
        UpdateAll();
    }

    private void OnBeverageAddButton(object sender, EventArgs e)
    {
        try
        {
            string bevName = beverageNameTextBox.Text;
            string coffeeName = beverageCoffeeComboBox.Text;
            string foamType = beverageFoamComboBox.Text;
            string milkVariety = beverageMilkComboBox.Text;

            var beverage = new object[] { bevName, coffeeName, foamType, milkVariety };
            dataAccessLayer.InsertRow(beverage, "beverage");
            UpdateAll();
        }
        catch (Exception ex)
        {
            lblUserMessage.Text = ex.Message;
        }


    }

    private void beverageDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
    {
        //DataGridView dgv = (DataGridView)sender;
        //if (e.Exception is ArgumentException)
        //{
        //    object value = dgv.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
        //    if (!((DataGridViewComboBoxColumn)dgv.Columns[e.ColumnIndex]).Items.Contains(value))
        //    {
        //        ((DataGridViewComboBoxCell)dgv[e.ColumnIndex, e.RowIndex]).Value = DBNull.Value;
        //        //((DataGridViewComboBoxColumn)dgv.Columns[e.ColumnIndex]).Items.Add(value);
        //        e.ThrowException = false;
        //    }
        //}
        //else
        //{
        //   lblUserMessage.Text = (e.Exception.Message);
        //    e.Cancel = true;
        //}
        e.Cancel = true;
    }

    private void btnReturn_Click(object sender, EventArgs e)
    {
    }
}