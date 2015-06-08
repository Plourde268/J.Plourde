using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ArrayExtensions
{
    class Program
    {

        static void Main(string[] args)
        {
            string Hamlet = Regex.Replace(File.ReadAllText("ham.txt").Replace("\r\n", " "), @"[^\w\s]", "");
            List<string> ignoreList = new List<string> { "the", "and", "to", "a" };
            i
            var result = hamletFile
                .Split(' ')
                .Where(t => !string.IsNullOrWhiteSpace(t) &&
                    !ignoreList.Any(i => t.IndexOf(i, 0, StringComparison.CurrentCultureIgnoreCase) !=-1))
                .GroupBy(t => t, StringComparer.InvariantCultureIgnoreCase)
                .OrderByDescending(t => t.Count());


            Console.WriteLine("The most used not boring word was\"{0}\" and it was used {1} times.", result.Key, result.Count());
            Console.ReadLine
        }
    }
}
