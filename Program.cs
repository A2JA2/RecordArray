using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordArray
{
    class Program
    {

        struct Student
        {
            public int StudentID; public string Surname; public string Forename; public int Age;
            public bool Enrolled;
        };

        static void Main(string[] args)
        {
            // create the record structure struct student
         
        Student mystudent; // declare the 'mystudent' student structure type

        //initialise the elements in the record structure
        mystudent.StudentID = 2001;
            mystudent.Surname = "Brush";
            mystudent.Forename = "Basil";
            mystudent.Age = 21;
            mystudent.Enrolled = true;

            //print the data in the record structure
            Console.WriteLine("ID        : {0}", mystudent.StudentID);
            Console.WriteLine("Surname   : {0}", mystudent.Surname);
            Console.WriteLine("Firstname : {0}", mystudent.Forename);
            Console.WriteLine("Age       : {0}", mystudent.Age);
            Console.WriteLine("Enrolled  : {0}", mystudent.Enrolled);
            //wait for key press to continue
            Console.ReadKey();
        }
    }
}
