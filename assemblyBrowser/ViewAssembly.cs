using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BrowserLibrary;
using Microsoft.Win32;

namespace assemblyBrowser
{
    public class ViewAssembly : ViewModel
    {
        List<NameSpaceClass> nameSpaceClasses;
        public List<ViewNameSpace> Views {
            get
            {
                List<ViewNameSpace> views1 = new List<ViewNameSpace>();
                foreach (NameSpaceClass spaceClass in nameSpaceClasses)
                {
                    views1.Add(new ViewNameSpace(spaceClass));
                }
                return views1;
            }
        }

        private Command command;
        public Command Load
        {
            get => command = new Command(o => {
                    OpenFileDialog open = new OpenFileDialog();
                    if (open.ShowDialog() == false)
                        return;
                    string filename = open.FileName;
                    InformAboutAssembly inform = new InformAboutAssembly(filename);
                    nameSpaceClasses = inform._namespaces;
                    OnPropertyChanged(nameof(Views));
                });
        }

        public ViewAssembly()
        {
            nameSpaceClasses = new List<NameSpaceClass>();
        }

    }
}
