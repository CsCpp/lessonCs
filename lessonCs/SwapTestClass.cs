using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lessonCs
{
    public static class SwapTestClass
    {
        public static void GenericSwap<T>(ref T a, ref T b)
        {
            T temp = a;
            a=b; 
            b=temp;
        }
        public static void Swap(ref object a, ref object b)
        {
            object temp = a;
            a = b;
            b = temp;
        }

    }
}
