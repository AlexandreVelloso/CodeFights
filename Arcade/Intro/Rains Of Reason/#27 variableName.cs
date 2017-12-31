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

    public class variableName{

        static bool method(string name) {

            // first: [a-z|A-Z|_] , verify if is a letter or a _
            // then: [a-z|A-Z|_|0-9]* , verify 0 or more letters, _, or digits
            Regex regex = new Regex(@"^[a-z|A-Z|_][a-z|A-Z|_|0-9]*$");

            // try to math the pattern
            Match match = regex.Match(name);

            return ( match.Success );
        }

        static void Main(string[] args)
        {
            Console.WriteLine( method( Console.ReadLine() ) );
        }
    }
}
