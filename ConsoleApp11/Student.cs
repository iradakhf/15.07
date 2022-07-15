using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp11
{
     class Student
    {
        static int id = 0;
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        public Student(string name, string surname)
        {

            id++;
            Name = name;
            Surname = surname;
            Id = id;
           
        }
        public void GetDetails()
        {
            Console.WriteLine($"Name { Name} Surname: {Surname} ID {Id} ");
        }
      
    }
}
