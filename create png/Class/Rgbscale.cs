using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace create_png.Class
{
    public class Rgbscale : IScale
    {
        private Random random=new Random(); 
        public void Render(Bitmap bmp)
        {
            int width=bmp.Width;
            int height=bmp.Height;

            for (int y = 0; y < height; y++) 
            {
                for (int x = 0; x < width; x++) 
                {
                Color color = Color.FromArgb(random.Next(0,255), random.Next(0, 255), random.Next(0, 255));
                bmp.SetPixel(x, y, color);  
                }
            
            }
           
            Console.ReadLine();
        }
    }
}




