using ServoReference;
using static ServoReference.ServoSoapClient;
using CoffeeAddictsService;
using static CoffeeAddictsService.WebService1SoapClient;
using System.Data.SqlClient;
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
            DataSet dataSet = ToDataSet(arrayOfX); 
            
            
            a3c2TableNameComboBox.DisplayMember = "TABLE_NAME";
            a3c2TableNameComboBox.BindingContext = this.BindingContext;
            a3c2TableNameComboBox.DataSource = dataSet.Tables[0];
            //a3c2TableNameComboBox.
           
        }

        private void OnA2C2FindButton_Click(object sender, EventArgs e)
        {
         
            string fileName = fileNameTextBox.Text;
            if (fileName == null || fileName.Equals(""))
            {
                a2c2OutputField.Text = "Please enter a file name.";
            } else
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
    }
}