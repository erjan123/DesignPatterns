namespace Command.GoFCommandStructural
{
    partial class GoFCommandClientCode
    {
        /// <summary>
        /// The 'Command' abstract class Command 
        /// </summary>
        abstract class Command
        {
            protected Receiver receiver;

            // Constructor
            public Command(Receiver receiver)
            {
                this.receiver = receiver;
            }

            public abstract void Execute();
        }
    }
}
