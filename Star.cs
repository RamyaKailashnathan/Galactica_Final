
using System.Xml.Linq;

namespace Galactica
{
   internal class Star:SpaceObject
    {
        private StarType type;
        private double tempearture;
        private double coordinates;
        
        // Enum Planettype creation
        public enum PlanetType { Terrestial, Giant, Dwarf, Gas_Giant }

        //List for planets
        public List<string> Planet = new List<string>();

        // Properties
        public StarType Type { get; set; }
        public double temperature { get; set; }

        public double Coordinates{
            get
            {
                return coordinates;
            }
            set
            {
                // coordinates value set to 0.0 
                coordinates = 0.0;
            }
            

        }
    }
}

