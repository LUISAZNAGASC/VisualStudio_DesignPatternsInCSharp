namespace VisualStudio_DesignPatternsInCSharp.Scripts.StructuralDesignPatterns.CompositeDesignPattern.RegularCompositeDesignPattern
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public sealed class ConsumableSpecificationName(
        string consumableSpecificationNameField) : SpecificationComponent<ConsumableComponent>()
    {
        public override bool CheckSpecificationComponentField(in ConsumableComponent consumableSpecificationNameInput)
        {
            if (consumableSpecificationNameInput is null)
            {
                return false;
            }

            return EqualityComparer<string>.Default.Equals(x: consumableSpecificationNameField, y: consumableSpecificationNameInput.ProductComponentName);
        }

        public override bool Equals(object uncastedConsumableSpecificationName)
        {
            StringBuilder consumableSpecificationNameStringBuilder = new();

            consumableSpecificationNameStringBuilder.Append(value: $"[START]{nameof(ConsumableSpecificationName)}[START]");
            consumableSpecificationNameStringBuilder.AppendLine(value: string.Empty);
            consumableSpecificationNameStringBuilder.Append(value: $"Method not implemented in '{nameof(ConsumableSpecificationName)}' class");
            consumableSpecificationNameStringBuilder.AppendLine(value: string.Empty);
            consumableSpecificationNameStringBuilder.Append(value: $"[END]{nameof(ConsumableSpecificationName)}[END]");

            throw new NotImplementedException(message: consumableSpecificationNameStringBuilder.ToString(), inner: new Exception());
        }

        public override int GetHashCode()
        {
            StringBuilder consumableSpecificationNameStringBuilder = new();

            consumableSpecificationNameStringBuilder.Append(value: $"[START]{nameof(ConsumableSpecificationName)}[START]");
            consumableSpecificationNameStringBuilder.AppendLine(value: string.Empty);
            consumableSpecificationNameStringBuilder.Append(value: $"Method not implemented in '{nameof(ConsumableSpecificationName)}' class");
            consumableSpecificationNameStringBuilder.AppendLine(value: string.Empty);
            consumableSpecificationNameStringBuilder.Append(value: $"[END]{nameof(ConsumableSpecificationName)}[END]");

            throw new NotImplementedException(message: consumableSpecificationNameStringBuilder.ToString(), inner: new Exception());
        }

        public override string ToString()
        {
            StringBuilder consumableSpecificationNameStringBuilder = new();

            consumableSpecificationNameStringBuilder.Append(value: $"[START]{nameof(ConsumableSpecificationName)}[START]");
            consumableSpecificationNameStringBuilder.AppendLine(value: string.Empty);
            consumableSpecificationNameStringBuilder.Append(value: $"Method not implemented in '{nameof(ConsumableSpecificationName)}' class");
            consumableSpecificationNameStringBuilder.AppendLine(value: string.Empty);
            consumableSpecificationNameStringBuilder.Append(value: $"[END]{nameof(ConsumableSpecificationName)}[END]");

            throw new NotImplementedException(message: consumableSpecificationNameStringBuilder.ToString(), inner: new Exception());
        }
    }
}