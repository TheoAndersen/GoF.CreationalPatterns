using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GoF.CreationalPatterns.Builder
{
    public abstract class MazeBuilder
    {
        public abstract void BuildMaze();
        public abstract void BuildRoom(int roomNumber);
        public abstract void BuildDoor(int roomFrom, int roomTo);
        public abstract Maze GetMaze();
    }
}
