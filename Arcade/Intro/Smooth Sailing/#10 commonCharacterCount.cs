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

    public class commonCharacterCount{

        public static int method(string s1, string s2) {

            // number of occurrence of each character in s1
            int[] occString1 = new int[ 26 ];
            // number of occurrence of each character in s2
            int[] occString2 = new int[ 26 ];

            // count the occurrences
            foreach( char c in s1 ){
                occString1[ c - 'a' ]++;
            }

            foreach( char c in s2 ){
                occString2[ c - 'a' ]++;
            }

            int sum = 0;
            // count the number of common characters
            for( int i = 0; i < 26; i++ ){
                sum += Math.Min( occString1[i], occString2[i] );
            }

            return sum;
        }

        public static void Main( string[] args ){

            string str1 = Console.ReadLine();
            string str2 = Console.ReadLine();

            Console.WriteLine( method(str1,str2) );
        }

    }
}
