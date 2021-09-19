using System;
using Tetris;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums1 = new int[5];
            nums1[0] = 1;
            nums1[1] = 2;

            //for(int i = 0; i < nums1.length; i++)
            //{
            //    console.writeline(nums1[i]);
            //}

            //foreach(int i in nums1)
            //{
            //    console.writeline(i);
            //}

            //point[] points = new point[3];
            //points[0] = new point(1, 2, '*');
            //points[1] = new point(3, 4, '#');
            //points[2] = new point(5, 6, '*');

            //foreach(point p in points)
            //{
            //    p.draw();
            //}

            //char[][] field = new char[3][];
            //field[0] = new char[3];
            //field[1] = new char[3];
            //field[2] = new char[3];

            //field[0][1] = '_';
            //field[1][0] = '|';
            //field[1][1] = '_';
            //field[1][2] = '|';



            for (int i = 0; i < field.Length; i++)
            {
                for(int j = 0; j < field[i].Length; j++)
                {
                    Console.Write(field[i][j]);
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
