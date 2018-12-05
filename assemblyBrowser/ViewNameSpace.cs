using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BrowserLibrary;

namespace assemblyBrowser
{
    public class ViewNameSpace
    {
        public string _namespaceClass;
        public List<ViewTypeData> viewTypes;

        public ViewNameSpace(NameSpaceClass nameSpace)
        {
            _namespaceClass = nameSpace._nameNameSpace;
            viewTypes = new List<ViewTypeData>();
            foreach (var vT in nameSpace._classes)
            {
                viewTypes.Add(new ViewTypeData(vT));
            }
        }
    }
}
