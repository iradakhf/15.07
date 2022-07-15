using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("enter first integer number");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter second integer number");
                int b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter one of these : /,*,+,-");
                char sign = Convert.ToChar(Console.ReadLine());
                int result = 0;
                switch (sign)
                {
                    case '/':
                        result = a / b;
                        break;
                    case '*':
                        result = a * b;
                        break;
                    case '-':
                        result = a - b;
                        break;
                    case '+':
                        result = a + b;
                        break;


                }
                Console.WriteLine("Result is : " + result);


            }
            catch (Exception)
            {
                Console.WriteLine("error 404 not found");
            }
        }
    }
}
