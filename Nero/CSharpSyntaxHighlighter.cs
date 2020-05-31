using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace McKnight.Nero
{
    public class CSharpSyntaxHighlighter : ISyntaxHighlighter
    {
        public FlowDocument CreateFlowDocument(IEnumerable<string> lines)
        {
            FlowDocument document = new FlowDocument();
            return document;
        }
    }
}
