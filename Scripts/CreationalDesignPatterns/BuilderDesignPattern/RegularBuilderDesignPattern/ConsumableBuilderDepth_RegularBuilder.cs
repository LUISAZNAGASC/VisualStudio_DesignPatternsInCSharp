namespace VisualStudio_DesignPatternsInCSharp.Scripts.CreationalDesignPatterns.BuilderDesignPattern.RegularBuilderDesignPattern
{
    using System;
    using System.Text;

    public class ConsumableBuilderDepth<Template1> : ConsumableBuilderHeight<ConsumableBuilderDepth<Template1>> where Template1 : ConsumableBuilderDepth<Template1>
    {
        protected ConsumableBuilderDepth() : base()
        {

        }

        public Template1 SetConsumableBuilderDepthInput(in ProductSize consumableBuilderDepthInput)
        {
            if (ConsumableBuilderOriginInstance is null)
            {
                StringBuilder consumableBuilderDepthStringBuilder = new();

                consumableBuilderDepthStringBuilder.Append(value: $"[START]{nameof(ConsumableBuilderDepth<Template1>)}[START]");
                consumableBuilderDepthStringBuilder.AppendLine(value: string.Empty);
                consumableBuilderDepthStringBuilder.Append(value: $"There was an issue in '{nameof(ConsumableBuilderDepth<Template1>)}' class");
                consumableBuilderDepthStringBuilder.AppendLine(value: string.Empty);
                consumableBuilderDepthStringBuilder.Append(value: $"[END]{nameof(ConsumableBuilderDepth<Template1>)}[END]");

                throw new InvalidOperationException(message: consumableBuilderDepthStringBuilder.ToString(), innerException: new Exception());
            }

            ConsumableBuilderOriginInstance.SetProductComponentDepth(productComponentDepth: consumableBuilderDepthInput);

            return (Template1)this;
        }

        public override bool Equals(object uncastedConsumableBuilderDepth)
        {
            StringBuilder consumableBuilderDepthStringBuilder = new();

            consumableBuilderDepthStringBuilder.Append(value: $"[START]{nameof(ConsumableBuilderDepth<Template1>)}[START]");
            consumableBuilderDepthStringBuilder.AppendLine(value: string.Empty);
            consumableBuilderDepthStringBuilder.Append(value: $"Method not implemented in '{nameof(ConsumableBuilderDepth<Template1>)}' class");
            consumableBuilderDepthStringBuilder.AppendLine(value: string.Empty);
            consumableBuilderDepthStringBuilder.Append(value: $"[END]{nameof(ConsumableBuilderDepth<Template1>)}[END]");

            throw new NotImplementedException(message: consumableBuilderDepthStringBuilder.ToString(), inner: new Exception());
        }

        public override int GetHashCode()
        {
            StringBuilder consumableBuilderDepthStringBuilder = new();

            consumableBuilderDepthStringBuilder.Append(value: $"[START]{nameof(ConsumableBuilderDepth<Template1>)}[START]");
            consumableBuilderDepthStringBuilder.AppendLine(value: string.Empty);
            consumableBuilderDepthStringBuilder.Append(value: $"Method not implemented in '{nameof(ConsumableBuilderDepth<Template1>)}' class");
            consumableBuilderDepthStringBuilder.AppendLine(value: string.Empty);
            consumableBuilderDepthStringBuilder.Append(value: $"[END]{nameof(ConsumableBuilderDepth<Template1>)}[END]");

            throw new NotImplementedException(message: consumableBuilderDepthStringBuilder.ToString(), inner: new Exception());
        }

        public override string ToString()
        {
            StringBuilder consumableBuilderDepthStringBuilder = new();

            consumableBuilderDepthStringBuilder.Append(value: $"[START]{nameof(ConsumableBuilderDepth<Template1>)}[START]");
            consumableBuilderDepthStringBuilder.AppendLine(value: string.Empty);
            consumableBuilderDepthStringBuilder.Append(value: $"Method not implemented in '{nameof(ConsumableBuilderDepth<Template1>)}' class");
            consumableBuilderDepthStringBuilder.AppendLine(value: string.Empty);
            consumableBuilderDepthStringBuilder.Append(value: $"[END]{nameof(ConsumableBuilderDepth<Template1>)}[END]");

            throw new NotImplementedException(message: consumableBuilderDepthStringBuilder.ToString(), inner: new Exception());
        }
    }
}