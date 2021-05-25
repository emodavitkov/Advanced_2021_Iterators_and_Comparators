﻿using System;

namespace Stack
{
    public class Program
    {
        static void Main(string[] args)
        {
            MyStack<int> myStack = new MyStack<int>();

            string commandInput = Console.ReadLine();

            while (commandInput!="END")
            {
                string[] commandData = commandInput.Split(new string[] {" ", ", "},StringSplitOptions.RemoveEmptyEntries);
                string command = commandData[0];

                if (command == "Push")
                {
                    for (int i = 1; i < commandData.Length; i++)
                    {
                        int item = int.Parse(commandData[i]);
                        myStack.Push(item);
                    }
                }

                else if (command=="Pop")
                {
                    try
                    {
                        myStack.Pop();
                    }
                    catch (InvalidOperationException ex)
                    {

                        Console.WriteLine(ex.Message);
                    }
                }



                commandInput = Console.ReadLine();     
            }

            foreach (var item in myStack)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(string.Join(Environment.NewLine,myStack));


            //myStack.Push(10);
            //myStack.Push(20);
            //myStack.Push(30);

            //foreach (var item in myStack)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine(myStack.Pop());
            //Console.WriteLine(myStack.Pop());
            //Console.WriteLine(myStack.Pop());
            //Console.WriteLine(myStack.Pop());
        }
    }
}
