using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp22.Prototype
{
    public abstract class ColorPrototype
    {
        public abstract ColorPrototype? Clone();
    }
    public class Color : ColorPrototype
    {
        int red;
        int green;
        int blue;
        // Constructor
        public Color(int red, int green, int blue)
        {
            this.red = red;
            this.green = green;
            this.blue = blue;
        }
        public override ColorPrototype? Clone()
        {
            Console.WriteLine(
                "Cloning color RGB: {0,3},{1,3},{2,3}",
                red, green, blue);
            return this.MemberwiseClone() as ColorPrototype;
        }
    }

    public class ColorManager
    {
        private Dictionary<string, ColorPrototype> colors = new();

        public ColorPrototype this[string key]
        {
            get => colors[key];
            set => colors.Add(key, value);
        }
    }
}
