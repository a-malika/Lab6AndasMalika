using Laboratory6;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory6
{
    public class Section : NestedElement
    {
        public string Title { get; set; }
        public string Text { get; set; }
        public Section() { }
        public Section(string title, string text)
        {
            Title = title;
            Text = text;
        }
        public override Section Clone()
        {
            return new Section(Title, Text);
        }
        public override string ToString()
        {
            return $"\n----------Section\nTitle: {Title}\nText: {Text}\n";
        }
    }
}
