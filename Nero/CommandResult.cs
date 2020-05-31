using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McKnight.Nero.Vim
{
    public class CommandResult
    {
        public string Message { get; set; }


        public VimCommand VimCommand { get; set; }
    }
}
