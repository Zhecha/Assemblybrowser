using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrowserLibrary
{
    public class TypeData
    {
        public string _nameClass { get; set; }
        public bool _abstract { get; set; }
        public bool _public { get; set; }
        public bool _interface { get; set; }
        public bool _class { get; set; }
        public List<MethodClass> _methods { get; set; }
        public List<PropertyClass> _properties { get; set; }
        public List<FieldClass> _fields { get; set; }

        public TypeData(Type type)
        {
            _nameClass = type.Name;
            _abstract = type.IsAbstract;
            _public = type.IsPublic;
            _interface = type.IsInterface;
            _class = type.IsClass;
            PropretiesFieldsMethods(type);
        }

        private void PropretiesFieldsMethods(Type type)
        {
            _fields = new List<FieldClass>();
            _properties = new List<PropertyClass>();
            _methods = new List<MethodClass>();
            var Fields = type.GetFields();
            var Properties = type.GetProperties();
            var Methods = type.GetMethods();
            foreach (var Field in Fields)
            {
                _fields.Add(new FieldClass(Field));
            }
            foreach(var Property in Properties)
            {
                _properties.Add(new PropertyClass(Property));
            }
            foreach (var Method in Methods)
            {
                _methods.Add(new MethodClass(Method));
            }
        }
    }
}
