using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLot
{
    public class ParkingSystem
    {
        private int bigSlots;
        private int mediumSlots;
        private int smallSlots;

        public ParkingSystem(int big, int medium, int small)
        {
            bigSlots = big;
            mediumSlots = medium;
            smallSlots = small;
        }

        public bool AddCar(int carType)
        {
            switch (carType)
            {
                case 1: // Big car
                    if (bigSlots > 0)
                    {
                        bigSlots--;
                        return true;
                    }
                    break;
                case 2: // Medium car
                    if (mediumSlots > 0)
                    {
                        mediumSlots--;
                        return true;
                    }
                    break;
                case 3: // Small car
                    if (smallSlots > 0)
                    {
                        smallSlots--;
                        return true;
                    }
                    break;
            }
            return false; // No available slot for the specified car type
        }

        public static void Main()
        {
            // Example usage
            ParkingSystem parkingSystem = new ParkingSystem(1, 1, 0);
            Console.WriteLine($"{parkingSystem.AddCar(1)} because there is 1 available slot for a big car"); // true (big car)
            Console.WriteLine($"{parkingSystem.AddCar(2)} because there is 1 available slot for a medium car"); // true (medium car)
            Console.WriteLine($"{parkingSystem.AddCar(3)} because there is no available slot for a small car"); // false (no small car slot)
            Console.WriteLine($"{parkingSystem.AddCar(1)} because there is no available slot for a big car. It is already occupied."); // false (big car slot already occupied)
            Console.ReadKey();
        }
    }
}
