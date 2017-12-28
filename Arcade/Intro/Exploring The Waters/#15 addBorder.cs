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

    public class addBorder{

        static string[] method(string[] picture)
        {
            // add 2 lines for the border
            string[] borderPicture = new string[picture.Length + 2];

            // fill the first line
            borderPicture[0] = "**";
            for (int i = 0; i < picture[0].Length; i++)
            {
                borderPicture[0] += '*';
            }

            // last line
            borderPicture[borderPicture.Length - 1] = borderPicture[0];

            // fill the res array
            for (int i = 1; i <= picture.Length; i++)
            {
                // concat * at line i
                borderPicture[i] = '*' + picture[i-1] + '*';
            }

            return borderPicture;
        }

        static void Main(string[] args)
        {
            int numLinhas = Convert.ToInt32(Console.ReadLine());
            string[] vetor = new string[numLinhas];

            for( int i = 0; i < numLinhas; i++)
            {
                vetor[i] = Console.ReadLine();
            }

            string[] resultado = method(vetor);
            
            for( int i = 0; i < resultado.Length; i++)
            {
                Console.WriteLine(resultado[i]);
            }
        }
    }
}
