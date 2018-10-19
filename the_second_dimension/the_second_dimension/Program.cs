using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace the_second_dimension
{
    class Program
    {
        //create a 2d array 
        public static int[,] board = new int[4, 4]
        {
            {5,-4,3,0 },
            {5,1,-2,-1},
            {8,6,-7,4},
            {-2,1,-5,2},
        };

        static void Main(string[] args)
        {
            nestedLoop();

            //Console.WriteLine(board[0,0]+board[1,1]+board[2,2]+board[3,3]);
            Console.ReadKey();
        }

        static void nestedLoop()
        {
            int sum = 0;
            // use nested loops to iterate through the array to get the index of each number in the diagonal position
            for (int x = 0; x < (board.GetLength(0))-1; x++)
            {

                for (int y = 0; y < (board.GetLength(1)) - 1; y++)
                {
                    if (board[x, y] % 2 == 0)
                    {
                        //i couldn't figure out the math for this. :( I ran out of time 
                        sum += board[x, y];
                        Console.WriteLine(sum);
                    }

                }


            }
           
        }

    }
}