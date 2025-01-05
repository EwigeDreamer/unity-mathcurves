using UnityEngine;

namespace ED.Curves.Samples
{
    internal static class ColorEx
    {
        public static Color SetR(this Color c, float r) => new Color(r, c.g, c.b, c.a);
        public static Color SetG(this Color c, float g) => new Color(c.r, g, c.b, c.a);
        public static Color SetB(this Color c, float b) => new Color(c.r, c.g, b, c.a);
        public static Color SetA(this Color c, float a) => new Color(c.r, c.g, c.b, a);
    }
}