using System;
using System.Drawing;
using static Painting.Figure;

namespace Painting
{
    public class XData
    {
        public Android.Graphics.Color Color { get; set; }
        public int Width { get; set; }
        public FType Type { get; set; }

        public XData()
        {
            Color = Android.Graphics.Color.Black;
            Width = 1;
            Type = FType.Curve;
        }
    }
}

