using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Using_var
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 5.0; // ← исправьте эту строку
            a += 0.5;
            Console.WriteLine(a);
        }
    }
}
