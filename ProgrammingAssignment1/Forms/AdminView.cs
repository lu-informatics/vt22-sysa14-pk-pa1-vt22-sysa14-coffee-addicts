using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;

namespace ProgrammingAssignment1;

public partial class AdminView : Form
{
    private DataAccessLayer dataAccessLayer = new DataAccessLayer();

    private DataSet coffeeAddicts = new DataSet("CoffeeAddicts");

    public AdminView()
    {
        InitializeComponent();

        UpdateAll();

        Debug.WriteLine(dataAccessLayer.IsServerConnected());

    }

    private void OnBeansSearchInput(object sender, EventArgs e)
    {
        (beansDataGridView.DataSource as DataTable).DefaultView.RowFilter = string.Format($"EAN LIKE '%{beansSearchBox.Text}%' OR roast LIKE '%{beansSearchBox.Text}%' ");
    }

    private void OnBeverageSearchInput(object sender, EventArgs e)
    {
        (beverageDataGridView.DataSource as DataTable).DefaultView.RowFilter = string.Format($"bevName LIKE '%{beverageSearchBox.Text}%' OR name LIKE '%{beverageSearchBox.Text}%' OR type LIKE '%{beverageSearchBox.Text}%' OR variety LIKE '%{beverageSearchBox.Text}%'");

    }
    private void OnCoffeeSearchInput(object sender, EventArgs e)
    {
        (coffeeDataGridView.DataSource as DataTable).DefaultView.RowFilter = string.Format($"name LIKE '%{coffeeSearchBox.Text}%' OR EAN LIKE '%{coffeeSearchBox.Text}%' OR Convert(beanWeightGram, 'System.String') LIKE '%{coffeeSearchBox.Text}%' OR Convert(grindSize, 'System.String') LIKE '%{coffeeSearchBox.Text}%' OR size LIKE '%{coffeeSearchBox.Text}%'");

    }
    private void OnFoamSearchInput(object sender, EventArgs e)
    {
        (foamDataGridView.DataSource as DataTable).DefaultView.RowFilter = string.Format($"type LIKE '%{foamSearchBox.Text}%' OR Convert(temperature, 'System.String') LIKE '%{foamSearchBox.Text}%' OR Convert(time, 'System.String') LIKE '%{foamSearchBox.Text}%'");

    }
    private void OnMilkSearchInput(object sender, EventArgs e)
    {
        (milkDataGridView.DataSource as DataTable).DefaultView.RowFilter = string.Format($"variety LIKE '%{milkSearchBox.Text}%' OR brand LIKE '%{milkSearchBox.Text}%' ");

    }
    private void OnWaterSearchInput(object sender, EventArgs e)
    {
        (waterDataGridView.DataSource as DataTable).DefaultView.RowFilter = string.Format($"Size LIKE '%{waterSearchBox.Text}%' OR Convert(volumeML, 'System.String') LIKE '%{waterSearchBox.Text}%' ");

    }
    private void OnBeansAddButton(object sender, EventArgs e)
    {
        try
        {
            string ean = beansEANTextBox.Text;
            string roast = beansRoastTextBox.Text;
            var bean = new string[] { ean, roast };
            dataAccessLayer.InsertRow(bean, "Beans");
            lblUserMessage.Text = $"Bean with EAN {ean} was added.";
            beansEANTextBox.Text = "";
            beansRoastTextBox.Text = "";
            UpdateTables();
        }
        catch (SqlException ex)
        {
            lblUserMessage.Text = SqlErrorHandling(ex);
        }
    }


    private void OnBeansDeleteButton(object sender, EventArgs e)
    {
        try
        {
            if (beansDataGridView.CurrentRow != null)
            {
                var ean = beansDataGridView.CurrentRow.Cells[0].Value;
                var primaryKey = new object[] { ean };
                dataAccessLayer.DeleteRow(primaryKey, "Beans");
                lblUserMessage.Text = $"Bean with EAN {ean} was deleted.";
                UpdateTables();
            }


        }
        catch (SqlException ex)
        {
            SqlErrorHandling(ex);
        }

    }

