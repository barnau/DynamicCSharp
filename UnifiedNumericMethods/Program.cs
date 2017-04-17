using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace UnifiedNumericMethods
{
    class Program
    {
        static void Main(string[] args)
        {

            int int1 = 5;
            int int2 = 2;

            WriteLine($"Int overload {CommonMath.Add(int1, int2)}");

            double dbl1 = 20;
            double dbl2 = 5;

            WriteLine($"Dbl overload {CommonMath.Add(dbl1, dbl2)}");

            WriteLine($"Dynamic version {CommonMathDynamic.Add(int1, int2)}");
            WriteLine($"Dynamic version {CommonMathDynamic.Add(dbl1, dbl2)}");

            // will set off run time error
            //String s = CommonMathDynamic.Add(int1, int2);

            WriteLine($"Dynamic with generic version {CommonMathDynamicWithGenerics.Add(int1, int2)}");
            WriteLine($"Dynamic with generic version {CommonMathDynamicWithGenerics.Add(dbl1, dbl2)}");

            //Will set off compile error
            //String s = CommonMathDynamicWithGenerics.Add(int1, int2);

            short short1 = 5;
            short short2 = 21;

            //Will set off runtime error because genereics get cast to int32
            //short x = CommonMathDynamicWithGenerics.Add(short1, short2);

            WriteLine($"Dynamic with generic version explicit cast {CommonMathDynamicWithGenericsWxplicitCast.Add(int1, int2)}");
            WriteLine($"Dynamic with generic version explicit cast {CommonMathDynamicWithGenericsWxplicitCast.Add(short1, short2)}");





            WriteLine("\n\nPress enter to exit");
            ReadLine();
            
        }
    }

    static class CommonMathDynamicWithGenericsWxplicitCast
    {
        public static T Add<T>(T a, T b)
        {
            dynamic result = (dynamic)a + b;
            return (T)result;
        }

    }

    static class CommonMath
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static double Add(double a, double b)
        {
            return a + b;
        }
    }

    static class CommonMathDynamicWithGenerics
    {
        public static T Add<T>(T a, T b)
        {
            dynamic result = (dynamic)a + b;
            return result;
        }
    }

    static class CommonMathDynamic
    {
        public static dynamic Add(dynamic a, dynamic b)
        {
            dynamic result = a + b;
            return result;
        }
    }
}
