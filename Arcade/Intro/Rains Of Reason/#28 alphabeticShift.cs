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

    public class alphabeticShift{

        static string method(string inputString) {
            string replaced = "";

            char newChar;
            foreach( char c in inputString ){
                newChar = (char)( ( c - 'a' + 1 )%26 + 'a');
                replaced += newChar ;
            }

            return replaced;
        }

        static void Main(string[] args)
        {
            string inputString = Console.ReadLine();
            Console.WriteLine( method( inputString ) );
        }
    }
}
