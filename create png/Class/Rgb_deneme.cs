using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace create_png.Class
{
    public class Rgb_deneme : IScale
    {
        public void Render(Bitmap bmp)

        {
            int width = bmp.Width;
            int height = bmp.Height;

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    // X ve Y koordinatlarına dayalı olarak RGB değerlerini hesapla

                    //Buralara tekrar bak !!!!!!!!!!!!!!!!!!!!!

                    int redValue = (int)(255.0 * x / width);
                    int greenValue = (int)(255.0 * y / height);
                    int blueValue = 255 - redValue;

                    // RGB değerlerinin geçerli aralıkta [0, 255] olduğundan emin ol
                    redValue = Math.Max(0, Math.Min(255, redValue));
                    greenValue = Math.Max(0, Math.Min(255, greenValue));
                    blueValue = Math.Max(0, Math.Min(255, blueValue));

                    // RGB rengi oluştur
                    Color rgbColor = Color.FromArgb(redValue, greenValue, blueValue);

                    // Pikseli RGB rengine ayarla
                    bmp.SetPixel(x, y, rgbColor);


                }
            }

        }
    }
}
