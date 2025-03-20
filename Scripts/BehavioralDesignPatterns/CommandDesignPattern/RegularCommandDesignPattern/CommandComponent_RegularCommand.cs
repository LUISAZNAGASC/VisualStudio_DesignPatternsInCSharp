namespace VisualStudio_DesignPatternsInCSharp.Scripts.BehavioralDesignPatterns.CommandDesignPattern.RegularCommandDesignPattern
{
    using System;
    using System.Text;

    public abstract class CommandComponent<Template1> where Template1 : class
    {
        protected Template1 CommandComponentReference { get; }

        protected CommandComponent() : base()
        {

        }

        protected CommandComponent(in Template1 commandComponentReference) : base()
        {
            CommandComponentReference = commandComponentReference;
        }

        public abstract void ExecuteCommandComponentUndoOperation();

        public abstract void ExecuteCommandComponentRedoOperation();

        public override bool Equals(object uncastedCommandComponent)
        {
            StringBuilder commandComponentStringBuilder = new();

            commandComponentStringBuilder.Append(value: $"[START]{nameof(CommandComponent<Template1>)}[START]");
            commandComponentStringBuilder.AppendLine(value: string.Empty);
            commandComponentStringBuilder.Append(value: $"Method not implemented in '{nameof(CommandComponent<Template1>)}' class");
            commandComponentStringBuilder.AppendLine(value: string.Empty);
            commandComponentStringBuilder.Append(value: $"[END]{nameof(CommandComponent<Template1>)}[END]");

            throw new NotImplementedException(message: commandComponentStringBuilder.ToString(), inner: new Exception());
        }

        public override int GetHashCode()
        {
            StringBuilder commandComponentStringBuilder = new();

            commandComponentStringBuilder.Append(value: $"[START]{nameof(CommandComponent<Template1>)}[START]");
            commandComponentStringBuilder.AppendLine(value: string.Empty);
            commandComponentStringBuilder.Append(value: $"Method not implemented in '{nameof(CommandComponent<Template1>)}' class");
            commandComponentStringBuilder.AppendLine(value: string.Empty);
            commandComponentStringBuilder.Append(value: $"[END]{nameof(CommandComponent<Template1>)}[END]");

            throw new NotImplementedException(message: commandComponentStringBuilder.ToString(), inner: new Exception());
        }

        public override string ToString()
        {
            StringBuilder commandComponentStringBuilder = new();

            commandComponentStringBuilder.Append(value: $"[START]{nameof(CommandComponent<Template1>)}[START]");
            commandComponentStringBuilder.AppendLine(value: string.Empty);
            commandComponentStringBuilder.Append(value: $"Method not implemented in '{nameof(CommandComponent<Template1>)}' class");
            commandComponentStringBuilder.AppendLine(value: string.Empty);
            commandComponentStringBuilder.Append(value: $"[END]{nameof(CommandComponent<Template1>)}[END]");

            throw new NotImplementedException(message: commandComponentStringBuilder.ToString(), inner: new Exception());
        }
    }
}