using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace externalMethods
{
    class MyMethods
    {
        public static int addMe(int one, int two)
        {
            return (one + two);
        }
        public static int addMe(int one, int two, int three)
        {
            return (one + two + three);
        }
        public static string addName(string one, string two)
        {
            return (one + " " + two);
        }
        public static string addName(string one)
        {
            return (one + " " + "NMN");
        }
    }
}
