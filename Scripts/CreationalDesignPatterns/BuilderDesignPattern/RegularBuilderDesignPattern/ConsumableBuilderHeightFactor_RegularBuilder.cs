namespace VisualStudio_DesignPatternsInCSharp.Scripts.CreationalDesignPatterns.BuilderDesignPattern.RegularBuilderDesignPattern
{
    using System;
    using System.Text;

    public class ConsumableBuilderHeightFactor<TemplateComponent1> : ConsumableBuilderWidthFactor<ConsumableBuilderHeightFactor<TemplateComponent1>>
        where TemplateComponent1 : ConsumableBuilderHeightFactor<TemplateComponent1>
    {
        protected ConsumableBuilderHeightFactor() : base()
        {

        }

        public TemplateComponent1 SetConsumableBuilderHeightFactorValue(in ProductSizeFactor consumableBuilderHeightFactorValue)
        {
            ConsumableBuilderOriginReference ??= new ConsumableComponent();

            ConsumableBuilderOriginReference.SetProductComponentHeightFactor(productComponentHeightFactor: consumableBuilderHeightFactorValue);

            return (TemplateComponent1)this;
        }

        public override bool Equals(object uncastedConsumableBuilderHeightFactor)
        {
            StringBuilder consumableBuilderHeightFactorStringBuilder = new();

            consumableBuilderHeightFactorStringBuilder.Append(value: $"[START]{nameof(ConsumableBuilderHeightFactor<TemplateComponent1>)}[START]");
            consumableBuilderHeightFactorStringBuilder.AppendLine(value: string.Empty);
            consumableBuilderHeightFactorStringBuilder.Append(value: $"Method not implemented in '{nameof(ConsumableBuilderHeightFactor<TemplateComponent1>)}' class");
            consumableBuilderHeightFactorStringBuilder.AppendLine(value: string.Empty);
            consumableBuilderHeightFactorStringBuilder.Append(value: $"[END]{nameof(ConsumableBuilderHeightFactor<TemplateComponent1>)}[END]");

            throw new NotImplementedException(message: consumableBuilderHeightFactorStringBuilder.ToString(), inner: new Exception());
        }

        public override int GetHashCode()
        {
            StringBuilder consumableBuilderHeightFactorStringBuilder = new();

            consumableBuilderHeightFactorStringBuilder.Append(value: $"[START]{nameof(ConsumableBuilderHeightFactor<TemplateComponent1>)}[START]");
            consumableBuilderHeightFactorStringBuilder.AppendLine(value: string.Empty);
            consumableBuilderHeightFactorStringBuilder.Append(value: $"Method not implemented in '{nameof(ConsumableBuilderHeightFactor<TemplateComponent1>)}' class");
            consumableBuilderHeightFactorStringBuilder.AppendLine(value: string.Empty);
            consumableBuilderHeightFactorStringBuilder.Append(value: $"[END]{nameof(ConsumableBuilderHeightFactor<TemplateComponent1>)}[END]");

            throw new NotImplementedException(message: consumableBuilderHeightFactorStringBuilder.ToString(), inner: new Exception());
        }

        public override string ToString()
        {
            StringBuilder consumableBuilderHeightFactorStringBuilder = new();

            consumableBuilderHeightFactorStringBuilder.Append(value: $"[START]{nameof(ConsumableBuilderHeightFactor<TemplateComponent1>)}[START]");
            consumableBuilderHeightFactorStringBuilder.AppendLine(value: string.Empty);
            consumableBuilderHeightFactorStringBuilder.Append(value: $"Method not implemented in '{nameof(ConsumableBuilderHeightFactor<TemplateComponent1>)}' class");
            consumableBuilderHeightFactorStringBuilder.AppendLine(value: string.Empty);
            consumableBuilderHeightFactorStringBuilder.Append(value: $"[END]{nameof(ConsumableBuilderHeightFactor<TemplateComponent1>)}[END]");

            throw new NotImplementedException(message: consumableBuilderHeightFactorStringBuilder.ToString(), inner: new Exception());
        }
    }
}