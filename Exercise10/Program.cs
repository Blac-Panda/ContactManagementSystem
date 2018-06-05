using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
    WRITTEN BY: OYEFESO OLUWATUNMISE (BLAC_PANDA)
    DATE: JANUARY 2017
*/
namespace Exercise10
{
    class Program
    {
        static LinkedList<String> names = new LinkedList<string>();
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("========================================================================");
                Console.WriteLine("\n\nThis is a contact management system.");
                Console.WriteLine("Contacts size => {0}\n", names.Count.ToString());
                //displayContacts();
                //assign values to each function
                Console.WriteLine("Enter 1 to add contact\nEnter 2 to show contacts in ascending order\nEnter 3 to show" +
                 " contacts in descending order\nEnter 4 to search for a contact\n\nEnter a number : ");
                //read your input
                int val = Int32.Parse(Console.ReadLine());
                string[] searchName;
                //compare with values below for action
                if (val == 1)
                {
                    Console.WriteLine("Enter name of the contact to be added");
                    //read your input
                    String val2 = Console.ReadLine();
                    addName(val2);
                    Console.WriteLine("Successfully Added");
                }
                else if (val == 2)
                {
                    Console.WriteLine("Showing contacts in ascending order");
                    String[] temp = names.ToArray();
                    //shows them in either sorted way
                    Array.Sort(temp);
                    names = new LinkedList<string>();
                    for (int i = 0; i < temp.Length; i++)
                    {
                        names.AddLast(temp[i]);
                    }
                    displayContacts();
                }
                else if (val == 3)
                {
                    Console.WriteLine("Showing contacts in descending order");
                    //stores the contacts in an array
                    String[] temp = names.ToArray();
                    //shows them in reverse way
                    Array.Sort(temp);
                    Array.Reverse(temp);
                    names = new LinkedList<string>();
                    for (int i = 0; i < temp.Length; i++)
                    {
                        names.AddLast(temp[i]);
                    }
                    displayContacts();
                }
                else if (val == 4)
                {
                    
                }
            }
        }
        //Creating a function that allows you to add string
        public static void addName(String name)
        {
            names.AddLast(name);
        }
        public static void displayContacts()
        {
            //displays the number of string you have input into names 
            Console.WriteLine("=====Contacts size => {0}=====", names.Count.ToString());
            for (int i = 0; i < names.Count; i++)
            {
                // returns the element in specified index i
                Console.WriteLine(names.ElementAt(i));
            }
            Console.WriteLine("\n");
        }
    }
}
