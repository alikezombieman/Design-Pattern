using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_patterns.Builder
{
    public class HouseBuilder : StructureBuilder
    {
        public override void SetDoors()
        {
            structure.Doors = 8;
        }

        public override void SetFloors()
        {
            structure.Floors = 2;
        }

        public override void SetRoof()
        {
            structure.Roof = 1;
        }

        public override void SetRooms()
        {
            structure.Rooms = 8;
        }

        public override void SetStructureType()
        {
            structure.StructureType = "House";
        }

        public override void SetWalls()
        {
            structure.Walls = 4;
        }

        public override void SetWindows()
        {
            structure.Windows = 10;
        }
    }
}
