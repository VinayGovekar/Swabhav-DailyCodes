using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleEncapsulationApp.Model
{
    class Rectangle
    {
        private int width;
        private int height;
        public string abc;
        public void setWidth(int paramWidth)
        {
            if (paramWidth > 100)
            {
                while (paramWidth > 100)
                {
                    paramWidth = paramWidth / 10;
                }
                width = paramWidth;
            }
            else if (paramWidth < 0)
            {
                while (paramWidth < 0)
                {
                    paramWidth = paramWidth * (-1);
                }
                width = paramWidth;
            }
            else {
                width = paramWidth;
            }
        }
        public void setHeight(int paramHeight)
        {
            if (paramHeight > 100)
            {
                while (paramHeight > 100)
                {
                    paramHeight = paramHeight / 10;
                }
                height = paramHeight;
            }
            else if (paramHeight < 0)
            {
                while (paramHeight < 0)
                {
                    paramHeight = paramHeight * (-1);
                }
                height = paramHeight;
            }
            else
            {
                height = paramHeight;
            }
        }
        public int GetHeight()
        {
            return height;
        }
        public int GetWidth()
        {
            return width;
        }
    }
}
