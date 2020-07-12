using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment3AbstractPlanets
// GiantPlant is a subclass inheriting from Plant class 
{ // GiantPlant class implements both IHasMoons and IHasRings interface
    class GiantPlanet:Planet,IHasMoons,IHasRings
                     
    { 
        // Private Instance Variables
        private string m_type="ice";

        //Constructor:to initialize the GiantPlanet object
        //take all the parameters of the Planet base class
        //type as a local variable and set the related instance variables

        public GiantPlanet(string name, double diameter, double mass, string type)
         :base(name,diameter,mass)
        {
            m_type = type;

        }
        // implement the interface IHasMoons member
        public  bool HasMoons()
        {
            if (MoonCount> 0)
            {
                return true;
            }
            return false;
        }
        // implement the interface IHasRings member
        public bool HasRings()
        {
            if (RingCount > 0)
            {
                return true;
            }
            return false;
        }


       
    }
}
