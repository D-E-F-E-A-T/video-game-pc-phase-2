using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceProxy
{
    public sealed class AddWaterCommand : WorldBuilderCommand
    {
        private int type;
        private int layerId;
        private int x;
        private int y;

        public int Type
        {
            get { return type; }
            set { type = value; }
        }

        public int LayerId
        {
            get { return layerId; }
            set { layerId = value; }
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

        public AddWaterCommand(int layerId, int x, int y)
        {
            this.type = 5;
            this.layerId = layerId;
            this.x = x;
            this.y = y;
        }
    }
}