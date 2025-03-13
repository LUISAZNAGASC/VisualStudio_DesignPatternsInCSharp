namespace VisualStudio_DesignPatternsInCSharp.Scripts.StructuralDesignPatterns.CompositeDesignPattern.RegularCompositeDesignPattern
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public sealed class ConsumableFilterWidth : FilterComponent<ConsumableComponent>
    {
        private ProductSize ConsumableFilterWidthField { get; }

        private ConsumableFilterWidth() : base()
        {

        }

        public ConsumableFilterWidth(in ProductSize consumableFilterWidthField) : base()
        {
            ConsumableFilterWidthField = consumableFilterWidthField;
        }

        public override bool CheckFilterComponentField(in ConsumableComponent consumableFilterWidthInput)
        {
            if (consumableFilterWidthInput is null)
            {
                StringBuilder consumableFilterWidthStringBuilder = new();

                consumableFilterWidthStringBuilder.Append(value: $"[START]{nameof(ConsumableFilterWidth)}[START]");
                consumableFilterWidthStringBuilder.AppendLine(value: string.Empty);
                consumableFilterWidthStringBuilder.Append(value: $"There was an issue in '{nameof(ConsumableFilterWidth)}' class");
                consumableFilterWidthStringBuilder.AppendLine(value: string.Empty);
                consumableFilterWidthStringBuilder.Append(value: $"[END]{nameof(ConsumableFilterWidth)}[END]");

                throw new InvalidOperationException(message: consumableFilterWidthStringBuilder.ToString(), innerException: new Exception());
            }

            return EqualityComparer<ProductSize>.Default.Equals(x: ConsumableFilterWidthField, y: consumableFilterWidthInput.ProductComponentWidth);
        }

        public override bool Equals(object uncastedConsumableFilterWidth)
        {
            StringBuilder consumableFilterWidthStringBuilder = new();

            consumableFilterWidthStringBuilder.Append(value: $"[START]{nameof(ConsumableFilterWidth)}[START]");
            consumableFilterWidthStringBuilder.AppendLine(value: string.Empty);
            consumableFilterWidthStringBuilder.Append(value: $"Method not implemented in '{nameof(ConsumableFilterWidth)}' class");
            consumableFilterWidthStringBuilder.AppendLine(value: string.Empty);
            consumableFilterWidthStringBuilder.Append(value: $"[END]{nameof(ConsumableFilterWidth)}[END]");

            throw new NotImplementedException(message: consumableFilterWidthStringBuilder.ToString(), inner: new Exception());
        }

        public override int GetHashCode()
        {
            StringBuilder consumableFilterWidthStringBuilder = new();

            consumableFilterWidthStringBuilder.Append(value: $"[START]{nameof(ConsumableFilterWidth)}[START]");
            consumableFilterWidthStringBuilder.AppendLine(value: string.Empty);
            consumableFilterWidthStringBuilder.Append(value: $"Method not implemented in '{nameof(ConsumableFilterWidth)}' class");
            consumableFilterWidthStringBuilder.AppendLine(value: string.Empty);
            consumableFilterWidthStringBuilder.Append(value: $"[END]{nameof(ConsumableFilterWidth)}[END]");

            throw new NotImplementedException(message: consumableFilterWidthStringBuilder.ToString(), inner: new Exception());
        }

        public override string ToString()
        {
            StringBuilder consumableFilterWidthStringBuilder = new();

            consumableFilterWidthStringBuilder.Append(value: $"[START]{nameof(ConsumableFilterWidth)}[START]");
            consumableFilterWidthStringBuilder.AppendLine(value: string.Empty);
            consumableFilterWidthStringBuilder.Append(value: $"Method not implemented in '{nameof(ConsumableFilterWidth)}' class");
            consumableFilterWidthStringBuilder.AppendLine(value: string.Empty);
            consumableFilterWidthStringBuilder.Append(value: $"[END]{nameof(ConsumableFilterWidth)}[END]");

            throw new NotImplementedException(message: consumableFilterWidthStringBuilder.ToString(), inner: new Exception());
        }
    }
}