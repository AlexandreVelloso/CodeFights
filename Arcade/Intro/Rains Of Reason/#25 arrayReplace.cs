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

    public class arrayReplace{

        static int[] method(int[] inputArray, int elemToReplace, int substitutionElem) {

            for( int i = 0; i < inputArray.Length; i++ ){
                if( inputArray[i] == elemToReplace ){
                    inputArray[i] = substitutionElem;
                }
            }

            return inputArray;
        }

        static void Main(string[] args)
        {
            int elemToReplace = Convert.ToInt32( Console.ReadLine() );
            int substitutionElem = Convert.ToInt32( Console.ReadLine() );
            int[] inputArray = Array.ConvertAll( Console.ReadLine().Split(' '), Parse.ToInt32 );

            inputArray = method( inputArray );

            for (int i = 0; i < inputArray.Length; i++) {
                Console.Write( inputArray[i]+" ");
            }
            Console.WriteLine();
        }
    }
}
