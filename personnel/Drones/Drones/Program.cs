using System.Security.Cryptography.X509Certificates;

namespace Drones
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            
            // Création de la flotte de drones

            List<Drone> fleet= new List<Drone>();
            
            

            for (int i = 0; i < 10; i++) 
            {
                fleet.Add(new Drone(AirSpace.WIDTH / 2, AirSpace.HEIGHT / 2, "Joe" + i));
              

                    
              
               
                
            }

            // Démarrage
            Application.Run(new AirSpace(fleet));


        }
    }
}