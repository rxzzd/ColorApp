using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Globalization;
using System.Windows.Media; // Использование только System.Windows.Media
using ColorEncodingApp.Converters;

namespace ColorEncodingApp.Tests
{
    [TestClass]
    public class HtmlColorConverterTests
    {
        [TestMethod]
        public void Convert_ValidHtmlColorCode_ReturnsCorrectColor()
        {
            // Arrange
            var converter = new HtmlColorConverter();
            string htmlColorCode = "#FF5733";
            var expectedColor = (Color)ColorConverter.ConvertFromString(htmlColorCode);

            // Act
            var result = (Color)converter.Convert(htmlColorCode, typeof(Color), null, CultureInfo.InvariantCulture);

            // Assert
            Assert.AreEqual(expectedColor, result);
        }

        [TestMethod]
        public void Convert_InvalidHtmlColorCode_ReturnsTransparent()
        {
            // Arrange
            var converter = new HtmlColorConverter();
            string invalidHtmlColorCode = "invalid";

            // Act
            var result = (Color)converter.Convert(invalidHtmlColorCode, typeof(Color), null, CultureInfo.InvariantCulture);

            // Assert
            Assert.AreEqual(Colors.Transparent, result);
        }

        [TestMethod]
        public void Convert_NullValue_ReturnsTransparent()
        {
            // Arrange
            var converter = new HtmlColorConverter();

            // Act
            var result = (Color)converter.Convert(null, typeof(Color), null, CultureInfo.InvariantCulture);

            // Assert
            Assert.AreEqual(Colors.Transparent, result);
        }
    }
}
