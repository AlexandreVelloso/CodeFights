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

    public class chessBoardCellColor{

        static bool method(string cell1, string cell2) {
            int letter1 = cell1[0] - 'a';
            int number1 = cell1[1] - '1';

            int letter2 = cell2[0] - 'a';
            int number2 = cell2[1] - '1';

            bool isSameColor;

            // se eles estao no mesmo tipo de numero:
            // par ou impar
            if( (number1 % 2) == (number2 % 2) ){

                // devem estar em colunas de tipos iguais
                if( (letter1 % 2 ) == ( letter2 % 2 ) ){
                    isSameColor = true;
                }else{
                    isSameColor = false;
                }

            }else{
                // se os numeros nao forem do mesmo tipo

                // as letras tem que ser de tipos diferentes
                if( (letter1 % 2 ) != ( letter2 % 2 ) ){
                    isSameColor = true;
                }else{
                    isSameColor = false;
                }
            }

            return isSameColor;
        }

        static void Main(string[] args)
        {
            string cell1 = Console.ReadLine();
            string cell2 = Console.ReadLine();

            Console.WriteLine( method( cell1, cell2 ) );
        }
    }
}
