namespace VisualStudio_DesignPatternsInCSharp.Scripts.BehavioralDesignPatterns.CommandDesignPattern.RegularCommandDesignPattern
{
    using System;
    using System.Text;

    public sealed class ConsumableCommandDamage : CommandComponent<ConsumableComponent>
    {
        private ConsumableEffect ConsumableCommandDamageUndoValue { get; }

        private ConsumableEffect ConsumableCommandDamageRedoValue { get; }

        private ConsumableCommandDamage() : base()
        {

        }

        public ConsumableCommandDamage(in ConsumableComponent consumableCommandDamageReference, in ConsumableEffect consumableCommandDamageRedoValue) : base(commandComponentReference: consumableCommandDamageReference)
        {
            ConsumableCommandDamageRedoValue = consumableCommandDamageRedoValue;

            ConsumableCommandDamageUndoValue = CommandComponentReference.ConsumableComponentDamage;
        }

        public override void ExecuteCommandComponentUndoOperation()
        {
            if (CommandComponentReference is null)
            {
                StringBuilder consumableCommandDamageStringBuilder = new();

                consumableCommandDamageStringBuilder.Append(value: $"[START]{nameof(ConsumableCommandDamage)}[START]");
                consumableCommandDamageStringBuilder.AppendLine(value: string.Empty);
                consumableCommandDamageStringBuilder.Append(value: $"There was an issue in '{nameof(ConsumableCommandDamage)}' class");
                consumableCommandDamageStringBuilder.AppendLine(value: string.Empty);
                consumableCommandDamageStringBuilder.Append(value: $"[END]{nameof(ConsumableCommandDamage)}[END]");

                throw new InvalidOperationException(message: consumableCommandDamageStringBuilder.ToString(), innerException: new Exception());
            }

            CommandComponentReference.SetConsumableComponentDamage(consumableComponentDamage: ConsumableCommandDamageUndoValue);
        }

        public override void ExecuteCommandComponentRedoOperation()
        {
            if (CommandComponentReference is null)
            {
                StringBuilder consumableCommandDamageStringBuilder = new();

                consumableCommandDamageStringBuilder.Append(value: $"[START]{nameof(ConsumableCommandDamage)}[START]");
                consumableCommandDamageStringBuilder.AppendLine(value: string.Empty);
                consumableCommandDamageStringBuilder.Append(value: $"There was an issue in '{nameof(ConsumableCommandDamage)}' class");
                consumableCommandDamageStringBuilder.AppendLine(value: string.Empty);
                consumableCommandDamageStringBuilder.Append(value: $"[END]{nameof(ConsumableCommandDamage)}[END]");

                throw new InvalidOperationException(message: consumableCommandDamageStringBuilder.ToString(), innerException: new Exception());
            }

            CommandComponentReference.SetConsumableComponentDamage(consumableComponentDamage: ConsumableCommandDamageRedoValue);
        }

        public override bool Equals(object uncastedConsumableCommandDamage)
        {
            StringBuilder consumableCommandDamageStringBuilder = new();

            consumableCommandDamageStringBuilder.Append(value: $"[START]{nameof(ConsumableCommandDamage)}[START]");
            consumableCommandDamageStringBuilder.AppendLine(value: string.Empty);
            consumableCommandDamageStringBuilder.Append(value: $"Method not implemented in '{nameof(ConsumableCommandDamage)}' class");
            consumableCommandDamageStringBuilder.AppendLine(value: string.Empty);
            consumableCommandDamageStringBuilder.Append(value: $"[END]{nameof(ConsumableCommandDamage)}[END]");

            throw new NotImplementedException(message: consumableCommandDamageStringBuilder.ToString(), inner: new Exception());
        }

        public override int GetHashCode()
        {
            StringBuilder consumableCommandDamageStringBuilder = new();

            consumableCommandDamageStringBuilder.Append(value: $"[START]{nameof(ConsumableCommandDamage)}[START]");
            consumableCommandDamageStringBuilder.AppendLine(value: string.Empty);
            consumableCommandDamageStringBuilder.Append(value: $"Method not implemented in '{nameof(ConsumableCommandDamage)}' class");
            consumableCommandDamageStringBuilder.AppendLine(value: string.Empty);
            consumableCommandDamageStringBuilder.Append(value: $"[END]{nameof(ConsumableCommandDamage)}[END]");

            throw new NotImplementedException(message: consumableCommandDamageStringBuilder.ToString(), inner: new Exception());
        }

        public override string ToString()
        {
            StringBuilder consumableCommandDamageStringBuilder = new();

            consumableCommandDamageStringBuilder.Append(value: $"[START]{nameof(ConsumableCommandDamage)}[START]");
            consumableCommandDamageStringBuilder.AppendLine(value: string.Empty);
            consumableCommandDamageStringBuilder.Append(value: $"Method not implemented in '{nameof(ConsumableCommandDamage)}' class");
            consumableCommandDamageStringBuilder.AppendLine(value: string.Empty);
            consumableCommandDamageStringBuilder.Append(value: $"[END]{nameof(ConsumableCommandDamage)}[END]");

            throw new NotImplementedException(message: consumableCommandDamageStringBuilder.ToString(), inner: new Exception());
        }
    }
}