namespace VisualStudio_DesignPatternsInCSharp.Scripts.CreationalDesignPatterns.BuilderDesignPattern.RegularBuilderDesignPattern
{
    using System;
    using System.Text;

    public class ConsumableBuilderDepthFactor<TemplateComponent1> : ConsumableBuilderHeightFactor<ConsumableBuilderDepthFactor<TemplateComponent1>>
        where TemplateComponent1 : ConsumableBuilderDepthFactor<TemplateComponent1>
    {
        protected ConsumableBuilderDepthFactor() : base()
        {

        }

        public TemplateComponent1 SetConsumableBuilderDepthFactorValue(in ProductSizeFactor consumableBuilderDepthFactorValue)
        {
            ConsumableBuilderOriginReference ??= new ConsumableComponent();

            ConsumableBuilderOriginReference.SetProductComponentDepthFactor(productComponentDepthFactor: consumableBuilderDepthFactorValue);

            return (TemplateComponent1)this;
        }

        public override bool Equals(object uncastedConsumableBuilderDepthFactor)
        {
            StringBuilder consumableBuilderDepthFactorStringBuilder = new();

            consumableBuilderDepthFactorStringBuilder.Append(value: $"[START]{nameof(ConsumableBuilderDepthFactor<TemplateComponent1>)}[START]");
            consumableBuilderDepthFactorStringBuilder.AppendLine(value: string.Empty);
            consumableBuilderDepthFactorStringBuilder.Append(value: $"Method not implemented in '{nameof(ConsumableBuilderDepthFactor<TemplateComponent1>)}' class");
            consumableBuilderDepthFactorStringBuilder.AppendLine(value: string.Empty);
            consumableBuilderDepthFactorStringBuilder.Append(value: $"[END]{nameof(ConsumableBuilderDepthFactor<TemplateComponent1>)}[END]");

            throw new NotImplementedException(message: consumableBuilderDepthFactorStringBuilder.ToString(), inner: new Exception());
        }

        public override int GetHashCode()
        {
            StringBuilder consumableBuilderDepthFactorStringBuilder = new();

            consumableBuilderDepthFactorStringBuilder.Append(value: $"[START]{nameof(ConsumableBuilderDepthFactor<TemplateComponent1>)}[START]");
            consumableBuilderDepthFactorStringBuilder.AppendLine(value: string.Empty);
            consumableBuilderDepthFactorStringBuilder.Append(value: $"Method not implemented in '{nameof(ConsumableBuilderDepthFactor<TemplateComponent1>)}' class");
            consumableBuilderDepthFactorStringBuilder.AppendLine(value: string.Empty);
            consumableBuilderDepthFactorStringBuilder.Append(value: $"[END]{nameof(ConsumableBuilderDepthFactor<TemplateComponent1>)}[END]");

            throw new NotImplementedException(message: consumableBuilderDepthFactorStringBuilder.ToString(), inner: new Exception());
        }

        public override string ToString()
        {
            StringBuilder consumableBuilderDepthFactorStringBuilder = new();

            consumableBuilderDepthFactorStringBuilder.Append(value: $"[START]{nameof(ConsumableBuilderDepthFactor<TemplateComponent1>)}[START]");
            consumableBuilderDepthFactorStringBuilder.AppendLine(value: string.Empty);
            consumableBuilderDepthFactorStringBuilder.Append(value: $"Method not implemented in '{nameof(ConsumableBuilderDepthFactor<TemplateComponent1>)}' class");
            consumableBuilderDepthFactorStringBuilder.AppendLine(value: string.Empty);
            consumableBuilderDepthFactorStringBuilder.Append(value: $"[END]{nameof(ConsumableBuilderDepthFactor<TemplateComponent1>)}[END]");

            throw new NotImplementedException(message: consumableBuilderDepthFactorStringBuilder.ToString(), inner: new Exception());
        }
    }
}