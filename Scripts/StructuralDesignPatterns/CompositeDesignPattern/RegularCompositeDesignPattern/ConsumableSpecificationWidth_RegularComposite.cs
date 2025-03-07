namespace VisualStudio_DesignPatternsInCSharp.Scripts.StructuralDesignPatterns.CompositeDesignPattern.RegularCompositeDesignPattern
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public sealed class ConsumableSpecificationWidth(
        ProductSize consumableSpecificationWidthField) : SpecificationComponent<ConsumableComponent>()
    {
        public override bool CheckSpecificationComponentField(in ConsumableComponent consumableSpecificationWidthInput)
        {
            if (consumableSpecificationWidthInput is null)
            {
                return false;
            }

            return EqualityComparer<ProductSize>.Default.Equals(x: consumableSpecificationWidthField, y: consumableSpecificationWidthInput.ProductComponentWidth);
        }

        public override bool Equals(object uncastedConsumableSpecificationWidth)
        {
            StringBuilder consumableSpecificationWidthStringBuilder = new();

            consumableSpecificationWidthStringBuilder.Append(value: $"[START]{nameof(ConsumableSpecificationWidth)}[START]");
            consumableSpecificationWidthStringBuilder.AppendLine(value: string.Empty);
            consumableSpecificationWidthStringBuilder.Append(value: $"Method not implemented in '{nameof(ConsumableSpecificationWidth)}' class");
            consumableSpecificationWidthStringBuilder.AppendLine(value: string.Empty);
            consumableSpecificationWidthStringBuilder.Append(value: $"[END]{nameof(ConsumableSpecificationWidth)}[END]");

            throw new NotImplementedException(message: consumableSpecificationWidthStringBuilder.ToString(), inner: new Exception());
        }

        public override int GetHashCode()
        {
            StringBuilder consumableSpecificationWidthStringBuilder = new();

            consumableSpecificationWidthStringBuilder.Append(value: $"[START]{nameof(ConsumableSpecificationWidth)}[START]");
            consumableSpecificationWidthStringBuilder.AppendLine(value: string.Empty);
            consumableSpecificationWidthStringBuilder.Append(value: $"Method not implemented in '{nameof(ConsumableSpecificationWidth)}' class");
            consumableSpecificationWidthStringBuilder.AppendLine(value: string.Empty);
            consumableSpecificationWidthStringBuilder.Append(value: $"[END]{nameof(ConsumableSpecificationWidth)}[END]");

            throw new NotImplementedException(message: consumableSpecificationWidthStringBuilder.ToString(), inner: new Exception());
        }

        public override string ToString()
        {
            StringBuilder consumableSpecificationWidthStringBuilder = new();

            consumableSpecificationWidthStringBuilder.Append(value: $"[START]{nameof(ConsumableSpecificationWidth)}[START]");
            consumableSpecificationWidthStringBuilder.AppendLine(value: string.Empty);
            consumableSpecificationWidthStringBuilder.Append(value: $"Method not implemented in '{nameof(ConsumableSpecificationWidth)}' class");
            consumableSpecificationWidthStringBuilder.AppendLine(value: string.Empty);
            consumableSpecificationWidthStringBuilder.Append(value: $"[END]{nameof(ConsumableSpecificationWidth)}[END]");

            throw new NotImplementedException(message: consumableSpecificationWidthStringBuilder.ToString(), inner: new Exception());
        }
    }
}