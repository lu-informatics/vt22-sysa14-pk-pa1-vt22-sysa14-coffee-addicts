using ServiceReference1;
using static ServiceReference1.ServoSoapClient;
EndpointConfiguration endpoint = EndpointConfiguration.ServoSoap;

ServoSoapClient client = new ServoSoapClient(endpoint);

while (true)
{
    Console.WriteLine("Enter file name: ");
    string fileName = Console.ReadLine();

    Console.WriteLine(client.FindFile(fileName));

    Console.WriteLine("Open another file? y/n");
    string answer = Console.ReadLine();
    if (answer.Equals("n"))
        break;
}

Environment.Exit(0);