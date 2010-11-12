using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GoF.CreationalPatterns.AbstractFactory;

namespace GoF.CreationalPatterns
{
    public static class MazeGame
    {
        public static Maze CreateGameInitialSimple()
        {
            Maze aMaze = new Maze();
            Room r1 = new Room(1);
            Room r2 = new Room(2);
            Door theDoor = new Door(r1, r2);

            aMaze.AddRoom(r1);
            aMaze.AddRoom(r2);

            r1.SetSide(Direction.North, new Wall());
            r1.SetSide(Direction.South, theDoor);
            r1.SetSide(Direction.East, new Wall());
            r1.SetSide(Direction.West, new Wall());

            r2.SetSide(Direction.North, new Wall());
            r2.SetSide(Direction.South, new Wall());
            r2.SetSide(Direction.East, new Wall());
            r2.SetSide(Direction.West, theDoor);

            return aMaze;
        }
    }
}
