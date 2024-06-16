using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media;

namespace ColorEncodingApp.Converters
{
    public class HtmlColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is string colorCode)
            {
                try
                {
                    return (Color)ColorConverter.ConvertFromString(colorCode);
                }
                catch (FormatException)
                {
                    return Colors.Transparent;
                }
            }
            return Colors.Transparent; //123
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
