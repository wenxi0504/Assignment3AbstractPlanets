using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Assignment3AbstractPlanets
{   // TerrestrialPlanet is a subclass of the Plant
    class TerrestrialPlanet: Planet,IHasMoons,IHabitable
    { // Private Instance Variable
        private bool m_oxygen;

     // Constructor
     public TerrestrialPlanet(string name, double diameter, double mass, bool oxygen)
         : base(name, diameter, mass)
     {
         m_oxygen = oxygen;

     }
     public bool HasMoons()
     {
         if (MoonCount > 0)
         {
             return true;
         }
         return false;
     }

     public bool Habitable()
     {

         if (m_oxygen = true)
         {
             return true;
         }

         return false;
     }

     

     


    }
}
