using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BrowserLibrary;

namespace assemblyBrowser
{
    public class ViewTypeData
    {
        public string _typedataClass;
        public List<ViewField> viewFields;
        public List<ViewMethod> viewMethods;
        public List<ViewProperty> viewProperties;

        public ViewTypeData(TypeData type)
        {
            string typedata = "";
            if (type._public)
                typedata += "public ";
            if (type._abstract && !type._interface)
                typedata += "abstract ";
            if (type._interface)
                typedata += "interface ";
            if (type._class)
                typedata += "class ";
            _typedataClass = typedata + " " + type._nameClass;
            InitializeViewFMP(type);
        }

        private void InitializeViewFMP(TypeData type)
        {
            viewFields = new List<ViewField>();
            viewProperties = new List<ViewProperty>();
            viewMethods = new List<ViewMethod>();
            foreach (FieldClass field in type._fields)
            {
                viewFields.Add(new ViewField(field));
            }
            foreach (PropertyClass property in type._properties)
            {
                viewProperties.Add(new ViewProperty(property));
            }
            foreach (MethodClass method in type._methods)
            {
                viewMethods.Add(new ViewMethod(method));
            }
        }
    }
}
