using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceProxy
{
    public sealed class AddPortalCommand : WorldBuilderCommand
    {
        private int type;
        private int layerId;
        private int x;
        private int y;
        private int direction;
        private int destination;

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

        public int Direction
        {
            get { return direction; }
            set { direction = value; }
        }

        public int Destination
        {
            get { return destination; }
            set { destination = value; }
        }



        public AddPortalCommand(int layerId, int x, int y, int direction, int destination)
        {
            this.type = 0;
            this.layerId = layerId;
            this.x = x;
            this.y = y;
            this.direction = direction;
            this.destination = destination;
        }
    }
}
