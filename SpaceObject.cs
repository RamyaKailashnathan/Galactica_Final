
namespace Galactica
{
    internal abstract class SpaceObject
    {
        private int id;
        private string name;

        private string position;
        private int x, y;

        public enum StarType { YellowDwarf, White, BlueNeutron, RedGiant }

        // Properties
        public int ID { get; set; }
        public string Name { get; set;}
        public string Position
        { get;
            set; }
        
    }
}

