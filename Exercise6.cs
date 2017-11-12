
using System;
using System.Collections.Generic;
using System.Windows;
using Sitech_ProgrammingExercise.Support;

namespace Sitech_ProgrammingExercise
{
    public partial class MainWindow
    {

        /// <summary>
        /// 
        /// </summary>
        /// <param name="radians"></param>
        /// <returns></returns>
        public static double ToDegrees(double radians)
        {
            return radians * 57.29578f;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="degrees"></param>
        /// <returns></returns>
        public static double ToRadians(double degrees)
        {
            return degrees * (Math.PI / 180.0f);
        }


        // return a collection of line objects that will ultimately be used to render the circumference of a circle on the canvas
        // the circle should be inside the bounds of the "Rect" argument (left,top,width,height)
        // the line class has 2 properties P1 & P2, that are used as drawing Points (X,Y)
        public IEnumerable<Line> Exercise6(Rect rect)
        {
            double centerY = rect.Height/2;
            double centerX = rect.Width/2;

            double radius = Math.Min(centerX, centerY);
            List<Line> lines = new List<Line>();

            double radians = ToRadians(0);
            double previousX = rect.X + centerX+ Math.Cos(radians) * radius;
            double previousY = rect.Y + centerY +Math.Sin(radians) * radius;

            for (int i=1;i<360;i++)
            {
                radians = ToRadians(i);
                Line line = new Line();
                line.P1 = new Point(previousX ,previousY );
                line.P2 = new Point (rect.X + centerX +Math.Cos(radians) * radius, rect.Y + centerY +Math.Sin(radians) * radius);
                previousX = rect.X + centerX +Math.Cos(radians) * radius;
                previousY = rect.Y + centerY +Math.Sin(radians) * radius;

                lines.Add(line);
            }

            return lines;
        }
    }
}
