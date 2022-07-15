using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class Bycyle: Vehicle
    {
       
        public override void Drive()
        {
            Console.WriteLine(Millage++); 
        }

    }
}
