﻿using System.Drawing;

namespace TagsCloudVisualization
{
    internal class Program
    {
        static void Main()
        {
            var center = new Point(400, 400);
            var rectangleSizes = RectanglesRandomizer.GetSortedRectangles(
                100, 100, 10);

            var layouter = new CircularCloudLayouter(new Spiral(center));
            var rectangles = layouter.GetRectangles(rectangleSizes);

            var visualizer = new CloudVisualizer(center, rectangles, @"..\..\..\Images\", "Cloud 10");
            visualizer.CreateImage();
        }
    }
}