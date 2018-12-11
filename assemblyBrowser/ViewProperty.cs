using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BrowserLibrary;

namespace assemblyBrowser
{
    public class ViewProperty
    {
        public string propertyClass { get; set; }

        public ViewProperty(PropertyClass property)
        {
            string propertystructure = "";
            string getAndset = "";
            if (property._public)
                propertystructure = "public" + " " + property._typeProperty + " " + property._nameProperty;
            if (property._read)
                getAndset += " get;";
            if (property._write)
                getAndset += " set;";
            propertyClass = propertystructure + " " + "{" + getAndset + "}";
        }
    }
}
