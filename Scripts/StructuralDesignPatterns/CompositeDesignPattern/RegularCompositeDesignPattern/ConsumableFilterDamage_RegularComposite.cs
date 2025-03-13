namespace VisualStudio_DesignPatternsInCSharp.Scripts.StructuralDesignPatterns.CompositeDesignPattern.RegularCompositeDesignPattern
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public sealed class ConsumableFilterDamage : FilterComponent<ConsumableComponent>
    {
        private ConsumableEffect ConsumableFilterDamageField { get; }

        private ConsumableFilterDamage() : base()
        {

        }

        public ConsumableFilterDamage(in ConsumableEffect consumableFilterDamageField) : base()
        {
            ConsumableFilterDamageField = consumableFilterDamageField;
        }

        public override bool CheckFilterComponentField(in ConsumableComponent consumableFilterDamageInput)
        {
            if (consumableFilterDamageInput is null)
            {
                StringBuilder consumableFilterDamageStringBuilder = new();

                consumableFilterDamageStringBuilder.Append(value: $"[START]{nameof(ConsumableFilterDamage)}[START]");
                consumableFilterDamageStringBuilder.AppendLine(value: string.Empty);
                consumableFilterDamageStringBuilder.Append(value: $"There was an issue in '{nameof(ConsumableFilterDamage)}' class");
                consumableFilterDamageStringBuilder.AppendLine(value: string.Empty);
                consumableFilterDamageStringBuilder.Append(value: $"[END]{nameof(ConsumableFilterDamage)}[END]");

                throw new InvalidOperationException(message: consumableFilterDamageStringBuilder.ToString(), innerException: new Exception());
            }

            return EqualityComparer<ConsumableEffect>.Default.Equals(x: ConsumableFilterDamageField, y: consumableFilterDamageInput.ConsumableComponentDamage);
        }

        public override bool Equals(object uncastedConsumableFilterDamage)
        {
            StringBuilder consumableFilterDamageStringBuilder = new();

            consumableFilterDamageStringBuilder.Append(value: $"[START]{nameof(ConsumableFilterDamage)}[START]");
            consumableFilterDamageStringBuilder.AppendLine(value: string.Empty);
            consumableFilterDamageStringBuilder.Append(value: $"Method not implemented in '{nameof(ConsumableFilterDamage)}' class");
            consumableFilterDamageStringBuilder.AppendLine(value: string.Empty);
            consumableFilterDamageStringBuilder.Append(value: $"[END]{nameof(ConsumableFilterDamage)}[END]");

            throw new NotImplementedException(message: consumableFilterDamageStringBuilder.ToString(), inner: new Exception());
        }

        public override int GetHashCode()
        {
            StringBuilder consumableFilterDamageStringBuilder = new();

            consumableFilterDamageStringBuilder.Append(value: $"[START]{nameof(ConsumableFilterDamage)}[START]");
            consumableFilterDamageStringBuilder.AppendLine(value: string.Empty);
            consumableFilterDamageStringBuilder.Append(value: $"Method not implemented in '{nameof(ConsumableFilterDamage)}' class");
            consumableFilterDamageStringBuilder.AppendLine(value: string.Empty);
            consumableFilterDamageStringBuilder.Append(value: $"[END]{nameof(ConsumableFilterDamage)}[END]");

            throw new NotImplementedException(message: consumableFilterDamageStringBuilder.ToString(), inner: new Exception());
        }

        public override string ToString()
        {
            StringBuilder consumableFilterDamageStringBuilder = new();

            consumableFilterDamageStringBuilder.Append(value: $"[START]{nameof(ConsumableFilterDamage)}[START]");
            consumableFilterDamageStringBuilder.AppendLine(value: string.Empty);
            consumableFilterDamageStringBuilder.Append(value: $"Method not implemented in '{nameof(ConsumableFilterDamage)}' class");
            consumableFilterDamageStringBuilder.AppendLine(value: string.Empty);
            consumableFilterDamageStringBuilder.Append(value: $"[END]{nameof(ConsumableFilterDamage)}[END]");

            throw new NotImplementedException(message: consumableFilterDamageStringBuilder.ToString(), inner: new Exception());
        }
    }
}