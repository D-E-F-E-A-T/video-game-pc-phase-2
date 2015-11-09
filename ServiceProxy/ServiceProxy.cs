using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceProxy
{
    public sealed class ServiceProxy
    {
        public IEnumerable<WorldBuilderCommand> Build()
        {
            LinkedList<WorldBuilderCommand> commands =
                new LinkedList<WorldBuilderCommand>();

            // Upper-left forest. Think Composite!!!
            commands.AddLast(new AddTreeCommand(2, 0, 0));
            commands.AddLast(new AddTreeCommand(2, 1, 0));
            commands.AddLast(new AddTreeCommand(2, 2, 0));
            commands.AddLast(new AddTreeCommand(2, 3, 0));
            commands.AddLast(new AddTreeCommand(2, 4, 0));
            commands.AddLast(new AddTreeCommand(2, 5, 0));
            commands.AddLast(new AddTreeCommand(2, 6, 0));

            commands.AddLast(new AddTreeCommand(2, 0, 1));
            commands.AddLast(new AddTreeCommand(2, 1, 1));
            commands.AddLast(new AddTreeCommand(2, 2, 1));
            commands.AddLast(new AddTreeCommand(2, 3, 1));
            commands.AddLast(new AddTreeCommand(2, 4, 1));
            commands.AddLast(new AddTreeCommand(2, 5, 1));
            commands.AddLast(new AddTreeCommand(2, 6, 1));

            commands.AddLast(new AddTreeCommand(2, 0, 2));
            commands.AddLast(new AddTreeCommand(2, 1, 2));
            commands.AddLast(new AddTreeCommand(2, 2, 2));
            commands.AddLast(new AddTreeCommand(2, 3, 2));
            commands.AddLast(new AddTreeCommand(2, 4, 2));
            commands.AddLast(new AddTreeCommand(2, 5, 2));
            commands.AddLast(new AddTreeCommand(2, 6, 2));

            commands.AddLast(new AddTreeCommand(2, 0, 3));
            commands.AddLast(new AddTreeCommand(2, 1, 3));
            commands.AddLast(new AddTreeCommand(2, 2, 3));
            commands.AddLast(new AddTreeCommand(2, 3, 3));
            commands.AddLast(new AddTreeCommand(2, 4, 3));
            commands.AddLast(new AddTreeCommand(2, 5, 3));
            commands.AddLast(new AddTreeCommand(2, 6, 3));

            commands.AddLast(new AddTreeCommand(2, 0, 4));
            commands.AddLast(new AddTreeCommand(2, 1, 4));
            commands.AddLast(new AddTreeCommand(2, 2, 4));
            commands.AddLast(new AddTreeCommand(2, 3, 4));
            commands.AddLast(new AddTreeCommand(2, 4, 4));

            commands.AddLast(new AddTreeCommand(2, 0, 5));
            commands.AddLast(new AddTreeCommand(2, 1, 5));
            commands.AddLast(new AddTreeCommand(2, 2, 5));
            commands.AddLast(new AddTreeCommand(2, 3, 5));

            commands.AddLast(new AddTreeCommand(2, 0, 6));
            commands.AddLast(new AddTreeCommand(2, 1, 6));
            commands.AddLast(new AddTreeCommand(2, 2, 6));


            // Upper-right forest
            commands.AddLast(new AddTreeCommand(2, 11, 0));
            commands.AddLast(new AddTreeCommand(2, 12, 0));
            commands.AddLast(new AddTreeCommand(2, 13, 0));
            commands.AddLast(new AddTreeCommand(2, 14, 0));
            commands.AddLast(new AddTreeCommand(2, 15, 0));
            commands.AddLast(new AddTreeCommand(2, 16, 0));

            commands.AddLast(new AddTreeCommand(2, 11, 1));
            commands.AddLast(new AddTreeCommand(2, 12, 1));
            commands.AddLast(new AddTreeCommand(2, 13, 1));
            commands.AddLast(new AddTreeCommand(2, 14, 1));
            commands.AddLast(new AddTreeCommand(2, 15, 1));
            commands.AddLast(new AddTreeCommand(2, 16, 1));

            commands.AddLast(new AddTreeCommand(2, 11, 2));
            commands.AddLast(new AddTreeCommand(2, 12, 2));
            commands.AddLast(new AddTreeCommand(2, 13, 2));
            commands.AddLast(new AddTreeCommand(2, 14, 2));
            commands.AddLast(new AddTreeCommand(2, 15, 2));
            commands.AddLast(new AddTreeCommand(2, 16, 2));

            commands.AddLast(new AddTreeCommand(2, 11, 3));
            commands.AddLast(new AddTreeCommand(2, 12, 3));
            commands.AddLast(new AddTreeCommand(2, 13, 3));
            commands.AddLast(new AddTreeCommand(2, 14, 3));
            commands.AddLast(new AddTreeCommand(2, 15, 3));
            commands.AddLast(new AddTreeCommand(2, 16, 3));

            commands.AddLast(new AddTreeCommand(2, 12, 4));
            commands.AddLast(new AddTreeCommand(2, 13, 4));
            commands.AddLast(new AddTreeCommand(2, 14, 4));
            commands.AddLast(new AddTreeCommand(2, 15, 4));
            commands.AddLast(new AddTreeCommand(2, 16, 4));

            // Lower-left forest
            commands.AddLast(new AddTreeCommand(2, 0, 10));
            commands.AddLast(new AddTreeCommand(2, 1, 10));
            commands.AddLast(new AddTreeCommand(2, 2, 10));
            commands.AddLast(new AddTreeCommand(2, 3, 10));
            commands.AddLast(new AddTreeCommand(2, 4, 10));
            commands.AddLast(new AddTreeCommand(2, 5, 10));

            commands.AddLast(new AddTreeCommand(2, 0, 11));
            commands.AddLast(new AddTreeCommand(2, 1, 11));
            commands.AddLast(new AddTreeCommand(2, 2, 11));
            commands.AddLast(new AddTreeCommand(2, 3, 11));
            commands.AddLast(new AddTreeCommand(2, 4, 11));
            commands.AddLast(new AddTreeCommand(2, 5, 11));
            commands.AddLast(new AddTreeCommand(2, 6, 11));

            commands.AddLast(new AddTreeCommand(2, 0, 12));
            commands.AddLast(new AddTreeCommand(2, 1, 12));
            commands.AddLast(new AddTreeCommand(2, 2, 12));
            commands.AddLast(new AddTreeCommand(2, 3, 12));
            commands.AddLast(new AddTreeCommand(2, 4, 12));
            commands.AddLast(new AddTreeCommand(2, 5, 12));
            commands.AddLast(new AddTreeCommand(2, 6, 12));
            commands.AddLast(new AddTreeCommand(2, 7, 12));

            commands.AddLast(new AddTreeCommand(2, 0, 13));
            commands.AddLast(new AddTreeCommand(2, 1, 13));
            commands.AddLast(new AddTreeCommand(2, 2, 13));
            commands.AddLast(new AddTreeCommand(2, 3, 13));
            commands.AddLast(new AddTreeCommand(2, 4, 13));
            commands.AddLast(new AddTreeCommand(2, 5, 13));
            commands.AddLast(new AddTreeCommand(2, 6, 13));
            commands.AddLast(new AddTreeCommand(2, 7, 13));

            commands.AddLast(new AddTreeCommand(2, 0, 14));
            commands.AddLast(new AddTreeCommand(2, 1, 14));
            commands.AddLast(new AddTreeCommand(2, 2, 14));
            commands.AddLast(new AddTreeCommand(2, 3, 14));
            commands.AddLast(new AddTreeCommand(2, 4, 14));
            commands.AddLast(new AddTreeCommand(2, 5, 14));
            commands.AddLast(new AddTreeCommand(2, 6, 14));
            commands.AddLast(new AddTreeCommand(2, 7, 14));


            // Lower-right forest
            commands.AddLast(new AddTreeCommand(2, 12, 9));
            commands.AddLast(new AddTreeCommand(2, 13, 9));
            commands.AddLast(new AddTreeCommand(2, 14, 9));
            commands.AddLast(new AddTreeCommand(2, 15, 9));
            commands.AddLast(new AddTreeCommand(2, 16, 9));

            commands.AddLast(new AddTreeCommand(2, 11, 10));
            commands.AddLast(new AddTreeCommand(2, 12, 10));
            commands.AddLast(new AddTreeCommand(2, 13, 10));
            commands.AddLast(new AddTreeCommand(2, 14, 10));
            commands.AddLast(new AddTreeCommand(2, 15, 10));
            commands.AddLast(new AddTreeCommand(2, 16, 10));

            commands.AddLast(new AddTreeCommand(2, 11, 11));
            commands.AddLast(new AddTreeCommand(2, 12, 11));
            commands.AddLast(new AddTreeCommand(2, 13, 11));
            commands.AddLast(new AddTreeCommand(2, 14, 11));
            commands.AddLast(new AddTreeCommand(2, 15, 11));
            commands.AddLast(new AddTreeCommand(2, 16, 11));

            commands.AddLast(new AddTreeCommand(2, 11, 12));
            commands.AddLast(new AddTreeCommand(2, 12, 12));
            commands.AddLast(new AddTreeCommand(2, 13, 12));
            commands.AddLast(new AddTreeCommand(2, 14, 12));
            commands.AddLast(new AddTreeCommand(2, 15, 12));
            commands.AddLast(new AddTreeCommand(2, 16, 12));

            commands.AddLast(new AddTreeCommand(2, 11, 13));
            commands.AddLast(new AddTreeCommand(2, 12, 13));
            commands.AddLast(new AddTreeCommand(2, 13, 13));
            commands.AddLast(new AddTreeCommand(2, 14, 13));
            commands.AddLast(new AddTreeCommand(2, 15, 13));
            commands.AddLast(new AddTreeCommand(2, 16, 13));

            commands.AddLast(new AddTreeCommand(2, 11, 14));
            commands.AddLast(new AddTreeCommand(2, 12, 14));
            commands.AddLast(new AddTreeCommand(2, 13, 14));
            commands.AddLast(new AddTreeCommand(2, 14, 14));
            commands.AddLast(new AddTreeCommand(2, 15, 14));
            commands.AddLast(new AddTreeCommand(2, 16, 14));


            commands.AddLast(new AddPortalCommand(3, 0, 7, 3, 16));
            commands.AddLast(new AddPortalCommand(3, 0, 8, 3, 16));
            commands.AddLast(new AddPortalCommand(3, 0, 9, 3, 16));

            commands.AddLast(new AddPortalCommand(3, 7, 0, 1, 11));
            commands.AddLast(new AddPortalCommand(3, 8, 0, 1, 11));
            commands.AddLast(new AddPortalCommand(3, 9, 0, 1, 11));
            commands.AddLast(new AddPortalCommand(3, 10, 0, 1, 11));

            commands.AddLast(new AddPortalCommand(3, 16, 5, 5, 14));
            commands.AddLast(new AddPortalCommand(3, 16, 6, 5, 14));
            commands.AddLast(new AddPortalCommand(3, 16, 7, 5, 14));
            commands.AddLast(new AddPortalCommand(3, 16, 8, 5, 14));

            commands.AddLast(new AddPortalCommand(3, 8, 14, 7, 18));
            commands.AddLast(new AddPortalCommand(3, 9, 14, 7, 18));
            commands.AddLast(new AddPortalCommand(3, 10, 14, 7, 18));




            return commands;
        }
    }
}
