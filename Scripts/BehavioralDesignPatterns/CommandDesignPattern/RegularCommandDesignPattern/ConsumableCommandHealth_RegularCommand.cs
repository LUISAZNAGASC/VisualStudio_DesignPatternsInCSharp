namespace VisualStudio_DesignPatternsInCSharp.Scripts.BehavioralDesignPatterns.CommandDesignPattern.RegularCommandDesignPattern
{
    using System;
    using System.Text;

    public sealed class ConsumableCommandHealth : CommandComponent<ConsumableComponent>
    {
        private ConsumableEffect ConsumableCommandHealthUndoValue { get; }

        private ConsumableEffect ConsumableCommandHealthRedoValue { get; }

        private ConsumableCommandHealth() : base()
        {

        }

        public ConsumableCommandHealth(in ConsumableComponent consumableCommandHealthReference, in ConsumableEffect consumableCommandHealthRedoValue) : base(commandComponentReference: consumableCommandHealthReference)
        {
            ConsumableCommandHealthRedoValue = consumableCommandHealthRedoValue;

            ConsumableCommandHealthUndoValue = CommandComponentReference.ConsumableComponentHealth;
        }

        public override void ExecuteCommandComponentUndoOperation()
        {
            if (CommandComponentReference is null)
            {
                StringBuilder consumableCommandHealthStringBuilder = new();

                consumableCommandHealthStringBuilder.Append(value: $"[START]{nameof(ConsumableCommandHealth)}[START]");
                consumableCommandHealthStringBuilder.AppendLine(value: string.Empty);
                consumableCommandHealthStringBuilder.Append(value: $"There was an issue in '{nameof(ConsumableCommandHealth)}' class");
                consumableCommandHealthStringBuilder.AppendLine(value: string.Empty);
                consumableCommandHealthStringBuilder.Append(value: $"[END]{nameof(ConsumableCommandHealth)}[END]");

                throw new InvalidOperationException(message: consumableCommandHealthStringBuilder.ToString(), innerException: new Exception());
            }

            CommandComponentReference.SetConsumableComponentHealth(consumableComponentHealth: ConsumableCommandHealthUndoValue);
        }

        public override void ExecuteCommandComponentRedoOperation()
        {
            if (CommandComponentReference is null)
            {
                StringBuilder consumableCommandHealthStringBuilder = new();

                consumableCommandHealthStringBuilder.Append(value: $"[START]{nameof(ConsumableCommandHealth)}[START]");
                consumableCommandHealthStringBuilder.AppendLine(value: string.Empty);
                consumableCommandHealthStringBuilder.Append(value: $"There was an issue in '{nameof(ConsumableCommandHealth)}' class");
                consumableCommandHealthStringBuilder.AppendLine(value: string.Empty);
                consumableCommandHealthStringBuilder.Append(value: $"[END]{nameof(ConsumableCommandHealth)}[END]");

                throw new InvalidOperationException(message: consumableCommandHealthStringBuilder.ToString(), innerException: new Exception());
            }

            CommandComponentReference.SetConsumableComponentHealth(consumableComponentHealth: ConsumableCommandHealthRedoValue);
        }

        public override bool Equals(object uncastedConsumableCommandHealth)
        {
            StringBuilder consumableCommandHealthStringBuilder = new();

            consumableCommandHealthStringBuilder.Append(value: $"[START]{nameof(ConsumableCommandHealth)}[START]");
            consumableCommandHealthStringBuilder.AppendLine(value: string.Empty);
            consumableCommandHealthStringBuilder.Append(value: $"Method not implemented in '{nameof(ConsumableCommandHealth)}' class");
            consumableCommandHealthStringBuilder.AppendLine(value: string.Empty);
            consumableCommandHealthStringBuilder.Append(value: $"[END]{nameof(ConsumableCommandHealth)}[END]");

            throw new NotImplementedException(message: consumableCommandHealthStringBuilder.ToString(), inner: new Exception());
        }

        public override int GetHashCode()
        {
            StringBuilder consumableCommandHealthStringBuilder = new();

            consumableCommandHealthStringBuilder.Append(value: $"[START]{nameof(ConsumableCommandHealth)}[START]");
            consumableCommandHealthStringBuilder.AppendLine(value: string.Empty);
            consumableCommandHealthStringBuilder.Append(value: $"Method not implemented in '{nameof(ConsumableCommandHealth)}' class");
            consumableCommandHealthStringBuilder.AppendLine(value: string.Empty);
            consumableCommandHealthStringBuilder.Append(value: $"[END]{nameof(ConsumableCommandHealth)}[END]");

            throw new NotImplementedException(message: consumableCommandHealthStringBuilder.ToString(), inner: new Exception());
        }

        public override string ToString()
        {
            StringBuilder consumableCommandHealthStringBuilder = new();

            consumableCommandHealthStringBuilder.Append(value: $"[START]{nameof(ConsumableCommandHealth)}[START]");
            consumableCommandHealthStringBuilder.AppendLine(value: string.Empty);
            consumableCommandHealthStringBuilder.Append(value: $"Method not implemented in '{nameof(ConsumableCommandHealth)}' class");
            consumableCommandHealthStringBuilder.AppendLine(value: string.Empty);
            consumableCommandHealthStringBuilder.Append(value: $"[END]{nameof(ConsumableCommandHealth)}[END]");

            throw new NotImplementedException(message: consumableCommandHealthStringBuilder.ToString(), inner: new Exception());
        }
    }
}