using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace BrowserLibrary
{
    public class InformAboutAssembly
    {
        public List<NameSpaceClass> _namespaces;

        public InformAboutAssembly(string path)
        {
            _namespaces = new List<NameSpaceClass>();
            LoadAssembly(path);
        }

        private void LoadAssembly(string path)
        {
            Assembly assembly = Assembly.LoadFrom(path);
            Type[] types;
            try
            {
                types = assembly.GetTypes();
                foreach(Type type in types)
                {
                    AddToCollection(type);
                }
            }
            catch (ReflectionTypeLoadException e)
            {
                Console.WriteLine(e.Message);
                types = e.Types.Where(t => ((t != null))).ToArray();
                foreach (Type type in types)
                {
                    AddToCollection(type);
                }
            }
        }

        private void AddToCollection(Type type)
        {
            if (type.Namespace != null)
            {
                NameSpaceClass tempNamespace = new NameSpaceClass(type.Namespace);
                tempNamespace._classes.Add(new TypeData(type));
                _namespaces.Add(tempNamespace);
            } else
            {
                NameSpaceClass tempNamespace = new NameSpaceClass("Global");
                tempNamespace._classes.Add(new TypeData(type));
                _namespaces.Add(tempNamespace);
            }
        }
    }
}
