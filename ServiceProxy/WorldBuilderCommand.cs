using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceProxy
{
    public interface WorldBuilderCommand
    {
        int Type { get; set; }
        int LayerId { get; set; }
        int X { get; set; }
        int Y { get; set; }
    }
}
