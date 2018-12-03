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
        public Collection<NameSpaceClass> _namespaces { get; set; }

        public InformAboutAssembly(string path)
        {
            LoadAssembly(path);
        }

        private void LoadAssembly(string path)
        {
            Assembly assembly = Assembly.LoadFrom(path);
            IEnumerator current = assembly.DefinedTypes.GetEnumerator();
            while (current.MoveNext())
            {
                Type item = (Type)current.Current;
                AddToCollection(item);
            }
            current.Reset();
        }

        private void AddToCollection(Type type)
        {
            if(type.Namespace != null)
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
