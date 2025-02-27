namespace VisualStudio_DesignPatternsInCSharp.Scripts.CreationalDesignPatterns.BuilderDesignPattern.RegularBuilderDesignPattern
{
    using System;
    using System.Text;

    public class ConsumableBuilderHealingFactor<TemplateComponent1> : ConsumableBuilderWeightFactor<ConsumableBuilderHealingFactor<TemplateComponent1>>
        where TemplateComponent1 : ConsumableBuilderHealingFactor<TemplateComponent1>
    {
        protected ConsumableBuilderHealingFactor() : base()
        {

        }

        public TemplateComponent1 SetConsumableBuilderHealingFactorValue(in ConsumableEffectFactor consumableBuilderHealingFactorValue)
        {
            ConsumableBuilderOriginReference ??= new ConsumableComponent();

            ConsumableBuilderOriginReference.SetConsumableComponentHealingFactor(consumableComponentHealingFactor: consumableBuilderHealingFactorValue);

            return (TemplateComponent1)this;
        }

        public override bool Equals(object uncastedConsumableBuilderHealingFactor)
        {
            StringBuilder consumableBuilderHealingFactorStringBuilder = new();

            consumableBuilderHealingFactorStringBuilder.Append(value: $"[START]{nameof(ConsumableBuilderHealingFactor<TemplateComponent1>)}[START]");
            consumableBuilderHealingFactorStringBuilder.AppendLine(value: string.Empty);
            consumableBuilderHealingFactorStringBuilder.Append(value: $"Method not implemented in '{nameof(ConsumableBuilderHealingFactor<TemplateComponent1>)}' class");
            consumableBuilderHealingFactorStringBuilder.AppendLine(value: string.Empty);
            consumableBuilderHealingFactorStringBuilder.Append(value: $"[END]{nameof(ConsumableBuilderHealingFactor<TemplateComponent1>)}[END]");

            throw new NotImplementedException(message: consumableBuilderHealingFactorStringBuilder.ToString(), inner: new Exception());
        }

        public override int GetHashCode()
        {
            StringBuilder consumableBuilderHealingFactorStringBuilder = new();

            consumableBuilderHealingFactorStringBuilder.Append(value: $"[START]{nameof(ConsumableBuilderHealingFactor<TemplateComponent1>)}[START]");
            consumableBuilderHealingFactorStringBuilder.AppendLine(value: string.Empty);
            consumableBuilderHealingFactorStringBuilder.Append(value: $"Method not implemented in '{nameof(ConsumableBuilderHealingFactor<TemplateComponent1>)}' class");
            consumableBuilderHealingFactorStringBuilder.AppendLine(value: string.Empty);
            consumableBuilderHealingFactorStringBuilder.Append(value: $"[END]{nameof(ConsumableBuilderHealingFactor<TemplateComponent1>)}[END]");

            throw new NotImplementedException(message: consumableBuilderHealingFactorStringBuilder.ToString(), inner: new Exception());
        }

        public override string ToString()
        {
            StringBuilder consumableBuilderHealingFactorStringBuilder = new();

            consumableBuilderHealingFactorStringBuilder.Append(value: $"[START]{nameof(ConsumableBuilderHealingFactor<TemplateComponent1>)}[START]");
            consumableBuilderHealingFactorStringBuilder.AppendLine(value: string.Empty);
            consumableBuilderHealingFactorStringBuilder.Append(value: $"Method not implemented in '{nameof(ConsumableBuilderHealingFactor<TemplateComponent1>)}' class");
            consumableBuilderHealingFactorStringBuilder.AppendLine(value: string.Empty);
            consumableBuilderHealingFactorStringBuilder.Append(value: $"[END]{nameof(ConsumableBuilderHealingFactor<TemplateComponent1>)}[END]");

            throw new NotImplementedException(message: consumableBuilderHealingFactorStringBuilder.ToString(), inner: new Exception());
        }
    }
}