using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace McKnight.Nero
{
    public interface ISyntaxHighlighter
    {
        FlowDocument CreateFlowDocument(IEnumerable<string> lines);
    }
}
