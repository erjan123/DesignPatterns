using System;
using System.Collections.Generic;
using System.Text;

namespace Command.CommandWithDelegate
{

    class CommandWithDelegateClientCode
    {
        public static void Run()
        {
            new Command(new Receiver());
            Execute();
            Redo();
            Undo();
            Execute();

            Console.WriteLine();
            Console.WriteLine("******************************************");
            Console.WriteLine();
        }

        // Command Pattern Judith Bishop June 2007
        // Uses a single delegate for the single type of commands that
        // the client invokes

        delegate void Invoker();
        static Invoker Execute, Undo, Redo;

        class Command
        {
            public Command(Receiver receiver)
            {
                Execute = receiver.Action;
                Redo = receiver.Action;
                Undo = receiver.Reverse;
            }
        }

        public class Receiver
        {
            string build, oldbuild;
            string s = "some string ";

            public void Action()
            {
                oldbuild = build;
                build += s;
                Console.WriteLine("Receiver is adding " + build);
            }

            public void Reverse()
            {
                build = oldbuild;
                Console.WriteLine("Receiver is reverting to " + build);
            }
        }
    }
}
 
