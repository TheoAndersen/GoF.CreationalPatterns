using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GoF.CreationalPatterns.FactoryMethod
{
    public class FactoryMethodMazeGame
    {
        protected virtual Maze MakeMaze()
        {
            return new Maze();
        }

        protected virtual Room MakeRoom(int roomNumber)
        {
            return new Room(roomNumber);
        }

        protected virtual Wall MakeWall()
        {
            return new Wall();
        }

        protected virtual Door MakeDoor(Room r1, Room r2)
        {
            return new Door(r1, r2);
        }

        public Maze CreateGame()
        {
            Maze aMaze = MakeMaze();
            Room r1 = MakeRoom(1);
            Room r2 = MakeRoom(2);
            Door theDoor = MakeDoor(r1, r2);

            aMaze.AddRoom(r1);
            aMaze.AddRoom(r2);

            r1.SetSide(Direction.North, MakeWall());
            r1.SetSide(Direction.South, theDoor);
            r1.SetSide(Direction.East, MakeWall());
            r1.SetSide(Direction.West, MakeWall());

            r2.SetSide(Direction.North, MakeWall());
            r2.SetSide(Direction.South, MakeWall());
            r2.SetSide(Direction.East, MakeWall());
            r2.SetSide(Direction.West, theDoor);

            return aMaze;
        }
    }
}
