namespace VisualStudio_DesignPatternsInCSharp.Scripts.CreationalDesignPatterns.BuilderDesignPattern.RegularBuilderDesignPattern
{
    using System;
    using System.Text;

    public class ConsumableBuilderWeightFactor<TemplateComponent1> : ConsumableBuilderDepthFactor<ConsumableBuilderWeightFactor<TemplateComponent1>>
        where TemplateComponent1 : ConsumableBuilderWeightFactor<TemplateComponent1>
    {
        protected ConsumableBuilderWeightFactor() : base()
        {

        }

        public TemplateComponent1 SetConsumableBuilderWeightFactorValue(in ProductWeightFactor consumableBuilderWeightFactorValue)
        {
            ConsumableBuilderOriginReference ??= new ConsumableComponent();

            ConsumableBuilderOriginReference.SetProductComponentWeightFactor(productComponentWeightFactor: consumableBuilderWeightFactorValue);

            return (TemplateComponent1)this;
        }

        public override bool Equals(object uncastedConsumableBuilderWeightFactor)
        {
            StringBuilder consumableBuilderWeightFactorStringBuilder = new();

            consumableBuilderWeightFactorStringBuilder.Append(value: $"[START]{nameof(ConsumableBuilderWeightFactor<TemplateComponent1>)}[START]");
            consumableBuilderWeightFactorStringBuilder.AppendLine(value: string.Empty);
            consumableBuilderWeightFactorStringBuilder.Append(value: $"Method not implemented in '{nameof(ConsumableBuilderWeightFactor<TemplateComponent1>)}' class");
            consumableBuilderWeightFactorStringBuilder.AppendLine(value: string.Empty);
            consumableBuilderWeightFactorStringBuilder.Append(value: $"[END]{nameof(ConsumableBuilderWeightFactor<TemplateComponent1>)}[END]");

            throw new NotImplementedException(message: consumableBuilderWeightFactorStringBuilder.ToString(), inner: new Exception());
        }

        public override int GetHashCode()
        {
            StringBuilder consumableBuilderWeightFactorStringBuilder = new();

            consumableBuilderWeightFactorStringBuilder.Append(value: $"[START]{nameof(ConsumableBuilderWeightFactor<TemplateComponent1>)}[START]");
            consumableBuilderWeightFactorStringBuilder.AppendLine(value: string.Empty);
            consumableBuilderWeightFactorStringBuilder.Append(value: $"Method not implemented in '{nameof(ConsumableBuilderWeightFactor<TemplateComponent1>)}' class");
            consumableBuilderWeightFactorStringBuilder.AppendLine(value: string.Empty);
            consumableBuilderWeightFactorStringBuilder.Append(value: $"[END]{nameof(ConsumableBuilderWeightFactor<TemplateComponent1>)}[END]");

            throw new NotImplementedException(message: consumableBuilderWeightFactorStringBuilder.ToString(), inner: new Exception());
        }

        public override string ToString()
        {
            StringBuilder consumableBuilderWeightFactorStringBuilder = new();

            consumableBuilderWeightFactorStringBuilder.Append(value: $"[START]{nameof(ConsumableBuilderWeightFactor<TemplateComponent1>)}[START]");
            consumableBuilderWeightFactorStringBuilder.AppendLine(value: string.Empty);
            consumableBuilderWeightFactorStringBuilder.Append(value: $"Method not implemented in '{nameof(ConsumableBuilderWeightFactor<TemplateComponent1>)}' class");
            consumableBuilderWeightFactorStringBuilder.AppendLine(value: string.Empty);
            consumableBuilderWeightFactorStringBuilder.Append(value: $"[END]{nameof(ConsumableBuilderWeightFactor<TemplateComponent1>)}[END]");

            throw new NotImplementedException(message: consumableBuilderWeightFactorStringBuilder.ToString(), inner: new Exception());
        }
    }
}