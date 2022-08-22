using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abhilash
{
    internal class ques3
    {
        public static bool isVowel(char ch)
        {
            ch = char.ToUpper(ch);
            return (ch == 'A' || ch == 'E' ||
                    ch == 'I' || ch == 'O' ||
                                 ch == 'U');
        }
        public static int CountVowels(string str)
        {
            int count = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (isVowel(str[i]))
                {
                    count++;
                }
            }
            return count;
        }
        public static void Main(string[] args)
        {
            string str = "Abhilash";
            Console.WriteLine(CountVowels(str));

        }
        }
    }

