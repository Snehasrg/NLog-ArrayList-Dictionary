using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NlogConfigDemo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    public class DictionaryCRUD
    {
        public static void DictionaryOperation()
        {
            // create a Dictionary
            Dictionary<string, int> patients = new Dictionary<string, int>();

            // add elements to the Dictionary
            Console.WriteLine("Adding elements in Dictionary.");
            patients.Add("Meera", 10);
            patients.Add("John", 70);
            patients.Add("Jeesy", 85);
            foreach (var patient in patients)
            {
                Console.WriteLine(patient.Key + " " + patient.Value);
            }

            // Read elements from the Dictionary
            Console.WriteLine("------------------");
            Console.WriteLine("Reading elements from dictionary.");
            Console.WriteLine("Meera is " + patients["Meera"] + " years old");
            Console.WriteLine("John is " + patients["John"] + " years old");
            Console.WriteLine("Jeesy is " + patients["Jeesy"] + " years old");

            // Update an element in the Dictionary
            Console.WriteLine("------------------");
            patients["John"] = 25;
            Console.WriteLine("After updating,John is now " + patients["John"] + " years old.");
            foreach (var patient in patients)
            {
                Console.WriteLine(patient.Key + " " + patient.Value);
            }

            // Delete an element from the Dictionary
            Console.WriteLine("------------------");
            patients.Remove("Jeesy");
            Console.WriteLine("After deleting,The Dictionary now contains " + patients.Count + " elements.");
            foreach (var patient in patients)
            {
                Console.WriteLine(patient.Key + " " + patient.Value);
            }

            Console.ReadLine();
        }
    }
}

