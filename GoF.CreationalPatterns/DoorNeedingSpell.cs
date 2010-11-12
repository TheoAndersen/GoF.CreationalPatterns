using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GoF.CreationalPatterns
{
    public class DoorNeedingSpell : Door
    {
        public DoorNeedingSpell(Room r1, Room r2) : base(r1, r2)
        {

        }
    }
}
