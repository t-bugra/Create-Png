using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace create_png.Class
{
    internal class Greyscale : IScale
    {
        public void Render(Bitmap bmp)
        {
            int width = bmp.Width;
            int height = bmp.Height;

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {

                    // height ten çıkarınca siyah üstte oluyo 
                    int grayValue = height-(255 - y);
                    // gri değeri 0,255 arasına eşitleme
                    grayValue = Math.Max(0, Math.Min(255, grayValue));

                    Color grayColor = Color.FromArgb(grayValue, grayValue, grayValue);
                    bmp.SetPixel(x, y, grayColor);


                }
            }
            
        }
    }
}
