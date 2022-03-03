using System;
public class Program{
    public static void Main(string[] args){
        WebService1 client = new WebService1();
        
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
    }

}