using static System.Net.Mime.MediaTypeNames;
using System.Text;

namespace Boat
{
    public class Container
    {
        private int Id;
        private float Weight;
        private bool IsRefrigerated;
        private string Color;
        List<string> Merchandise;
        public Container(int id, float weight, bool isrefrigerated, string color, List<string> merchandise)
        {
            Id = id;
            Weight = weight;
            IsRefrigerated = isrefrigerated;
            Color = color;
            Merchandise = merchandise;
        }

        public void ViewContent()
        {
            Console.WriteLine("Le container" + $"{this.Id}" + "a dedans : " + this.Merchandise);
        }
        public void AddMerchandise()
        { 
            Console.WriteLine("Le container" + $"{this.Id}" + "ajoute : " + this.Merchandise);
        }
    }

}