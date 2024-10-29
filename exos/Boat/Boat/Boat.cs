using static System.Net.Mime.MediaTypeNames;
using System.Text;

namespace Boat
{
    public class Boat
    {
        private int MaxSpeed;
        private string Name;
        private float MaxCargoWeight;
        public Boat(int speed, string name, float maxCargoWeight)
        {
            MaxCargoWeight = maxCargoWeight;
            Name = name;
            MaxSpeed = speed;
        }
        public bool Start(Container container)
        {
            Console.WriteLine("Le bateau demarre");
            return true;
        }
        public bool LoadContainer(IContainer container) 
        { 
            Console.WriteLine("Le container" +$"{this.Name}" + "a ete charge");
            return false;
        }
        public void UnloadContainer(IContainer container)
        { 
            Console.WriteLine("Le container" + $"{this.Name}" + "a ete décharge");
        }
    }
}