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
            _namespaces = LoadAssembly(path);
        }

        private Collection<NameSpaceClass> LoadAssembly(string path)
        {
            Collection<NameSpaceClass> NameSpaces = new Collection<NameSpaceClass>();
            Assembly assembly = Assembly.LoadFrom(path);
            IEnumerator current = assembly.DefinedTypes.GetEnumerator();
            while (current.MoveNext())
            {
                Type item = (Type)current.Current;
                AddToCollection(item);
            }
            current.Reset();
            return NameSpaces;
        }
    }
}
