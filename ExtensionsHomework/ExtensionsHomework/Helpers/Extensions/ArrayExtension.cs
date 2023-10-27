using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionsHomework.Helpers.Extensions
{
    public static class ArrayExtension
    {
        public static int Multiply(this int[] array)
        {
           
            int multiply = 1;
            foreach (int item in array)
            {
                multiply *= item;
            }

            return multiply;
        }
    }
}
