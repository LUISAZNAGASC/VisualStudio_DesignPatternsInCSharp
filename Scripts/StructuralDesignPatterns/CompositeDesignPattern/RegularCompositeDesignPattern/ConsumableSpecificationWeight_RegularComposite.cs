namespace VisualStudio_DesignPatternsInCSharp.Scripts.StructuralDesignPatterns.CompositeDesignPattern.RegularCompositeDesignPattern
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public sealed class ConsumableSpecificationWeight(
        ProductWeight consumableSpecificationWeightField) : SpecificationComponent<ConsumableComponent>()
    {
        public override bool CheckSpecificationComponentField(in ConsumableComponent consumableSpecificationWeightInput)
        {
            if (consumableSpecificationWeightInput is null)
            {
                return false;
            }

            return EqualityComparer<ProductWeight>.Default.Equals(x: consumableSpecificationWeightField, y: consumableSpecificationWeightInput.ProductComponentWeight);
        }

        public override bool Equals(object uncastedConsumableSpecificationWeight)
        {
            StringBuilder consumableSpecificationWeightStringBuilder = new();

            consumableSpecificationWeightStringBuilder.Append(value: $"[START]{nameof(ConsumableSpecificationWeight)}[START]");
            consumableSpecificationWeightStringBuilder.AppendLine(value: string.Empty);
            consumableSpecificationWeightStringBuilder.Append(value: $"Method not implemented in '{nameof(ConsumableSpecificationWeight)}' class");
            consumableSpecificationWeightStringBuilder.AppendLine(value: string.Empty);
            consumableSpecificationWeightStringBuilder.Append(value: $"[END]{nameof(ConsumableSpecificationWeight)}[END]");

            throw new NotImplementedException(message: consumableSpecificationWeightStringBuilder.ToString(), inner: new Exception());
        }

        public override int GetHashCode()
        {
            StringBuilder consumableSpecificationWeightStringBuilder = new();

            consumableSpecificationWeightStringBuilder.Append(value: $"[START]{nameof(ConsumableSpecificationWeight)}[START]");
            consumableSpecificationWeightStringBuilder.AppendLine(value: string.Empty);
            consumableSpecificationWeightStringBuilder.Append(value: $"Method not implemented in '{nameof(ConsumableSpecificationWeight)}' class");
            consumableSpecificationWeightStringBuilder.AppendLine(value: string.Empty);
            consumableSpecificationWeightStringBuilder.Append(value: $"[END]{nameof(ConsumableSpecificationWeight)}[END]");

            throw new NotImplementedException(message: consumableSpecificationWeightStringBuilder.ToString(), inner: new Exception());
        }

        public override string ToString()
        {
            StringBuilder consumableSpecificationWeightStringBuilder = new();

            consumableSpecificationWeightStringBuilder.Append(value: $"[START]{nameof(ConsumableSpecificationWeight)}[START]");
            consumableSpecificationWeightStringBuilder.AppendLine(value: string.Empty);
            consumableSpecificationWeightStringBuilder.Append(value: $"Method not implemented in '{nameof(ConsumableSpecificationWeight)}' class");
            consumableSpecificationWeightStringBuilder.AppendLine(value: string.Empty);
            consumableSpecificationWeightStringBuilder.Append(value: $"[END]{nameof(ConsumableSpecificationWeight)}[END]");

            throw new NotImplementedException(message: consumableSpecificationWeightStringBuilder.ToString(), inner: new Exception());
        }
    }
}