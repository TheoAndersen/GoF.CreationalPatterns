using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GoF.CreationalPatterns
{
    public class Room : MapSite
    {
        public int roomNo;
        MapSite northSide;
        MapSite southSide;
        MapSite westSide;
        MapSite eastSide;


        public Room(int roomNo)
        {
            this.roomNo = roomNo;
        }

        public MapSite GetSide(Direction direction)
        {
            switch (direction)
            {
                case Direction.North:
                    return northSide;
                case Direction.South:
                    return southSide;
                case Direction.East:
                    return eastSide;
                case Direction.West:
                    return westSide;
            }
            return null;
        }

        public void SetSide(Direction direction, MapSite mapSite)
        {
            switch (direction)
            {
                case Direction.North:
                    northSide = mapSite;
                    break;
                case Direction.South:
                    southSide = mapSite;
                    break;
                case Direction.East:
                    eastSide = mapSite;
                    break;
                case Direction.West:
                    westSide = mapSite;
                    break;
                default:
                    break;
            }
        }

        public override void Enter()
        {
            throw new NotImplementedException();
        }
    }
}
