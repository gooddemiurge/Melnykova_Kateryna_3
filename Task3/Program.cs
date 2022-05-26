using System;
using System.Linq;
using System.Collections.Generic;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<int>() { 123, 23, 78, 91, 330 };
            int tvir = list.Aggregate(seed:1, func:(result, item) => result*(item%10)); // ((((1*3)*3)*8)*1)*4
            Console.WriteLine("Твiр останнiх цифр елементiв послiдовностi: " + tvir);
        }
    }
}
