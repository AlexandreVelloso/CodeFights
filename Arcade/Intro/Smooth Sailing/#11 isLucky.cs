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

        public static int method(int n) {

            int sumFirstHalf = 0;
            int sumSecondHalf = 0;

            // sum the second half
            for( int i = 0; i <= (""+n).Length/2; i++ ){
                sumSecondHalf += n%10;
                n = n/10;
            }

            // sum the first half
            while( n > 0 ){
                sumFirstHalf += n%10;
                n = n/10;
            }

            return ( sumFirstHalf == sumSecondHalf );
        }

        public static void Main( string[] args ){

            int num = 1230;

            Console.WriteLine( method(num) );
        }

    }
}
