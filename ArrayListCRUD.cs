using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    public class ArrayListCRUD
    {
        public static void ArraylistOperation()
        {
            // Create an ArrayList
            ArrayList Car = new ArrayList();

            // Add elements to the ArrayList
            Console.WriteLine("Adding elements in Arraylist");
            Car.Add("Hyundai");
            Car.Add("BMW");
            Car.Add("Maruti Suzuki");
            foreach (string e in Car)
            {
                Console.WriteLine(e);
            }


            // Read elements from the ArrayList
            Console.WriteLine("------------------");
            Console.WriteLine("Reading Elements from Arraylist");
            Console.WriteLine("The first element is " + Car[0]);
            Console.WriteLine("The second element is " + Car[1]);
            Console.WriteLine("The third element is " + Car[2]);

            // Update an element in the ArrayList
            Car[1] = "Toyota";
            Console.WriteLine("-----------------");
            Console.WriteLine("After updating element, second car is now " + Car[1]);
            foreach (string e in Car)
            {
                Console.WriteLine(e);
            }

            //Delete an element from the ArrayList
            Car.Remove("Hyundai");
            Console.WriteLine("------------------");
            Console.WriteLine("After Deleting element, ArrayList now contains " + Car.Count + " elements");
            foreach (string e in Car)
            {
                Console.WriteLine(e);
            }
            Console.ReadLine();
        }
    }
}
