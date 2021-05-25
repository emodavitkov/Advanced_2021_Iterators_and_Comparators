using System;
using System.Collections.Generic;
using System.Linq;

namespace ListyIterator
{
    public class Program
    {
        static void Main(string[] args)
        {
            //tests

            //ListyIterator<int> list = new ListyIterator<int>(2,4);
            //list.Print();
            //Console.WriteLine(list.HasNext());
            //Console.WriteLine(list.Move());
            //Console.WriteLine(list.Move());

            //if we tested without params ctor

            //List<string> names = new List<string> {"asd","asd" };
            //ListyIterator<string> test = new ListyIterator<string>(names);

            List<string> items = Console.ReadLine()
                .Split(" ").Skip(1).ToList();

            ListyIterator<string> list = new ListyIterator<string>(items);

            string command = Console.ReadLine();

            while (command!="END")
            {
                switch (command)
                {
                    case "Move":
                        Console.WriteLine(list.Move());
                        break;
                    case "HasNext":
                        Console.WriteLine(list.HasNext());
                        break;
                    case "Print":
                        try
                        {
                            list.Print();
                        }
                        catch (InvalidOperationException ex)
                        {

                            Console.WriteLine(ex.Message);
                        }
                        
                        break;

                    default:
                        break;
                }

                command = Console.ReadLine();
            }



        }
    }
}
