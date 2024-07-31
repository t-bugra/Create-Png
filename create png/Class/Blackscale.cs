using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace create_png.Class
{
    internal class Blackscale : IScale
    {
        public void Render(Bitmap bmp)
        {
            int width = bmp.Width;
            int height = bmp.Height;

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    int BlackValue = x % 2 == 0 ? 0 : 255;
                    Color BlackColor = Color.FromArgb(BlackValue, BlackValue, BlackValue);
                    bmp.SetPixel(x, y, BlackColor);
                }
            }
            
        }
    }
}
