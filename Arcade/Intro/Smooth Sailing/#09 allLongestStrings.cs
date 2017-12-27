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

    public class allLongestStrings{

        public static string[] method(string[] inputArray) {

            // size of the strings from inputArray
            int[] sizes = new int[ inputArray.Length ];
            int max = 0;

            // save all string sizes from inputArray
            for( int i = 0; i < inputArray.Length; i++ ){
                sizes[i] = inputArray[i].Length;

                max = Math.Max( inputArray[i].Length, max );
            }

            int count = 0;
            // count the number of longest strings
            for( int i = 0; i < sizes.Length; i++ ){
                if( sizes[i] == max )
                    count++;
            }

            // add all longest strings in the allLongestStrings array
            string[] allLongestStrings = new string[ count ];

            int j = 0;
            // save all longest strings
            for( int i = 0; i < sizes.Length; i++ ){
                if( sizes[i] == max ){
                    allLongestStrings[j++] = inputArray[i];
                }
            }

            return allLongestStrings;
        }

        public static void Main( string[] args ){

            int numLinhas = Convert.ToInt32( Console.ReadLine() );
            string[] input = new string[ numLinhas ];

            for( int i = 0; i < numLinhas; i++ ){
                input = Console.ReadLine();
            }

            foreach ( string s in method(input) ){
                Console.WriteLine( s );
            }
        }

    }
}
