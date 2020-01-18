using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.IO;

namespace McKnight.Nero.Controls
{
    public class CodeEditor :  RichTextBox
    {
        private ISyntaxHighlighter syntaxHighlighter;

        public void LoadFile(string fileName)
        {
            SyntaxHighlighterFactory factory = new SyntaxHighlighterFactory();
            ISyntaxHighlighter syntaxHighlighter = factory.CreateSyntaxHighlighter(fileName);
            this.Document = syntaxHighlighter.CreateFlowDocument(File.ReadLines(fileName));            
        }
    }
}
