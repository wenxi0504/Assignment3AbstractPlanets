using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment3AbstractPlanets
{
    class GiantPlanet:Planet
    { 
        // Private Instance Variables
        private string m_type="ice";

        public GiantPlanet(string name, double diameter, double mass, string type)
         :base(name,diameter,mass)
        {
            m_type = type;

        }

        public  bool HasMoons(int MoonCount)
        {
            if (MoonCount > 0)
            {
                return true;
            }
            return false;
        }

        public bool HasRings(int RingCount)
        {
            if (RingCount > 0)
            {
                return true;
            }
            return false;
        } 

    }
}
