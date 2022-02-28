using CoffeeAddictsService;
using ServoReference;
using System.Data;


namespace GuiClient
{
    public partial class Form1 : Form
    {
        private static WebService1SoapClient.EndpointConfiguration endpoint = WebService1SoapClient.EndpointConfiguration.WebService1Soap;
        private WebService1SoapClient coffeeAddictsClient = new WebService1SoapClient(endpoint);

        private static ServoSoapClient.EndpointConfiguration endpointServo = ServoSoapClient.EndpointConfiguration.ServoSoap;
        private ServoSoapClient servoClient = new ServoSoapClient(endpointServo);
        public Form1()
        {
            InitializeComponent();



            ArrayOfXElement arrayOfX = coffeeAddictsClient.GetTableNames();
            DataSet tableNames = ToDataSet(arrayOfX);

            
            a4c1dataGridView.AutoGenerateColumns = false;
            a3c2TableNameComboBox.DisplayMember = "TABLE_NAME";
            a3c2TableNameComboBox.BindingContext = this.BindingContext;
            a3c2TableNameComboBox.DataSource = tableNames.Tables[0];
            empTabEmployeesDataGridView.AutoGenerateColumns = false;

            a4c1dataGridView.DataSource = coffeeAddictsClient.GetEmployees();
          
            empTabEmployeesDataGridView.DataSource = coffeeAddictsClient.GetEmployees();
            


            a5c1MethodComboBox.Items.Add("All keys");
            a5c1MethodComboBox.Items.Add("All indexes");
            a5c1MethodComboBox.Items.Add("All table_constraints");
            a5c1MethodComboBox.Items.Add("All tables #1");
            a5c1MethodComboBox.Items.Add("All tables #2");
            a5c1MethodComboBox.Items.Add("All employee columns #1");
            a5c1MethodComboBox.Items.Add("All employee columns #2");
            a5c1MethodComboBox.Items.Add("Absentee");
            a5c1MethodComboBox.Items.Add("Sickness");
            a5c1MethodComboBox.Items.Add("Employees and relatives");
            a5c1MethodComboBox.Items.Add("All Employee Tables Metadata");
            


        }
        private CRONUS_Sverige_AB_Employee FillDefaultValues(CRONUS_Sverige_AB_Employee employee)
        {
            Random random = new Random();
            employee.Address = "DEFAULT";
            employee.Address_2 = "DEFAULT";
            employee.Alt__Address_Code = "DEFAULT";
            employee.Alt__Address_End_Date = DateTime.Now.AddDays(50);
            employee.Alt__Address_Start_Date = DateTime.Now;
            employee.Birth_Date = DateTime.Now;
            employee.Cause_of_Inactivity_Code = "DEFAULT";
            employee.Company_E_Mail = "DEFAULT";
            employee.Country_Region_Code = "DEFAULT";
            employee.County = "DEFAULT";
            employee.Employment_Date = DateTime.Now;
            employee.Emplymt__Contract_Code = "DEFAULT";
            employee.Extension = "DEFAULT";
            employee.E_Mail = "DEFAULT";
            employee.Fax_No_ = "DEFAULT";
            employee.Global_Dimension_1_Code = "DEFAULT";
            employee.Global_Dimension_2_Code = "DEFAULT";
            employee.Grounds_for_Term__Code = "DEFAULT";
            employee.Inactive_Date = DateTime.Now;
            employee.Initials = "DEFAULT";
            employee.Last_Date_Modified = DateTime.Now;
            employee.Manager_No_ = "DEFAULT";
            employee.Middle_Name = "DEFAULT";
            employee.Mobile_Phone_No_ = "DEFAULT";
            employee.No_ = random.Next().ToString();
            employee.No__Series = "DEFAULT";
            employee.Pager = "DEFAULT";
            employee.Picture = null;
            employee.Post_Code = "DEFAULT";
            employee.Resource_No_ = "DEFAULT";
            employee.Salespers__Purch__Code = "DEFAULT";
            employee.Search_Name = "DEFAULT";
            employee.Sex = 0;
            employee.Social_Security_No_ = "DEFAULT";
            employee.Statistics_Group_Code = "DEFAULT";
            employee.Status = 0;
            employee.Termination_Date = DateTime.Now;
            //employee.timestamp = ;
            employee.Title = "DEFAULT";
            employee.Union_Code = "DEFAULT";
            employee.Union_Membership_No_ = "DEFAULT";
            return employee;
        }
        private void OnA2C2FindButton_Click(object sender, EventArgs e)
        {

            string fileName = fileNameTextBox.Text;
            if (fileName == null || fileName.Equals(""))
            {
                a2c2OutputField.Text = "Please enter a file name.";
            }
            else
            {
                a2c2OutputField.Text = servoClient.FindFile(fileName);
            }
        }
        public DataSet ToDataSet(ArrayOfXElement arrayOfXElement)
        {
            var strSchema = arrayOfXElement.Nodes[0].ToString();
            var strData = arrayOfXElement.Nodes[1].ToString();
            var strXml = "<?xml version=\"1.0\" encoding=\"utf-8\" ?>\n\t<DataSet>";
            strXml += strSchema + strData;
            strXml += "</DataSet>";

            DataSet ds = new DataSet("TestDataSet");
            ds.ReadXml(new MemoryStream(System.Text.Encoding.UTF8.GetBytes(strXml)));

            return ds;
        }

