using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory6
{
    public class Image : NestedElement
    {
        public string URL { get; set; }
        public Image() { }
        public Image(string url)
        {
            URL = url;
        }
        public override Image Clone()
        {
            return new Image(URL);
        }
        public override string ToString()
        {
            return $"\n----------Image\nURL: {URL}\n";
        }
    }
}
