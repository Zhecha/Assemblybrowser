using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BrowserLibrary;

namespace assemblyBrowser
{
    public class ViewMethod
    {
        public string methodClass { get; set; }

        public ViewMethod(MethodClass method)
        {
            string methodacces = "";
            if (method._public)
                methodacces += "public";
            if (method._static)
                methodacces += " " + "static";
            methodClass = methodacces + " " + method._sign;
        }
    }
}
