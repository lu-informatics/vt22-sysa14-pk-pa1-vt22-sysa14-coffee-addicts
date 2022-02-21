using ServoService;
using static ServoService.ServoSoapClient;

namespace GuiClient
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void OnA2C2FindButton_Click(object sender, EventArgs e)
        {
            EndpointConfiguration endpoint = EndpointConfiguration.ServoSoap;
            ServoSoapClient client = new ServoSoapClient(endpoint);
            string fileName = fileNameTextBox.Text;
            if (fileName == null || fileName.Equals(""))
            {
                a2c2OutputField.Text = "Please enter a file name.";
            } else
            {
                a2c2OutputField.Text = client.FindFile(fileName);
            }
        }
    }
}