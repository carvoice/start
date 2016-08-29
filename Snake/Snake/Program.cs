using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(2, 3, '*');
            p1.Draw();
            
            Point p2 = new Point(2, 4, '*');
            p2.Draw();

            Point p3 = new Point(3, 2, '*');
            p3.Draw();

            Point p4 = new Point(3, 5, '*');
            p4.Draw();

            Point p5 = new Point(4, 2, '*');
            p5.Draw();

            Point p6 = new Point(4, 6, '*');
            p6.Draw();

            Point p7 = new Point(5, 3, '*');
            p7.Draw();

            Point p8 = new Point(5, 7, '*');
            p8.Draw();

            Point p9 = new Point(6, 2, '*');
            p9.Draw();

            Point p10 = new Point(6, 6, '*');
            p10.Draw();

            Point p11 = new Point(7, 2, '*');
            p11.Draw();

            Point p12 = new Point(7, 5, '*');
            p12.Draw();

            Point p13 = new Point(8, 3, '*');
            p13.Draw();

            Point p14 = new Point(8, 4, '*');
            p14.Draw();

            Console.ReadLine();

            List<char> charList = new List<char>();
            charList.Add('*');
            charList.Add('#');
            charList.Add('^');
            charList.Add('&');
            charList.Add('%');
                        
            int x = charList[0];
            int y = charList[1];
            int z = charList[2];
            int a = charList[3];
            int b = charList[4];

            charList.RemoveAt(2);

            foreach(char i in charList)
            {
                Console.WriteLine(i);
            }

            Console.ReadLine();
                                                
            List<Point> plist = new List<Point>();
            plist.Add(p1);
            plist.Add(p2);
            plist.Add(p3);
            plist.Add(p4);
            plist.Add(p5);
            plist.Add(p6);
            plist.Add(p7);
            plist.Add(p8);
            plist.Add(p9);
            plist.Add(p10);
            plist.Add(p11);
            plist.Add(p12);
            plist.Add(p13);
            plist.Add(p14);                         
                                              
        }
                 
}
    }

