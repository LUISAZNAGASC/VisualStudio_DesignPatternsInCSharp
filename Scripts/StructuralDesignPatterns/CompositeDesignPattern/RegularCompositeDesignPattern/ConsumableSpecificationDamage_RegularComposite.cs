namespace VisualStudio_DesignPatternsInCSharp.Scripts.StructuralDesignPatterns.CompositeDesignPattern.RegularCompositeDesignPattern
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public sealed class ConsumableSpecificationDamage(
        ConsumableEffect consumableSpecificationDamageField) : SpecificationComponent<ConsumableComponent>()
    {
        public override bool CheckSpecificationComponentField(in ConsumableComponent consumableSpecificationDamageInput)
        {
            if (consumableSpecificationDamageInput is null)
            {
                return false;
            }

            return EqualityComparer<ConsumableEffect>.Default.Equals(x: consumableSpecificationDamageField, y: consumableSpecificationDamageInput.ConsumableComponentDamage);
        }

        public override bool Equals(object uncastedConsumableSpecificationDamage)
        {
            StringBuilder consumableSpecificationDamageStringBuilder = new();

            consumableSpecificationDamageStringBuilder.Append(value: $"[START]{nameof(ConsumableSpecificationDamage)}[START]");
            consumableSpecificationDamageStringBuilder.AppendLine(value: string.Empty);
            consumableSpecificationDamageStringBuilder.Append(value: $"Method not implemented in '{nameof(ConsumableSpecificationDamage)}' class");
            consumableSpecificationDamageStringBuilder.AppendLine(value: string.Empty);
            consumableSpecificationDamageStringBuilder.Append(value: $"[END]{nameof(ConsumableSpecificationDamage)}[END]");

            throw new NotImplementedException(message: consumableSpecificationDamageStringBuilder.ToString(), inner: new Exception());
        }

        public override int GetHashCode()
        {
            StringBuilder consumableSpecificationDamageStringBuilder = new();

            consumableSpecificationDamageStringBuilder.Append(value: $"[START]{nameof(ConsumableSpecificationDamage)}[START]");
            consumableSpecificationDamageStringBuilder.AppendLine(value: string.Empty);
            consumableSpecificationDamageStringBuilder.Append(value: $"Method not implemented in '{nameof(ConsumableSpecificationDamage)}' class");
            consumableSpecificationDamageStringBuilder.AppendLine(value: string.Empty);
            consumableSpecificationDamageStringBuilder.Append(value: $"[END]{nameof(ConsumableSpecificationDamage)}[END]");

            throw new NotImplementedException(message: consumableSpecificationDamageStringBuilder.ToString(), inner: new Exception());
        }

        public override string ToString()
        {
            StringBuilder consumableSpecificationDamageStringBuilder = new();

            consumableSpecificationDamageStringBuilder.Append(value: $"[START]{nameof(ConsumableSpecificationDamage)}[START]");
            consumableSpecificationDamageStringBuilder.AppendLine(value: string.Empty);
            consumableSpecificationDamageStringBuilder.Append(value: $"Method not implemented in '{nameof(ConsumableSpecificationDamage)}' class");
            consumableSpecificationDamageStringBuilder.AppendLine(value: string.Empty);
            consumableSpecificationDamageStringBuilder.Append(value: $"[END]{nameof(ConsumableSpecificationDamage)}[END]");

            throw new NotImplementedException(message: consumableSpecificationDamageStringBuilder.ToString(), inner: new Exception());
        }
    }
}