using System;

namespace TheatreSquare{
    
    class Program{
    
        static void Main(string[] args){
            //Taking input
            var line = Console.ReadLine();
            
            //Tokenizing input. Delim -> ' '
            var data = line.Split(' ');
            var length = long.Parse(data[0]); //width 
            var width = long.Parse(data[1]); //length
            var sq_length = long.Parse(data[2]); //sq_length           
            
            //Declaring tiles along length, tiles along width
            long tilesAlongLength, tilesAlingWidth;

            /*Checking if tiles can be placed along the length
            *perfectly. If not, we need an extra tile and thus 
            *adding +1*/
            if (length%sq_length == 0){
                tilesAlongLength = length / sq_length;
            }
            else{
                tilesAlongLength = (length / sq_length) + 1;
            }

            /*Doing the same check for the width*/
            if(width%sq_length == 0){
                tilesAlingWidth = width / sq_length;
            }
            else{
                tilesAlingWidth = (width / sq_length) + 1;
            }

            /*Now we know total number of tiles along length, and 
            *total number of tiles along width. Multiplying both we
            *get total number of tiles in the theatre square 
            */

            long totalTiles = tilesAlingWidth * tilesAlongLength;
            Console.WriteLine(totalTiles);
        }
    }
}
