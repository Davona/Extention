using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extention
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = "Barev";
            Console.WriteLine(word.FirstAndLast());
            string newword = word.GetLettersOfOddIndex();
            Console.WriteLine(newword);
            List<int> list= new List<int>()
            { 5, 7,5,8,6,3,9};
            bool aresult = list.IsNullOrEmpty();
            int value = list.GetMiddelValue();
            Console.WriteLine(value);
        }
    }
}
