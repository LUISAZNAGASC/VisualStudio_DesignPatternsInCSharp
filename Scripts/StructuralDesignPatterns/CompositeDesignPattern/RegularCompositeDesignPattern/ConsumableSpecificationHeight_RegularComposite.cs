namespace VisualStudio_DesignPatternsInCSharp.Scripts.StructuralDesignPatterns.CompositeDesignPattern.RegularCompositeDesignPattern
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public sealed class ConsumableSpecificationHeight(
        ProductSize consumableSpecificationHeightField) : SpecificationComponent<ConsumableComponent>()
    {
        public override bool CheckSpecificationComponentField(in ConsumableComponent consumableSpecificationHeightInput)
        {
            if (consumableSpecificationHeightInput is null)
            {
                return false;
            }

            return EqualityComparer<ProductSize>.Default.Equals(x: consumableSpecificationHeightField, y: consumableSpecificationHeightInput.ProductComponentHeight);
        }

        public override bool Equals(object uncastedConsumableSpecificationHeight)
        {
            StringBuilder consumableSpecificationHeightStringBuilder = new();

            consumableSpecificationHeightStringBuilder.Append(value: $"[START]{nameof(ConsumableSpecificationHeight)}[START]");
            consumableSpecificationHeightStringBuilder.AppendLine(value: string.Empty);
            consumableSpecificationHeightStringBuilder.Append(value: $"Method not implemented in '{nameof(ConsumableSpecificationHeight)}' class");
            consumableSpecificationHeightStringBuilder.AppendLine(value: string.Empty);
            consumableSpecificationHeightStringBuilder.Append(value: $"[END]{nameof(ConsumableSpecificationHeight)}[END]");

            throw new NotImplementedException(message: consumableSpecificationHeightStringBuilder.ToString(), inner: new Exception());
        }

        public override int GetHashCode()
        {
            StringBuilder consumableSpecificationHeightStringBuilder = new();

            consumableSpecificationHeightStringBuilder.Append(value: $"[START]{nameof(ConsumableSpecificationHeight)}[START]");
            consumableSpecificationHeightStringBuilder.AppendLine(value: string.Empty);
            consumableSpecificationHeightStringBuilder.Append(value: $"Method not implemented in '{nameof(ConsumableSpecificationHeight)}' class");
            consumableSpecificationHeightStringBuilder.AppendLine(value: string.Empty);
            consumableSpecificationHeightStringBuilder.Append(value: $"[END]{nameof(ConsumableSpecificationHeight)}[END]");

            throw new NotImplementedException(message: consumableSpecificationHeightStringBuilder.ToString(), inner: new Exception());
        }

        public override string ToString()
        {
            StringBuilder consumableSpecificationHeightStringBuilder = new();

            consumableSpecificationHeightStringBuilder.Append(value: $"[START]{nameof(ConsumableSpecificationHeight)}[START]");
            consumableSpecificationHeightStringBuilder.AppendLine(value: string.Empty);
            consumableSpecificationHeightStringBuilder.Append(value: $"Method not implemented in '{nameof(ConsumableSpecificationHeight)}' class");
            consumableSpecificationHeightStringBuilder.AppendLine(value: string.Empty);
            consumableSpecificationHeightStringBuilder.Append(value: $"[END]{nameof(ConsumableSpecificationHeight)}[END]");

            throw new NotImplementedException(message: consumableSpecificationHeightStringBuilder.ToString(), inner: new Exception());
        }
    }
}