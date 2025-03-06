namespace VisualStudio_DesignPatternsInCSharp.Scripts.CreationalDesignPatterns.BuilderDesignPattern.RegularBuilderDesignPattern
{
    using System;
    using System.Text;

    public class ConsumableBuilderHeight<Template1> : ConsumableBuilderWidth<ConsumableBuilderHeight<Template1>>
        where Template1 : ConsumableBuilderHeight<Template1>
    {
        protected ConsumableBuilderHeight() : base()
        {

        }

        public Template1 SetConsumableBuilderHeightInput(in ProductSize consumableBuilderHeightInput)
        {
            ConsumableBuilderOriginInstance ??= new ConsumableComponent();

            ConsumableBuilderOriginInstance.SetProductComponentHeight(productComponentHeight: consumableBuilderHeightInput);

            return (Template1)this;
        }

        public override bool Equals(object uncastedConsumableBuilderHeight)
        {
            StringBuilder consumableBuilderHeightStringBuilder = new();

            consumableBuilderHeightStringBuilder.Append(value: $"[START]{nameof(ConsumableBuilderHeight<Template1>)}[START]");
            consumableBuilderHeightStringBuilder.AppendLine(value: string.Empty);
            consumableBuilderHeightStringBuilder.Append(value: $"Method not implemented in '{nameof(ConsumableBuilderHeight<Template1>)}' class");
            consumableBuilderHeightStringBuilder.AppendLine(value: string.Empty);
            consumableBuilderHeightStringBuilder.Append(value: $"[END]{nameof(ConsumableBuilderHeight<Template1>)}[END]");

            throw new NotImplementedException(message: consumableBuilderHeightStringBuilder.ToString(), inner: new Exception());
        }

        public override int GetHashCode()
        {
            StringBuilder consumableBuilderHeightStringBuilder = new();

            consumableBuilderHeightStringBuilder.Append(value: $"[START]{nameof(ConsumableBuilderHeight<Template1>)}[START]");
            consumableBuilderHeightStringBuilder.AppendLine(value: string.Empty);
            consumableBuilderHeightStringBuilder.Append(value: $"Method not implemented in '{nameof(ConsumableBuilderHeight<Template1>)}' class");
            consumableBuilderHeightStringBuilder.AppendLine(value: string.Empty);
            consumableBuilderHeightStringBuilder.Append(value: $"[END]{nameof(ConsumableBuilderHeight<Template1>)}[END]");

            throw new NotImplementedException(message: consumableBuilderHeightStringBuilder.ToString(), inner: new Exception());
        }

        public override string ToString()
        {
            StringBuilder consumableBuilderHeightStringBuilder = new();

            consumableBuilderHeightStringBuilder.Append(value: $"[START]{nameof(ConsumableBuilderHeight<Template1>)}[START]");
            consumableBuilderHeightStringBuilder.AppendLine(value: string.Empty);
            consumableBuilderHeightStringBuilder.Append(value: $"Method not implemented in '{nameof(ConsumableBuilderHeight<Template1>)}' class");
            consumableBuilderHeightStringBuilder.AppendLine(value: string.Empty);
            consumableBuilderHeightStringBuilder.Append(value: $"[END]{nameof(ConsumableBuilderHeight<Template1>)}[END]");

            throw new NotImplementedException(message: consumableBuilderHeightStringBuilder.ToString(), inner: new Exception());
        }
    }
}