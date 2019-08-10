using System;

namespace TheatreSquare
{
    class Program
    {
        
        static void Main(string[] args)
        {
            var line = Console.ReadLine();
            var data = line.Split(' ');
            var length = long.Parse(data[0]); //width 
            var width = long.Parse(data[1]); //length
            var sq_length = long.Parse(data[2]); //sq_length
            long result = length / sq_length;
            long tiles;
            if (result%2 == 0)
            {
                tiles = result * width;
                Console.WriteLine(tiles);
            }
            else
            {
                tiles = (result+1) * width;
                Console.WriteLine(tiles);
            }

        }
    }
}
