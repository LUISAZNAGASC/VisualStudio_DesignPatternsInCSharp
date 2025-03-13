namespace VisualStudio_DesignPatternsInCSharp.Scripts.StructuralDesignPatterns.CompositeDesignPattern.RegularCompositeDesignPattern
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public sealed class ConsumableFilterDepth : FilterComponent<ConsumableComponent>
    {
        private ProductSize ConsumableFilterDepthField { get; }

        private ConsumableFilterDepth() : base()
        {

        }

        public ConsumableFilterDepth(in ProductSize consumableFilterDepthField) : base()
        {
            ConsumableFilterDepthField = consumableFilterDepthField;
        }

        public override bool CheckFilterComponentField(in ConsumableComponent consumableFilterDepthInput)
        {
            if (consumableFilterDepthInput is null)
            {
                StringBuilder consumableFilterDepthStringBuilder = new();

                consumableFilterDepthStringBuilder.Append(value: $"[START]{nameof(ConsumableFilterDepth)}[START]");
                consumableFilterDepthStringBuilder.AppendLine(value: string.Empty);
                consumableFilterDepthStringBuilder.Append(value: $"There was an issue in '{nameof(ConsumableFilterDepth)}' class");
                consumableFilterDepthStringBuilder.AppendLine(value: string.Empty);
                consumableFilterDepthStringBuilder.Append(value: $"[END]{nameof(ConsumableFilterDepth)}[END]");

                throw new InvalidOperationException(message: consumableFilterDepthStringBuilder.ToString(), innerException: new Exception());
            }

            return EqualityComparer<ProductSize>.Default.Equals(x: ConsumableFilterDepthField, y: consumableFilterDepthInput.ProductComponentDepth);
        }

        public override bool Equals(object uncastedConsumableFilterDepth)
        {
            StringBuilder consumableFilterDepthStringBuilder = new();

            consumableFilterDepthStringBuilder.Append(value: $"[START]{nameof(ConsumableFilterDepth)}[START]");
            consumableFilterDepthStringBuilder.AppendLine(value: string.Empty);
            consumableFilterDepthStringBuilder.Append(value: $"Method not implemented in '{nameof(ConsumableFilterDepth)}' class");
            consumableFilterDepthStringBuilder.AppendLine(value: string.Empty);
            consumableFilterDepthStringBuilder.Append(value: $"[END]{nameof(ConsumableFilterDepth)}[END]");

            throw new NotImplementedException(message: consumableFilterDepthStringBuilder.ToString(), inner: new Exception());
        }

        public override int GetHashCode()
        {
            StringBuilder consumableFilterDepthStringBuilder = new();

            consumableFilterDepthStringBuilder.Append(value: $"[START]{nameof(ConsumableFilterDepth)}[START]");
            consumableFilterDepthStringBuilder.AppendLine(value: string.Empty);
            consumableFilterDepthStringBuilder.Append(value: $"Method not implemented in '{nameof(ConsumableFilterDepth)}' class");
            consumableFilterDepthStringBuilder.AppendLine(value: string.Empty);
            consumableFilterDepthStringBuilder.Append(value: $"[END]{nameof(ConsumableFilterDepth)}[END]");

            throw new NotImplementedException(message: consumableFilterDepthStringBuilder.ToString(), inner: new Exception());
        }

        public override string ToString()
        {
            StringBuilder consumableFilterDepthStringBuilder = new();

            consumableFilterDepthStringBuilder.Append(value: $"[START]{nameof(ConsumableFilterDepth)}[START]");
            consumableFilterDepthStringBuilder.AppendLine(value: string.Empty);
            consumableFilterDepthStringBuilder.Append(value: $"Method not implemented in '{nameof(ConsumableFilterDepth)}' class");
            consumableFilterDepthStringBuilder.AppendLine(value: string.Empty);
            consumableFilterDepthStringBuilder.Append(value: $"[END]{nameof(ConsumableFilterDepth)}[END]");

            throw new NotImplementedException(message: consumableFilterDepthStringBuilder.ToString(), inner: new Exception());
        }
    }
}