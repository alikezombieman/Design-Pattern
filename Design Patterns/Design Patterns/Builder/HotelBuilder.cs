using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_patterns.Builder
{
    public class HotelBuilder : StructureBuilder
    {
        public override void SetDoors()
        {
            structure.Doors = 110;
        }

        public override void SetFloors()
        {
            structure.Floors = 3;
        }

        public override void SetRoof()
        {
            structure.Roof = 2;
        }

        public override void SetRooms()
        {
            structure.Rooms = 100;
        }

        public override void SetStructureType()
        {
            structure.StructureType = "Hotel";
        }

        public override void SetWalls()
        {
            structure.Walls = 4;
        }

        public override void SetWindows()
        {
            structure.Windows = 110;
        }
    }
}
