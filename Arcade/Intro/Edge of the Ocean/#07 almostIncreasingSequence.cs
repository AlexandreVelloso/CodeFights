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

    public class almostIncreasingSequence{

        // metodo para resolver o problema
        public static bool method(int[] sequence) {

            int count = 0;
            bool sequenciaContinua = true;

            for( int i = 0; i < sequence.Length-1; i++ ){

                // se o numero for maior do que o proximo:
                //  3 2
                if( sequence[i] >= sequence[i+1] ){

                    // conta o numero de numeros maiores que o proximo
                    count++;

                    // se nao for o 1 numero( para evitar erros )
                    if( i > 0 ){

                        // eu encontrei um numero que e' um erro:
                        // 2 4 3
                        if( sequence[i-1] >= sequence[i+1] ){

                            // se existir 2 numeros a frente
                            if( i+2 < sequence.Length ){

                                // se esses NAO numero se encaixarem:
                                // 2 4 3 4
                                // eu nao posso fazer
                                if( sequence[i] >= sequence[i+2] ){
                                    sequenciaContinua = false;
                                    break;
                                }

                            // se nao cair em nenhum dos casos, falha
                            }else if( count > 1 ){
                                // se nao cair em nenhum dos outros casos, sequencia falha
                                sequenciaContinua = false;
                                break;
                            }
                        }
                    }

                }
            }

            return ( count < 2 && sequenciaContinua );
        }

        public static void Main( string[] args ){

            string[] input = Console.ReadLine().Split(' ');
            int[] sequence = Array.ConvertAll( input, Int32.Parse );

            Console.WriteLine( method(sequence) );
        }

    }
}
