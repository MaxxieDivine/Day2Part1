using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Day3Part1
{
    class Program
    {

        static void Main()
        {
            //
            // It will free resources on its own.
            //
            //int counter = 0;
            //string line;
            //Looks like we need a list of points (x,y)
            //switch/case
            //if >...x++
            //if v...y--
            //if <...x--
            //if ^...y++

            int x = 1;
            int y = 0;
            string s = ">^^v^<>v<<<v";
            foreach(char c in s)
            {
                Console.WriteLine(c);
                if(c.ToString() == ">")
                {
                    x++;
                    break;
                }
                if (c.ToString() == "v")
                {
                    y--;
                    break;
                }
                if (c.ToString() == "<")
                {
                    x--;
                    break;
                }
                if (c.ToString() == "^")
                {
                    y++;
                    break;
                }
            }


            // Read the file and display it line by line.
            /*System.IO.StreamReader file = new System.IO.StreamReader("input.txt");
            while ((line = file.Read().ToString()) != null)
            {
                int temp = file.Read();
                string s = temp.ToString();
                Console.WriteLine(s);
            }

            file.Close();*/
        }
    }
}
