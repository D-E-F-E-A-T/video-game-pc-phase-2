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

            commands.AddLast(new DeclareWorldCommand(5, 5));


            BuildScreen5(commands);

            BuildScreen10(commands);
            BuildScreen11(commands);
            BuildScreen12(commands);
            BuildScreen13(commands);
            BuildScreen14(commands);
            BuildScreen15(commands);
            BuildScreen16(commands);
            BuildScreen17(commands);
            BuildScreen18(commands);
            BuildScreen19(commands);
            BuildScreen20(commands);
            BuildScreen21(commands);
            BuildScreen22(commands);
            BuildScreen23(commands);
            BuildScreen24(commands);

            return commands;
        }

        private void BuildScreen5(LinkedList<WorldBuilderCommand> commands)
        {
            commands.AddLast(new DeclareScreenCommand(0, 1));

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

            commands.AddLast(new AddTreeCommand(2, 0, 7));
            commands.AddLast(new AddTreeCommand(2, 0, 8));



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

            commands.AddLast(new AddTreeCommand(4, 15, 5));
            commands.AddLast(new AddTreeCommand(4, 16, 5));

            commands.AddLast(new AddTreeCommand(4, 15, 6));
            commands.AddLast(new AddTreeCommand(4, 16, 6));


            // Lower-left forest
            commands.AddLast(new AddTreeCommand(2, 0, 9));
            commands.AddLast(new AddTreeCommand(2, 1, 9));
            commands.AddLast(new AddTreeCommand(2, 2, 9));
            commands.AddLast(new AddTreeCommand(2, 3, 9));
            commands.AddLast(new AddTreeCommand(2, 4, 9));

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

            commands.AddLast(new AddWaterCommand(2, 0, 12));
            commands.AddLast(new AddTreeCommand(2, 1, 12));
            commands.AddLast(new AddTreeCommand(2, 2, 12));
            commands.AddLast(new AddTreeCommand(2, 3, 12));
            commands.AddLast(new AddTreeCommand(2, 4, 12));
            commands.AddLast(new AddTreeCommand(2, 5, 12));
            commands.AddLast(new AddTreeCommand(2, 6, 12));
            commands.AddLast(new AddTreeCommand(2, 7, 12));

            commands.AddLast(new AddWaterCommand(2, 0, 13));
            commands.AddLast(new AddWaterCommand(2, 1, 13));
            commands.AddLast(new AddWaterCommand(2, 2, 13));
            commands.AddLast(new AddTreeCommand(2, 3, 13));
            commands.AddLast(new AddTreeCommand(2, 4, 13));
            commands.AddLast(new AddTreeCommand(2, 5, 13));
            commands.AddLast(new AddTreeCommand(2, 6, 13));
            commands.AddLast(new AddTreeCommand(2, 7, 13));

            commands.AddLast(new AddWaterCommand(2, 0, 14));
            commands.AddLast(new AddWaterCommand(2, 1, 14));
            commands.AddLast(new AddWaterCommand(2, 2, 14));
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


            commands.AddLast(new AddPortalCommand(4, 0, 7, 1, 0));
            commands.AddLast(new AddPortalCommand(4, 0, 8, 1, 0));
            commands.AddLast(new AddPortalCommand(4, 0, 9, 1, 0));
            commands.AddLast(new AddPortalCommand(4, 0, 10, 1, 0));

            commands.AddLast(new AddPortalCommand(4, 16, 7, 5, 6));
            commands.AddLast(new AddPortalCommand(4, 16, 8, 5, 6));

            commands.AddLast(new AddPortalCommand(4, 8, 14, 7, 10));
            commands.AddLast(new AddPortalCommand(4, 9, 14, 7, 10));
            commands.AddLast(new AddPortalCommand(4, 10, 14, 7, 10));
        }

        private void BuildScreen10(LinkedList<WorldBuilderCommand> commands)
        {
            commands.AddLast(new DeclareScreenCommand(0, 2));

            commands.AddLast(new AddWaterCommand(2, 0, 0));
            commands.AddLast(new AddWaterCommand(2, 1, 0));
            commands.AddLast(new AddWaterCommand(2, 2, 0));

            commands.AddLast(new AddWaterCommand(2, 0, 1));
            commands.AddLast(new AddWaterCommand(2, 1, 1));
            commands.AddLast(new AddWaterCommand(2, 2, 1));

            commands.AddLast(new AddWaterCommand(2, 0, 2));
            commands.AddLast(new AddWaterCommand(2, 1, 2));
            commands.AddLast(new AddWaterCommand(2, 2, 2));

            commands.AddLast(new AddWaterCommand(2, 0, 3));
            commands.AddLast(new AddWaterCommand(2, 1, 3));
            commands.AddLast(new AddWaterCommand(2, 2, 3));

            commands.AddLast(new AddWaterCommand(2, 0, 4));
            commands.AddLast(new AddWaterCommand(2, 1, 4));
            commands.AddLast(new AddWaterCommand(2, 2, 4));

            commands.AddLast(new AddWaterCommand(2, 0, 5));
            commands.AddLast(new AddWaterCommand(2, 1, 5));
            commands.AddLast(new AddWaterCommand(2, 2, 5));

            commands.AddLast(new AddWaterCommand(2, 0, 6));
            commands.AddLast(new AddWaterCommand(2, 1, 6));
            commands.AddLast(new AddWaterCommand(2, 2, 6));

            commands.AddLast(new AddWaterCommand(2, 0, 7));
            commands.AddLast(new AddWaterCommand(2, 1, 7));
            commands.AddLast(new AddWaterCommand(2, 2, 7));

            commands.AddLast(new AddWaterCommand(2, 0, 8));
            commands.AddLast(new AddWaterCommand(2, 1, 8));
            commands.AddLast(new AddWaterCommand(2, 2, 8));

            commands.AddLast(new AddWaterCommand(2, 0, 9));
            commands.AddLast(new AddWaterCommand(2, 1, 9));
            commands.AddLast(new AddWaterCommand(2, 2, 9));

            commands.AddLast(new AddWaterCommand(2, 0, 10));
            commands.AddLast(new AddWaterCommand(2, 1, 10));
            commands.AddLast(new AddWaterCommand(2, 2, 10));

            commands.AddLast(new AddWaterCommand(2, 0, 11));
            commands.AddLast(new AddWaterCommand(2, 1, 11));
            commands.AddLast(new AddWaterCommand(2, 2, 11));

            commands.AddLast(new AddWaterCommand(2, 0, 12));
            commands.AddLast(new AddWaterCommand(2, 1, 12));
            commands.AddLast(new AddWaterCommand(2, 2, 12));

            commands.AddLast(new AddWaterCommand(2, 0, 13));
            commands.AddLast(new AddWaterCommand(2, 1, 13));
            commands.AddLast(new AddWaterCommand(2, 2, 13));

            commands.AddLast(new AddWaterCommand(2, 0, 14));
            commands.AddLast(new AddWaterCommand(2, 1, 14));
            commands.AddLast(new AddWaterCommand(2, 2, 14));

            commands.AddLast(new AddTreeCommand(2, 3, 0));
            commands.AddLast(new AddTreeCommand(2, 4, 0));
            commands.AddLast(new AddTreeCommand(2, 5, 0));
            commands.AddLast(new AddTreeCommand(2, 6, 0));
            commands.AddLast(new AddTreeCommand(2, 7, 0));

            commands.AddLast(new AddTreeCommand(2, 3, 1));
            commands.AddLast(new AddTreeCommand(2, 4, 1));
            commands.AddLast(new AddTreeCommand(2, 5, 1));

            commands.AddLast(new AddTreeCommand(2, 3, 2));
            commands.AddLast(new AddTreeCommand(2, 4, 2));


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

            commands.AddLast(new AddPortalCommand(4, 7, 0, 1, 5));
            commands.AddLast(new AddPortalCommand(4, 8, 0, 1, 5));
            commands.AddLast(new AddPortalCommand(4, 9, 0, 1, 5));
            commands.AddLast(new AddPortalCommand(4, 10, 0, 1, 5));

            commands.AddLast(new AddPortalCommand(4, 16, 5, 5, 12));
            commands.AddLast(new AddPortalCommand(4, 16, 6, 5, 12));
            commands.AddLast(new AddPortalCommand(4, 16, 7, 5, 12));
            commands.AddLast(new AddPortalCommand(4, 16, 8, 5, 12));



            commands.AddLast(new AddPortalCommand(4, 3, 14, 7, 15));
            commands.AddLast(new AddPortalCommand(4, 4, 14, 7, 15));
            commands.AddLast(new AddPortalCommand(4, 5, 14, 7, 15));
            commands.AddLast(new AddPortalCommand(4, 6, 14, 7, 15));
            commands.AddLast(new AddPortalCommand(4, 7, 14, 7, 15));
            commands.AddLast(new AddPortalCommand(4, 8, 14, 7, 15));
            commands.AddLast(new AddPortalCommand(4, 9, 14, 7, 15));
            commands.AddLast(new AddPortalCommand(4, 10, 14, 7, 15));


        }

        private void BuildScreen11(LinkedList<WorldBuilderCommand> commands)
        {
            commands.AddLast(new DeclareScreenCommand(1, 2));

            // Upper-left forest. Think Composite!!!
            commands.AddLast(new AddTreeCommand(2, 0, 0));
            commands.AddLast(new AddTreeCommand(2, 1, 0));
            commands.AddLast(new AddTreeCommand(2, 2, 0));
            commands.AddLast(new AddTreeCommand(2, 3, 0));
            commands.AddLast(new AddTreeCommand(2, 4, 0));
            commands.AddLast(new AddTreeCommand(2, 5, 0));
            commands.AddLast(new AddTreeCommand(2, 6, 0));
            commands.AddLast(new AddTreeCommand(2, 7, 0));

            commands.AddLast(new AddTreeCommand(2, 0, 1));
            commands.AddLast(new AddTreeCommand(2, 1, 1));
            commands.AddLast(new AddTreeCommand(2, 2, 1));
            commands.AddLast(new AddTreeCommand(2, 3, 1));
            commands.AddLast(new AddTreeCommand(2, 4, 1));
            commands.AddLast(new AddTreeCommand(2, 5, 1));
            commands.AddLast(new AddTreeCommand(2, 6, 1));

            commands.AddLast(new AddTreeCommand(2, 0, 2));
            commands.AddLast(new AddTreeCommand(2, 1, 2));

            commands.AddLast(new AddTreeCommand(2, 0, 3));
            commands.AddLast(new AddTreeCommand(2, 1, 3));

            commands.AddLast(new AddTreeCommand(2, 0, 4));
            commands.AddLast(new AddTreeCommand(2, 1, 4));




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

            commands.AddLast(new AddTreeCommand(2, 15, 2));
            commands.AddLast(new AddTreeCommand(2, 16, 2));

            commands.AddLast(new AddTreeCommand(2, 15, 3));
            commands.AddLast(new AddTreeCommand(2, 16, 3));

            commands.AddLast(new AddTreeCommand(2, 15, 4));
            commands.AddLast(new AddTreeCommand(2, 16, 4));

            commands.AddLast(new AddTreeCommand(2, 16, 5));

            commands.AddLast(new AddTreeCommand(2, 16, 6));



            // Lower-left forest
            commands.AddLast(new AddTreeCommand(2, 0, 9));
            commands.AddLast(new AddTreeCommand(2, 1, 9));

            commands.AddLast(new AddTreeCommand(2, 0, 10));
            commands.AddLast(new AddTreeCommand(2, 1, 10));

            commands.AddLast(new AddTreeCommand(2, 0, 11));
            commands.AddLast(new AddTreeCommand(2, 1, 11));

            commands.AddLast(new AddTreeCommand(2, 0, 12));
            commands.AddLast(new AddTreeCommand(2, 1, 12));

            commands.AddLast(new AddTreeCommand(2, 0, 13));
            commands.AddLast(new AddTreeCommand(2, 1, 13));
            commands.AddLast(new AddTreeCommand(2, 2, 13));
            commands.AddLast(new AddTreeCommand(2, 3, 13));
            commands.AddLast(new AddTreeCommand(2, 4, 13));
            commands.AddLast(new AddTreeCommand(2, 5, 13));

            commands.AddLast(new AddTreeCommand(2, 0, 14));
            commands.AddLast(new AddTreeCommand(2, 1, 14));
            commands.AddLast(new AddTreeCommand(2, 2, 14));
            commands.AddLast(new AddTreeCommand(2, 3, 14));
            commands.AddLast(new AddTreeCommand(2, 4, 14));
            commands.AddLast(new AddTreeCommand(2, 5, 14));
            commands.AddLast(new AddTreeCommand(2, 6, 14));


            // Lower-right forest
            commands.AddLast(new AddTreeCommand(2, 15, 9));
            commands.AddLast(new AddTreeCommand(2, 16, 9));

            commands.AddLast(new AddTreeCommand(2, 15, 10));
            commands.AddLast(new AddTreeCommand(2, 16, 10));

            commands.AddLast(new AddTreeCommand(2, 15, 11));
            commands.AddLast(new AddTreeCommand(2, 16, 11));

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





            commands.AddLast(new AddPortalCommand(4, 0, 5, 3, 10));
            commands.AddLast(new AddPortalCommand(4, 0, 6, 3, 10));
            commands.AddLast(new AddPortalCommand(4, 0, 7, 3, 10));
            commands.AddLast(new AddPortalCommand(4, 0, 8, 3, 10));

            commands.AddLast(new AddPortalCommand(4, 8, 0, 1, 6));
            commands.AddLast(new AddPortalCommand(4, 9, 0, 1, 6));
            commands.AddLast(new AddPortalCommand(4, 10, 0, 1, 6));

            commands.AddLast(new AddPortalCommand(4, 16, 7, 5, 12));
            commands.AddLast(new AddPortalCommand(4, 16, 8, 5, 12));

            commands.AddLast(new AddPortalCommand(4, 7, 14, 7, 16));
            commands.AddLast(new AddPortalCommand(4, 8, 14, 7, 16));
            commands.AddLast(new AddPortalCommand(4, 9, 14, 7, 16));
            commands.AddLast(new AddPortalCommand(4, 10, 14, 7, 16));
        }

        private void BuildScreen12(LinkedList<WorldBuilderCommand> commands)
        {
            commands.AddLast(new DeclareScreenCommand(2, 2));

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

            commands.AddLast(new AddTreeCommand(4, 16, 5));
            commands.AddLast(new AddTreeCommand(4, 16, 6));


            // Lower-left forest
            commands.AddLast(new AddTreeCommand(2, 0, 9));
            commands.AddLast(new AddTreeCommand(2, 1, 9));
            commands.AddLast(new AddTreeCommand(2, 2, 9));
            commands.AddLast(new AddTreeCommand(2, 3, 9));
            commands.AddLast(new AddTreeCommand(2, 4, 9));

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

            commands.AddLast(new AddTreeCommand(2, 0, 13));
            commands.AddLast(new AddTreeCommand(2, 1, 13));
            commands.AddLast(new AddTreeCommand(2, 2, 13));
            commands.AddLast(new AddTreeCommand(2, 3, 13));
            commands.AddLast(new AddTreeCommand(2, 4, 13));
            commands.AddLast(new AddTreeCommand(2, 5, 13));
            commands.AddLast(new AddTreeCommand(2, 6, 13));

            commands.AddLast(new AddTreeCommand(2, 0, 14));
            commands.AddLast(new AddTreeCommand(2, 1, 14));
            commands.AddLast(new AddTreeCommand(2, 2, 14));
            commands.AddLast(new AddTreeCommand(2, 3, 14));
            commands.AddLast(new AddTreeCommand(2, 4, 14));
            commands.AddLast(new AddTreeCommand(2, 5, 14));
            commands.AddLast(new AddTreeCommand(2, 6, 14));


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


            commands.AddLast(new AddPortalCommand(4, 0, 7, 3, 11));
            commands.AddLast(new AddPortalCommand(4, 0, 8, 3, 11));
            

            commands.AddLast(new AddPortalCommand(4, 7, 0, 1, 7));
            commands.AddLast(new AddPortalCommand(4, 8, 0, 1, 7));
            commands.AddLast(new AddPortalCommand(4, 9, 0, 1, 7));
            commands.AddLast(new AddPortalCommand(4, 10, 0, 1, 7));

            commands.AddLast(new AddPortalCommand(4, 16, 7, 5, 13));
            commands.AddLast(new AddPortalCommand(4, 16, 8, 5, 13));

            commands.AddLast(new AddPortalCommand(4, 7, 14, 7, 17));
            commands.AddLast(new AddPortalCommand(4, 8, 14, 7, 17));
            commands.AddLast(new AddPortalCommand(4, 9, 14, 7, 17));
            commands.AddLast(new AddPortalCommand(4, 10, 14, 7, 17));
        }

        private void BuildScreen13(LinkedList<WorldBuilderCommand> commands)
        {
            commands.AddLast(new DeclareScreenCommand(3, 2));

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
            commands.AddLast(new AddTreeCommand(2, 0, 9));
            commands.AddLast(new AddTreeCommand(2, 1, 9));
            commands.AddLast(new AddTreeCommand(2, 2, 9));
            commands.AddLast(new AddTreeCommand(2, 3, 9));
            commands.AddLast(new AddTreeCommand(2, 4, 9));

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

            commands.AddLast(new AddTreeCommand(2, 0, 13));
            commands.AddLast(new AddTreeCommand(2, 1, 13));
            commands.AddLast(new AddTreeCommand(2, 2, 13));
            commands.AddLast(new AddTreeCommand(2, 3, 13));
            commands.AddLast(new AddTreeCommand(2, 4, 13));
            commands.AddLast(new AddTreeCommand(2, 5, 13));
            commands.AddLast(new AddTreeCommand(2, 6, 13));

            commands.AddLast(new AddTreeCommand(2, 0, 14));
            commands.AddLast(new AddTreeCommand(2, 1, 14));
            commands.AddLast(new AddTreeCommand(2, 2, 14));
            commands.AddLast(new AddTreeCommand(2, 3, 14));
            commands.AddLast(new AddTreeCommand(2, 4, 14));
            commands.AddLast(new AddTreeCommand(2, 5, 14));
            commands.AddLast(new AddTreeCommand(2, 6, 14));


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


            commands.AddLast(new AddPortalCommand(4, 0, 7, 3, 16));
            commands.AddLast(new AddPortalCommand(4, 0, 8, 3, 16));

            commands.AddLast(new AddPortalCommand(4, 7, 0, 1, 11));
            commands.AddLast(new AddPortalCommand(4, 8, 0, 1, 11));
            commands.AddLast(new AddPortalCommand(4, 9, 0, 1, 11));
            commands.AddLast(new AddPortalCommand(4, 10, 0, 1, 11));

            commands.AddLast(new AddPortalCommand(4, 16, 5, 5, 14));
            commands.AddLast(new AddPortalCommand(4, 16, 6, 5, 14));
            commands.AddLast(new AddPortalCommand(4, 16, 7, 5, 14));
            commands.AddLast(new AddPortalCommand(4, 16, 8, 5, 14));

            commands.AddLast(new AddPortalCommand(4, 7, 14, 7, 18));
            commands.AddLast(new AddPortalCommand(4, 8, 14, 7, 18));
            commands.AddLast(new AddPortalCommand(4, 9, 14, 7, 18));
            commands.AddLast(new AddPortalCommand(4, 10, 14, 7, 18));
        }

        private void BuildScreen14(LinkedList<WorldBuilderCommand> commands)
        {
            commands.AddLast(new DeclareScreenCommand(4, 2));

            commands.AddLast(new AddTreeCommand(2, 0, 0));
            commands.AddLast(new AddTreeCommand(2, 1, 0));
            commands.AddLast(new AddTreeCommand(2, 2, 0));
            commands.AddLast(new AddTreeCommand(2, 3, 0));
            commands.AddLast(new AddTreeCommand(2, 4, 0));
            commands.AddLast(new AddTreeCommand(2, 5, 0));
            commands.AddLast(new AddTreeCommand(2, 6, 0));

            commands.AddLast(new AddTreeCommand(2, 11, 0));
            commands.AddLast(new AddTreeCommand(2, 12, 0));
            commands.AddLast(new AddTreeCommand(2, 13, 0));
            commands.AddLast(new AddTreeCommand(2, 14, 0));
            commands.AddLast(new AddTreeCommand(2, 15, 0));
            commands.AddLast(new AddTreeCommand(2, 16, 0));

            commands.AddLast(new AddTreeCommand(2, 0, 1));
            commands.AddLast(new AddTreeCommand(2, 16, 1));

            commands.AddLast(new AddTreeCommand(2, 0, 2));
            commands.AddLast(new AddTreeCommand(2, 16, 2));

            commands.AddLast(new AddTreeCommand(2, 0, 3));
            commands.AddLast(new AddTreeCommand(2, 16, 3));

            commands.AddLast(new AddTreeCommand(2, 0, 4));
            commands.AddLast(new AddTreeCommand(2, 16, 4));

            commands.AddLast(new AddTreeCommand(2, 16, 5));

            commands.AddLast(new AddTreeCommand(2, 7, 6));
            commands.AddLast(new AddTreeCommand(2, 8, 6));
            commands.AddLast(new AddTreeCommand(2, 9, 6));
            commands.AddLast(new AddTreeCommand(2, 16, 6));

            commands.AddLast(new AddTreeCommand(2, 7, 7));
            commands.AddLast(new AddTreeCommand(2, 9, 7));
            commands.AddLast(new AddTreeCommand(2, 16, 7));

            commands.AddLast(new AddTreeCommand(2, 7, 8));
            commands.AddLast(new AddTreeCommand(2, 8, 8));
            commands.AddLast(new AddTreeCommand(2, 9, 8));
            commands.AddLast(new AddTreeCommand(2, 16, 8));

            commands.AddLast(new AddTreeCommand(2, 0, 9));
            commands.AddLast(new AddTreeCommand(2, 16, 9));

            commands.AddLast(new AddTreeCommand(2, 0, 10));
            commands.AddLast(new AddTreeCommand(2, 16, 10));

            commands.AddLast(new AddTreeCommand(2, 0, 11));
            commands.AddLast(new AddTreeCommand(2, 16, 11));

            commands.AddLast(new AddTreeCommand(2, 0, 12));
            commands.AddLast(new AddTreeCommand(2, 16, 12));

            commands.AddLast(new AddTreeCommand(2, 0, 13));
            commands.AddLast(new AddTreeCommand(2, 16, 13));

            commands.AddLast(new AddTreeCommand(2, 0, 14));
            commands.AddLast(new AddTreeCommand(2, 1, 14));
            commands.AddLast(new AddTreeCommand(2, 2, 14));
            commands.AddLast(new AddTreeCommand(2, 3, 14));
            commands.AddLast(new AddTreeCommand(2, 4, 14));
            commands.AddLast(new AddTreeCommand(2, 5, 14));
            commands.AddLast(new AddTreeCommand(2, 6, 14));

            commands.AddLast(new AddTreeCommand(2, 11, 14));
            commands.AddLast(new AddTreeCommand(2, 12, 14));
            commands.AddLast(new AddTreeCommand(2, 13, 14));
            commands.AddLast(new AddTreeCommand(2, 14, 14));
            commands.AddLast(new AddTreeCommand(2, 15, 14));
            commands.AddLast(new AddTreeCommand(2, 16, 14));

            commands.AddLast(new AddPortalCommand(4, 0, 5, 3, 13));
            commands.AddLast(new AddPortalCommand(4, 0, 6, 3, 13));
            commands.AddLast(new AddPortalCommand(4, 0, 7, 3, 13));
            commands.AddLast(new AddPortalCommand(4, 0, 8, 3, 13));

            commands.AddLast(new AddPortalCommand(4, 7, 0, 1, 9));
            commands.AddLast(new AddPortalCommand(4, 8, 0, 1, 9));
            commands.AddLast(new AddPortalCommand(4, 9, 0, 1, 9));
            commands.AddLast(new AddPortalCommand(4, 10, 0, 1, 9));

            commands.AddLast(new AddPortalCommand(4, 7, 14, 7, 19));
            commands.AddLast(new AddPortalCommand(4, 8, 14, 7, 19));
            commands.AddLast(new AddPortalCommand(4, 9, 14, 7, 19));
            commands.AddLast(new AddPortalCommand(4, 10, 14, 7, 19));
        }

        private void BuildScreen15(LinkedList<WorldBuilderCommand> commands)
        {
            commands.AddLast(new DeclareScreenCommand(0, 3));

            commands.AddLast(new AddWaterCommand(2, 0, 0));
            commands.AddLast(new AddWaterCommand(2, 1, 0));
            commands.AddLast(new AddWaterCommand(2, 2, 0));

            commands.AddLast(new AddWaterCommand(2, 0, 1));
            commands.AddLast(new AddWaterCommand(2, 1, 1));
            commands.AddLast(new AddWaterCommand(2, 2, 1));

            commands.AddLast(new AddWaterCommand(2, 0, 2));
            commands.AddLast(new AddWaterCommand(2, 1, 2));
            commands.AddLast(new AddWaterCommand(2, 2, 2));

            commands.AddLast(new AddWaterCommand(2, 0, 3));
            commands.AddLast(new AddWaterCommand(2, 1, 3));
            commands.AddLast(new AddWaterCommand(2, 2, 3));

            commands.AddLast(new AddWaterCommand(2, 0, 4));
            commands.AddLast(new AddWaterCommand(2, 1, 4));
            commands.AddLast(new AddWaterCommand(2, 2, 4));
            commands.AddLast(new AddWaterCommand(2, 3, 4));

            commands.AddLast(new AddWaterCommand(2, 0, 5));
            commands.AddLast(new AddWaterCommand(2, 1, 5));
            commands.AddLast(new AddWaterCommand(2, 2, 5));
            commands.AddLast(new AddWaterCommand(2, 3, 5));
            commands.AddLast(new AddWaterCommand(2, 4, 5));

            commands.AddLast(new AddWaterCommand(2, 0, 6));
            commands.AddLast(new AddWaterCommand(2, 1, 6));
            commands.AddLast(new AddWaterCommand(2, 2, 6));
            commands.AddLast(new AddWaterCommand(2, 3, 6));
            commands.AddLast(new AddWaterCommand(2, 4, 6));
            commands.AddLast(new AddWaterCommand(2, 5, 6));

            commands.AddLast(new AddWaterCommand(2, 0, 7));
            commands.AddLast(new AddWaterCommand(2, 1, 7));
            commands.AddLast(new AddWaterCommand(2, 2, 7));
            commands.AddLast(new AddWaterCommand(2, 3, 7));
            commands.AddLast(new AddWaterCommand(2, 4, 7));
            commands.AddLast(new AddWaterCommand(2, 5, 7));
            commands.AddLast(new AddWaterCommand(2, 6, 7));

            commands.AddLast(new AddWaterCommand(2, 0, 8));
            commands.AddLast(new AddWaterCommand(2, 1, 8));
            commands.AddLast(new AddWaterCommand(2, 2, 8));
            commands.AddLast(new AddWaterCommand(2, 3, 8));
            commands.AddLast(new AddWaterCommand(2, 4, 8));
            commands.AddLast(new AddWaterCommand(2, 5, 8));
            commands.AddLast(new AddWaterCommand(2, 6, 8));
            commands.AddLast(new AddWaterCommand(2, 7, 8));

            commands.AddLast(new AddWaterCommand(2, 0, 9));
            commands.AddLast(new AddWaterCommand(2, 1, 9));
            commands.AddLast(new AddWaterCommand(2, 2, 9));
            commands.AddLast(new AddWaterCommand(2, 3, 9));
            commands.AddLast(new AddWaterCommand(2, 4, 9));
            commands.AddLast(new AddWaterCommand(2, 5, 9));
            commands.AddLast(new AddWaterCommand(2, 6, 9));
            commands.AddLast(new AddWaterCommand(2, 7, 9));

            commands.AddLast(new AddWaterCommand(2, 0, 10));
            commands.AddLast(new AddWaterCommand(2, 1, 10));
            commands.AddLast(new AddWaterCommand(2, 2, 10));
            commands.AddLast(new AddWaterCommand(2, 3, 10));
            commands.AddLast(new AddWaterCommand(2, 4, 10));
            commands.AddLast(new AddWaterCommand(2, 5, 10));
            commands.AddLast(new AddWaterCommand(2, 6, 10));
            commands.AddLast(new AddWaterCommand(2, 7, 10));

            commands.AddLast(new AddWaterCommand(2, 0, 11));
            commands.AddLast(new AddWaterCommand(2, 1, 11));
            commands.AddLast(new AddWaterCommand(2, 2, 11));
            commands.AddLast(new AddWaterCommand(2, 3, 11));
            commands.AddLast(new AddWaterCommand(2, 4, 11));
            commands.AddLast(new AddWaterCommand(2, 5, 11));
            commands.AddLast(new AddWaterCommand(2, 6, 11));
            commands.AddLast(new AddWaterCommand(2, 7, 11));

            commands.AddLast(new AddWaterCommand(2, 0, 12));
            commands.AddLast(new AddWaterCommand(2, 1, 12));
            commands.AddLast(new AddWaterCommand(2, 2, 12));
            commands.AddLast(new AddWaterCommand(2, 3, 12));
            commands.AddLast(new AddWaterCommand(2, 4, 12));
            commands.AddLast(new AddWaterCommand(2, 5, 12));
            commands.AddLast(new AddWaterCommand(2, 6, 12));
            commands.AddLast(new AddWaterCommand(2, 7, 12));

            commands.AddLast(new AddWaterCommand(2, 0, 13));
            commands.AddLast(new AddWaterCommand(2, 1, 13));
            commands.AddLast(new AddWaterCommand(2, 2, 13));
            commands.AddLast(new AddWaterCommand(2, 3, 13));
            commands.AddLast(new AddWaterCommand(2, 4, 13));
            commands.AddLast(new AddWaterCommand(2, 5, 13));
            commands.AddLast(new AddWaterCommand(2, 6, 13));
            commands.AddLast(new AddWaterCommand(2, 7, 13));

            commands.AddLast(new AddWaterCommand(2, 0, 14));
            commands.AddLast(new AddWaterCommand(2, 1, 14));
            commands.AddLast(new AddWaterCommand(2, 2, 14));
            commands.AddLast(new AddWaterCommand(2, 3, 14));
            commands.AddLast(new AddWaterCommand(2, 4, 14));
            commands.AddLast(new AddWaterCommand(2, 5, 14));
            commands.AddLast(new AddWaterCommand(2, 6, 14));
            commands.AddLast(new AddWaterCommand(2, 7, 14));





            commands.AddLast(new AddWaterCommand(2, 0, 6));
            commands.AddLast(new AddWaterCommand(2, 1, 6));
            commands.AddLast(new AddWaterCommand(2, 2, 6));

            commands.AddLast(new AddWaterCommand(2, 0, 7));
            commands.AddLast(new AddWaterCommand(2, 1, 7));
            commands.AddLast(new AddWaterCommand(2, 2, 7));

            commands.AddLast(new AddWaterCommand(2, 0, 8));
            commands.AddLast(new AddWaterCommand(2, 1, 8));
            commands.AddLast(new AddWaterCommand(2, 2, 8));

            commands.AddLast(new AddWaterCommand(2, 0, 9));
            commands.AddLast(new AddWaterCommand(2, 1, 9));
            commands.AddLast(new AddWaterCommand(2, 2, 9));

            commands.AddLast(new AddWaterCommand(2, 0, 10));
            commands.AddLast(new AddWaterCommand(2, 1, 10));
            commands.AddLast(new AddWaterCommand(2, 2, 10));

            commands.AddLast(new AddWaterCommand(2, 0, 11));
            commands.AddLast(new AddWaterCommand(2, 1, 11));
            commands.AddLast(new AddWaterCommand(2, 2, 11));

            commands.AddLast(new AddWaterCommand(2, 0, 12));
            commands.AddLast(new AddWaterCommand(2, 1, 12));
            commands.AddLast(new AddWaterCommand(2, 2, 12));

            commands.AddLast(new AddWaterCommand(2, 0, 13));
            commands.AddLast(new AddWaterCommand(2, 1, 13));
            commands.AddLast(new AddWaterCommand(2, 2, 13));

            commands.AddLast(new AddWaterCommand(2, 0, 14));
            commands.AddLast(new AddWaterCommand(2, 1, 14));
            commands.AddLast(new AddWaterCommand(2, 2, 14));

            /*
            commands.AddLast(new AddTreeCommand(2, 3, 0));
            commands.AddLast(new AddTreeCommand(2, 4, 0));
            commands.AddLast(new AddTreeCommand(2, 5, 0));
            commands.AddLast(new AddTreeCommand(2, 6, 0));
            commands.AddLast(new AddTreeCommand(2, 7, 0));

            commands.AddLast(new AddTreeCommand(2, 3, 1));
            commands.AddLast(new AddTreeCommand(2, 4, 1));
            commands.AddLast(new AddTreeCommand(2, 5, 1));

            commands.AddLast(new AddTreeCommand(2, 3, 2));
            commands.AddLast(new AddTreeCommand(2, 4, 2));
            */


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

            commands.AddLast(new AddTreeCommand(2, 15, 5));
            commands.AddLast(new AddTreeCommand(2, 16, 5));

            commands.AddLast(new AddTreeCommand(2, 15, 6));
            commands.AddLast(new AddTreeCommand(2, 16, 6));

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

            commands.AddLast(new AddPortalCommand(4, 3, 0, 1, 10));
            commands.AddLast(new AddPortalCommand(4, 4, 0, 1, 10));
            commands.AddLast(new AddPortalCommand(4, 5, 0, 1, 10));
            commands.AddLast(new AddPortalCommand(4, 6, 0, 1, 10));
            commands.AddLast(new AddPortalCommand(4, 7, 0, 1, 10));
            commands.AddLast(new AddPortalCommand(4, 8, 0, 1, 10));
            commands.AddLast(new AddPortalCommand(4, 9, 0, 1, 10));
            commands.AddLast(new AddPortalCommand(4, 10, 0, 1, 10));


            commands.AddLast(new AddPortalCommand(4, 16, 7, 5, 16));
            commands.AddLast(new AddPortalCommand(4, 16, 8, 5, 16));

            commands.AddLast(new AddPortalCommand(4, 8, 14, 7, 20));
            commands.AddLast(new AddPortalCommand(4, 9, 14, 7, 20));
            commands.AddLast(new AddPortalCommand(4, 10, 14, 7, 20));


        }

        private void BuildScreen16(LinkedList<WorldBuilderCommand> commands)
        {
            commands.AddLast(new DeclareScreenCommand(1, 3));

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

            commands.AddLast(new AddTreeCommand(4, 15, 5));
            commands.AddLast(new AddTreeCommand(4, 16, 5));


            // Lower-left forest
            commands.AddLast(new AddTreeCommand(2, 0, 9));
            commands.AddLast(new AddTreeCommand(2, 1, 9));
            commands.AddLast(new AddTreeCommand(2, 2, 9));
            commands.AddLast(new AddTreeCommand(2, 3, 9));
            commands.AddLast(new AddTreeCommand(2, 4, 9));

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

            commands.AddLast(new AddTreeCommand(2, 0, 13));
            commands.AddLast(new AddTreeCommand(2, 1, 13));
            commands.AddLast(new AddTreeCommand(2, 2, 13));
            commands.AddLast(new AddTreeCommand(2, 3, 13));
            commands.AddLast(new AddTreeCommand(2, 4, 13));
            commands.AddLast(new AddTreeCommand(2, 5, 13));
            commands.AddLast(new AddTreeCommand(2, 6, 13));

            commands.AddLast(new AddTreeCommand(2, 0, 14));
            commands.AddLast(new AddTreeCommand(2, 1, 14));
            commands.AddLast(new AddTreeCommand(2, 2, 14));
            commands.AddLast(new AddTreeCommand(2, 3, 14));
            commands.AddLast(new AddTreeCommand(2, 4, 14));
            commands.AddLast(new AddTreeCommand(2, 5, 14));
            commands.AddLast(new AddTreeCommand(2, 6, 14));


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


            commands.AddLast(new AddPortalCommand(4, 0, 7, 3, 15));
            commands.AddLast(new AddPortalCommand(4, 0, 8, 3, 15));

            commands.AddLast(new AddPortalCommand(4, 7, 0, 1, 11));
            commands.AddLast(new AddPortalCommand(4, 8, 0, 1, 11));
            commands.AddLast(new AddPortalCommand(4, 9, 0, 1, 11));
            commands.AddLast(new AddPortalCommand(4, 10, 0, 1, 11));

            commands.AddLast(new AddPortalCommand(4, 16, 5, 5, 17));
            commands.AddLast(new AddPortalCommand(4, 16, 6, 5, 17));
            commands.AddLast(new AddPortalCommand(4, 16, 7, 5, 17));
            commands.AddLast(new AddPortalCommand(4, 16, 8, 5, 17));

            commands.AddLast(new AddPortalCommand(4, 7, 14, 7, 21));
            commands.AddLast(new AddPortalCommand(4, 8, 14, 7, 21));
            commands.AddLast(new AddPortalCommand(4, 9, 14, 7, 21));
            commands.AddLast(new AddPortalCommand(4, 10, 14, 7, 21));
        }

        private void BuildScreen17(LinkedList<WorldBuilderCommand> commands)
        {
            commands.AddLast(new DeclareScreenCommand(2, 3));

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
            commands.AddLast(new AddTreeCommand(2, 0, 9));
            commands.AddLast(new AddTreeCommand(2, 1, 9));
            commands.AddLast(new AddTreeCommand(2, 2, 9));
            commands.AddLast(new AddTreeCommand(2, 3, 9));
            commands.AddLast(new AddTreeCommand(2, 4, 9));

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

            commands.AddLast(new AddTreeCommand(2, 0, 13));
            commands.AddLast(new AddTreeCommand(2, 1, 13));
            commands.AddLast(new AddTreeCommand(2, 2, 13));
            commands.AddLast(new AddTreeCommand(2, 3, 13));
            commands.AddLast(new AddTreeCommand(2, 4, 13));
            commands.AddLast(new AddTreeCommand(2, 5, 13));
            commands.AddLast(new AddTreeCommand(2, 6, 13));

            commands.AddLast(new AddTreeCommand(2, 0, 14));
            commands.AddLast(new AddTreeCommand(2, 1, 14));
            commands.AddLast(new AddTreeCommand(2, 2, 14));
            commands.AddLast(new AddTreeCommand(2, 3, 14));
            commands.AddLast(new AddTreeCommand(2, 4, 14));
            commands.AddLast(new AddTreeCommand(2, 5, 14));
            commands.AddLast(new AddTreeCommand(2, 6, 14));


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


            commands.AddLast(new AddPortalCommand(4, 0, 6, 3, 16));
            commands.AddLast(new AddPortalCommand(4, 0, 7, 3, 16));
            commands.AddLast(new AddPortalCommand(4, 0, 8, 3, 16));

            commands.AddLast(new AddPortalCommand(4, 7, 0, 1, 12));
            commands.AddLast(new AddPortalCommand(4, 8, 0, 1, 12));
            commands.AddLast(new AddPortalCommand(4, 9, 0, 1, 12));
            commands.AddLast(new AddPortalCommand(4, 10, 0, 1, 12));

            commands.AddLast(new AddPortalCommand(4, 16, 5, 5, 18));
            commands.AddLast(new AddPortalCommand(4, 16, 6, 5, 18));
            commands.AddLast(new AddPortalCommand(4, 16, 7, 5, 18));
            commands.AddLast(new AddPortalCommand(4, 16, 8, 5, 18));

            commands.AddLast(new AddPortalCommand(4, 7, 14, 7, 22));
            commands.AddLast(new AddPortalCommand(4, 8, 14, 7, 22));
            commands.AddLast(new AddPortalCommand(4, 9, 14, 7, 22));
            commands.AddLast(new AddPortalCommand(4, 10, 14, 7, 22));
        }

        private void BuildScreen18(LinkedList<WorldBuilderCommand> commands)
        {
            commands.AddLast(new DeclareScreenCommand(3, 3));

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
            commands.AddLast(new AddTreeCommand(2, 0, 9));
            commands.AddLast(new AddTreeCommand(2, 1, 9));

            commands.AddLast(new AddTreeCommand(2, 0, 10));
            commands.AddLast(new AddTreeCommand(2, 1, 10));

            commands.AddLast(new AddTreeCommand(2, 0, 11));
            commands.AddLast(new AddTreeCommand(2, 1, 11));
            commands.AddLast(new AddTreeCommand(2, 2, 11));
            commands.AddLast(new AddTreeCommand(2, 3, 11));

            commands.AddLast(new AddTreeCommand(2, 0, 12));
            commands.AddLast(new AddTreeCommand(2, 1, 12));
            commands.AddLast(new AddTreeCommand(2, 2, 12));
            commands.AddLast(new AddTreeCommand(2, 3, 12));

            commands.AddLast(new AddTreeCommand(2, 0, 13));
            commands.AddLast(new AddTreeCommand(2, 1, 13));
            commands.AddLast(new AddTreeCommand(2, 2, 13));
            commands.AddLast(new AddTreeCommand(2, 3, 13));
            commands.AddLast(new AddTreeCommand(2, 4, 13));
            commands.AddLast(new AddTreeCommand(2, 5, 13));
            commands.AddLast(new AddTreeCommand(2, 6, 13));

            commands.AddLast(new AddTreeCommand(2, 0, 14));
            commands.AddLast(new AddTreeCommand(2, 1, 14));
            commands.AddLast(new AddTreeCommand(2, 2, 14));
            commands.AddLast(new AddTreeCommand(2, 3, 14));
            commands.AddLast(new AddTreeCommand(2, 4, 14));
            commands.AddLast(new AddTreeCommand(2, 5, 14));
            commands.AddLast(new AddTreeCommand(2, 6, 14));


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


            commands.AddLast(new AddPortalCommand(4, 0, 5, 3, 17));
            commands.AddLast(new AddPortalCommand(4, 0, 6, 3, 17));
            commands.AddLast(new AddPortalCommand(4, 0, 7, 3, 17));
            commands.AddLast(new AddPortalCommand(4, 0, 8, 3, 17));

            commands.AddLast(new AddPortalCommand(4, 7, 0, 1, 13));
            commands.AddLast(new AddPortalCommand(4, 8, 0, 1, 13));
            commands.AddLast(new AddPortalCommand(4, 9, 0, 1, 13));
            commands.AddLast(new AddPortalCommand(4, 10, 0, 1, 13));

            commands.AddLast(new AddPortalCommand(4, 16, 4, 5, 19));
            commands.AddLast(new AddPortalCommand(4, 16, 5, 5, 19));
            commands.AddLast(new AddPortalCommand(4, 16, 6, 5, 19));
            commands.AddLast(new AddPortalCommand(4, 16, 7, 5, 19));
            commands.AddLast(new AddPortalCommand(4, 16, 8, 5, 19));

            commands.AddLast(new AddPortalCommand(4, 7, 14, 7, 23));
            commands.AddLast(new AddPortalCommand(4, 8, 14, 7, 23));
            commands.AddLast(new AddPortalCommand(4, 9, 14, 7, 23));
            commands.AddLast(new AddPortalCommand(4, 10, 14, 7, 23));
        }

        private void BuildScreen19(LinkedList<WorldBuilderCommand> commands)
        {
            commands.AddLast(new DeclareScreenCommand(4, 3));

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

            commands.AddLast(new AddTreeCommand(2, 12, 5));
            commands.AddLast(new AddTreeCommand(2, 13, 5));
            commands.AddLast(new AddTreeCommand(2, 14, 5));
            commands.AddLast(new AddTreeCommand(2, 15, 5));
            commands.AddLast(new AddTreeCommand(2, 16, 5));


            // Lower-left forest
            commands.AddLast(new AddTreeCommand(2, 0, 9));
            commands.AddLast(new AddTreeCommand(2, 1, 9));
            commands.AddLast(new AddTreeCommand(2, 2, 9));
            commands.AddLast(new AddTreeCommand(2, 3, 9));
            commands.AddLast(new AddTreeCommand(2, 4, 9));

            commands.AddLast(new AddTreeCommand(2, 0, 10));
            commands.AddLast(new AddTreeCommand(2, 1, 10));
            commands.AddLast(new AddTreeCommand(2, 2, 10));
            commands.AddLast(new AddTreeCommand(2, 3, 10));
            commands.AddLast(new AddTreeCommand(2, 4, 10));

            commands.AddLast(new AddTreeCommand(2, 0, 11));
            commands.AddLast(new AddTreeCommand(2, 1, 11));
            commands.AddLast(new AddTreeCommand(2, 2, 11));
            commands.AddLast(new AddTreeCommand(2, 3, 11));
            commands.AddLast(new AddTreeCommand(2, 4, 11));

            commands.AddLast(new AddTreeCommand(2, 0, 12));
            commands.AddLast(new AddTreeCommand(2, 1, 12));
            commands.AddLast(new AddTreeCommand(2, 2, 12));
            commands.AddLast(new AddTreeCommand(2, 3, 12));
            commands.AddLast(new AddTreeCommand(2, 4, 12));

            commands.AddLast(new AddTreeCommand(2, 0, 13));
            commands.AddLast(new AddTreeCommand(2, 1, 13));
            commands.AddLast(new AddTreeCommand(2, 2, 13));
            commands.AddLast(new AddTreeCommand(2, 3, 13));
            commands.AddLast(new AddTreeCommand(2, 4, 13));

            commands.AddLast(new AddTreeCommand(2, 0, 14));
            commands.AddLast(new AddTreeCommand(2, 1, 14));
            commands.AddLast(new AddTreeCommand(2, 2, 14));
            commands.AddLast(new AddTreeCommand(2, 3, 14));
            commands.AddLast(new AddTreeCommand(2, 4, 14));


            // Lower-right forest
            commands.AddLast(new AddTreeCommand(2, 15, 5));
            commands.AddLast(new AddTreeCommand(2, 16, 5));

            commands.AddLast(new AddTreeCommand(2, 15, 6));
            commands.AddLast(new AddTreeCommand(2, 16, 6));

            commands.AddLast(new AddTreeCommand(2, 15, 7));
            commands.AddLast(new AddTreeCommand(2, 16, 7));

            commands.AddLast(new AddTreeCommand(2, 15, 8));
            commands.AddLast(new AddTreeCommand(2, 16, 8));

            commands.AddLast(new AddTreeCommand(2, 15, 9));
            commands.AddLast(new AddTreeCommand(2, 16, 9));

            commands.AddLast(new AddTreeCommand(2, 15, 10));
            commands.AddLast(new AddTreeCommand(2, 16, 10));

            commands.AddLast(new AddTreeCommand(2, 15, 11));
            commands.AddLast(new AddTreeCommand(2, 16, 11));

            commands.AddLast(new AddTreeCommand(2, 14, 12));
            commands.AddLast(new AddTreeCommand(2, 15, 12));
            commands.AddLast(new AddTreeCommand(2, 16, 12));

            commands.AddLast(new AddTreeCommand(2, 12, 13));
            commands.AddLast(new AddTreeCommand(2, 13, 13));
            commands.AddLast(new AddTreeCommand(2, 14, 13));
            commands.AddLast(new AddTreeCommand(2, 15, 13));
            commands.AddLast(new AddTreeCommand(2, 16, 13));

            commands.AddLast(new AddTreeCommand(2, 12, 14));
            commands.AddLast(new AddTreeCommand(2, 13, 14));
            commands.AddLast(new AddTreeCommand(2, 14, 14));
            commands.AddLast(new AddTreeCommand(2, 15, 14));
            commands.AddLast(new AddTreeCommand(2, 16, 14));

            commands.AddLast(new AddPortalCommand(4, 0, 5, 3, 18));
            commands.AddLast(new AddPortalCommand(4, 0, 6, 3, 18));
            commands.AddLast(new AddPortalCommand(4, 0, 7, 3, 18));
            commands.AddLast(new AddPortalCommand(4, 0, 8, 3, 18));

            commands.AddLast(new AddPortalCommand(4, 7, 0, 1, 14));
            commands.AddLast(new AddPortalCommand(4, 8, 0, 1, 14));
            commands.AddLast(new AddPortalCommand(4, 9, 0, 1, 14));
            commands.AddLast(new AddPortalCommand(4, 10, 0, 1, 14));

            commands.AddLast(new AddPortalCommand(4, 5, 14, 7, 24));
            commands.AddLast(new AddPortalCommand(4, 6, 14, 7, 24));
            commands.AddLast(new AddPortalCommand(4, 7, 14, 7, 24));
            commands.AddLast(new AddPortalCommand(4, 8, 14, 7, 24));
            commands.AddLast(new AddPortalCommand(4, 9, 14, 7, 24));
            commands.AddLast(new AddPortalCommand(4, 10, 14, 7, 24));
            commands.AddLast(new AddPortalCommand(4, 11, 14, 7, 24));
        }

        private void BuildScreen20(LinkedList<WorldBuilderCommand> commands)
        {
            commands.AddLast(new DeclareScreenCommand(0, 4));

            commands.AddLast(new AddWaterCommand(2, 0, 0));
            commands.AddLast(new AddWaterCommand(2, 1, 0));
            commands.AddLast(new AddWaterCommand(2, 2, 0));
            commands.AddLast(new AddWaterCommand(2, 3, 0));
            commands.AddLast(new AddWaterCommand(2, 4, 0));
            commands.AddLast(new AddWaterCommand(2, 5, 0));
            commands.AddLast(new AddWaterCommand(2, 6, 0));
            commands.AddLast(new AddWaterCommand(2, 7, 0));

            commands.AddLast(new AddWaterCommand(2, 0, 1));
            commands.AddLast(new AddWaterCommand(2, 1, 1));
            commands.AddLast(new AddWaterCommand(2, 2, 1));
            commands.AddLast(new AddWaterCommand(2, 3, 1));
            commands.AddLast(new AddWaterCommand(2, 4, 1));
            commands.AddLast(new AddWaterCommand(2, 5, 1));
            commands.AddLast(new AddWaterCommand(2, 6, 1));
            commands.AddLast(new AddWaterCommand(2, 7, 1));

            commands.AddLast(new AddWaterCommand(2, 0, 2));
            commands.AddLast(new AddWaterCommand(2, 1, 2));
            commands.AddLast(new AddWaterCommand(2, 2, 2));
            commands.AddLast(new AddWaterCommand(2, 3, 2));
            commands.AddLast(new AddWaterCommand(2, 4, 2));
            commands.AddLast(new AddWaterCommand(2, 5, 2));
            commands.AddLast(new AddWaterCommand(2, 6, 2));
            commands.AddLast(new AddWaterCommand(2, 7, 2));

            commands.AddLast(new AddWaterCommand(2, 0, 3));
            commands.AddLast(new AddWaterCommand(2, 1, 3));
            commands.AddLast(new AddWaterCommand(2, 2, 3));
            commands.AddLast(new AddWaterCommand(2, 3, 3));
            commands.AddLast(new AddWaterCommand(2, 4, 3));
            commands.AddLast(new AddWaterCommand(2, 5, 3));
            commands.AddLast(new AddWaterCommand(2, 6, 3));
            commands.AddLast(new AddWaterCommand(2, 7, 3));

            commands.AddLast(new AddWaterCommand(2, 0, 4));
            commands.AddLast(new AddWaterCommand(2, 1, 4));
            commands.AddLast(new AddWaterCommand(2, 2, 4));
            commands.AddLast(new AddWaterCommand(2, 3, 4));
            commands.AddLast(new AddWaterCommand(2, 4, 4));
            commands.AddLast(new AddWaterCommand(2, 5, 4));
            commands.AddLast(new AddWaterCommand(2, 6, 4));
            commands.AddLast(new AddWaterCommand(2, 7, 4));

            commands.AddLast(new AddWaterCommand(2, 0, 5));
            commands.AddLast(new AddWaterCommand(2, 1, 5));
            commands.AddLast(new AddWaterCommand(2, 2, 5));
            commands.AddLast(new AddWaterCommand(2, 3, 5));
            commands.AddLast(new AddWaterCommand(2, 4, 5));
            commands.AddLast(new AddWaterCommand(2, 5, 5));
            commands.AddLast(new AddWaterCommand(2, 6, 5));
            commands.AddLast(new AddWaterCommand(2, 7, 5));

            commands.AddLast(new AddWaterCommand(2, 0, 6));
            commands.AddLast(new AddWaterCommand(2, 1, 6));
            commands.AddLast(new AddWaterCommand(2, 2, 6));
            commands.AddLast(new AddWaterCommand(2, 3, 6));
            commands.AddLast(new AddWaterCommand(2, 4, 6));
            commands.AddLast(new AddWaterCommand(2, 5, 6));
            commands.AddLast(new AddWaterCommand(2, 6, 6));
            commands.AddLast(new AddWaterCommand(2, 7, 6));

            commands.AddLast(new AddWaterCommand(2, 0, 7));
            commands.AddLast(new AddWaterCommand(2, 1, 7));
            commands.AddLast(new AddWaterCommand(2, 2, 7));
            commands.AddLast(new AddWaterCommand(2, 3, 7));
            commands.AddLast(new AddWaterCommand(2, 4, 7));
            commands.AddLast(new AddWaterCommand(2, 5, 7));
            commands.AddLast(new AddWaterCommand(2, 6, 7));
            commands.AddLast(new AddWaterCommand(2, 7, 7));

            commands.AddLast(new AddWaterCommand(2, 0, 8));
            commands.AddLast(new AddWaterCommand(2, 1, 8));
            commands.AddLast(new AddWaterCommand(2, 2, 8));
            commands.AddLast(new AddWaterCommand(2, 3, 8));
            commands.AddLast(new AddWaterCommand(2, 4, 8));
            commands.AddLast(new AddWaterCommand(2, 5, 8));
            commands.AddLast(new AddWaterCommand(2, 6, 8));
            commands.AddLast(new AddWaterCommand(2, 7, 8));




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



            commands.AddLast(new AddWaterCommand(2, 0, 9));
            commands.AddLast(new AddWaterCommand(2, 1, 9));
            commands.AddLast(new AddWaterCommand(2, 2, 9));
            commands.AddLast(new AddWaterCommand(2, 3, 9));
            commands.AddLast(new AddWaterCommand(2, 4, 9));
            commands.AddLast(new AddWaterCommand(2, 5, 9));
            commands.AddLast(new AddWaterCommand(2, 6, 9));
            commands.AddLast(new AddWaterCommand(2, 7, 9));
            commands.AddLast(new AddWaterCommand(2, 8, 9));
            commands.AddLast(new AddWaterCommand(2, 9, 9));
            commands.AddLast(new AddWaterCommand(2, 10, 9));
            commands.AddLast(new AddWaterCommand(2, 11, 9));
            commands.AddLast(new AddWaterCommand(2, 12, 9));
            commands.AddLast(new AddWaterCommand(2, 13, 9));
            commands.AddLast(new AddWaterCommand(2, 14, 9));
            commands.AddLast(new AddWaterCommand(2, 15, 9));
            commands.AddLast(new AddWaterCommand(2, 16, 9));

            commands.AddLast(new AddWaterCommand(2, 0, 10));
            commands.AddLast(new AddWaterCommand(2, 1, 10));
            commands.AddLast(new AddWaterCommand(2, 2, 10));
            commands.AddLast(new AddWaterCommand(2, 3, 10));
            commands.AddLast(new AddWaterCommand(2, 4, 10));
            commands.AddLast(new AddWaterCommand(2, 5, 10));
            commands.AddLast(new AddWaterCommand(2, 6, 10));
            commands.AddLast(new AddWaterCommand(2, 7, 10));
            commands.AddLast(new AddWaterCommand(2, 8, 10));
            commands.AddLast(new AddWaterCommand(2, 9, 10));
            commands.AddLast(new AddWaterCommand(2, 10, 10));
            commands.AddLast(new AddWaterCommand(2, 11, 10));
            commands.AddLast(new AddWaterCommand(2, 12, 10));
            commands.AddLast(new AddWaterCommand(2, 13, 10));
            commands.AddLast(new AddWaterCommand(2, 14, 10));
            commands.AddLast(new AddWaterCommand(2, 15, 10));
            commands.AddLast(new AddWaterCommand(2, 16, 10));

            commands.AddLast(new AddWaterCommand(2, 0, 11));
            commands.AddLast(new AddWaterCommand(2, 1, 11));
            commands.AddLast(new AddWaterCommand(2, 2, 11));
            commands.AddLast(new AddWaterCommand(2, 3, 11));
            commands.AddLast(new AddWaterCommand(2, 4, 11));
            commands.AddLast(new AddWaterCommand(2, 5, 11));
            commands.AddLast(new AddWaterCommand(2, 6, 11));
            commands.AddLast(new AddWaterCommand(2, 7, 11));
            commands.AddLast(new AddWaterCommand(2, 8, 11));
            commands.AddLast(new AddWaterCommand(2, 9, 11));
            commands.AddLast(new AddWaterCommand(2, 10, 11));
            commands.AddLast(new AddWaterCommand(2, 11, 11));
            commands.AddLast(new AddWaterCommand(2, 12, 11));
            commands.AddLast(new AddWaterCommand(2, 13, 11));
            commands.AddLast(new AddWaterCommand(2, 14, 11));
            commands.AddLast(new AddWaterCommand(2, 15, 11));
            commands.AddLast(new AddWaterCommand(2, 16, 11));



            commands.AddLast(new AddWaterCommand(2, 0, 12));
            commands.AddLast(new AddWaterCommand(2, 1, 12));
            commands.AddLast(new AddWaterCommand(2, 2, 12));
            commands.AddLast(new AddWaterCommand(2, 3, 12));
            commands.AddLast(new AddWaterCommand(2, 4, 12));
            commands.AddLast(new AddWaterCommand(2, 5, 12));
            commands.AddLast(new AddWaterCommand(2, 6, 12));
            commands.AddLast(new AddWaterCommand(2, 7, 12));
            commands.AddLast(new AddWaterCommand(2, 8, 12));
            commands.AddLast(new AddWaterCommand(2, 9, 12));
            commands.AddLast(new AddWaterCommand(2, 10, 12));
            commands.AddLast(new AddWaterCommand(2, 11, 12));
            commands.AddLast(new AddWaterCommand(2, 12, 12));
            commands.AddLast(new AddWaterCommand(2, 13, 12));
            commands.AddLast(new AddWaterCommand(2, 14, 12));
            commands.AddLast(new AddWaterCommand(2, 15, 12));
            commands.AddLast(new AddWaterCommand(2, 16, 12));

            commands.AddLast(new AddWaterCommand(2, 0, 13));
            commands.AddLast(new AddWaterCommand(2, 1, 13));
            commands.AddLast(new AddWaterCommand(2, 2, 13));
            commands.AddLast(new AddWaterCommand(2, 3, 13));
            commands.AddLast(new AddWaterCommand(2, 4, 13));
            commands.AddLast(new AddWaterCommand(2, 5, 13));
            commands.AddLast(new AddWaterCommand(2, 6, 13));
            commands.AddLast(new AddWaterCommand(2, 7, 13));
            commands.AddLast(new AddWaterCommand(2, 8, 13));
            commands.AddLast(new AddWaterCommand(2, 9, 13));
            commands.AddLast(new AddWaterCommand(2, 10, 13));
            commands.AddLast(new AddWaterCommand(2, 11, 13));
            commands.AddLast(new AddWaterCommand(2, 12, 13));
            commands.AddLast(new AddWaterCommand(2, 13, 13));
            commands.AddLast(new AddWaterCommand(2, 14, 13));
            commands.AddLast(new AddWaterCommand(2, 15, 13));
            commands.AddLast(new AddWaterCommand(2, 16, 13));

            commands.AddLast(new AddWaterCommand(2, 0, 14));
            commands.AddLast(new AddWaterCommand(2, 1, 14));
            commands.AddLast(new AddWaterCommand(2, 2, 14));
            commands.AddLast(new AddWaterCommand(2, 3, 14));
            commands.AddLast(new AddWaterCommand(2, 4, 14));
            commands.AddLast(new AddWaterCommand(2, 5, 14));
            commands.AddLast(new AddWaterCommand(2, 6, 14));
            commands.AddLast(new AddWaterCommand(2, 7, 14));
            commands.AddLast(new AddWaterCommand(2, 8, 14));
            commands.AddLast(new AddWaterCommand(2, 9, 14));
            commands.AddLast(new AddWaterCommand(2, 10, 14));
            commands.AddLast(new AddWaterCommand(2, 11, 14));
            commands.AddLast(new AddWaterCommand(2, 12, 14));
            commands.AddLast(new AddWaterCommand(2, 13, 14));
            commands.AddLast(new AddWaterCommand(2, 14, 14));
            commands.AddLast(new AddWaterCommand(2, 15, 14));
            commands.AddLast(new AddWaterCommand(2, 16, 14));


          
            commands.AddLast(new AddPortalCommand(4, 8, 0, 1, 15));
            commands.AddLast(new AddPortalCommand(4, 9, 0, 1, 15));
            commands.AddLast(new AddPortalCommand(4, 10, 0, 1, 15));

            commands.AddLast(new AddPortalCommand(4, 16, 5, 5, 21));
            commands.AddLast(new AddPortalCommand(4, 16, 6, 5, 21));
            commands.AddLast(new AddPortalCommand(4, 16, 7, 5, 21));
            commands.AddLast(new AddPortalCommand(4, 16, 8, 5, 21));

        }

        private void BuildScreen21(LinkedList<WorldBuilderCommand> commands)
        {
            commands.AddLast(new DeclareScreenCommand(1, 4));

            // Upper-left forest
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

            commands.AddLast(new AddTreeCommand(2, 2, 5));
            commands.AddLast(new AddTreeCommand(2, 3, 5));

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




            commands.AddLast(new AddWaterCommand(2, 0, 9));
            commands.AddLast(new AddWaterCommand(2, 1, 9));
            commands.AddLast(new AddWaterCommand(2, 2, 9));
            commands.AddLast(new AddWaterCommand(2, 3, 9));
            commands.AddLast(new AddWaterCommand(2, 4, 9));
            commands.AddLast(new AddWaterCommand(2, 5, 9));
            commands.AddLast(new AddWaterCommand(2, 6, 9));
            commands.AddLast(new AddWaterCommand(2, 7, 9));
            commands.AddLast(new AddWaterCommand(2, 8, 9));
            commands.AddLast(new AddWaterCommand(2, 9, 9));
            commands.AddLast(new AddWaterCommand(2, 10, 9));
            commands.AddLast(new AddWaterCommand(2, 11, 9));
            commands.AddLast(new AddWaterCommand(2, 12, 9));
            commands.AddLast(new AddWaterCommand(2, 13, 9));
            commands.AddLast(new AddWaterCommand(2, 14, 9));
            commands.AddLast(new AddWaterCommand(2, 15, 9));
            commands.AddLast(new AddWaterCommand(2, 16, 9));

            commands.AddLast(new AddWaterCommand(2, 0, 10));
            commands.AddLast(new AddWaterCommand(2, 1, 10));
            commands.AddLast(new AddWaterCommand(2, 2, 10));
            commands.AddLast(new AddWaterCommand(2, 3, 10));
            commands.AddLast(new AddWaterCommand(2, 4, 10));
            commands.AddLast(new AddWaterCommand(2, 5, 10));
            commands.AddLast(new AddWaterCommand(2, 6, 10));
            commands.AddLast(new AddWaterCommand(2, 7, 10));
            commands.AddLast(new AddWaterCommand(2, 8, 10));
            commands.AddLast(new AddWaterCommand(2, 9, 10));
            commands.AddLast(new AddWaterCommand(2, 10, 10));
            commands.AddLast(new AddWaterCommand(2, 11, 10));
            commands.AddLast(new AddWaterCommand(2, 12, 10));
            commands.AddLast(new AddWaterCommand(2, 13, 10));
            commands.AddLast(new AddWaterCommand(2, 14, 10));
            commands.AddLast(new AddWaterCommand(2, 15, 10));
            commands.AddLast(new AddWaterCommand(2, 16, 10));

            commands.AddLast(new AddWaterCommand(2, 0, 11));
            commands.AddLast(new AddWaterCommand(2, 1, 11));
            commands.AddLast(new AddWaterCommand(2, 2, 11));
            commands.AddLast(new AddWaterCommand(2, 3, 11));
            commands.AddLast(new AddWaterCommand(2, 4, 11));
            commands.AddLast(new AddWaterCommand(2, 5, 11));
            commands.AddLast(new AddWaterCommand(2, 6, 11));
            commands.AddLast(new AddWaterCommand(2, 7, 11));
            commands.AddLast(new AddWaterCommand(2, 8, 11));
            commands.AddLast(new AddWaterCommand(2, 9, 11));
            commands.AddLast(new AddWaterCommand(2, 10, 11));
            commands.AddLast(new AddWaterCommand(2, 11, 11));
            commands.AddLast(new AddWaterCommand(2, 12, 11));
            commands.AddLast(new AddWaterCommand(2, 13, 11));
            commands.AddLast(new AddWaterCommand(2, 14, 11));
            commands.AddLast(new AddWaterCommand(2, 15, 11));
            commands.AddLast(new AddWaterCommand(2, 16, 11));



            commands.AddLast(new AddWaterCommand(2, 0, 12));
            commands.AddLast(new AddWaterCommand(2, 1, 12));
            commands.AddLast(new AddWaterCommand(2, 2, 12));
            commands.AddLast(new AddWaterCommand(2, 3, 12));
            commands.AddLast(new AddWaterCommand(2, 4, 12));
            commands.AddLast(new AddWaterCommand(2, 5, 12));
            commands.AddLast(new AddWaterCommand(2, 6, 12));
            commands.AddLast(new AddWaterCommand(2, 7, 12));
            commands.AddLast(new AddWaterCommand(2, 8, 12));
            commands.AddLast(new AddWaterCommand(2, 9, 12));
            commands.AddLast(new AddWaterCommand(2, 10, 12));
            commands.AddLast(new AddWaterCommand(2, 11, 12));
            commands.AddLast(new AddWaterCommand(2, 12, 12));
            commands.AddLast(new AddWaterCommand(2, 13, 12));
            commands.AddLast(new AddWaterCommand(2, 14, 12));
            commands.AddLast(new AddWaterCommand(2, 15, 12));
            commands.AddLast(new AddWaterCommand(2, 16, 12));

            commands.AddLast(new AddWaterCommand(2, 0, 13));
            commands.AddLast(new AddWaterCommand(2, 1, 13));
            commands.AddLast(new AddWaterCommand(2, 2, 13));
            commands.AddLast(new AddWaterCommand(2, 3, 13));
            commands.AddLast(new AddWaterCommand(2, 4, 13));
            commands.AddLast(new AddWaterCommand(2, 5, 13));
            commands.AddLast(new AddWaterCommand(2, 6, 13));
            commands.AddLast(new AddWaterCommand(2, 7, 13));
            commands.AddLast(new AddWaterCommand(2, 8, 13));
            commands.AddLast(new AddWaterCommand(2, 9, 13));
            commands.AddLast(new AddWaterCommand(2, 10, 13));
            commands.AddLast(new AddWaterCommand(2, 11, 13));
            commands.AddLast(new AddWaterCommand(2, 12, 13));
            commands.AddLast(new AddWaterCommand(2, 13, 13));
            commands.AddLast(new AddWaterCommand(2, 14, 13));
            commands.AddLast(new AddWaterCommand(2, 15, 13));
            commands.AddLast(new AddWaterCommand(2, 16, 13));

            commands.AddLast(new AddWaterCommand(2, 0, 14));
            commands.AddLast(new AddWaterCommand(2, 1, 14));
            commands.AddLast(new AddWaterCommand(2, 2, 14));
            commands.AddLast(new AddWaterCommand(2, 3, 14));
            commands.AddLast(new AddWaterCommand(2, 4, 14));
            commands.AddLast(new AddWaterCommand(2, 5, 14));
            commands.AddLast(new AddWaterCommand(2, 6, 14));
            commands.AddLast(new AddWaterCommand(2, 7, 14));
            commands.AddLast(new AddWaterCommand(2, 8, 14));
            commands.AddLast(new AddWaterCommand(2, 9, 14));
            commands.AddLast(new AddWaterCommand(2, 10, 14));
            commands.AddLast(new AddWaterCommand(2, 11, 14));
            commands.AddLast(new AddWaterCommand(2, 12, 14));
            commands.AddLast(new AddWaterCommand(2, 13, 14));
            commands.AddLast(new AddWaterCommand(2, 14, 14));
            commands.AddLast(new AddWaterCommand(2, 15, 14));
            commands.AddLast(new AddWaterCommand(2, 16, 14));

            commands.AddLast(new AddPortalCommand(4, 0, 5, 3, 20));
            commands.AddLast(new AddPortalCommand(4, 0, 6, 3, 20));
            commands.AddLast(new AddPortalCommand(4, 0, 7, 3, 20));
            commands.AddLast(new AddPortalCommand(4, 0, 8, 3, 20));

            commands.AddLast(new AddPortalCommand(4, 7, 0, 1, 16));
            commands.AddLast(new AddPortalCommand(4, 8, 0, 1, 16));
            commands.AddLast(new AddPortalCommand(4, 9, 0, 1, 16));
            commands.AddLast(new AddPortalCommand(4, 10, 0, 1, 16));

            commands.AddLast(new AddPortalCommand(4, 16, 5, 5, 22));
            commands.AddLast(new AddPortalCommand(4, 16, 6, 5, 22));
            commands.AddLast(new AddPortalCommand(4, 16, 7, 5, 22));
            commands.AddLast(new AddPortalCommand(4, 16, 8, 5, 22));

        }

        private void BuildScreen22(LinkedList<WorldBuilderCommand> commands)
        {
            commands.AddLast(new DeclareScreenCommand(2, 4));

            // Upper-left forest
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






            commands.AddLast(new AddWaterCommand(2, 0, 9));
            commands.AddLast(new AddWaterCommand(2, 1, 9));
            commands.AddLast(new AddWaterCommand(2, 2, 9));
            commands.AddLast(new AddWaterCommand(2, 3, 9));

            commands.AddLast(new AddWaterCommand(2, 0, 10));
            commands.AddLast(new AddWaterCommand(2, 1, 10));
            commands.AddLast(new AddWaterCommand(2, 2, 10));
            commands.AddLast(new AddWaterCommand(2, 3, 10));

            commands.AddLast(new AddWaterCommand(2, 0, 11));
            commands.AddLast(new AddWaterCommand(2, 1, 11));
            commands.AddLast(new AddWaterCommand(2, 2, 11));
            commands.AddLast(new AddWaterCommand(2, 3, 11));

            commands.AddLast(new AddWaterCommand(2, 13, 9));
            commands.AddLast(new AddWaterCommand(2, 14, 9));
            commands.AddLast(new AddWaterCommand(2, 15, 9));
            commands.AddLast(new AddWaterCommand(2, 16, 9));

            commands.AddLast(new AddWaterCommand(2, 13, 10));
            commands.AddLast(new AddWaterCommand(2, 14, 10));
            commands.AddLast(new AddWaterCommand(2, 15, 10));
            commands.AddLast(new AddWaterCommand(2, 16, 10));

            commands.AddLast(new AddWaterCommand(2, 13, 11));
            commands.AddLast(new AddWaterCommand(2, 14, 11));
            commands.AddLast(new AddWaterCommand(2, 15, 11));
            commands.AddLast(new AddWaterCommand(2, 16, 11));


            commands.AddLast(new AddWaterCommand(2, 0, 12));
            commands.AddLast(new AddWaterCommand(2, 1, 12));
            commands.AddLast(new AddWaterCommand(2, 2, 12));
            commands.AddLast(new AddWaterCommand(2, 3, 12));
            commands.AddLast(new AddWaterCommand(2, 4, 12));
            commands.AddLast(new AddWaterCommand(2, 5, 12));
            commands.AddLast(new AddWaterCommand(2, 6, 12));
            commands.AddLast(new AddWaterCommand(2, 7, 12));
            commands.AddLast(new AddWaterCommand(2, 8, 12));
            commands.AddLast(new AddWaterCommand(2, 9, 12));
            commands.AddLast(new AddWaterCommand(2, 10, 12));
            commands.AddLast(new AddWaterCommand(2, 11, 12));
            commands.AddLast(new AddWaterCommand(2, 12, 12));
            commands.AddLast(new AddWaterCommand(2, 13, 12));
            commands.AddLast(new AddWaterCommand(2, 14, 12));
            commands.AddLast(new AddWaterCommand(2, 15, 12));
            commands.AddLast(new AddWaterCommand(2, 16, 12));

            commands.AddLast(new AddWaterCommand(2, 0, 13));
            commands.AddLast(new AddWaterCommand(2, 1, 13));
            commands.AddLast(new AddWaterCommand(2, 2, 13));
            commands.AddLast(new AddWaterCommand(2, 3, 13));
            commands.AddLast(new AddWaterCommand(2, 4, 13));
            commands.AddLast(new AddWaterCommand(2, 5, 13));
            commands.AddLast(new AddWaterCommand(2, 6, 13));
            commands.AddLast(new AddWaterCommand(2, 7, 13));
            commands.AddLast(new AddWaterCommand(2, 8, 13));
            commands.AddLast(new AddWaterCommand(2, 9, 13));
            commands.AddLast(new AddWaterCommand(2, 10, 13));
            commands.AddLast(new AddWaterCommand(2, 11, 13));
            commands.AddLast(new AddWaterCommand(2, 12, 13));
            commands.AddLast(new AddWaterCommand(2, 13, 13));
            commands.AddLast(new AddWaterCommand(2, 14, 13));
            commands.AddLast(new AddWaterCommand(2, 15, 13));
            commands.AddLast(new AddWaterCommand(2, 16, 13));        

            commands.AddLast(new AddWaterCommand(2, 0, 14));
            commands.AddLast(new AddWaterCommand(2, 1, 14));
            commands.AddLast(new AddWaterCommand(2, 2, 14));
            commands.AddLast(new AddWaterCommand(2, 3, 14));
            commands.AddLast(new AddWaterCommand(2, 4, 14));
            commands.AddLast(new AddWaterCommand(2, 5, 14));
            commands.AddLast(new AddWaterCommand(2, 6, 14));
            commands.AddLast(new AddWaterCommand(2, 7, 14));
            commands.AddLast(new AddWaterCommand(2, 8, 14));
            commands.AddLast(new AddWaterCommand(2, 9, 14));
            commands.AddLast(new AddWaterCommand(2, 10, 14));
            commands.AddLast(new AddWaterCommand(2, 11, 14));
            commands.AddLast(new AddWaterCommand(2, 12, 14));
            commands.AddLast(new AddWaterCommand(2, 13, 14));
            commands.AddLast(new AddWaterCommand(2, 14, 14));
            commands.AddLast(new AddWaterCommand(2, 15, 14));
            commands.AddLast(new AddWaterCommand(2, 16, 14));

           
            commands.AddLast(new AddPortalCommand(4, 0, 5, 3, 21));
            commands.AddLast(new AddPortalCommand(4, 0, 6, 3, 21));
            commands.AddLast(new AddPortalCommand(4, 0, 7, 3, 21));
            commands.AddLast(new AddPortalCommand(4, 0, 8, 3, 21));

            commands.AddLast(new AddPortalCommand(4, 7, 0, 1, 17));
            commands.AddLast(new AddPortalCommand(4, 8, 0, 1, 17));
            commands.AddLast(new AddPortalCommand(4, 9, 0, 1, 17));
            commands.AddLast(new AddPortalCommand(4, 10, 0, 1, 17));

            commands.AddLast(new AddPortalCommand(4, 16, 5, 5, 23));
            commands.AddLast(new AddPortalCommand(4, 16, 6, 5, 23));
            commands.AddLast(new AddPortalCommand(4, 16, 7, 5, 23));
            commands.AddLast(new AddPortalCommand(4, 16, 8, 5, 23));

        }

        private void BuildScreen23(LinkedList<WorldBuilderCommand> commands)
        {
            commands.AddLast(new DeclareScreenCommand(3, 4));

            // Upper-left forest
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

            commands.AddLast(new AddTreeCommand(2, 0, 3));
            commands.AddLast(new AddTreeCommand(2, 1, 3));

            commands.AddLast(new AddTreeCommand(2, 0, 4));
            commands.AddLast(new AddTreeCommand(2, 1, 4));


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

            commands.AddLast(new AddTreeCommand(2, 12, 5));
            commands.AddLast(new AddTreeCommand(2, 13, 5));
            commands.AddLast(new AddTreeCommand(2, 14, 5));
            commands.AddLast(new AddTreeCommand(2, 15, 5));
            commands.AddLast(new AddTreeCommand(2, 16, 5));


            commands.AddLast(new AddWaterCommand(2, 0, 9));
            commands.AddLast(new AddWaterCommand(2, 0, 10));
            commands.AddLast(new AddWaterCommand(2, 0, 11));
            commands.AddLast(new AddWaterCommand(2, 0, 12));
            commands.AddLast(new AddWaterCommand(2, 0, 13));

            commands.AddLast(new AddWaterCommand(2, 0, 13));
            commands.AddLast(new AddWaterCommand(2, 1, 13));
            commands.AddLast(new AddWaterCommand(2, 2, 13));
            commands.AddLast(new AddWaterCommand(2, 3, 13));
            commands.AddLast(new AddWaterCommand(2, 4, 13));
            commands.AddLast(new AddWaterCommand(2, 5, 13));
            commands.AddLast(new AddWaterCommand(2, 6, 13));
            commands.AddLast(new AddWaterCommand(2, 7, 13));
            commands.AddLast(new AddWaterCommand(2, 8, 13));
            commands.AddLast(new AddWaterCommand(2, 9, 13));
            commands.AddLast(new AddWaterCommand(2, 10, 13));
            commands.AddLast(new AddWaterCommand(2, 11, 13));
            commands.AddLast(new AddWaterCommand(2, 12, 13));
            commands.AddLast(new AddWaterCommand(2, 13, 13));
            commands.AddLast(new AddWaterCommand(2, 14, 13));
            commands.AddLast(new AddWaterCommand(2, 15, 13));
            commands.AddLast(new AddWaterCommand(2, 16, 13));

            commands.AddLast(new AddWaterCommand(2, 0, 14));
            commands.AddLast(new AddWaterCommand(2, 1, 14));
            commands.AddLast(new AddWaterCommand(2, 2, 14));
            commands.AddLast(new AddWaterCommand(2, 3, 14));
            commands.AddLast(new AddWaterCommand(2, 4, 14));
            commands.AddLast(new AddWaterCommand(2, 5, 14));
            commands.AddLast(new AddWaterCommand(2, 6, 14));
            commands.AddLast(new AddWaterCommand(2, 7, 14));
            commands.AddLast(new AddWaterCommand(2, 8, 14));
            commands.AddLast(new AddWaterCommand(2, 9, 14));
            commands.AddLast(new AddWaterCommand(2, 10, 14));
            commands.AddLast(new AddWaterCommand(2, 11, 14));
            commands.AddLast(new AddWaterCommand(2, 12, 14));
            commands.AddLast(new AddWaterCommand(2, 13, 14));
            commands.AddLast(new AddWaterCommand(2, 14, 14));
            commands.AddLast(new AddWaterCommand(2, 15, 14));
            commands.AddLast(new AddWaterCommand(2, 16, 14));



            commands.AddLast(new AddPortalCommand(4, 0, 5, 3, 22));
            commands.AddLast(new AddPortalCommand(4, 0, 6, 3, 22));
            commands.AddLast(new AddPortalCommand(4, 0, 7, 3, 22));
            commands.AddLast(new AddPortalCommand(4, 0, 8, 3, 22));

            commands.AddLast(new AddPortalCommand(4, 7, 0, 1, 18));
            commands.AddLast(new AddPortalCommand(4, 8, 0, 1, 18));
            commands.AddLast(new AddPortalCommand(4, 9, 0, 1, 18));
            commands.AddLast(new AddPortalCommand(4, 10, 0, 1, 18));

            commands.AddLast(new AddPortalCommand(4, 16, 5, 5, 24));
            commands.AddLast(new AddPortalCommand(4, 16, 6, 5, 24));
            commands.AddLast(new AddPortalCommand(4, 16, 7, 5, 24));
            commands.AddLast(new AddPortalCommand(4, 16, 8, 5, 24));
            commands.AddLast(new AddPortalCommand(4, 16, 9, 5, 24));
            commands.AddLast(new AddPortalCommand(4, 16, 10, 5, 24));
            commands.AddLast(new AddPortalCommand(4, 16, 11, 5, 24));
            commands.AddLast(new AddPortalCommand(4, 16, 12, 5, 24));
        }

        private void BuildScreen24(LinkedList<WorldBuilderCommand> commands)
        {
            commands.AddLast(new DeclareScreenCommand(4, 4));

            commands.AddLast(new AddTreeCommand(2, 0, 0));
            commands.AddLast(new AddTreeCommand(2, 1, 0));
            commands.AddLast(new AddTreeCommand(2, 2, 0));
            commands.AddLast(new AddTreeCommand(2, 3, 0));
            commands.AddLast(new AddTreeCommand(2, 4, 0));

            commands.AddLast(new AddTreeCommand(2, 0, 1));
            commands.AddLast(new AddTreeCommand(2, 1, 1));
            commands.AddLast(new AddTreeCommand(2, 2, 1));
            commands.AddLast(new AddTreeCommand(2, 3, 1));
            commands.AddLast(new AddTreeCommand(2, 4, 1));

            commands.AddLast(new AddTreeCommand(2, 0, 2));
            commands.AddLast(new AddTreeCommand(2, 1, 2));
            commands.AddLast(new AddTreeCommand(2, 2, 2));
            commands.AddLast(new AddTreeCommand(2, 3, 2));
            commands.AddLast(new AddTreeCommand(2, 4, 2));

            commands.AddLast(new AddTreeCommand(2, 0, 3));
            commands.AddLast(new AddTreeCommand(2, 1, 3));
            commands.AddLast(new AddTreeCommand(2, 2, 3));
            commands.AddLast(new AddTreeCommand(2, 3, 3));
            commands.AddLast(new AddTreeCommand(2, 4, 3));

            commands.AddLast(new AddTreeCommand(2, 0, 4));
            commands.AddLast(new AddTreeCommand(2, 1, 4));
            commands.AddLast(new AddTreeCommand(2, 2, 4));
            commands.AddLast(new AddTreeCommand(2, 3, 4));
            commands.AddLast(new AddTreeCommand(2, 4, 4));

            commands.AddLast(new AddTreeCommand(2, 2, 5));
            commands.AddLast(new AddTreeCommand(2, 3, 5));

            commands.AddLast(new AddTreeCommand(2, 12, 0));
            commands.AddLast(new AddTreeCommand(2, 13, 0));
            commands.AddLast(new AddTreeCommand(2, 14, 0));
            commands.AddLast(new AddTreeCommand(2, 15, 0));
            commands.AddLast(new AddTreeCommand(2, 16, 0));

            commands.AddLast(new AddTreeCommand(2, 13, 1));
            commands.AddLast(new AddTreeCommand(2, 14, 1));
            commands.AddLast(new AddTreeCommand(2, 15, 1));
            commands.AddLast(new AddTreeCommand(2, 16, 1));

            commands.AddLast(new AddTreeCommand(2, 13, 2));
            commands.AddLast(new AddTreeCommand(2, 14, 2));
            commands.AddLast(new AddTreeCommand(2, 15, 2));
            commands.AddLast(new AddTreeCommand(2, 16, 2));

            commands.AddLast(new AddTreeCommand(2, 14, 3));
            commands.AddLast(new AddTreeCommand(2, 15, 3));
            commands.AddLast(new AddTreeCommand(2, 16, 3));

            commands.AddLast(new AddTreeCommand(2, 15, 4));
            commands.AddLast(new AddTreeCommand(2, 16, 4));

            commands.AddLast(new AddTreeCommand(2, 16, 5));

            commands.AddLast(new AddTreeCommand(2, 16, 6));

            commands.AddLast(new AddTreeCommand(2, 16, 7));

            commands.AddLast(new AddTreeCommand(2, 16, 8));

            commands.AddLast(new AddTreeCommand(2, 16, 9));

            commands.AddLast(new AddTreeCommand(2, 16, 10));

            commands.AddLast(new AddTreeCommand(2, 15, 11));
            commands.AddLast(new AddTreeCommand(2, 16, 11));

            commands.AddLast(new AddTreeCommand(2, 15, 12));
            commands.AddLast(new AddTreeCommand(2, 16, 12));

            commands.AddLast(new AddTreeCommand(2, 14, 13));
            commands.AddLast(new AddTreeCommand(2, 15, 13));
            commands.AddLast(new AddTreeCommand(2, 16, 13));

            commands.AddLast(new AddWaterCommand(2, 0, 13));
            commands.AddLast(new AddWaterCommand(2, 1, 13));
            commands.AddLast(new AddWaterCommand(2, 2, 13));

            commands.AddLast(new AddWaterCommand(2, 0, 14));
            commands.AddLast(new AddWaterCommand(2, 1, 14));
            commands.AddLast(new AddWaterCommand(2, 2, 14));

            commands.AddLast(new AddWaterCommand(2, 0, 14));
            commands.AddLast(new AddWaterCommand(2, 1, 14));
            commands.AddLast(new AddWaterCommand(2, 2, 14));
            commands.AddLast(new AddWaterCommand(2, 3, 14));
            commands.AddLast(new AddWaterCommand(2, 4, 14));
            commands.AddLast(new AddWaterCommand(2, 5, 14));
            commands.AddLast(new AddWaterCommand(2, 6, 14));
            commands.AddLast(new AddWaterCommand(2, 7, 14));
            commands.AddLast(new AddWaterCommand(2, 8, 14));
            commands.AddLast(new AddWaterCommand(2, 9, 14));
            commands.AddLast(new AddWaterCommand(2, 10, 14));
            commands.AddLast(new AddWaterCommand(2, 11, 14));
            commands.AddLast(new AddWaterCommand(2, 12, 14));
            commands.AddLast(new AddWaterCommand(2, 13, 14));
            commands.AddLast(new AddWaterCommand(2, 14, 14));
            commands.AddLast(new AddWaterCommand(2, 15, 14));
            commands.AddLast(new AddWaterCommand(2, 16, 14));

            commands.AddLast(new AddPortalCommand(4, 0, 5, 3, 23));
            commands.AddLast(new AddPortalCommand(4, 0, 6, 3, 23));
            commands.AddLast(new AddPortalCommand(4, 0, 7, 3, 23));
            commands.AddLast(new AddPortalCommand(4, 0, 8, 3, 23));
            commands.AddLast(new AddPortalCommand(4, 0, 9, 3, 23));
            commands.AddLast(new AddPortalCommand(4, 0, 10, 3, 23));
            commands.AddLast(new AddPortalCommand(4, 0, 11, 3, 23));
            commands.AddLast(new AddPortalCommand(4, 0, 12, 3, 23));

            commands.AddLast(new AddPortalCommand(4, 5, 0, 1, 19));
            commands.AddLast(new AddPortalCommand(4, 6, 0, 1, 19));
            commands.AddLast(new AddPortalCommand(4, 7, 0, 1, 19));
            commands.AddLast(new AddPortalCommand(4, 8, 0, 1, 19));
            commands.AddLast(new AddPortalCommand(4, 9, 0, 1, 19));
            commands.AddLast(new AddPortalCommand(4, 10, 0, 1, 19));
            commands.AddLast(new AddPortalCommand(4, 11, 0, 1, 19));
        }
    }
}
