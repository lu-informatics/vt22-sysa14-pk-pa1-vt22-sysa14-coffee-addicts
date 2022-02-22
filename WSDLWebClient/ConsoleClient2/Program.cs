using System;
using System.Data.SqlClient;
using System.Collections.Generic;
public class Program
{
    public static void Main(string[] args)
    {
        try
        {
            WebService1 client = new WebService1();


            while (true)
            {
                Console.WriteLine("Choose table:");
                Console.WriteLine("1: Beans\n2: Beverage\n3: Coffee\n4: Foam\n5: Milk\n6: Water");
                Console.WriteLine("Select a number between 1-6:");
                string number = Console.ReadLine();
                string tableName = "Beverage";
                switch (number)
                {
                    case "1":
                        tableName = "Beans";
                        break;
                    case "2":
                        tableName = "Beverage";
                        break;
                    case "3":
                        tableName = "Coffee";
                        break;
                    case "4":
                        tableName = "Foam";
                        break;
                    case "5":
                        tableName = "Milk";
                        break;
                    case "6":
                        tableName = "Water";
                        break;
                }
                
                var list = client.GetTableValuesAsList(tableName);
                            
                foreach (var item in list)
                {
                    string obj = "";
                    foreach (object value in item)
                    {
                        if (value != null)
                        {
                            obj += value + ", ";

                        }
                        else
                        {

                            obj += "NULL" + ", ";
                        }
                    }
                    Console.WriteLine(obj);

                }
                Console.WriteLine("Find new table? y/n");
                string answer = Console.ReadLine();
                if (answer.Equals("n"))
                    break;


            }
            
        }
        catch (SqlException e)
        {
            Console.WriteLine(e.Message);
        }
        catch(Exception e)
        {
            Console.WriteLine(e.Message);
        }

    }

}