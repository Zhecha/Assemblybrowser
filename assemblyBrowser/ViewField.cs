using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BrowserLibrary;

namespace assemblyBrowser
{
    public class ViewField
    {
        public string _fieldClass;

        public ViewField (FieldClass field)
        {
            string fieldstructure = "";
            if (field._public)
                fieldstructure = "public";
            if (field._static)
                fieldstructure += " " + "static";
            fieldstructure += field._typeField + " " + field._nameField;
            _fieldClass = fieldstructure;
        }
    }
}
