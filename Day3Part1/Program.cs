using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;

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
            //Looks like we need a dictionary of points (x,y)
            //switch/case
            //if >...x++
            //if v...y--
            //if <...x--
            //if ^...y++
            Point point = new Point();
            List<Point> list = new List<Point>();
            
            int x = 0;
            int y = 0;
            string s = File.ReadAllText("input.txt");
            //string s = ">v<^";
            int count = 0;

            if (list.Count == 0)
            {
                point.X = x;
                point.Y = y;
                list.Add(point);
            }

            foreach (char c in s)
            {
                

                //Console.WriteLine(c);
                if(c.ToString() == ">")
                {
                    x++;
                    point.X = x;
                    Console.WriteLine(x + "," + y);
                    foreach (Point p in list)
                    {
                        if(p.X == point.X && p.Y == point.Y)
                        {
                            Console.WriteLine("There was a dupe!");
                            continue;
                        }
                        else
                        {
                            list.Add(point);
                            count++;
                            break;
                        }
                    }
                    
                }
                if (c.ToString() == "v")
                {
                    y--;
                    point.Y = y;
                    Console.WriteLine(x + "," + y);
                    foreach (Point p in list)
                    {
                        if (p.X == point.X && p.Y == point.Y)
                        {
                            Console.WriteLine("There was a dupe!");
                            continue;
                        }
                        else
                        {
                            list.Add(point);
                            count++;
                            break;
                        }
                    }
                    
                }
                if (c.ToString() == "<")
                {
                    x--;
                    point.X = x;
                    Console.WriteLine(x + "," + y);
                    foreach (Point p in list)
                    {
                        if (p.X == point.X && p.Y == point.Y)
                        {
                            Console.WriteLine("There was a dupe!");
                            continue;
                        }
                        else
                        {

                            list.Add(point);
                            count++;
                            break;
                        }
                    }
                }
                if (c.ToString() == "^")
                {
                    y++;
                    point.Y = y;
                    Console.WriteLine(x + "," + y);
                    foreach (Point p in list)
                    {
                        if (p.X == point.X && p.Y == point.Y)
                        {
                            Console.WriteLine("There was a dupe!");
                            continue;
                        }
                        else
                        {
                            list.Add(point);
                            count++;
                            break;
                        }
                    }
                    
                }

                
            }
            Console.WriteLine("X Value = " + x);
            Console.WriteLine("Y Value = " + y);

            Console.WriteLine("The number of houses is: " + count);



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
