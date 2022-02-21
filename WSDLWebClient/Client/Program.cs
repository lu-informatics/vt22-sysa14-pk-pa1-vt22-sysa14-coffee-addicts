using System;
public class Program{
    public static void Main(string[] args){
        Servo client = new Servo();
        
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