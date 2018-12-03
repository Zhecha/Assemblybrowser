using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrowserLibrary
{
    public class NameSpaceClass
    {
        public string _nameNameSpace { get; set; }
        public List<TypeData> _classes { get; set; }

        public NameSpaceClass(string Namespace)
        {
            _nameNameSpace = Namespace;
            _classes = new List<TypeData>();
        }
    }
}
