using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment3AbstractPlanets
{ // GiantPlant class implements both IHasMoons and IHasRings interface
    class GiantPlanet:Planet,IHasMoons,IHasRings
                     
    { 
        // Private Instance Variables
        private string m_type="ice";

        public GiantPlanet(string name, double diameter, double mass, string type)
         :base(name,diameter,mass)
        {
            m_type = type;

        }

        public  bool HasMoons()
        {
            if (MoonCount> 0)
            {
                return true;
            }
            return false;
        }

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
