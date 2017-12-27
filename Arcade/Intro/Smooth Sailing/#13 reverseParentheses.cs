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

    public class reverseParentheses{

        public static string invert( string s ){
                string inverted = "";
                for( int i = s.Length-1; i >= 0; i-- ){
                        inverted += s[i];
                }

                return inverted;
        }

        public static string method(string s) {

                while( s.IndexOf('(') != -1 ){

                        int indexOpen = s.LastIndexOf('(');
                        // string to be inverted
                        string toInvert = "";
                        string reversed = "";

                        // get all string between ( )
                        for( int i = indexOpen+1; s[i] != ')'; i++ ){
                                toInvert += s[i];
                        }

                        // invert the string
                        toInvert = invert( toInvert );

                        // save all before (
                        for( int i = 0; i < indexOpen; i++ ){
                                reversed += s[i];
                        }

                        // save inverted string
                        for( int i = 0; i < toInvert.Length; i++ ){
                                reversed += toInvert[i];
                        }
                        // save all after )
                        for( int i = indexOpen + toInvert.Length + 2; i < s.Length; i++ ){
                                reversed += s[i];
                        }

                        s = reversed;
                }

                return s;
        }

        /**
        * Essa versao do codigo eu peguei como base
        * a do grey_h https://codefights.com/profile/grey_h
        * ele fez em python, e eu adaptei para C#
        */
        public static string method_rec(string s) {

            int start = 0, end = 0;

            for( int x = 0; x < s.Length; x++ ){

                    if( s[x] == '(' ){
                            start = x;
                    }else if( s[x] == ')' ){
                            end = x;

                            string reversed = "";

                            // save all before (
                            for( int i = 0; i < start; i++ ){
                                    reversed += s[i];
                            }

                            // save inverted string
                            for( int i = end-1; i > start; i-- ){
                                    reversed += s[i];
                            }
                            // save all after )
                            for( int i = end+1; i < s.Length; i++ ){
                                    reversed += s[i];
                            }

                            return method_rec( reversed );
                    }
            }

            return s;
        }

        public static void Main( string[] args ){
            string input = Console.ReadLine();
            Console.WriteLine( method(input) );
        }
    }
}
