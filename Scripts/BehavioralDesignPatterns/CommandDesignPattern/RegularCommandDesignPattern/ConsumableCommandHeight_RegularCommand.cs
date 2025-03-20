namespace VisualStudio_DesignPatternsInCSharp.Scripts.BehavioralDesignPatterns.CommandDesignPattern.RegularCommandDesignPattern
{
    using System;
    using System.Text;

    public sealed class ConsumableCommandHeight : CommandComponent<ConsumableComponent>
    {
        private ProductSize ConsumableCommandHeightUndoValue { get; }

        private ProductSize ConsumableCommandHeightRedoValue { get; }

        private ConsumableCommandHeight() : base()
        {

        }

        public ConsumableCommandHeight(in ConsumableComponent consumableCommandHeightReference, in ProductSize consumableCommandHeightRedoValue) : base(commandComponentReference: consumableCommandHeightReference)
        {
            ConsumableCommandHeightRedoValue = consumableCommandHeightRedoValue;

            ConsumableCommandHeightUndoValue = CommandComponentReference.ProductComponentHeight;
        }

        public override void ExecuteCommandComponentUndoOperation()
        {
            if (CommandComponentReference is null)
            {
                StringBuilder consumableCommandHeightStringBuilder = new();

                consumableCommandHeightStringBuilder.Append(value: $"[START]{nameof(ConsumableCommandHeight)}[START]");
                consumableCommandHeightStringBuilder.AppendLine(value: string.Empty);
                consumableCommandHeightStringBuilder.Append(value: $"There was an issue in '{nameof(ConsumableCommandHeight)}' class");
                consumableCommandHeightStringBuilder.AppendLine(value: string.Empty);
                consumableCommandHeightStringBuilder.Append(value: $"[END]{nameof(ConsumableCommandHeight)}[END]");

                throw new InvalidOperationException(message: consumableCommandHeightStringBuilder.ToString(), innerException: new Exception());
            }

            CommandComponentReference.SetProductComponentHeight(productComponentHeight: ConsumableCommandHeightUndoValue);
        }

        public override void ExecuteCommandComponentRedoOperation()
        {
            if (CommandComponentReference is null)
            {
                StringBuilder consumableCommandHeightStringBuilder = new();

                consumableCommandHeightStringBuilder.Append(value: $"[START]{nameof(ConsumableCommandHeight)}[START]");
                consumableCommandHeightStringBuilder.AppendLine(value: string.Empty);
                consumableCommandHeightStringBuilder.Append(value: $"There was an issue in '{nameof(ConsumableCommandHeight)}' class");
                consumableCommandHeightStringBuilder.AppendLine(value: string.Empty);
                consumableCommandHeightStringBuilder.Append(value: $"[END]{nameof(ConsumableCommandHeight)}[END]");

                throw new InvalidOperationException(message: consumableCommandHeightStringBuilder.ToString(), innerException: new Exception());
            }

            CommandComponentReference.SetProductComponentHeight(productComponentHeight: ConsumableCommandHeightRedoValue);
        }

        public override bool Equals(object uncastedConsumableCommandHeight)
        {
            StringBuilder consumableCommandHeightStringBuilder = new();

            consumableCommandHeightStringBuilder.Append(value: $"[START]{nameof(ConsumableCommandHeight)}[START]");
            consumableCommandHeightStringBuilder.AppendLine(value: string.Empty);
            consumableCommandHeightStringBuilder.Append(value: $"Method not implemented in '{nameof(ConsumableCommandHeight)}' class");
            consumableCommandHeightStringBuilder.AppendLine(value: string.Empty);
            consumableCommandHeightStringBuilder.Append(value: $"[END]{nameof(ConsumableCommandHeight)}[END]");

            throw new NotImplementedException(message: consumableCommandHeightStringBuilder.ToString(), inner: new Exception());
        }

        public override int GetHashCode()
        {
            StringBuilder consumableCommandHeightStringBuilder = new();

            consumableCommandHeightStringBuilder.Append(value: $"[START]{nameof(ConsumableCommandHeight)}[START]");
            consumableCommandHeightStringBuilder.AppendLine(value: string.Empty);
            consumableCommandHeightStringBuilder.Append(value: $"Method not implemented in '{nameof(ConsumableCommandHeight)}' class");
            consumableCommandHeightStringBuilder.AppendLine(value: string.Empty);
            consumableCommandHeightStringBuilder.Append(value: $"[END]{nameof(ConsumableCommandHeight)}[END]");

            throw new NotImplementedException(message: consumableCommandHeightStringBuilder.ToString(), inner: new Exception());
        }

        public override string ToString()
        {
            StringBuilder consumableCommandHeightStringBuilder = new();

            consumableCommandHeightStringBuilder.Append(value: $"[START]{nameof(ConsumableCommandHeight)}[START]");
            consumableCommandHeightStringBuilder.AppendLine(value: string.Empty);
            consumableCommandHeightStringBuilder.Append(value: $"Method not implemented in '{nameof(ConsumableCommandHeight)}' class");
            consumableCommandHeightStringBuilder.AppendLine(value: string.Empty);
            consumableCommandHeightStringBuilder.Append(value: $"[END]{nameof(ConsumableCommandHeight)}[END]");

            throw new NotImplementedException(message: consumableCommandHeightStringBuilder.ToString(), inner: new Exception());
        }
    }
}