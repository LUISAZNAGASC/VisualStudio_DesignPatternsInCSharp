namespace VisualStudio_DesignPatternsInCSharp.Scripts.CreationalDesignPatterns.BuilderDesignPattern.RegularBuilderDesignPattern
{
    using System;
    using System.Text;

    public class ConsumableBuilderWidthFactor<TemplateComponent1> : ConsumableBuilderDescription<ConsumableBuilderWidthFactor<TemplateComponent1>>
        where TemplateComponent1 : ConsumableBuilderWidthFactor<TemplateComponent1>
    {
        protected ConsumableBuilderWidthFactor() : base()
        {

        }

        public TemplateComponent1 SetConsumableBuilderWidthFactorValue(in ProductSizeFactor consumableBuilderWidthFactorValue)
        {
            ConsumableBuilderOriginReference ??= new ConsumableComponent();

            ConsumableBuilderOriginReference.SetProductComponentWidthFactor(productComponentWidthFactor: consumableBuilderWidthFactorValue);

            return (TemplateComponent1)this;
        }

        public override bool Equals(object uncastedConsumableBuilderWidthFactor)
        {
            StringBuilder consumableBuilderWidthFactorStringBuilder = new();

            consumableBuilderWidthFactorStringBuilder.Append(value: $"[START]{nameof(ConsumableBuilderWidthFactor<TemplateComponent1>)}[START]");
            consumableBuilderWidthFactorStringBuilder.AppendLine(value: string.Empty);
            consumableBuilderWidthFactorStringBuilder.Append(value: $"Method not implemented in '{nameof(ConsumableBuilderWidthFactor<TemplateComponent1>)}' class");
            consumableBuilderWidthFactorStringBuilder.AppendLine(value: string.Empty);
            consumableBuilderWidthFactorStringBuilder.Append(value: $"[END]{nameof(ConsumableBuilderWidthFactor<TemplateComponent1>)}[END]");

            throw new NotImplementedException(message: consumableBuilderWidthFactorStringBuilder.ToString(), inner: new Exception());
        }

        public override int GetHashCode()
        {
            StringBuilder consumableBuilderWidthFactorStringBuilder = new();

            consumableBuilderWidthFactorStringBuilder.Append(value: $"[START]{nameof(ConsumableBuilderWidthFactor<TemplateComponent1>)}[START]");
            consumableBuilderWidthFactorStringBuilder.AppendLine(value: string.Empty);
            consumableBuilderWidthFactorStringBuilder.Append(value: $"Method not implemented in '{nameof(ConsumableBuilderWidthFactor<TemplateComponent1>)}' class");
            consumableBuilderWidthFactorStringBuilder.AppendLine(value: string.Empty);
            consumableBuilderWidthFactorStringBuilder.Append(value: $"[END]{nameof(ConsumableBuilderWidthFactor<TemplateComponent1>)}[END]");

            throw new NotImplementedException(message: consumableBuilderWidthFactorStringBuilder.ToString(), inner: new Exception());
        }

        public override string ToString()
        {
            StringBuilder consumableBuilderWidthFactorStringBuilder = new();

            consumableBuilderWidthFactorStringBuilder.Append(value: $"[START]{nameof(ConsumableBuilderWidthFactor<TemplateComponent1>)}[START]");
            consumableBuilderWidthFactorStringBuilder.AppendLine(value: string.Empty);
            consumableBuilderWidthFactorStringBuilder.Append(value: $"Method not implemented in '{nameof(ConsumableBuilderWidthFactor<TemplateComponent1>)}' class");
            consumableBuilderWidthFactorStringBuilder.AppendLine(value: string.Empty);
            consumableBuilderWidthFactorStringBuilder.Append(value: $"[END]{nameof(ConsumableBuilderWidthFactor<TemplateComponent1>)}[END]");

            throw new NotImplementedException(message: consumableBuilderWidthFactorStringBuilder.ToString(), inner: new Exception());
        }
    }
}