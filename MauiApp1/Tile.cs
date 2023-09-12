using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1
{
    public class Tile : IHasAttribute
    {

        public Dictionary<string, string> Attributes { get; set; }
        public String Text { get; set; }

        public String Id { get; set; }
        public String ImageID { get; set; }

        public double Width { get; set; }

        public ImageSource ImageSource { get; set; }
        public Image GetImage()
        {
            return new Image
            {
                Source = ImageSource,
            };
        }

        public Tile(string id, string name, string imageID)
        {
            Attributes = new Dictionary<string, string>();
            Id = id;
            Text = name;
            ImageID = imageID;
            Width = 150;
        }

        public String getAttribute(string key)
        {
            if (Attributes.ContainsKey(key)) return Attributes[key];
            return "none";
        }


    }
}
