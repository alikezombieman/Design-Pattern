using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_patterns.Builder
{
    public abstract class StructureBuilder
    {
        public Structure structure;
        public void CreateStructure()
        {
            structure = new Structure();
        }

        public abstract void SetStructureType();
        public abstract void SetWalls();
        public abstract void SetWindows();
        public abstract void SetDoors();
        public abstract void SetRoof();
        public abstract void SetFloors();
        public abstract void SetRooms();

        public Structure GetStructure()
        {
            return structure;
        }

    }
}
