using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using BrowserLibrary;

namespace assemblyBrowser
{
    public class ViewNameSpace
    {
        public string namespaceClass { get; set; }
        public ObservableCollection<ViewTypeData> viewTypes { get; set; }

        public ViewNameSpace(NameSpaceClass nameSpace)
        {
            namespaceClass = nameSpace._nameNameSpace;
            viewTypes = new ObservableCollection<ViewTypeData>();
            foreach (var vT in nameSpace._classes)
            {
                viewTypes.Add(new ViewTypeData(vT));
            }
        }
    }
}
