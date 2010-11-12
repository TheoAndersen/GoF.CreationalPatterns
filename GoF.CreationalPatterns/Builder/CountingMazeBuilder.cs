using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GoF.CreationalPatterns.Builder
{
    public class CountingMazeBuilder : MazeBuilder
    {
        int doors;
        int rooms;

        public int Doors 
        { 
            get
            {
                return doors;
            }
        }

        public int Rooms
        {
            get
            {
                return rooms;
            }
        }

        public CountingMazeBuilder()
        {
            doors = 0;
            rooms = 0;
        }

        public override void BuildMaze()
        {
            
        }

        public override void BuildRoom(int roomNumber)
        {
            rooms++;
        }

        public override void BuildDoor(int roomFrom, int roomTo)
        {
            doors++;
        }

        public override Maze GetMaze()
        {
            return null;
        }
    }
}
