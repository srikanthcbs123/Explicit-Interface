using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Explicit_Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Class3 obj= new Class3();
            IFirst firstObj = obj;
            firstObj.Display();
            ISecond secondObj = obj;
            secondObj.Display();
            Console.ReadKey();
        }

       
    }
}
