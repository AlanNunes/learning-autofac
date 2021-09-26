namespace Jewelry.Models
{
    public class Ring
    {

        public double Radius { get; set; }
        protected Material Material { get; set; }
        public Ring(Material material)
        {
            Material = material;
        }
    }
}
