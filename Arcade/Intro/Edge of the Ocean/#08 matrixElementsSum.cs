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

    public class matrixElementsSum{

        // metodo para resolver o problema
        public static int method(int[][] matrix) {

            // se a coluna for assombrada, vou marcar ela como 0,
            // caso contrario -1
            int[] colunasAssombradas = new int[ matrix[0].Length ];

            // inicializa a matriz de colunasAssombradas com -1
            for( int i = 0; i < colunasAssombradas.Length; i++ ){
                colunasAssombradas[i] = -1;
            }

            int preco = 0;

            for( int i = 0; i < matrix.Length; i++ ){
                for( int j = 0; j < matrix[0].Length; j++ ){

                    // se esse quarto for assombrado
                    // marque a coluna como assombrada
                    if( matrix[i][j] == 0 ){
                        colunasAssombradas[j] = 0;
                    }

                    // se a coluna nao for assombrada
                    // conte o numero
                    if( colunasAssombradas[j] != 0 ){
                        preco += matrix[i][j];
                    }
                }
            }

            return preco;
        }

        public static void Main( string[] args ){

            int numLinhas = Convert.ToInt32( Console.ReadLine() );
            int[][] matrix = new int[ numLinhas ][];

            for( int i = 0; i < numLinhas; i++ ){
                int[] linha = Array.ConvertAll( Console.ReadLine(), Int32.Parse );
                matrix[i] = linha;
            }

            Console.WriteLine( method( matrix ) );
        }

    }
}
