using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars_Testing1_2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // https://www.codewars.com/kata/54bf85e3d5b56c7a05000cf9/
        }

        // First solution
        public static List<string> Number(List<string> lines, int ctr = 0) => lines.Select(x => x = $"{++ctr}: {x}").ToList();

        // Refactored version
        public static List<string> NumberTwo(List<string> lines, int ctr = 0) => lines.ConvertAll(x => x = $"{++ctr}: {x}");

        // Third version
        public static List<string> NumberThree(List<string> lines) => lines.Select((x, i) => $"{i + 1}: {x}").ToList();
        // This version does not work with .ConvertAll since it uses more than just x.
    }
}
