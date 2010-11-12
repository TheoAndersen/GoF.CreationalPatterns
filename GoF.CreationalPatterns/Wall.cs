using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GoF.CreationalPatterns
{
    public class Wall : MapSite
    {
        public override void Enter()
        {

        }

        #region Needed For Prototype pattern

        public Wall Clone()
        {
            return (Wall)this.MemberwiseClone();
        }

        #endregion
    }
}
