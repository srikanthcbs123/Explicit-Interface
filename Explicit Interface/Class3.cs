using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Explicit_Interface
{
    public class Class3 : IFirst, ISecond//multiple inheritence achived by interfaces
    {
        void IFirst.Display()
        {
            Console.WriteLine("i am Ifirst interfcae method");
        }
        void ISecond.Display()
        {
            Console.WriteLine("i am ISecond interfcae method");
        }
    }
}
