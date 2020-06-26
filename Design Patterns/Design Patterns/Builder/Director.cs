using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_patterns.Builder
{
    class Director
    {
        public Structure GenerateStructure(StructureBuilder structureBuilder)
        {
            structureBuilder.CreateStructure();
            structureBuilder.SetStructureType();
            structureBuilder.SetWalls();
            structureBuilder.SetFloors();
            structureBuilder.SetRoof();
            structureBuilder.SetRooms();
            structureBuilder.SetDoors();
            structureBuilder.SetWindows();

            return structureBuilder.GetStructure();
        }
    }
}
