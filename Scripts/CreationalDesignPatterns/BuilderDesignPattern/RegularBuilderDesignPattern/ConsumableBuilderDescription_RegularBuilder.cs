namespace VisualStudio_DesignPatternsInCSharp.Scripts.CreationalDesignPatterns.BuilderDesignPattern.RegularBuilderDesignPattern
{
    using System;
    using System.Text;

    public class ConsumableBuilderDescription<TemplateComponent1> : ConsumableBuilderIdentifier<ConsumableBuilderDescription<TemplateComponent1>>
        where TemplateComponent1 : ConsumableBuilderDescription<TemplateComponent1>
    {
        protected ConsumableBuilderDescription() : base()
        {

        }

        public TemplateComponent1 SetConsumableBuilderDescriptionValue(in string consumableBuilderDescriptionValue)
        {
            ConsumableBuilderOriginReference ??= new ConsumableComponent();

            ConsumableBuilderOriginReference.SetProductComponentDescription(productComponentDescription: consumableBuilderDescriptionValue);

            return (TemplateComponent1)this;
        }

        public override bool Equals(object uncastedConsumableBuilderDescription)
        {
            StringBuilder consumableBuilderDescriptionStringBuilder = new();

            consumableBuilderDescriptionStringBuilder.Append(value: $"[START]{nameof(ConsumableBuilderDescription<TemplateComponent1>)}[START]");
            consumableBuilderDescriptionStringBuilder.AppendLine(value: string.Empty);
            consumableBuilderDescriptionStringBuilder.Append(value: $"Method not implemented in '{nameof(ConsumableBuilderDescription<TemplateComponent1>)}' class");
            consumableBuilderDescriptionStringBuilder.AppendLine(value: string.Empty);
            consumableBuilderDescriptionStringBuilder.Append(value: $"[END]{nameof(ConsumableBuilderDescription<TemplateComponent1>)}[END]");

            throw new NotImplementedException(message: consumableBuilderDescriptionStringBuilder.ToString(), inner: new Exception());
        }

        public override int GetHashCode()
        {
            StringBuilder consumableBuilderDescriptionStringBuilder = new();

            consumableBuilderDescriptionStringBuilder.Append(value: $"[START]{nameof(ConsumableBuilderDescription<TemplateComponent1>)}[START]");
            consumableBuilderDescriptionStringBuilder.AppendLine(value: string.Empty);
            consumableBuilderDescriptionStringBuilder.Append(value: $"Method not implemented in '{nameof(ConsumableBuilderDescription<TemplateComponent1>)}' class");
            consumableBuilderDescriptionStringBuilder.AppendLine(value: string.Empty);
            consumableBuilderDescriptionStringBuilder.Append(value: $"[END]{nameof(ConsumableBuilderDescription<TemplateComponent1>)}[END]");

            throw new NotImplementedException(message: consumableBuilderDescriptionStringBuilder.ToString(), inner: new Exception());
        }

        public override string ToString()
        {
            StringBuilder consumableBuilderDescriptionStringBuilder = new();

            consumableBuilderDescriptionStringBuilder.Append(value: $"[START]{nameof(ConsumableBuilderDescription<TemplateComponent1>)}[START]");
            consumableBuilderDescriptionStringBuilder.AppendLine(value: string.Empty);
            consumableBuilderDescriptionStringBuilder.Append(value: $"Method not implemented in '{nameof(ConsumableBuilderDescription<TemplateComponent1>)}' class");
            consumableBuilderDescriptionStringBuilder.AppendLine(value: string.Empty);
            consumableBuilderDescriptionStringBuilder.Append(value: $"[END]{nameof(ConsumableBuilderDescription<TemplateComponent1>)}[END]");

            throw new NotImplementedException(message: consumableBuilderDescriptionStringBuilder.ToString(), inner: new Exception());
        }
    }
}