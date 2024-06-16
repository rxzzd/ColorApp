using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using ColorEncodingApp.Models;

namespace ColorEncodingApp.Services
{
    public class ImageProcessor
    {
        public List<ColorInfo> GetColorInfo(string imagePath)
        {
            using (Bitmap bitmap = new Bitmap(imagePath))
            {
                Dictionary<string, int> colorDict = new Dictionary<string, int>();

                for (int y = 0; y < bitmap.Height; y++)
                {
                    for (int x = 0; x < bitmap.Width; x++)
                    {
                        Color color = bitmap.GetPixel(x, y);
                        string colorCode = ColorTranslator.ToHtml(color);

                        if (colorDict.ContainsKey(colorCode))
                        {
                            colorDict[colorCode]++;
                        }
                        else
                        {
                            colorDict[colorCode] = 1;
                        }
                    }
                }

                return colorDict.OrderByDescending(kvp => kvp.Value)
                                .Select(kvp =>
                                {
                                    var color = ColorTranslator.FromHtml(kvp.Key);
                                    return new ColorInfo(kvp.Key, kvp.Value, color.R, color.G, color.B);
                                })
                                .ToList();
            }
        }

        public ColorInfo GetPixelColor(string imagePath, int x, int y)
        {
            using (Bitmap bitmap = new Bitmap(imagePath))
            {
                if (x >= 0 && x < bitmap.Width && y >= 0 && y < bitmap.Height)
                {
                    Color color = bitmap.GetPixel(x, y);
                    string colorCode = ColorTranslator.ToHtml(color);
                    return new ColorInfo(colorCode, 0, color.R, color.G, color.B);
                }
                return new ColorInfo("#FFFFFF", 0, 255, 255, 255); // Белый цвет по умолчанию, если координаты вне диапазона
            }
        }
    }
}
