using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {



            string text = "lorem ipsum dolor sit amet...";

            int number = 420;

            bool variable = true;

            Sample ownclass = new Sample();

            List<char> charList = new List<char>();



            string a = "A";

            string b = a + "B";

            //azaz

            b = "AB";

            //vagy
            







            b += "C";
            text += "hello";

            number += 2;

            variable = !variable;

            ownclass.something += " hello";

            charList.Add('A');
        }
    }
}
