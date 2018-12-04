using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace BrowserLibrary
{
    public class MethodClass
    {
        public string _nameMethod { get; set; }
        public bool _static { get; set; }
        public bool _public { get; set; }
        public string _sign { get; set; }

        public MethodClass(MethodInfo methodInfo)
        {
            _nameMethod = methodInfo.Name;
            _sign = methodInfo.ToString();
            _public = methodInfo.IsPublic;
            _static = methodInfo.IsStatic;
        }
    }
}
