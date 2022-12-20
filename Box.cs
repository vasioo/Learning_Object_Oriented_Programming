using System;
using System.Collections.Generic;
using System.Text;

namespace ClassBoxData
{
    public class Box
    {
        private double surfaceArea;
        private double lateralSurfaceArea;
        private double volume;

        public Box(double length, double height, double width)
        {
            try
            {
                Length = length;
                Height = height;
                Width = width;
            }
            catch (Exception)
            {
                throw new ArgumentException("new arg");
            }
        }
        public double Length { get; set; }
        public double Height { get; set; }
        public double Width { get; set; }
      
        private double SurfaceArea(double height, double width, double lenght)
        {
            surfaceArea=(2 * (lenght * width)) + (2 * (lenght * height)) + (2 * (height * width));
            return surfaceArea;
        }
        public override string ToString()
        {
            return $"Surface Area - {SurfaceArea(Height, Width, Length):f2}" +
                $"\nLateral Surface Area - {LateralSurfaceArea(Height, Width, Length):f2}" +
                $"\nVolume - {Volume(Height, Width, Length):f2}";
        }
        private double LateralSurfaceArea(double height,double width, double lenght)
        {
            //2l,3h,4w
            //12+24
            lateralSurfaceArea= (2*lenght*height)+(2*width*height);
            return lateralSurfaceArea;
        }
        private double Volume(double height, double width, double lenght)
        {
            volume= lenght * height * width;
            return volume;
        }
    }
}
