using System;

namespace Assignment3AbstractPlanets
{
    class Program
    {
        //--Author's name:Wen Xu
        //--Author’s student number:301098127,
        //--Date last Modified:12,July,2020,
        //--Program description:1.0.0 version is to create four classes(Planet,GiantPlanet,TerrestrialPlanet,Program)
        //and three interfaces(IHasMoons,IHasRings,Ihabitable).The output should display giantPlanet's attributes
        //(name,diameter and mass) as well as terrestrialPlanet's attributes(name, diameter and mass)
        //--Revision History:1.0.0
        // Implement method WaitForAnyKey
       

        static void Main(string[] args)
        {   // implement GiantPlanet class
            GiantPlanet giantPlanet=new GiantPlanet("Jupiter", 139820,1.898E27, "ice");
            Console.WriteLine(giantPlanet.ToString());
           

            // Implement TerrestrialPlant class
            TerrestrialPlanet terrestrialPlanet=new TerrestrialPlanet("Mars", 6779, 6.39E23, false);
            Console.WriteLine(terrestrialPlanet.ToString());


            static void WaitForAnyKey()
            {
                Console.ReadKey();
            }

        }
    }
}
