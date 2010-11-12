using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GoF.CreationalPatterns
{
    public class Door : MapSite
    {
        Room room1;
        Room room2;
        bool isOpen;

        public Door(Room room1, Room room2)
        {
            this.room1 = room1;
            this.room2 = room2;
        }

        public Room OtherSideFrom(Room room)
        {
            if (room.Equals(room1))
                return room2;
            else if (room.Equals(room2))
                return room1;
            else
                return null;
        }

        public override void Enter()
        {
        }
    }
}
