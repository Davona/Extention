using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extention
{
    public static class Extentions
    {
        public static string FirstAndLast(this string letter)
        {
            string word = "";
            if (letter.Length == 1)
            {
                word = letter;
            }
            else
            {
                word = word + letter[0] + letter[letter.Length - 1];
            }
            return word;
        }
        public static string GetLettersOfOddIndex(this string word) 
        {
            string letter = "";
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i]%2==0)
                {
                    letter = letter + word[i];
                }
            }
            return letter;
        }
        public static bool IsNullOrEmpty<T> (this List<T> source ) 
        {
            bool result = false;
            if (source==null||source.Count==0)
            {
                result = true;
            }
            return result;
        }
        public static T GetMiddelValue<T>(this List<T> source) 
        {
            T value=default(T);
            if (source.Count%2!=0)
            {
                value = source[source.Count / 2];
            }
            else
            {
                value = source[source.Count / 2];
            }
            return value;
        }
        

    }
}
