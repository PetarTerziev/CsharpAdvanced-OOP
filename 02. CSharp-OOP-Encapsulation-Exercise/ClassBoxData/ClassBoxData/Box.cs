using System;
using System.Collections.Generic;
using System.Text;

namespace ClassBoxData
{
    public class Box
    {
        //length, width and height
        

        private double length;
        private double width;
        private double height;
        private const string errorMessage = "cannot be zero or negative.";

        public Box(double length, double width, double height)
        {
            this.Length = length;
            this.Width = width;
            this.Height = height;
        }

        public double Length 
        {
            get => length;
            private set 
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Length " + errorMessage);
                }

                length = value;
            
            }        
        }

        public double Width
        {
            get => width;
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Width " + errorMessage);
                }

                width = value;
            }
        }

        public double Height
        {
            get => height;
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Height " + errorMessage);
                }

                height = value;
            }
        }

        //Volume = lwh

        public double Volume() 
        {
            return Length * Width * Height;
        }

        //Surface Area = 2lw + 2lh + 2wh

        public double SurfaceArea()
        {
            return 2 * Length * Width + 2 * Length * Height + 2 * Width * Height;
        }
        //Lateral Surface Area = 2lh + 2wh

        public double LateralSurfaceArea()
        {
            return 2 * Length * Height + 2 * Width * Height;
        }
    }
}
