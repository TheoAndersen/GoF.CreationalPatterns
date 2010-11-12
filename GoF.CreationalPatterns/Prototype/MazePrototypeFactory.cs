using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GoF.CreationalPatterns.AbstractFactory;

namespace GoF.CreationalPatterns.Prototype
{
    public class MazePrototypeFactory : MazeFactory
    {
        Maze prototypeMaze;
        Room prototypeRoom;
        Door prototypeDoor;
        Wall prototypeWall;

        public MazePrototypeFactory(Maze maze, Room room, Door door, Wall wall)
        {
            this.prototypeMaze = maze;
            this.prototypeRoom = room;
            this.prototypeDoor = door;
            this.prototypeWall = wall;
        }

        public override Maze MakeMaze()
        {
            return prototypeMaze.Clone();
        }

        public override Room MakeRoom(int n)
        {
            return prototypeRoom.Clone(n);
        }

        public override Wall MakeWall()
        {
            return prototypeWall.Clone();
        }

        public override Door MakeDoor(Room r1, Room r2)
        {
            return prototypeDoor.Clone(r1, r2);
        }
    }
}
