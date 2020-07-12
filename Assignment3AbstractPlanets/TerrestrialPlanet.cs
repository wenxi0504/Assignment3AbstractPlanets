using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Assignment3AbstractPlanets
{
    class TerrestrialPlanet: Planet
    { // Private Instance Variable
        private bool m_oxygen;

     // Constructor
     public TerrestrialPlanet(string name, double diameter, double mass, bool oxygen)
         : base(name, diameter, mass)
     {
         m_oxygen = oxygen;

     }
     public bool HasMoons(int MoonCount)
     {
         if (MoonCount > 0)
         {
             return true;
         }
         return false;
     }

     public bool Habitable( bool oxygen)
     {

         if (oxygen =true)
         {
             return true;
         }

         return false;
     }

     

     


    }
}
