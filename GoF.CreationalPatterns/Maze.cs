using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GoF.CreationalPatterns
{
    public class Maze
    {
        public List<Room> rooms;

        public Maze()
        {
            rooms = new List<Room>();
        }

        public void AddRoom(Room room)
        {
            rooms.Add(room);
        }

        public Room RoomNumber(int number)
        {
            return rooms.Find(r => r.roomNo == number);
        }
    }
}
