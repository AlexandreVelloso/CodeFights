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

    public class arrayMaximalAdjacentDifference{

		int method(int[] inputArray) {
			int max = Math.Abs( inputArray[0] - inputArray[1] );
			
			for( int i = 1; i < inputArray.Length-1; i++ ){
				max = Math.Max( max, Math.Abs( inputArray[i] - inputArray[i+1] ) );
			}
			
			return max;
		}

        static void Main(string[] args)
        {
			string[] input = Console.ReadLine().Split(' ');
			int[] array = Array.ConvertAll( input, Int32.Parse );
			
			Console.WriteLine( method(array) );
        }
    }
}