using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceProxy
{
    public sealed class DeclareCaveCommand : WorldBuilderCommand
    {
        private int type;

        public int Type
        {
            get { return type; }
            set { type = value; }
        }

        public DeclareCaveCommand()
        {
            this.type = 10;
        }
    }
}
