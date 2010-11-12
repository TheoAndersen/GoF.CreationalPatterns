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


        public Door()
        {


        }

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

        #region Needed For Prototype pattern

        internal void Initialize(Room r1, Room r2)
        {
            this.room1 = r1;
            this.room2 = r2;
        }

        public Door Clone(Room r1, Room r2)
        {
            Door door = (Door)this.MemberwiseClone();
            door.Initialize(r1, r2);
            return door;
        }

        #endregion     
    }
}
