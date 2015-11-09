using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceProxy
{
    public sealed class DeclareScreenCommand : WorldBuilderCommand
    {
        private int type;
        private int x;
        private int y;

        public int Type
        {
            get { return type; }
            set { type = value; }
        }

        public int X
        {
            get { return x; }
            set { x = value; }
        }

        public int Y
        {
            get { return y; }
            set { y = value; }
        }

        public DeclareScreenCommand(int x, int y)
        {
            this.type = 2;
            this.x = x;
            this.y = y;
        }
    }
}
