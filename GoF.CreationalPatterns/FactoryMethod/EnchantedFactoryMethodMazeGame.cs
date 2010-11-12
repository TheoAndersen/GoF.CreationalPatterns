using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GoF.CreationalPatterns.FactoryMethod
{
    public class EnchantedFactoryMethodMazeGame : FactoryMethodMazeGame
    {
        protected override Room MakeRoom(int roomNumber)
        {
            return new EnchantedRoom(roomNumber, MakeSpell());
        }

        protected override Door MakeDoor(Room r1, Room r2)
        {
            return new DoorNeedingSpell(r1, r2);
        }

        private Spell MakeSpell()
        {
            return new Spell();
        }
    }
}
