using System;
using System.Collections.Generic;
using System.Text;

namespace ClassBoxData
{
    public class Box
    {
        private double lenght;
        private double width;
        private double height;

       public Box(double lenght,double width, double height)
        {
            this.Lenght = lenght;
            this.Width = width;
            this.Height = height;
        }
        public double Lenght
        {
            get => this.lenght;
            private set
            {
                this.ThrowIfInvalidSide(value, nameof(this.Lenght));
                this.lenght = value;
            }
        }
        public double Width
        {
            get => this.width;
            private set
            {
                this.ThrowIfInvalidSide(value, nameof(this.Width));
                this.width = value;
            }
        }

        public double Height
        {
            get => this.height;
            private set
            {
                this.ThrowIfInvalidSide(value, nameof(this.Height));
                this.height = value;
            }
        }


        public double  CalculateVolume()
        {
            return this.Width * this.Lenght * this.Height;
        }

        public double CalculateLateralSurfaceArea()
        {
            return 2 * this.Lenght * this.Height + 2 * this.Width * this.Height;
        }

        public double CalculateSurfaceArea()
        {
            return 2 * this.Lenght * this.Width + 2 * this.Lenght * this.Height + 2 * this.Width * this.Height;
        }
        private void ThrowIfInvalidSide(double value, string side)
        {
            if (value<=0)
            {
                throw new ArgumentException($"{ side} cannot be zero or negative.");
            }
        }
    }
}
