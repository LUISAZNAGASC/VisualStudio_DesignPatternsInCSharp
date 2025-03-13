namespace VisualStudio_DesignPatternsInCSharp.Scripts.CreationalDesignPatterns.BuilderDesignPattern.RegularBuilderDesignPattern
{
    using System;
    using System.Text;

    public class ConsumableBuilderName<Template1> : ConsumableBuilderOrigin<ConsumableBuilderName<Template1>> where Template1 : ConsumableBuilderName<Template1>
    {
        protected ConsumableBuilderName() : base()
        {

        }

        public Template1 SetConsumableBuilderNameInput(in string consumableBuilderNameInput)
        {
            if (ConsumableBuilderOriginInstance is null)
            {
                StringBuilder consumableBuilderNameStringBuilder = new();

                consumableBuilderNameStringBuilder.Append(value: $"[START]{nameof(ConsumableBuilderName<Template1>)}[START]");
                consumableBuilderNameStringBuilder.AppendLine(value: string.Empty);
                consumableBuilderNameStringBuilder.Append(value: $"There was an issue in '{nameof(ConsumableBuilderName<Template1>)}' class");
                consumableBuilderNameStringBuilder.AppendLine(value: string.Empty);
                consumableBuilderNameStringBuilder.Append(value: $"[END]{nameof(ConsumableBuilderName<Template1>)}[END]");

                throw new InvalidOperationException(message: consumableBuilderNameStringBuilder.ToString(), innerException: new Exception());
            }

            ConsumableBuilderOriginInstance.SetProductComponentName(productComponentName: consumableBuilderNameInput);

            return (Template1)this;
        }

        public override bool Equals(object uncastedConsumableBuilderName)
        {
            StringBuilder consumableBuilderNameStringBuilder = new();

            consumableBuilderNameStringBuilder.Append(value: $"[START]{nameof(ConsumableBuilderName<Template1>)}[START]");
            consumableBuilderNameStringBuilder.AppendLine(value: string.Empty);
            consumableBuilderNameStringBuilder.Append(value: $"Method not implemented in '{nameof(ConsumableBuilderName<Template1>)}' class");
            consumableBuilderNameStringBuilder.AppendLine(value: string.Empty);
            consumableBuilderNameStringBuilder.Append(value: $"[END]{nameof(ConsumableBuilderName<Template1>)}[END]");

            throw new NotImplementedException(message: consumableBuilderNameStringBuilder.ToString(), inner: new Exception());
        }

        public override int GetHashCode()
        {
            StringBuilder consumableBuilderNameStringBuilder = new();

            consumableBuilderNameStringBuilder.Append(value: $"[START]{nameof(ConsumableBuilderName<Template1>)}[START]");
            consumableBuilderNameStringBuilder.AppendLine(value: string.Empty);
            consumableBuilderNameStringBuilder.Append(value: $"Method not implemented in '{nameof(ConsumableBuilderName<Template1>)}' class");
            consumableBuilderNameStringBuilder.AppendLine(value: string.Empty);
            consumableBuilderNameStringBuilder.Append(value: $"[END]{nameof(ConsumableBuilderName<Template1>)}[END]");

            throw new NotImplementedException(message: consumableBuilderNameStringBuilder.ToString(), inner: new Exception());
        }

        public override string ToString()
        {
            StringBuilder consumableBuilderNameStringBuilder = new();

            consumableBuilderNameStringBuilder.Append(value: $"[START]{nameof(ConsumableBuilderName<Template1>)}[START]");
            consumableBuilderNameStringBuilder.AppendLine(value: string.Empty);
            consumableBuilderNameStringBuilder.Append(value: $"Method not implemented in '{nameof(ConsumableBuilderName<Template1>)}' class");
            consumableBuilderNameStringBuilder.AppendLine(value: string.Empty);
            consumableBuilderNameStringBuilder.Append(value: $"[END]{nameof(ConsumableBuilderName<Template1>)}[END]");

            throw new NotImplementedException(message: consumableBuilderNameStringBuilder.ToString(), inner: new Exception());
        }
    }
}