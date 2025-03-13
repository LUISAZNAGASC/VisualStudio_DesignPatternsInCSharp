namespace VisualStudio_DesignPatternsInCSharp.Scripts.StructuralDesignPatterns.CompositeDesignPattern.RegularCompositeDesignPattern
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public sealed class ConsumableFilterName : FilterComponent<ConsumableComponent>
    {
        private string ConsumableFilterNameField { get; }

        private ConsumableFilterName() : base()
        {

        }

        public ConsumableFilterName(in string consumableFilterNameField) : base()
        {
            ConsumableFilterNameField = consumableFilterNameField;
        }

        public override bool CheckFilterComponentField(in ConsumableComponent consumableFilterNameInput)
        {
            if (consumableFilterNameInput is null)
            {
                StringBuilder consumableFilterNameStringBuilder = new();

                consumableFilterNameStringBuilder.Append(value: $"[START]{nameof(ConsumableFilterName)}[START]");
                consumableFilterNameStringBuilder.AppendLine(value: string.Empty);
                consumableFilterNameStringBuilder.Append(value: $"There was an issue in '{nameof(ConsumableFilterName)}' class");
                consumableFilterNameStringBuilder.AppendLine(value: string.Empty);
                consumableFilterNameStringBuilder.Append(value: $"[END]{nameof(ConsumableFilterName)}[END]");

                throw new InvalidOperationException(message: consumableFilterNameStringBuilder.ToString(), innerException: new Exception());
            }

            return EqualityComparer<string>.Default.Equals(x: ConsumableFilterNameField, y: consumableFilterNameInput.ProductComponentName);
        }

        public override bool Equals(object uncastedConsumableFilterName)
        {
            StringBuilder consumableFilterNameStringBuilder = new();

            consumableFilterNameStringBuilder.Append(value: $"[START]{nameof(ConsumableFilterName)}[START]");
            consumableFilterNameStringBuilder.AppendLine(value: string.Empty);
            consumableFilterNameStringBuilder.Append(value: $"Method not implemented in '{nameof(ConsumableFilterName)}' class");
            consumableFilterNameStringBuilder.AppendLine(value: string.Empty);
            consumableFilterNameStringBuilder.Append(value: $"[END]{nameof(ConsumableFilterName)}[END]");

            throw new NotImplementedException(message: consumableFilterNameStringBuilder.ToString(), inner: new Exception());
        }

        public override int GetHashCode()
        {
            StringBuilder consumableFilterNameStringBuilder = new();

            consumableFilterNameStringBuilder.Append(value: $"[START]{nameof(ConsumableFilterName)}[START]");
            consumableFilterNameStringBuilder.AppendLine(value: string.Empty);
            consumableFilterNameStringBuilder.Append(value: $"Method not implemented in '{nameof(ConsumableFilterName)}' class");
            consumableFilterNameStringBuilder.AppendLine(value: string.Empty);
            consumableFilterNameStringBuilder.Append(value: $"[END]{nameof(ConsumableFilterName)}[END]");

            throw new NotImplementedException(message: consumableFilterNameStringBuilder.ToString(), inner: new Exception());
        }

        public override string ToString()
        {
            StringBuilder consumableFilterNameStringBuilder = new();

            consumableFilterNameStringBuilder.Append(value: $"[START]{nameof(ConsumableFilterName)}[START]");
            consumableFilterNameStringBuilder.AppendLine(value: string.Empty);
            consumableFilterNameStringBuilder.Append(value: $"Method not implemented in '{nameof(ConsumableFilterName)}' class");
            consumableFilterNameStringBuilder.AppendLine(value: string.Empty);
            consumableFilterNameStringBuilder.Append(value: $"[END]{nameof(ConsumableFilterName)}[END]");

            throw new NotImplementedException(message: consumableFilterNameStringBuilder.ToString(), inner: new Exception());
        }
    }
}