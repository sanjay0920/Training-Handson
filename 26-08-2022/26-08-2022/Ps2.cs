using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using student;

namespace application
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create array of structure
            StudentClass.student[] emp = { new Student() };


            // Pass the array indexes with values as structures
            emp[0].SetStudent(1, "sanjay", 20);
            emp[1].SetStudent(2, "ajay", 21);
            emp[2].SetStudent(3, "lalith" +
                "", 23);

            // Call the display method
            emp[0].DisplayStudent();
            emp[1].DisplayStudent();
            emp[2].DisplayStudent();
            Console.ReadKey();
        }
    }
}