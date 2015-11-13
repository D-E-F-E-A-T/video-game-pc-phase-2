using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceProxy
{
    public sealed class DeclareDungeonCommand : WorldBuilderCommand
    {
        private int type;

        public int Type
        {
            get { return type; }
            set { type = value; }
        }
    }
}
