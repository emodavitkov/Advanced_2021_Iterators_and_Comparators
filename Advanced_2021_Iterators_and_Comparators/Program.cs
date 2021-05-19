using System;

namespace Library
{
    public class Program
    {
        static void Main(string[] args)
        {
            PrintNames("Gosho", "Pesho");  
        }

        private static void PrintNames(params string[] names)
        {
            foreach (var item in names)
            {
                Console.WriteLine(item);
            }
        }
    }

    
}
