namespace VisualStudio_DesignPatternsInCSharp.Scripts.CreationalDesignPatterns.BuilderDesignPattern.RegularBuilderDesignPattern
{
    using System;
    using System.Text;

    public class ConsumableBuilderIdentifier<TemplateComponent1> : ConsumableBuilderOrigin<ConsumableBuilderIdentifier<TemplateComponent1>>
        where TemplateComponent1 : ConsumableBuilderIdentifier<TemplateComponent1>
    {
        protected ConsumableBuilderIdentifier() : base()
        {

        }

        public TemplateComponent1 SetConsumableBuilderIdentifierValue(in string consumableBuilderIdentifierValue)
        {
            ConsumableBuilderOriginReference ??= new ConsumableComponent();

            ConsumableBuilderOriginReference.SetProductComponentIdentifier(productComponentIdentifier: consumableBuilderIdentifierValue);

            return (TemplateComponent1)this;
        }

        public override bool Equals(object uncastedConsumableBuilderIdentifier)
        {
            StringBuilder consumableBuilderIdentifierStringBuilder = new();

            consumableBuilderIdentifierStringBuilder.Append(value: $"[START]{nameof(ConsumableBuilderIdentifier<TemplateComponent1>)}[START]");
            consumableBuilderIdentifierStringBuilder.AppendLine(value: string.Empty);
            consumableBuilderIdentifierStringBuilder.Append(value: $"Method not implemented in '{nameof(ConsumableBuilderIdentifier<TemplateComponent1>)}' class");
            consumableBuilderIdentifierStringBuilder.AppendLine(value: string.Empty);
            consumableBuilderIdentifierStringBuilder.Append(value: $"[END]{nameof(ConsumableBuilderIdentifier<TemplateComponent1>)}[END]");

            throw new NotImplementedException(message: consumableBuilderIdentifierStringBuilder.ToString(), inner: new Exception());
        }

        public override int GetHashCode()
        {
            StringBuilder consumableBuilderIdentifierStringBuilder = new();

            consumableBuilderIdentifierStringBuilder.Append(value: $"[START]{nameof(ConsumableBuilderIdentifier<TemplateComponent1>)}[START]");
            consumableBuilderIdentifierStringBuilder.AppendLine(value: string.Empty);
            consumableBuilderIdentifierStringBuilder.Append(value: $"Method not implemented in '{nameof(ConsumableBuilderIdentifier<TemplateComponent1>)}' class");
            consumableBuilderIdentifierStringBuilder.AppendLine(value: string.Empty);
            consumableBuilderIdentifierStringBuilder.Append(value: $"[END]{nameof(ConsumableBuilderIdentifier<TemplateComponent1>)}[END]");

            throw new NotImplementedException(message: consumableBuilderIdentifierStringBuilder.ToString(), inner: new Exception());
        }

        public override string ToString()
        {
            StringBuilder consumableBuilderIdentifierStringBuilder = new();

            consumableBuilderIdentifierStringBuilder.Append(value: $"[START]{nameof(ConsumableBuilderIdentifier<TemplateComponent1>)}[START]");
            consumableBuilderIdentifierStringBuilder.AppendLine(value: string.Empty);
            consumableBuilderIdentifierStringBuilder.Append(value: $"Method not implemented in '{nameof(ConsumableBuilderIdentifier<TemplateComponent1>)}' class");
            consumableBuilderIdentifierStringBuilder.AppendLine(value: string.Empty);
            consumableBuilderIdentifierStringBuilder.Append(value: $"[END]{nameof(ConsumableBuilderIdentifier<TemplateComponent1>)}[END]");

            throw new NotImplementedException(message: consumableBuilderIdentifierStringBuilder.ToString(), inner: new Exception());
        }
    }
}