using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace BrowserLibrary
{
    public class PropertyClass
    {
        public string _nameProperty { get; set; }
        public string _typeProperty { get; set; }
        public bool _public { get; set; }
        public bool _write { get; set; }
        public bool _read { get; set; }

        public PropertyClass(PropertyInfo propertyInfo)
        {
            _nameProperty = propertyInfo.Name;
            _typeProperty = propertyInfo.PropertyType.Name;
            _public = true;
            _write = propertyInfo.CanWrite;
            _read = propertyInfo.CanRead;
        }
    }
}
