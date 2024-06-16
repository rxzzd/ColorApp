using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using ColorEncodingApp.Models;
using ColorEncodingApp.Services;
using System.IO;

namespace ColorEncodingApp.Tests
{
    [TestClass]
    public class ImageProcessorTests
    {
        private string CreateTestImage()
        {
            string imagePath = Path.Combine(Path.GetTempPath(), "C:\\Users\\spectella\\TUSUR\\ColorEncodingApp\\images_for_tests\\25600_102_1160_MTY4Nzg4MTkxNC0xMjMwMzMyOTg4.jpg");

            using (Bitmap bitmap = new Bitmap(10, 10))
            {
                for (int y = 0; y < 10; y++)
                {
                    for (int x = 0; x < 10; x++)
                    {
                        bitmap.SetPixel(x, y, Color.Red);
                    }
                }
                bitmap.Save(imagePath);
            }
            return imagePath;
        }

        [TestMethod]
        public void GetColorInfo_ValidImage_ReturnsCorrectColorInfo()
        {
            // Arrange
            string imagePath = CreateTestImage();
            var processor = new ImageProcessor();

            // Act
            List<ColorInfo> result = processor.GetColorInfo(imagePath);

            // Assert
            Assert.AreEqual(1, result.Count);
            Assert.AreEqual("#FF0000", result[0].HtmlCode);
            Assert.AreEqual(100, result[0].Count);
            Assert.AreEqual(255, result[0].Red);
            Assert.AreEqual(0, result[0].Green);
            Assert.AreEqual(0, result[0].Blue);

            File.Delete(imagePath);
        }

        [TestMethod]
        public void GetPixelColor_ValidCoordinates_ReturnsCorrectColor()
        {
            // Arrange
            string imagePath = CreateTestImage();
            var processor = new ImageProcessor();

            // Act
            ColorInfo result = processor.GetPixelColor(imagePath, 5, 5);

            // Assert
            Assert.AreEqual("#FF0000", result.HtmlCode);
            Assert.AreEqual(255, result.Red);
            Assert.AreEqual(0, result.Green);
            Assert.AreEqual(0, result.Blue);

            File.Delete(imagePath);
        }

        [TestMethod]
        public void GetPixelColor_InvalidCoordinates_ReturnsWhiteColor()
        {
            // Arrange
            string imagePath = CreateTestImage();
            var processor = new ImageProcessor();

            // Act
            ColorInfo result = processor.GetPixelColor(imagePath, -1, -1);

            // Assert
            Assert.AreEqual("#FFFFFF", result.HtmlCode);
            Assert.AreEqual(255, result.Red);
            Assert.AreEqual(255, result.Green);
            Assert.AreEqual(255, result.Blue);

            File.Delete(imagePath);
        }
    }
}
