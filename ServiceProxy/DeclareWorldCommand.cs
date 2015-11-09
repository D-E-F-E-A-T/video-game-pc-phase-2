using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceProxy
{
    public sealed class DeclareWorldCommand : WorldBuilderCommand
    {
        private int type;
        private int width;
        private int height;

        public int Type
        {
            get { return type; }
            set { type = value; }
        }

        public int Width
        {
            get { return width; }
            set { width = value; }
        }

        public int Height
        {
            get { return height; }
            set { height = value; }
        }

        public DeclareWorldCommand(int width, int height)
        {
            this.type = 4;
            this.width = width;
            this.height = height;
        }
    }
}
