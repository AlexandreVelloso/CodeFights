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

    public class circleOfNumbers{

        static int method(int n, int firstNumber) {
            return( (firstNumber + (n/2)) % n );
        }


        static void Main(string[] args)
        {
            int n = Convert.ToInt32( Console.ReadLine() );
            int firstNumber = Convert.ToInt32( Console.ReadLine() );

            Console.WriteLine( method( n, firstNumer ) );
        }
    }
}
