using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSP2
{
    public class PresentationObject
    {
        public int width { get; set; }
        public int height { get; set; }

        public void Copy()
        {
            Console.WriteLine("copied");
        }

        public void Duplicate()
        {
            Console.WriteLine("duplicated");
        }
    }
    public class Text : PresentationObject
    {
        public int FontSize { get; set; }
        public string FontName { get; set; }

        public void AddHyperlink(string url)
        {
            Console.WriteLine("hyperlink added " + url);
        }
    }
    class SectionThreeMain
    {
        static void Main(string[] args)
        {
            var text = new Text();
            text.width = 10;
            text.Copy();
        }
    }
}
