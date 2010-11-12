using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GoF.CreationalPatterns.Builder
{
    public class StandardMazeBuilder : MazeBuilder
    {
        private Maze currentMaze;

        public override void BuildMaze()
        {
            currentMaze = new Maze();
        }

        public override void BuildRoom(int roomNumber)
        {
            if (currentMaze.RoomNumber(roomNumber) == null)
            {
                Room room = new Room(roomNumber);
                currentMaze.AddRoom(room);

                room.SetSide(Direction.North, new Wall());
                room.SetSide(Direction.South, new Wall());
                room.SetSide(Direction.East, new Wall());
                room.SetSide(Direction.West, new Wall());
            }
        }

        public override void BuildDoor(int n1, int n2)
        {
            Room r1 = currentMaze.RoomNumber(n1);
            Room r2 = currentMaze.RoomNumber(n2);
            Door d = new Door(r1, r2);

            r1.SetSide(Direction.North, d);
            r2.SetSide(Direction.South, d);
        }

        public override Maze GetMaze()
        {
            return currentMaze;
        }
    }
}