    private void OnCoffeeAddButton(object sender, EventArgs e)
    {
        try
        {
            var name = coffeeNameTextBox.Text;
            var waterSize = (waterComboBox.SelectedItem as DataRowView)[0];
            var beanEan = (beanComboBox.SelectedItem as DataRowView)[0];
            int grindSize = Convert.ToInt32(Math.Round(coffeeGrindSizeNumUpDown.Value, 0));
            int beanWeight = Convert.ToInt32(Math.Round(coffeeBeanWeightNumUpDown.Value, 0));
            var coffee = new object[] { name, beanEan, beanWeight, grindSize, waterSize };
            dataAccessLayer.InsertRow(coffee, "Coffee");
            lblUserMessage.Text = $"{name} was added.";
            coffeeNameTextBox.Text = "";
            UpdateTables();
            Debug.WriteLine(coffeeDataGridView.Columns[4].GetType().Name);

        }
        catch (SqlException ex)
        {
            lblUserMessage.Text = SqlErrorHandling(ex);
        }
    }

    private void OnFoamAddButton(object sender, EventArgs e)
    {
        try
        {
            int temperature = Convert.ToInt32(Math.Round(foamTemperatureNumUpDown.Value, 0));
            int time = Convert.ToInt32(Math.Round(foamTimeNumUpDown.Value, 0));
            string name = foamNameTextBox.Text;

            var foam = new object[] { name, temperature, time };
            dataAccessLayer.InsertRow(foam, "Foam");
            lblUserMessage.Text = $"Foam with name {name} was added.";
            foamNameTextBox.Text = "";
            UpdateTables();
        }
        catch (SqlException ex)
        {
            lblUserMessage.Text = SqlErrorHandling(ex);
        }
    }

    private void OnFoamDeleteButton(object sender, EventArgs e)
    {
        try
        {
            var name = foamDataGridView.CurrentRow.Cells[0].Value;
            var primaryKeys = new object[] { name };
            dataAccessLayer.DeleteRow(primaryKeys, "Foam");
            lblUserMessage.Text = $"Foam with name {name} was deleted.";
            UpdateTables();
        }
        catch (SqlException ex)
        {

            lblUserMessage.Text = SqlErrorHandling(ex);
        }
    }

    private void OnWaterAddButton(object sender, EventArgs e)
    {
        try
        {
            string size = waterSizeTextBox.Text;
            int volume = Convert.ToInt32(Math.Round(waterVolumeMlNumUpDown.Value, 0));
            var water = new object[] { size, volume };
            dataAccessLayer.InsertRow(water, "water");
            lblUserMessage.Text = $"Water with size {size} was added.";
            waterSizeTextBox.Text = "";
            UpdateTables();
            Debug.WriteLine(coffeeDataGridView.Columns[4].GetType().Name);
        }
        catch (SqlException ex)
        {

            lblUserMessage.Text = SqlErrorHandling(ex);
        }

    }

    private void OnWaterDeleteButton(object sender, EventArgs e)
    {
        try
        {
            var size = waterDataGridView.CurrentRow.Cells[0].Value;
            var primaryKey = new object[] { size };
            dataAccessLayer.DeleteRow(primaryKey, "Water");
            lblUserMessage.Text = $"Water with size {size} was deleted.";
            UpdateTables();
        }
        catch (SqlException ex)
        {

            lblUserMessage.Text = SqlErrorHandling(ex);
        }
    }
    private void OnMilkAddButton(object sender, EventArgs e)
    {
        try
        {
            string variety = milkVarietyTextBox.Text;
            string brand = milkBrandTextBox.Text;
            var milk = new object[] { variety, brand };
            dataAccessLayer.InsertRow(milk, "milk");
            lblUserMessage.Text = $"Milk with variety {variety} was added.";
            milkBrandTextBox.Text = "";
            milkVarietyTextBox.Text = "";
            UpdateTables();
        }
        catch (SqlException ex)
        {

            lblUserMessage.Text = SqlErrorHandling(ex);
        }


    }
    private void OnMilkDeleteButton(object sender, EventArgs e)
    {
        try
        {
            var variety = milkDataGridView.CurrentRow.Cells[0].Value;
            var primaryKeys = new object[] { variety };
            dataAccessLayer.DeleteRow(primaryKeys, "Milk");
            lblUserMessage.Text = $"Milk with variety {variety} was deleted.";
            UpdateTables();
        }
        catch (SqlException ex)
        {

            lblUserMessage.Text = SqlErrorHandling(ex);
        }
    }

