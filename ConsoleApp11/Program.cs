using System;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("Irada", "Feyzullayeva");
            Student student2 = new Student("Ira", "Fey");
            Student student3 = new Student("Iris","Feyzu");

            student3.GetDetails();
        }
    }
}
