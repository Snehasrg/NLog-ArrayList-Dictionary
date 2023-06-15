
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
            Console.WriteLine("\n1. For Nlog Config Example. \n2. CRUD operation on ArrayList. \n3. CRUD operation on Dictionary.");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)

            {
                case 2:
                    ArrayListCRUD.ArraylistOperation();
                    break;
                case 3:
                    DictionaryCRUD.DictionaryOperation();
                    break;
               

            }
        }
    }
}