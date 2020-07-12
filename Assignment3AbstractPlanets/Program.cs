using System;

namespace Assignment3AbstractPlanets
{
    class Program
    {
        //--Author's name:Wen Xu
        //--Author’s student number:301098127,
        //--Date last Modified:11,July,2020,
        //Program description:
        //Revision History:

        static void Main(string[] args)
        {   // implement GiantPlanet class
            GiantPlanet giantPlant=new GiantPlanet("Jupiter", 139820,1.898E27, "giant");
            Console.WriteLine(giantPlant.ToString());
           

            // Implement TerrestrialPlant class
            TerrestrialPlanet terrestrialPlanet=new TerrestrialPlanet("Mars", 6779, 6.39E23, false);
            Console.WriteLine(terrestrialPlanet.ToString());
            

            // Implement method WaitForAnyKey
            static void WaitForAnyKey()
            {
                Console.ReadKey();
            }





        }
    }
}
