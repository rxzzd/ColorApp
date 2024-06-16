namespace ColorEncodingApp.Models
{
    public class ColorInfo
    {
        public string HtmlCode { get; set; }
        public int Count { get; set; }
        public int Red { get; set; }
        public int Green { get; set; }
        public int Blue { get; set; }

        public ColorInfo(string htmlCode, int count, int red, int green, int blue)
        {
            HtmlCode = htmlCode;
            Count = count;
            Red = red;
            Green = green;
            Blue = blue;
        }
    }
}
