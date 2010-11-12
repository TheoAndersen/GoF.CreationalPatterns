using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GoF.CreationalPatterns
{
    public class EnchantedRoom : Room
    {
        Spell spell;

        public EnchantedRoom(Spell spell)
        {
            this.spell = spell;
        }

        public EnchantedRoom(int n, Spell spell) : base(n)
        {
            this.spell = spell;    
        }
    }
}