        private void A3c2TableNameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tableName = a3c2TableNameComboBox.Text;
            var tableArray = coffeeAddictsClient.GetTable(tableName);
            DataSet set = ToDataSet(tableArray);
            a3c2DataGridView.DataSource = set.Tables[0];
        }

        private void a4c1dataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true; //This ignores the problems with pictures and timestamps! NOT ELEGANT #USCH
        }

        private void OnA4c1DeleteBtn_Click(object sender, EventArgs e)
        {
            CRONUS_Sverige_AB_Employee employee = a4c1dataGridView.CurrentRow.DataBoundItem as CRONUS_Sverige_AB_Employee;
            coffeeAddictsClient.DeleteEmployee(employee.No_);
            a4c1dataGridView.DataSource = coffeeAddictsClient.GetEmployees();
        }


        private void a4c1dataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            CRONUS_Sverige_AB_Employee tmpEmp = a4c1dataGridView.Rows[e.RowIndex].DataBoundItem as CRONUS_Sverige_AB_Employee;
            //Debug.Write(tmpEmp.First_Name);
            coffeeAddictsClient.UpdateEmployee(tmpEmp);

            a4c1dataGridView.DataSource = coffeeAddictsClient.GetEmployees();

        }

        private void a4c1AddBtn_Click(object sender, EventArgs e)
        {
            string firstName = a4c1FirstNameTextBox.Text;
            string lastName = a4c1LastNameTextBox.Text;
            string jobTitle = a4c1JobTitleTextBox.Text;
            string phoneNumber = a4c1PhoneNumberTextBox.Text;
            string city = a4c1CityTextBox.Text;

            CRONUS_Sverige_AB_Employee employee = new CRONUS_Sverige_AB_Employee();
            employee = FillDefaultValues(employee);
            employee.First_Name = firstName;
            employee.Last_Name = lastName;
            employee.Job_Title = jobTitle;
            employee.Phone_No_ = phoneNumber;
            employee.City = city;

            coffeeAddictsClient.CreateEmployee(employee);
            a4c1dataGridView.DataSource = coffeeAddictsClient.GetEmployees();

            a4c1CityTextBox.Text = "";
            a4c1FirstNameTextBox.Text = "";
            a4c1LastNameTextBox.Text = "";
            a4c1JobTitleTextBox.Text = "";
            a4c1PhoneNumberTextBox.Text = "";

        }

        private void OnA5c1MethodComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            a5c1OutputDataGridView.DataSource = ToDataSet(coffeeAddictsClient.GetCronusData(a5c1MethodComboBox.Text)).Tables[0];
        }

        private void OnRelationSelection(object sender, EventArgs e)
        {
            var emp = empTabEmployeesDataGridView.CurrentRow.DataBoundItem as CRONUS_Sverige_AB_Employee;
            
            string relation = empTabRelationComboBox.Text;
            string empID = emp.No_;

            switch (relation)
            {
                case "Absences":
                    empTabRelationsDataGridView.DataSource = coffeeAddictsClient.GetEmployeeAbsence(empID);
                    break;
                case "Relatives":
                    empTabRelationsDataGridView.DataSource = coffeeAddictsClient.GetEmployeeRelatives(empID);
                    break;
                case "Qualifications":
                    empTabRelationsDataGridView.DataSource = coffeeAddictsClient.GetEmployeeQualifications(empID);
                    break;
            }
           
        }

        private void OnEmployeeTablesCellClickChangeRelationTable(object sender, DataGridViewCellEventArgs e)
        {
            var emp = empTabEmployeesDataGridView.CurrentRow.DataBoundItem as CRONUS_Sverige_AB_Employee;

            string relation = empTabRelationComboBox.Text;
            string empID = emp.No_;

            switch (relation)
            {
                case "Absences":
                    empTabRelationsDataGridView.DataSource = coffeeAddictsClient.GetEmployeeAbsence(empID);
                    break;
                case "Relatives":
                    empTabRelationsDataGridView.DataSource = coffeeAddictsClient.GetEmployeeRelatives(empID);
                    break;
                case "Qualifications":
                    empTabRelationsDataGridView.DataSource = coffeeAddictsClient.GetEmployeeQualifications(empID);
                    break;
            }
            
        }
        

       
    }
}