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

    public class evenDigitsOnly{

        static bool method(int n) {

            bool allEven = true;

            // number to be tested
            int numTest;
            while( n > 0 ){

                numTest = n % 10;

                if( numTest % 2 == 1 ){
                    allEven = false;
                    break;
                }

                n = n / 10;
            }

            return allEven;
        }

        static void Main(string[] args)
        {
            int num = Conver.ToInt32( Console.ReadLine() );
            Console.WriteLine( method(num) );
        }
    }
}
