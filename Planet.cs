

namespace Galactica
{
    //inheriting from class SpaceObject
    internal class Planet : SpaceObject
    {
        private string planettype;
        private int diameter_minutes;
        private int revolution_period_hours;
        private int revolution_period_days;

        //List for Moon
        public List<string> Moon = new List<string>();
        
        // Properties
        public string PlanetType { get; set; }
        public int Diameter_minutes { get; set; }
        public int Revolution_period_hours { get; set; }
        public int Revolution_period_days { get; set; }

        //method Distance to calculate the distance between the two stars and this method return a double value
        internal double Distance(int x1, int y1,int x2,int y2)
        {
            //distance = √((x_2 - x_1)²+(y_2 - y_1)²);
            double distance = Math.Sqrt (Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            return distance;
        }
        
    }
}

