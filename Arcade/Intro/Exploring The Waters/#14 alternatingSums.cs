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

    public class alternatingSums{

        public static int[] method(int[] a) {

            int[] sum = new int[2]{ 0,0 };

            for( int i = 0; i < a.Length; i++){
                sum[ i % 2 ] += a[i];
            }

            return sum;
        }

        public static void Main( string[] args ){

            string[] input = Console.ReadLine().Split(' ');
            int[] array = Array.ConvertAll( input, Int32.Parse );

            int[] teams = method( array );
            Console.WriteLine( teams[0]+"\n"+teams[1] );
        }
    }
}
