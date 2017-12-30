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

    public class isIPv4Address{

		bool isValido(string num)
		{
			int n = Int32.Parse(num);

			return (n >= 0 && n <= 255);
		}

		bool method(string inputString)
				{
			// [0-9] numero entre 0 e 9
			// {1,3} de 1 a 3 numeros
			// \. verifica se existe 1 caractere '.'
			// $ final da String
			Regex regex = new Regex(@"^[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}$");

			// tenta dar Match no regex
			Match match = regex.Match(inputString);

			bool isCorreto = false;

			// se a expressao regular deu certo
			if (match.Success)
			{
				// separa os numeros e verifica se eles estao entre 0 e 255
				string[] numbers = inputString.Split('.');

				if (isValido(numbers[0]) && isValido(numbers[1]) &&
					isValido(numbers[2]) && isValido(numbers[3]))
				{

					isCorreto = true;
				}
			}

			return isCorreto;
		}

        static void Main(string[] args)
        {
			string input = Console.ReadLine()
			
			Console.WriteLine( method(input) );
        }
    }
}