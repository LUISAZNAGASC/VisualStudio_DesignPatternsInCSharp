namespace VisualStudio_DesignPatternsInCSharp.Scripts.StructuralDesignPatterns.CompositeDesignPattern.RegularCompositeDesignPattern
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public sealed class ConsumableSpecificationHealth(
        ConsumableEffect consumableSpecificationHealthField) : SpecificationComponent<ConsumableComponent>()
    {
        public override bool CheckSpecificationComponentField(in ConsumableComponent consumableSpecificationHealthInput)
        {
            if (consumableSpecificationHealthInput is null)
            {
                return false;
            }

            return EqualityComparer<ConsumableEffect>.Default.Equals(x: consumableSpecificationHealthField, y: consumableSpecificationHealthInput.ConsumableComponentHealth);
        }

        public override bool Equals(object uncastedConsumableSpecificationHealth)
        {
            StringBuilder consumableSpecificationHealthStringBuilder = new();

            consumableSpecificationHealthStringBuilder.Append(value: $"[START]{nameof(ConsumableSpecificationHealth)}[START]");
            consumableSpecificationHealthStringBuilder.AppendLine(value: string.Empty);
            consumableSpecificationHealthStringBuilder.Append(value: $"Method not implemented in '{nameof(ConsumableSpecificationHealth)}' class");
            consumableSpecificationHealthStringBuilder.AppendLine(value: string.Empty);
            consumableSpecificationHealthStringBuilder.Append(value: $"[END]{nameof(ConsumableSpecificationHealth)}[END]");

            throw new NotImplementedException(message: consumableSpecificationHealthStringBuilder.ToString(), inner: new Exception());
        }

        public override int GetHashCode()
        {
            StringBuilder consumableSpecificationHealthStringBuilder = new();

            consumableSpecificationHealthStringBuilder.Append(value: $"[START]{nameof(ConsumableSpecificationHealth)}[START]");
            consumableSpecificationHealthStringBuilder.AppendLine(value: string.Empty);
            consumableSpecificationHealthStringBuilder.Append(value: $"Method not implemented in '{nameof(ConsumableSpecificationHealth)}' class");
            consumableSpecificationHealthStringBuilder.AppendLine(value: string.Empty);
            consumableSpecificationHealthStringBuilder.Append(value: $"[END]{nameof(ConsumableSpecificationHealth)}[END]");

            throw new NotImplementedException(message: consumableSpecificationHealthStringBuilder.ToString(), inner: new Exception());
        }

        public override string ToString()
        {
            StringBuilder consumableSpecificationHealthStringBuilder = new();

            consumableSpecificationHealthStringBuilder.Append(value: $"[START]{nameof(ConsumableSpecificationHealth)}[START]");
            consumableSpecificationHealthStringBuilder.AppendLine(value: string.Empty);
            consumableSpecificationHealthStringBuilder.Append(value: $"Method not implemented in '{nameof(ConsumableSpecificationHealth)}' class");
            consumableSpecificationHealthStringBuilder.AppendLine(value: string.Empty);
            consumableSpecificationHealthStringBuilder.Append(value: $"[END]{nameof(ConsumableSpecificationHealth)}[END]");

            throw new NotImplementedException(message: consumableSpecificationHealthStringBuilder.ToString(), inner: new Exception());
        }
    }
}