
namespace Galactica
{
    //inherting from Planet class
    // And this class is SEALED as we do not want MOON class to be instantiated further

    internal sealed class Moon:Planet
    {

        public Planet Orbiting { get; set; }

        // OVERLOADING Distance method
        internal int Distance(int x1,int y1,int x2,int y2)
        {
            int result = x1 + y1 + x2 + y2;
                
            return result;
          
        }
        
    }
}

