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

    public class absoluteValuesSumMinimization{

        static int method(int[] a) {

            // size of the array
            int size = a.Length;

            // if the Length is a odd number
            if( size % 2 == 1 ){

                return a[ size/2 ];
            }else{

                return ( Math.Min( a[ size/2 ] , a[ size/2-1 ] ) );
            }
        }

        static void Main(string[] args)
        {
            int[] array = Array.ConvertAll( Console.ReadLine().Split(' '), Parse.ToInt32 );

            Console.WriteLine( mehtod( array ) );
        }
    }
}
