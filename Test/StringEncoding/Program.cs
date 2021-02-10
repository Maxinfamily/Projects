using System;
using System.Collections.Generic;

namespace StringEncoding
{
    class Program
    {
        static void Main(string[] args)
        {
            //In this problem, a string can be encrypted to another string by replacing each character with another throughout the string
            // This encryption is valid as every letter has been "encrypted" to just ONE character.
            // A -> B -- valid
            // A -> G -- valid
            // AA -> BB -- valid
            // AA -> HH -- valid
            // AA -> HJ -- INVALID -- A>H but also A>J
            // AB -> EN -- valid -- A>E, B>N
            // ABA -> ENE -- valid -- A>E, B>N
            // AAABBBAAA -> JJJIIIJJJ -- valid A>J, B>I
            // ABAA -> DFDD -- valid -- A>D, B>F

            //Create a function that returns true if two strings have a valid encryption
            //You may assume the strings are of the same length, and not null or whitespace

            //Test cases 
            //"ABAB", "CDCD", Result = true
            //"AAABBB", "CCCDDD", Result = true
            //"ABCBA", "BCDCB", Result = true
            //"AAAA", "BBBB", Result = true
            //"BAAB", "ABBA", Result = true
            //"BAAB", "QZZQ", Result = true
            //"TTZZVV", "PPSSBB", Result = true
            //"ZYX", "ABC", Result = true
            //"AABAA", "SSCSS", Result = true
            //"AABAABAA", "SSCSSCSS", Result = true
            //"UBUBUBUB", "WEWEWEWE", Result = true
            //"FFGG", "FFGF", Result = false
            //"FFGG", "CDCD", Result = false
            //"FFFG", "GGHI", Result = false
            //"FFFF", "ABCD", Result = false
            //"ABCA", "ABCD", Result = false
            //"ABCAAA", "DDABCD", Result = false

            //AAAAAAA.. 1000000 -> //BCBBBBBBBBB

            Console.WriteLine("The encryption is valid:" + IsValidEncryption("acdacdacd", "xwyxwyxwy"));
        }

        static bool IsValidEncryption(string a, string b)
        {

            Dictionary<char, char> encoding = new Dictionary<char, char>();
            bool isValid = true;

            try
            {
                for (int i = 0; i < a.Length && isValid; i++)
                {
                    if (encoding.ContainsKey(a[i]))
                    {
                        if (encoding[a[i]] != b[i])
                        {
                            isValid = false;
                        }
                    }
                    else if (encoding.ContainsValue(b[i]))
                    {
                        isValid = false;
                    }
                    else
                    {
                        encoding.Add(a[i], b[i]);
                    }
                }
            }
            catch(Exception ex)
            {
                isValid = false;
                Console.WriteLine(ex.Message);
            }

            return isValid;
        }
    }
}
