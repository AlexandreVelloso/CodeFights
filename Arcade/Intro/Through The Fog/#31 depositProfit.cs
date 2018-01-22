using System;
using System.IO;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text;
using SimpleJson.Reflection;
using System.Text.RegularExpressions;
using System.Linq;

namespace CodeFights{

    public class depositProfit{

        static int method(int deposit, int rate, int threshold) {
            int days = 0;
            double d = deposit;

            while( d < threshold ){

                d *= 1+( rate/100.0 );
                days++;
            }

            return days;
        }

        static void Main(string[] args)
        {
            int deposit = Convert.ToInt32( Console.ReadLine() );
            int rate = Convert.ToInt32( Console.ReadLine() );
            int threshold = Convert.ToInt32( Console.ReadLine() );

            Console.WriteLine( method( deposit, rate, threshold ) );
        }
    }
}
