using Android.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Painting
{
    public class Figure
    {
        public Path Path { get; set; }
        public PointF Start { get; set; }
        public PointF End { get; set; }
        public Color Color { get; set; }
        public int StrokeWidth { get; set; }

        public Figure(PointF start, PointF end, Color color, int width)
        {
            Start = start;
            End = end;
            Color = color;
            StrokeWidth = width;
            Path = CreatePath();
        }

        private Path CreatePath()
        {
            Path path = new Path();
            path.MoveTo(Start.X, Start.Y);
            path.LineTo(End.X, End.Y);
            path.Close();
            return path;
        }
    }

}
