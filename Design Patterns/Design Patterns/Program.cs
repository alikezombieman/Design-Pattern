using Design_patterns.Builder;
using Design_patterns.Decorator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_patterns
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Structure Hotel = CreateHotel();
            PrintHotel(Hotel);

            Structure House = CreateHouse();
            PrintHouse(House);

            IComponent structure = new Component();

            Print(structure);
            Print(new AddStaff(structure));
            Print(new AddStaff(new AddFurniture(structure)));

            PrintHotelWithStaff(Hotel, structure);

        }

        private static void PrintHotelWithStaff(Structure Hotel, IComponent structure)
        {
            PrintHotel(Hotel);
            Print(new AddStaff(structure));
        }

        private static Structure CreateHotel()
        {
            StructureBuilder HotelBuilder = new HotelBuilder();
            Director dir = new Director();
            Structure Hotel = dir.GenerateStructure(HotelBuilder);
            Console.WriteLine("A hotel was created.");
            Console.WriteLine();
            return Hotel;
        }

        private static Structure CreateHouse()
        {
            StructureBuilder Housebuilder = new HouseBuilder();
            Director dir = new Director();
            
            Structure House = dir.GenerateStructure(Housebuilder);
            Console.WriteLine("A house was created.");
            Console.WriteLine();
            return House;
        }

        private static void PrintHouse(Structure House)
        {
            Console.WriteLine("This is a {0}.", House.StructureType);
            Console.WriteLine("It has: ");
            Console.WriteLine("Doors: {0}", House.Doors);
            Console.WriteLine("Walls: {0}", House.Walls);
            Console.WriteLine("Floors: {0}", House.Floors);
            Console.WriteLine("Windows: {0}", House.Windows);
            Console.WriteLine("Rooms: {0}", House.Rooms);
            Console.WriteLine("Roof: {0}", House.Roof);
            Console.WriteLine();
        }

        private static void PrintHotel(Structure Hotel)
        {
            Console.WriteLine("This is a {0}.", Hotel.StructureType);
            Console.WriteLine("It has: ");
            Console.WriteLine("Doors: {0}", Hotel.Doors);
            Console.WriteLine("Walls: {0}", Hotel.Walls);
            Console.WriteLine("Floors: {0}", Hotel.Floors);
            Console.WriteLine("Windows: {0}", Hotel.Windows);
            Console.WriteLine("Rooms: {0}", Hotel.Rooms);
            Console.WriteLine("Roof: {0}", Hotel.Roof);
            Console.WriteLine();
        }

        static void Print(IComponent a)
        {
            Console.WriteLine(a.Operation());
            Console.WriteLine();
        }
    }
}
