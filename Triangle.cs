using System;
using System.Collections.Generic;
using System.Text;

namespace ConstructorSampe
{
    class Triangle
    {
        private float bottom;
        private float height;
        public Triangle(float b, float h)
        {
            this.bottom = b;
            this.height = h;
        }
        public float GetSurface()
        {
            return bottom * height / 2;
        }
    }
}
