using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BrowserLibrary
{
    public class FieldClass
    {
        public bool _static { get; set; }
        public bool _public { get; set; }
        public string _nameField { get; set; }
        public string _typeField { get; set; }

        public FieldClass(FieldInfo fieldinfo)
        {
            _static = fieldinfo.IsStatic;
            _public = fieldinfo.IsPublic;
            _nameField = fieldinfo.Name;
            _typeField = fieldinfo.FieldType.Name;
        }
    }
}
