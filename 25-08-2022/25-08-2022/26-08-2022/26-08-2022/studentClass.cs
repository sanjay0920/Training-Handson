using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace student

{
    internal class StudentClass
    {

        public struct student
        {
            public int Id;
            public string Name;
            public int Age;


            public void SetStudent(int id, string name, int age)
            {
                Id = id;
                Name = name;
                Age = age;
            }

            internal void DisplayStudent()
            {
                throw new NotImplementedException();
            }
        }
    }
}