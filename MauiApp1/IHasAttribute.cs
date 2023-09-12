using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1
{
    public interface IHasAttribute
    {
        Dictionary<string, string> Attributes { get; set; }

        string getAttribute(string name);

    }
}
