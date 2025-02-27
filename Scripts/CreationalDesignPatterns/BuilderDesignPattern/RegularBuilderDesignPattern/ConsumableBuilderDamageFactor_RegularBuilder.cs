namespace VisualStudio_DesignPatternsInCSharp.Scripts.CreationalDesignPatterns.BuilderDesignPattern.RegularBuilderDesignPattern
{
    using System;
    using System.Text;

    public class ConsumableBuilderDamageFactor<TemplateComponent1> : ConsumableBuilderHealingFactor<ConsumableBuilderDamageFactor<TemplateComponent1>>
        where TemplateComponent1 : ConsumableBuilderDamageFactor<TemplateComponent1>
    {
        protected ConsumableBuilderDamageFactor() : base()
        {

        }

        public TemplateComponent1 SetConsumableBuilderDamageFactorValue(in ConsumableEffectFactor consumableBuilderDamageFactorValue)
        {
            ConsumableBuilderOriginReference ??= new ConsumableComponent();

            ConsumableBuilderOriginReference.SetConsumableComponentDamageFactor(consumableComponentDamageFactor: consumableBuilderDamageFactorValue);

            return (TemplateComponent1)this;
        }

        public override bool Equals(object uncastedConsumableBuilderDamageFactor)
        {
            StringBuilder consumableBuilderDamageFactorStringBuilder = new();

            consumableBuilderDamageFactorStringBuilder.Append(value: $"[START]{nameof(ConsumableBuilderDamageFactor<TemplateComponent1>)}[START]");
            consumableBuilderDamageFactorStringBuilder.AppendLine(value: string.Empty);
            consumableBuilderDamageFactorStringBuilder.Append(value: $"Method not implemented in '{nameof(ConsumableBuilderDamageFactor<TemplateComponent1>)}' class");
            consumableBuilderDamageFactorStringBuilder.AppendLine(value: string.Empty);
            consumableBuilderDamageFactorStringBuilder.Append(value: $"[END]{nameof(ConsumableBuilderDamageFactor<TemplateComponent1>)}[END]");

            throw new NotImplementedException(message: consumableBuilderDamageFactorStringBuilder.ToString(), inner: new Exception());
        }

        public override int GetHashCode()
        {
            StringBuilder consumableBuilderDamageFactorStringBuilder = new();

            consumableBuilderDamageFactorStringBuilder.Append(value: $"[START]{nameof(ConsumableBuilderDamageFactor<TemplateComponent1>)}[START]");
            consumableBuilderDamageFactorStringBuilder.AppendLine(value: string.Empty);
            consumableBuilderDamageFactorStringBuilder.Append(value: $"Method not implemented in '{nameof(ConsumableBuilderDamageFactor<TemplateComponent1>)}' class");
            consumableBuilderDamageFactorStringBuilder.AppendLine(value: string.Empty);
            consumableBuilderDamageFactorStringBuilder.Append(value: $"[END]{nameof(ConsumableBuilderDamageFactor<TemplateComponent1>)}[END]");

            throw new NotImplementedException(message: consumableBuilderDamageFactorStringBuilder.ToString(), inner: new Exception());
        }

        public override string ToString()
        {
            StringBuilder consumableBuilderDamageFactorStringBuilder = new();

            consumableBuilderDamageFactorStringBuilder.Append(value: $"[START]{nameof(ConsumableBuilderDamageFactor<TemplateComponent1>)}[START]");
            consumableBuilderDamageFactorStringBuilder.AppendLine(value: string.Empty);
            consumableBuilderDamageFactorStringBuilder.Append(value: $"Method not implemented in '{nameof(ConsumableBuilderDamageFactor<TemplateComponent1>)}' class");
            consumableBuilderDamageFactorStringBuilder.AppendLine(value: string.Empty);
            consumableBuilderDamageFactorStringBuilder.Append(value: $"[END]{nameof(ConsumableBuilderDamageFactor<TemplateComponent1>)}[END]");

            throw new NotImplementedException(message: consumableBuilderDamageFactorStringBuilder.ToString(), inner: new Exception());
        }
    }
}