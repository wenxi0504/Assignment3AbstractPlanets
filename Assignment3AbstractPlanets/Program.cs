using System;

namespace Assignment3AbstractPlanets
{
    class Program
    {
        static void Main(string[] args)
        {   // implement GiantPlanet class
            GiantPlanet giantPlant=new GiantPlanet("Jupiter", 139820,1.898E27, "giant");
            giantPlant.ToString();

            // Implement TerrestrialPlant class
            TerrestrialPlanet terrestrialPlanet=new TerrestrialPlanet("Mars", 6779, 6.39E23, false);
            terrestrialPlanet.ToString();

            // Implement method WaitForAnyKey
            static void WaitForAnyKey()
            {
                Console.ReadKey();
            }





        }
    }
}
