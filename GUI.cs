// This GUI class will handle Data input and Data insertion in lists

/* InputData() - Asks the user to enter details and insert it in the appropriate list.
 * ShowPlanets() - All the planets info is obtained from the user and distance is calculated using the Distance method in Planet class
 * ShowMoons() -All moon information is obtained from the user and distance is calculated by my own formlula in the OVERLOADED Distance method in the Moon Class
 * 
 */
namespace Galactica
{
    internal class GUI
    {
        
       public void InputData()
        {
            // object creation to access all properties and methods of the class
            Planet planet = new();
            Star star = new();
            Moon moon = new();

            double sun_to_planet_distance;
            // This list will store the Planet Name,Type,Distance to the Sun
            List<string> Planet_Result = new List<string>();
            // This list will store the Moon Name,its own orbitting planet and distance between each other
            List<string> Moon_Result = new List<string>();
            #region Sun_Coordinates Input
            Console.WriteLine("Enter the Position of the Sun in the solarsystem ");
            Console.Write("Enter the Sun's X co-ordinates:");
            int sun_x_coordinate = Convert.ToInt16 (Console.ReadLine());
            Console.Write("Enter the Sun's Y co-ordinates:");
            int sun_y_coordinate = Convert.ToInt16(Console.ReadLine());
            #endregion

            /*Console.Write("Would you like to input details for Planets(Press p) or Moon(Press m)? ");
            string choice = Console.ReadLine();
            if (choice.ToLower() == "p") ShowPlanets();
            else ShowMoon();*/
            ShowPlanets();
            ShowMoon();
            #region ShowPlanets
            void ShowPlanets()
            {

            
            Console.Write("Enter the number of planets in the solar system: ");
            int planet_count = Convert.ToInt32(Console.ReadLine());

            for (int i=0; i < planet_count; i++)
            {
                Console.Write("Enter the planet name:");
                string planet_name = Console.ReadLine();
                // addding the planet in to the Planet list which exists in the Star class
                star.Planet.Add(planet_name);

                Console.Write("Enter the planet type(Terrestial, Giant, Dwarf, Gas_Giant): ");
                planet.PlanetType = Console.ReadLine();

                Console.WriteLine("Enter the {0}  position:",planet_name);
                Console.Write("Enter the {0} X co-ordinates:",planet_name);
                int planet_x_coordinate= Convert.ToInt16(Console.ReadLine());
                Console.Write("Enter the {0} Y co-ordinates:",planet_name);
                int planet_y_coordinate = Convert.ToInt16(Console.ReadLine());

                // Calling the distance method from Planet class
                sun_to_planet_distance= planet.Distance(sun_x_coordinate, sun_y_coordinate, planet_x_coordinate, planet_y_coordinate);
                string planet_result = planet_name+ " planet is " + planet.PlanetType + "type " + sun_to_planet_distance
                    +" light years away from the sun.";

                Planet_Result.Add(planet_result);

                //Console.WriteLine("Distance of planet :{0}to the Sun is {1} .", planet_name, sun_to_planet_distance);
            }
            Console.Clear();
            for (int i= 0; i<Planet_Result.Count();i++)
            {
                
                Console.WriteLine(Planet_Result[i]);
            }

            }
            #endregion

            #region Show Moon
            void ShowMoon()
            {
              
                Console.Write("Enter the name of the moon: ");
                string moon_name = Console.ReadLine();
                // adding the moon name in to the Moon list which is inherited from Planet class 
                planet.Moon.Add(moon_name);
                // Coordinates of the moon 
                Console.WriteLine("Enter the moon  position:" );
                Console.Write("Enter the {0} X co-ordinates:",moon_name);
                int moon_x_coordinate = Convert.ToInt16(Console.ReadLine());
                Console.Write("Enter the {0} Y co-ordinates:", moon_name);
                int moon_y_coordinate = Convert.ToInt16(Console.ReadLine());

                Console.WriteLine("Existing Planets in the solar system: ");
                for (int i=0;i< star.Planet.Count();i++)
                {
                    Console.WriteLine(star.Planet[i]);
                }
                Console.WriteLine("Choose frm the above list.");
                

                Console.Write("Enter the moon's orbitting planet");
                string orbit_planet = Console.ReadLine();

                Console.WriteLine("Enter this {0} 's position:", orbit_planet);
                Console.Write("Enter this {0}'s X co-ordinates:", orbit_planet);
                int planet_x_coordinate = Convert.ToInt16(Console.ReadLine());
                Console.Write("Enter the {0} 's Y co-ordinates:", orbit_planet);
                int planet_y_coordinate = Convert.ToInt16(Console.ReadLine());
                
            // Calling the distance method from Moon class(Depicting OVERLOADING)
            // this Distance method has a different signature(this method returns integer value and has a different formula)

            int moon_to_planet_distance = moon.Distance(planet_x_coordinate,planet_y_coordinate, moon_x_coordinate, moon_y_coordinate);
            
            string moon_result = moon_name + " moon belongs to  " + orbit_planet + " and the distance is  " + moon_to_planet_distance
                + " away from "+ orbit_planet;
                Moon_Result.Add(moon_result);
                for (int i = 0; i < Moon_Result.Count(); i++)
                {

                    Console.WriteLine(Moon_Result[i]);
                }


            }
            #endregion region Show Moon

        }




    }

}