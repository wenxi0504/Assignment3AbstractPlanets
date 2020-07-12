using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Assignment3AbstractPlanets
{   // TerrestrialPlanet is a subclass of the Plant
    //TerrestrialPlanet class implements both IHasMoons and IHabitable interface
    class TerrestrialPlanet : Planet,IHasMoons,IHabitable
    { // Private Instance Variable
        private bool m_oxygen;

        // Constructor:to initialize the terrestrial object
        //take all the parameters of the Planet base class
        //oxygen as a local variable and set the related instance variable
        public TerrestrialPlanet(string name, double diameter, double mass, bool oxygen)
         : base(name, diameter, mass)
     {
         m_oxygen = oxygen;

     }
        // implement the interface IHasMoons member
        public bool HasMoons()
     {
         if (MoonCount > 0)
         {
             return true;
         }
         return false;
     }
        // implement the interface IHabitable member
        public bool Habitable()
     { 
         return m_oxygen;
     }

     

     


    }
}
