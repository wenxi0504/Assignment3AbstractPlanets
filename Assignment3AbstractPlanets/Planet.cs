using System;
using System.Collections.Generic;
using System.Text;
using System.Transactions;

namespace Assignment3AbstractPlanets
{   // class Planet is a superclass
    class Planet
    { // Private Instance Variables
        private double m_diameter, m_mass, m_orbitalPeriod, m_rotationPeriod;
        private int m_moonCount, m_ringCount;
        private string m_name;

        /*Public Properties: get:it create a parameter then returns to backing field
        set: it creates a method with a parameter name value*/ 
        // readonly
        public double Diameter
        {
            get { return m_diameter; }
            
        }
        // readonly
        public double Mass
        {
            get { return m_mass; }
            
        }

        public int MoonCount
        {
            get { return m_moonCount; }
            set { m_moonCount = value; }
        }
        // readonly
        public string Name
        {
            get { return m_name;}
          
        }

        public double OrbitalPeriod
        {
            get { return m_orbitalPeriod; }
            set { m_orbitalPeriod = value; }
        }

        public int RingCount
        {
            get { return m_ringCount; }
            set { m_ringCount = value; }
        }

        public double RotationPeriod
        {
            get { return m_rotationPeriod; }
            set { m_rotationPeriod = value; }
        }
         
        // Constructor:to initialize the objects
        public Planet (string name, double diameter, double mass)
        {
            m_name = name;
            m_diameter = diameter;
            m_mass = mass;

        }

        //This method is overridden so that the object values can be returned.
        //Declare a ToString method and Implement the method so that it returns a string.
        public override string ToString()
        {
            return $"{Name}\t{Diameter}\t,{Mass}";
        }




    }
}
