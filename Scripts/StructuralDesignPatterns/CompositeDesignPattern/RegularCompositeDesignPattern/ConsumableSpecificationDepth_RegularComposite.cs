namespace VisualStudio_DesignPatternsInCSharp.Scripts.StructuralDesignPatterns.CompositeDesignPattern.RegularCompositeDesignPattern
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public sealed class ConsumableSpecificationDepth(
        ProductSize consumableSpecificationDepthField) : SpecificationComponent<ConsumableComponent>()
    {
        public override bool CheckSpecificationComponentField(in ConsumableComponent consumableSpecificationDepthInput)
        {
            if (consumableSpecificationDepthInput is null)
            {
                return false;
            }

            return EqualityComparer<ProductSize>.Default.Equals(x: consumableSpecificationDepthField, y: consumableSpecificationDepthInput.ProductComponentDepth);
        }

        public override bool Equals(object uncastedConsumableSpecificationDepth)
        {
            StringBuilder consumableSpecificationDepthStringBuilder = new();

            consumableSpecificationDepthStringBuilder.Append(value: $"[START]{nameof(ConsumableSpecificationDepth)}[START]");
            consumableSpecificationDepthStringBuilder.AppendLine(value: string.Empty);
            consumableSpecificationDepthStringBuilder.Append(value: $"Method not implemented in '{nameof(ConsumableSpecificationDepth)}' class");
            consumableSpecificationDepthStringBuilder.AppendLine(value: string.Empty);
            consumableSpecificationDepthStringBuilder.Append(value: $"[END]{nameof(ConsumableSpecificationDepth)}[END]");

            throw new NotImplementedException(message: consumableSpecificationDepthStringBuilder.ToString(), inner: new Exception());
        }

        public override int GetHashCode()
        {
            StringBuilder consumableSpecificationDepthStringBuilder = new();

            consumableSpecificationDepthStringBuilder.Append(value: $"[START]{nameof(ConsumableSpecificationDepth)}[START]");
            consumableSpecificationDepthStringBuilder.AppendLine(value: string.Empty);
            consumableSpecificationDepthStringBuilder.Append(value: $"Method not implemented in '{nameof(ConsumableSpecificationDepth)}' class");
            consumableSpecificationDepthStringBuilder.AppendLine(value: string.Empty);
            consumableSpecificationDepthStringBuilder.Append(value: $"[END]{nameof(ConsumableSpecificationDepth)}[END]");

            throw new NotImplementedException(message: consumableSpecificationDepthStringBuilder.ToString(), inner: new Exception());
        }

        public override string ToString()
        {
            StringBuilder consumableSpecificationDepthStringBuilder = new();

            consumableSpecificationDepthStringBuilder.Append(value: $"[START]{nameof(ConsumableSpecificationDepth)}[START]");
            consumableSpecificationDepthStringBuilder.AppendLine(value: string.Empty);
            consumableSpecificationDepthStringBuilder.Append(value: $"Method not implemented in '{nameof(ConsumableSpecificationDepth)}' class");
            consumableSpecificationDepthStringBuilder.AppendLine(value: string.Empty);
            consumableSpecificationDepthStringBuilder.Append(value: $"[END]{nameof(ConsumableSpecificationDepth)}[END]");

            throw new NotImplementedException(message: consumableSpecificationDepthStringBuilder.ToString(), inner: new Exception());
        }
    }
}