    private void OnCellEdit(object sender, DataGridViewCellValidatingEventArgs e)
    {
        try
        {
            DataGridView dataGridView = sender as DataGridView;
            string tableName = dataGridView.Name;
            tableName = tableName.Remove(tableName.Length - 12, 12);
            UpdateCellValue(dataGridView, e, tableName);
        }
        catch (SqlException ex)
        {

            lblUserMessage.Text = SqlErrorHandling(ex);
        }
    }
    public void UpdateCellValue(DataGridView dataGridView, DataGridViewCellValidatingEventArgs e, string tableName)
    {
        try
        {
            var oldValue = dataGridView[e.ColumnIndex, e.RowIndex].Value;
            var newValue = e.FormattedValue;
            Debug.WriteLine(oldValue + "=" + newValue);
            Debug.WriteLine(oldValue);
            Debug.WriteLine(newValue.GetType);

            if(!newValue.ToString().Equals(""))
            {
                if (!newValue.ToString().Equals(oldValue.ToString())) //Only happens on new cell value!
                {
                    if (IntInputValidation(dataGridView, e, tableName))
                    {
                        var oldRow = dataGridView.Rows[e.RowIndex];
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

                        e.Cancel = true;
                        lblUserMessage.Text = $"Updated {oldValue} to {newValue}.";
                    }
                    UpdateTables();
                }
            } else
            {
                lblUserMessage.Text = "New value cannot be empty.";
                UpdateTables();
            }
        }
        catch (SqlException ex)
        {
            lblUserMessage.Text = SqlErrorHandling(ex);
        }
        catch (Exception ex)
        {
            lblUserMessage.Text = ex.Message;
        }
    }
    public void UpdateTables()
    {
        coffeeAddicts.Tables[0].Clear();
        coffeeAddicts.Tables[1].Clear();
        coffeeAddicts.Tables[2].Clear();
        coffeeAddicts.Tables[3].Clear();
        coffeeAddicts.Tables[4].Clear();
        coffeeAddicts.Tables[5].Clear();

        DataTableReader dataReader1 = new DataTableReader(dataAccessLayer.GetTable("Beans"));
        DataTableReader dataReader2 = new DataTableReader(dataAccessLayer.GetTable("water"));
        DataTableReader dataReader3 = new DataTableReader(dataAccessLayer.GetTable("milk"));
        DataTableReader dataReader4 = new DataTableReader(dataAccessLayer.GetTable("Foam"));
        DataTableReader dataReader5 = new DataTableReader(dataAccessLayer.GetTable("CoffeeView"));
        DataTableReader dataReader6 = new DataTableReader(dataAccessLayer.GetTable("BeverageView"));

        coffeeAddicts.Tables[0].Load(dataReader1);
        coffeeAddicts.Tables[1].Load(dataReader2);
        coffeeAddicts.Tables[2].Load(dataReader3);
        coffeeAddicts.Tables[3].Load(dataReader4);
        coffeeAddicts.Tables[4].Load(dataReader5);
        coffeeAddicts.Tables[5].Load(dataReader6);

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

            waterComboBox.DisplayMember = "Size";
            waterComboBox.BindingContext = this.BindingContext;

            beverageCoffeeComboBox.DisplayMember = "name";
            beverageCoffeeComboBox.BindingContext = this.BindingContext;

            beverageFoamComboBox.DisplayMember = "type";
            beverageFoamComboBox.BindingContext = this.BindingContext;

            beverageMilkComboBox.DisplayMember = "variety";
            beverageMilkComboBox.BindingContext = this.BindingContext;

            coffeeAddicts.Tables.Add(dataAccessLayer.GetTable("Beans"));
            coffeeAddicts.Tables.Add(dataAccessLayer.GetTable("Water"));
            coffeeAddicts.Tables.Add(dataAccessLayer.GetTable("Milk"));
            coffeeAddicts.Tables.Add(dataAccessLayer.GetTable("Foam"));
            coffeeAddicts.Tables.Add(dataAccessLayer.GetTable("CoffeeView"));
            coffeeAddicts.Tables.Add(dataAccessLayer.GetTable("BeverageView"));

            coffeeAddicts.Tables[0].TableName = "Beans";
            coffeeAddicts.Tables[1].TableName = "Water";
            coffeeAddicts.Tables[2].TableName = "Milk";
            coffeeAddicts.Tables[3].TableName = "Foam";
            coffeeAddicts.Tables[4].TableName = "Coffee";
            coffeeAddicts.Tables[5].TableName = "Beverage";

            coffeeAddicts.Tables[0].Columns.Add("FullString",
            typeof(string),
            "EAN + ' | ' + roast");
            beanComboBox.DisplayMember = "FullString";

            //beanComboBox.DisplayMember = "EAN";
            beanComboBox.BindingContext = this.BindingContext;

            coffeeBeanEANColumn.DataSource = coffeeAddicts.Tables[0];
            coffeeWaterSizeColumn.DataSource = coffeeAddicts.Tables[1];
            beverageMilkVarietyColumn.DataSource = coffeeAddicts.Tables[2];
            beverageFoamTypeColumn.DataSource = coffeeAddicts.Tables[3];
            beverageCoffeeNameColumn.DataSource = coffeeAddicts.Tables[4];

            beanComboBox.DataSource = coffeeAddicts.Tables[0];
            waterComboBox.DataSource = coffeeAddicts.Tables[1];
            beverageMilkComboBox.DataSource = coffeeAddicts.Tables[2];
            beverageFoamComboBox.DataSource = coffeeAddicts.Tables[3];
            beverageCoffeeComboBox.DataSource = coffeeAddicts.Tables[4];

            beansDataGridView.DataSource = coffeeAddicts.Tables[0];
            waterDataGridView.DataSource = coffeeAddicts.Tables[1];
            milkDataGridView.DataSource = coffeeAddicts.Tables[2];
            foamDataGridView.DataSource = coffeeAddicts.Tables[3];
            coffeeDataGridView.DataSource = coffeeAddicts.Tables[4];
            beverageDataGridView.DataSource = coffeeAddicts.Tables[5];

            beansDataGridView.Columns[2].Visible = false;

        }
        catch (SqlException ex)
        {
            lblUserMessage.Text = SqlErrorHandling(ex);
        }
    }


    private void OnCoffeeDeleteButton(object sender, EventArgs e)
    {
        try
        {
            var name = coffeeDataGridView.CurrentRow.Cells[0].Value;
            var primaryKeys = new object[] { name };
            dataAccessLayer.DeleteRow(primaryKeys, "Coffee");
            lblUserMessage.Text = $"{name} was deleted.";
            UpdateTables();
        }
        catch (SqlException ex)
        {

            lblUserMessage.Text = SqlErrorHandling(ex);
        }
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
            lblUserMessage.Text = $"{bevName} was added.";
            beverageNameTextBox.Text = "";
            UpdateTables();
        }
        catch (SqlException ex)
        {
            lblUserMessage.Text = SqlErrorHandling(ex);
        }
    }

    //private void beverageDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
    //{
    //    DataGridView dgv = (DataGridView)sender;
    //    if (e.Exception is ArgumentException)
    //    {
    //        object value = dgv.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
    //        if (!((DataGridViewComboBoxColumn)dgv.Columns[e.ColumnIndex]).Items.Contains(value))
    //        {
    //            dgv.Columns[4].DataPropertyName = "size";
    //            //dgv.Columns[4] = DataGridViewComboBoxColumn;
    //            //((DataGridViewComboBoxCell)dgv[e.ColumnIndex, e.RowIndex]).Value = DBNull.Value;

    //            //((DataGridViewComboBoxColumn)dgv.Columns[e.ColumnIndex]).Items.Add(value);
    //            e.ThrowException = false;
    //        }
    //    }
    //    else
    //    {
    //        lblUserMessage.Text = (e.Exception.Message);
    //        e.Cancel = true;
    //    }
    //    e.Cancel = true;
    //}

    private void OnReturnButton(object sender, EventArgs e)
    {
        MessageBox.Show("Front End Is Under Development!", "Front End");
    }

    private bool IntInputValidation(DataGridView dataGridView, DataGridViewCellValidatingEventArgs e, string tableName)
    {
        bool isValidated = true;
        int num = -1;

        NumericUpDown fieldA = null;
        NumericUpDown fieldB = null;
        int fieldAcolumnIndex = 0;
        int fieldBcolumnIndex = 0;
        Debug.WriteLine(num);

        switch (tableName)
        {
            case "water":
                fieldA = waterVolumeMlNumUpDown;
                fieldAcolumnIndex = 1;
                break;

            case "foam":
                fieldA = foamTemperatureNumUpDown;
                fieldB = foamTimeNumUpDown;
                fieldAcolumnIndex = 1;
                fieldBcolumnIndex = 2;
                break;

            case "coffee":
                fieldA = coffeeBeanWeightNumUpDown;
                fieldB = coffeeGrindSizeNumUpDown;
                fieldAcolumnIndex = 2;
                fieldBcolumnIndex = 3;
                break;

            default:
                return true;
        }

        if (e.ColumnIndex == fieldAcolumnIndex)
        {
            try
            {
                num = Int32.Parse((string)e.FormattedValue);
            }
            catch (FormatException ex)
            {
                lblUserMessage.Text = (ex.Message);
            }
            if (num < fieldA.Minimum || num > fieldA.Maximum)
            {
                isValidated = false;
                lblUserMessage.Text = ($"Please Enter a Number Between {fieldA.Minimum} and {fieldA.Maximum}.");
            }
        }
        else if (e.ColumnIndex == fieldBcolumnIndex)
        {
            try
            {
                num = Int32.Parse((string)e.FormattedValue);
            }
            catch (FormatException ex)
            {
                lblUserMessage.Text = (ex.Message);
            }
            if (num < fieldB.Minimum || num > fieldB.Maximum)
            {
                isValidated = false;
                lblUserMessage.Text = ($"Please Enter a Number Between {fieldB.Minimum} and {fieldB.Maximum}.");
            }
        }
        return isValidated;
    }

    private void FoamDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
    {
        try
        {

            DataGridView dataGridView = sender as DataGridView;
            e.Cancel = true;
            UpdateTables();
            dataGridView[e.ColumnIndex, e.RowIndex].ErrorText = "Wrong type of input";

        }
        catch (SqlException ex)
        {

            lblUserMessage.Text = SqlErrorHandling(ex);
        }
    }

    public string SqlErrorHandling(SqlException error)//NEEDS EXPANDING, TODO...
    {
        int code = error.Number;
        string message = error.Message;

        if (code == 0)
        {
            return "Connection couldn't be established";
        }
        else if (message.Contains("PK__Beans"))
        {
            return "There already exists a Bean with that EAN. Please try a new EAN.";
        }
        else if (message.Contains("PK__Beverage"))
        {
            return "There already exists a Beverage with that name. Please choose a different name.";
        }
        else if (message.Contains("PK__Coffee"))
        {
            return "There already exists a Coffee with that name. Please choose a different name.";
        }
        else if (message.Contains("PK__Foam"))
        {
            return "There already exists a Foam with that name. Please choose a different name.";
        }
        else if (message.Contains("PK__Milk"))
        {
            return "There already exists a Milk of that variety. Please choose a different variety.";
        }
        else if (message.Contains("PK__Water"))
        {
            return "There already exists a Water with that size. Please choose a different size.";
        }
        else
        { return message; }

    }

    private void OnBeverageDeleteBtn_Click(object sender, EventArgs e)
    {
        try
        {
            if (beverageDataGridView.CurrentRow != null)
            {
                var name = beverageDataGridView.CurrentRow.Cells[0].Value;
                var primaryKey = new object[] { name };
                dataAccessLayer.DeleteRow(primaryKey, "Beverage");
                lblUserMessage.Text = $"{name} was deleted.";
                UpdateTables();
            }


        }
        catch (SqlException ex)
        {
            SqlErrorHandling(ex);
        }
    }


}

