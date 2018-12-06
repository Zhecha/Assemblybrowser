using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BrowserLibrary;

namespace assemblyBrowser
{
    public class ViewAssembly : ViewModel
    {
        private Command command;
        List<NameSpaceClass> nameSpaceClasses;
        public List<ViewNameSpace> views;

        public ViewAssembly()
        {
            nameSpaceClasses = new List<NameSpaceClass>();
            views = new List<ViewNameSpace>();
            foreach(NameSpaceClass spaceClass in nameSpaceClasses)
            {
                views.Add(new ViewNameSpace(spaceClass));
            }
        }
    }
}
