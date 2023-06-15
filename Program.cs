// See https://aka.ms/new-console-template for more information
using Demo;
using NlogConfigDemo;
using System.Collections.Generic;

namespace NlogConfigDemo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to NLog Configuration,Arraylist and Dictionary CRUD operation!");
            Console.WriteLine("Select any one Option for Opreration");
            Console.WriteLine("\n 1. For Nlog Config Example. \n 2. CRUD operation on ArrayList.");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)

            {
                case 2:
                    ArrayListCRUD.ArraylistOperation();
                    break;
               

            }
        }
    }
}