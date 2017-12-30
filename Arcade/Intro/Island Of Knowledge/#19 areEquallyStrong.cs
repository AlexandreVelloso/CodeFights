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

    public class areEquallyStrong{

        static bool method(int yourLeft, int yourRight, int friendsLeft, int friendsRight) {
			
			return( 
				(yourLeft == friendsLeft && yourRight == friendsRight) ||
				( yourLeft == friendsRight && yourRight == friendsLeft )
			);
		}

        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
			int[] values = Array.ConvertAll( input, Int32.Parse );
			
			Console.WriteLine( method( values[0],values[1],values[2],values[3]) );
        }
    }
}