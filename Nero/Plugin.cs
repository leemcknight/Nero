using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McKnight.Nero
{
    public class Plugin
    {
        private string name;
        private string description;
        private string version;
        private string pluginNamespace;
        private IEnumerable<INeroEditor> editors;
    }
}
