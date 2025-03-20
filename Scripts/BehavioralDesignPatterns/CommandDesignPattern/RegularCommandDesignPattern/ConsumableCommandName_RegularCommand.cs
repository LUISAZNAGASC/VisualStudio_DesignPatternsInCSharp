namespace VisualStudio_DesignPatternsInCSharp.Scripts.BehavioralDesignPatterns.CommandDesignPattern.RegularCommandDesignPattern
{
    using System;
    using System.Text;

    public sealed class ConsumableCommandName : CommandComponent<ConsumableComponent>
    {
        private string ConsumableCommandNameUndoValue { get; }

        private string ConsumableCommandNameRedoValue { get; }

        private ConsumableCommandName() : base()
        {

        }

        public ConsumableCommandName(in ConsumableComponent consumableCommandNameReference, in string consumableCommandNameRedoValue) : base(commandComponentReference: consumableCommandNameReference)
        {
            ConsumableCommandNameRedoValue = consumableCommandNameRedoValue;

            ConsumableCommandNameUndoValue = CommandComponentReference.ProductComponentName;
        }

        public override void ExecuteCommandComponentUndoOperation()
        {
            if (CommandComponentReference is null)
            {
                StringBuilder consumableCommandNameStringBuilder = new();

                consumableCommandNameStringBuilder.Append(value: $"[START]{nameof(ConsumableCommandName)}[START]");
                consumableCommandNameStringBuilder.AppendLine(value: string.Empty);
                consumableCommandNameStringBuilder.Append(value: $"There was an issue in '{nameof(ConsumableCommandName)}' class");
                consumableCommandNameStringBuilder.AppendLine(value: string.Empty);
                consumableCommandNameStringBuilder.Append(value: $"[END]{nameof(ConsumableCommandName)}[END]");

                throw new InvalidOperationException(message: consumableCommandNameStringBuilder.ToString(), innerException: new Exception());
            }

            CommandComponentReference.SetProductComponentName(productComponentName: ConsumableCommandNameUndoValue);
        }

        public override void ExecuteCommandComponentRedoOperation()
        {
            if (CommandComponentReference is null)
            {
                StringBuilder consumableCommandNameStringBuilder = new();

                consumableCommandNameStringBuilder.Append(value: $"[START]{nameof(ConsumableCommandName)}[START]");
                consumableCommandNameStringBuilder.AppendLine(value: string.Empty);
                consumableCommandNameStringBuilder.Append(value: $"There was an issue in '{nameof(ConsumableCommandName)}' class");
                consumableCommandNameStringBuilder.AppendLine(value: string.Empty);
                consumableCommandNameStringBuilder.Append(value: $"[END]{nameof(ConsumableCommandName)}[END]");

                throw new InvalidOperationException(message: consumableCommandNameStringBuilder.ToString(), innerException: new Exception());
            }

            CommandComponentReference.SetProductComponentName(productComponentName: ConsumableCommandNameRedoValue);
        }

        public override bool Equals(object uncastedConsumableCommandName)
        {
            StringBuilder consumableCommandNameStringBuilder = new();

            consumableCommandNameStringBuilder.Append(value: $"[START]{nameof(ConsumableCommandName)}[START]");
            consumableCommandNameStringBuilder.AppendLine(value: string.Empty);
            consumableCommandNameStringBuilder.Append(value: $"Method not implemented in '{nameof(ConsumableCommandName)}' class");
            consumableCommandNameStringBuilder.AppendLine(value: string.Empty);
            consumableCommandNameStringBuilder.Append(value: $"[END]{nameof(ConsumableCommandName)}[END]");

            throw new NotImplementedException(message: consumableCommandNameStringBuilder.ToString(), inner: new Exception());
        }

        public override int GetHashCode()
        {
            StringBuilder consumableCommandNameStringBuilder = new();

            consumableCommandNameStringBuilder.Append(value: $"[START]{nameof(ConsumableCommandName)}[START]");
            consumableCommandNameStringBuilder.AppendLine(value: string.Empty);
            consumableCommandNameStringBuilder.Append(value: $"Method not implemented in '{nameof(ConsumableCommandName)}' class");
            consumableCommandNameStringBuilder.AppendLine(value: string.Empty);
            consumableCommandNameStringBuilder.Append(value: $"[END]{nameof(ConsumableCommandName)}[END]");

            throw new NotImplementedException(message: consumableCommandNameStringBuilder.ToString(), inner: new Exception());
        }

        public override string ToString()
        {
            StringBuilder consumableCommandNameStringBuilder = new();

            consumableCommandNameStringBuilder.Append(value: $"[START]{nameof(ConsumableCommandName)}[START]");
            consumableCommandNameStringBuilder.AppendLine(value: string.Empty);
            consumableCommandNameStringBuilder.Append(value: $"Method not implemented in '{nameof(ConsumableCommandName)}' class");
            consumableCommandNameStringBuilder.AppendLine(value: string.Empty);
            consumableCommandNameStringBuilder.Append(value: $"[END]{nameof(ConsumableCommandName)}[END]");

            throw new NotImplementedException(message: consumableCommandNameStringBuilder.ToString(), inner: new Exception());
        }
    }
}