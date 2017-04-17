using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using System.Reflection;


namespace CustomDynamicClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            //InvokeMethodUsingReflection();
            InvokeMethodUsingDynamic();

            WriteLine("\n\nPress enter to exit");
            ReadLine();
        }

        private static void InvokeMethodUsingReflection()
        {
            StringBuilder sb = new StringBuilder("fuck face: " ); 
            sb.GetType().InvokeMember("AppendLine", BindingFlags.InvokeMethod, null, sb, new object[] { "Hello reflection!"});

            WriteLine(sb);

            
        }

        private static void InvokeMethodUsingDynamic()
        {
            StringBuilder sb = new StringBuilder("bung hole");

            ((dynamic)sb).AppendLine("shit fuck!");

            WriteLine(sb);
        }
    }
}
