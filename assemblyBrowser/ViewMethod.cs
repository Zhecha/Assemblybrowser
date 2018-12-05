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
        public string _methodClass;

        public ViewMethod(MethodClass method)
        {
            string methodacces = "";
            if (method._public)
                methodacces += "public";
            if (method._static)
                methodacces += " " + "static";
            _methodClass = methodacces + " " + method._sign;
        }
    }
}
