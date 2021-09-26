using Autofac;
using Jewelry.Models;

namespace Jewelry
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new ContainerBuilder();
            builder.Register<Ring>(
                (container, prop) =>
                {
                    var material = prop.Named<Material>("Material");
                    if (material.ToString() == "Gold")
                        return new GoldRing();
                    else if (material.ToString() == "Silver")
                        return new SilverRing();
                    else
                        return new Ring(material);
                });

            var container = builder.Build();
            var ring = container.Resolve<Ring>(new NamedParameter("Material", Material.Gold));
        }
    }
}
