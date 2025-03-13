namespace VisualStudio_DesignPatternsInCSharp.Scripts.BehavioralDesignPatterns.CommandDesignPattern.RegularCommandDesignPattern
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public sealed class CommandInvoker<Template1> where Template1 : class
    {
        private Stack<CommandComponent<Template1>> CommandInvokerUndoCollection { get; }

        private Stack<CommandComponent<Template1>> CommandInvokerRedoCollection { get; }

        public CommandInvoker() : base()
        {
            CommandInvokerUndoCollection = new Stack<CommandComponent<Template1>>(collection: []);

            CommandInvokerRedoCollection = new Stack<CommandComponent<Template1>>(collection: []);
        }

        public void CreateCommandInvokerCommandComponent(in CommandComponent<Template1> commandInvokerCommandComponent)
        {
            if (CommandInvokerUndoCollection is null || CommandInvokerRedoCollection is null)
            {
                StringBuilder commandInvokerStringBuilder = new();

                commandInvokerStringBuilder.Append(value: $"[START]{nameof(CommandInvoker<Template1>)}[START]");
                commandInvokerStringBuilder.AppendLine(value: string.Empty);
                commandInvokerStringBuilder.Append(value: $"There was an issue in '{nameof(CommandInvoker<Template1>)}' class");
                commandInvokerStringBuilder.AppendLine(value: string.Empty);
                commandInvokerStringBuilder.Append(value: $"[END]{nameof(CommandInvoker<Template1>)}[END]");

                throw new InvalidOperationException(message: commandInvokerStringBuilder.ToString(), innerException: new Exception());
            }

            if (commandInvokerCommandComponent is null)
            {
                StringBuilder commandInvokerStringBuilder = new();

                commandInvokerStringBuilder.Append(value: $"[START]{nameof(CommandInvoker<Template1>)}[START]");
                commandInvokerStringBuilder.AppendLine(value: string.Empty);
                commandInvokerStringBuilder.Append(value: $"There was an issue in '{nameof(CommandInvoker<Template1>)}' class");
                commandInvokerStringBuilder.AppendLine(value: string.Empty);
                commandInvokerStringBuilder.Append(value: $"[END]{nameof(CommandInvoker<Template1>)}[END]");

                throw new InvalidOperationException(message: commandInvokerStringBuilder.ToString(), innerException: new Exception());
            }

            commandInvokerCommandComponent.ExecuteCommandComponentRedoOperation();

            CommandInvokerRedoCollection.Clear();

            CommandInvokerUndoCollection.Push(item: commandInvokerCommandComponent);
        }

        public bool ExecuteCommandInvokerUndoOperation()
        {
            if (CommandInvokerUndoCollection is null || CommandInvokerRedoCollection is null)
            {
                StringBuilder commandInvokerStringBuilder = new();

                commandInvokerStringBuilder.Append(value: $"[START]{nameof(CommandInvoker<Template1>)}[START]");
                commandInvokerStringBuilder.AppendLine(value: string.Empty);
                commandInvokerStringBuilder.Append(value: $"There was an issue in '{nameof(CommandInvoker<Template1>)}' class");
                commandInvokerStringBuilder.AppendLine(value: string.Empty);
                commandInvokerStringBuilder.Append(value: $"[END]{nameof(CommandInvoker<Template1>)}[END]");

                throw new InvalidOperationException(message: commandInvokerStringBuilder.ToString(), innerException: new Exception());
            }

            if (!CommandInvokerUndoCollection.TryPop(result: out CommandComponent<Template1> commandInvokerCommandComponent))
            {
                return false;
            }

            if (commandInvokerCommandComponent is null)
            {
                StringBuilder commandInvokerStringBuilder = new();

                commandInvokerStringBuilder.Append(value: $"[START]{nameof(CommandInvoker<Template1>)}[START]");
                commandInvokerStringBuilder.AppendLine(value: string.Empty);
                commandInvokerStringBuilder.Append(value: $"There was an issue in '{nameof(CommandInvoker<Template1>)}' class");
                commandInvokerStringBuilder.AppendLine(value: string.Empty);
                commandInvokerStringBuilder.Append(value: $"[END]{nameof(CommandInvoker<Template1>)}[END]");

                throw new InvalidOperationException(message: commandInvokerStringBuilder.ToString(), innerException: new Exception());
            }

            commandInvokerCommandComponent.ExecuteCommandComponentUndoOperation();

            CommandInvokerRedoCollection.Push(item: commandInvokerCommandComponent);

            return true;
        }

        public bool ExecuteCommandInvokerRedoOperation()
        {
            if (CommandInvokerUndoCollection is null || CommandInvokerRedoCollection is null)
            {
                StringBuilder commandInvokerStringBuilder = new();

                commandInvokerStringBuilder.Append(value: $"[START]{nameof(CommandInvoker<Template1>)}[START]");
                commandInvokerStringBuilder.AppendLine(value: string.Empty);
                commandInvokerStringBuilder.Append(value: $"There was an issue in '{nameof(CommandInvoker<Template1>)}' class");
                commandInvokerStringBuilder.AppendLine(value: string.Empty);
                commandInvokerStringBuilder.Append(value: $"[END]{nameof(CommandInvoker<Template1>)}[END]");

                throw new InvalidOperationException(message: commandInvokerStringBuilder.ToString(), innerException: new Exception());
            }

            if (!CommandInvokerRedoCollection.TryPop(result: out CommandComponent<Template1> commandInvokerCommandComponent))
            {
                return false;
            }

            if (commandInvokerCommandComponent is null)
            {
                StringBuilder commandInvokerStringBuilder = new();

                commandInvokerStringBuilder.Append(value: $"[START]{nameof(CommandInvoker<Template1>)}[START]");
                commandInvokerStringBuilder.AppendLine(value: string.Empty);
                commandInvokerStringBuilder.Append(value: $"There was an issue in '{nameof(CommandInvoker<Template1>)}' class");
                commandInvokerStringBuilder.AppendLine(value: string.Empty);
                commandInvokerStringBuilder.Append(value: $"[END]{nameof(CommandInvoker<Template1>)}[END]");

                throw new InvalidOperationException(message: commandInvokerStringBuilder.ToString(), innerException: new Exception());
            }

            commandInvokerCommandComponent.ExecuteCommandComponentRedoOperation();

            CommandInvokerUndoCollection.Push(item: commandInvokerCommandComponent);

            return true;
        }

        public override bool Equals(object uncastedCommandInvoker)
        {
            StringBuilder commandInvokerStringBuilder = new();

            commandInvokerStringBuilder.Append(value: $"[START]{nameof(CommandInvoker<Template1>)}[START]");
            commandInvokerStringBuilder.AppendLine(value: string.Empty);
            commandInvokerStringBuilder.Append(value: $"Method not implemented in '{nameof(CommandInvoker<Template1>)}' class");
            commandInvokerStringBuilder.AppendLine(value: string.Empty);
            commandInvokerStringBuilder.Append(value: $"[END]{nameof(CommandInvoker<Template1>)}[END]");

            throw new NotImplementedException(message: commandInvokerStringBuilder.ToString(), inner: new Exception());
        }

        public override int GetHashCode()
        {
            StringBuilder commandInvokerStringBuilder = new();

            commandInvokerStringBuilder.Append(value: $"[START]{nameof(CommandInvoker<Template1>)}[START]");
            commandInvokerStringBuilder.AppendLine(value: string.Empty);
            commandInvokerStringBuilder.Append(value: $"Method not implemented in '{nameof(CommandInvoker<Template1>)}' class");
            commandInvokerStringBuilder.AppendLine(value: string.Empty);
            commandInvokerStringBuilder.Append(value: $"[END]{nameof(CommandInvoker<Template1>)}[END]");

            throw new NotImplementedException(message: commandInvokerStringBuilder.ToString(), inner: new Exception());
        }

        public override string ToString()
        {
            StringBuilder commandInvokerStringBuilder = new();

            commandInvokerStringBuilder.Append(value: $"[START]{nameof(CommandInvoker<Template1>)}[START]");
            commandInvokerStringBuilder.AppendLine(value: string.Empty);
            commandInvokerStringBuilder.Append(value: $"Method not implemented in '{nameof(CommandInvoker<Template1>)}' class");
            commandInvokerStringBuilder.AppendLine(value: string.Empty);
            commandInvokerStringBuilder.Append(value: $"[END]{nameof(CommandInvoker<Template1>)}[END]");

            throw new NotImplementedException(message: commandInvokerStringBuilder.ToString(), inner: new Exception());
        }
    }
}