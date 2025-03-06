namespace VisualStudio_DesignPatternsInCSharp.Scripts.CreationalDesignPatterns.BuilderDesignPattern.RegularBuilderDesignPattern
{
    using System;
    using System.Text;

    public class ConsumableBuilderHealth<Template1> : ConsumableBuilderWeight<ConsumableBuilderHealth<Template1>>
        where Template1 : ConsumableBuilderHealth<Template1>
    {
        protected ConsumableBuilderHealth() : base()
        {

        }

        public Template1 SetConsumableBuilderHealthInput(in ConsumableEffect consumableBuilderHealthInput)
        {
            ConsumableBuilderOriginInstance ??= new ConsumableComponent();

            ConsumableBuilderOriginInstance.SetConsumableComponentHealth(consumableComponentHealth: consumableBuilderHealthInput);

            return (Template1)this;
        }

        public override bool Equals(object uncastedConsumableBuilderHealth)
        {
            StringBuilder consumableBuilderHealthStringBuilder = new();

            consumableBuilderHealthStringBuilder.Append(value: $"[START]{nameof(ConsumableBuilderHealth<Template1>)}[START]");
            consumableBuilderHealthStringBuilder.AppendLine(value: string.Empty);
            consumableBuilderHealthStringBuilder.Append(value: $"Method not implemented in '{nameof(ConsumableBuilderHealth<Template1>)}' class");
            consumableBuilderHealthStringBuilder.AppendLine(value: string.Empty);
            consumableBuilderHealthStringBuilder.Append(value: $"[END]{nameof(ConsumableBuilderHealth<Template1>)}[END]");

            throw new NotImplementedException(message: consumableBuilderHealthStringBuilder.ToString(), inner: new Exception());
        }

        public override int GetHashCode()
        {
            StringBuilder consumableBuilderHealthStringBuilder = new();

            consumableBuilderHealthStringBuilder.Append(value: $"[START]{nameof(ConsumableBuilderHealth<Template1>)}[START]");
            consumableBuilderHealthStringBuilder.AppendLine(value: string.Empty);
            consumableBuilderHealthStringBuilder.Append(value: $"Method not implemented in '{nameof(ConsumableBuilderHealth<Template1>)}' class");
            consumableBuilderHealthStringBuilder.AppendLine(value: string.Empty);
            consumableBuilderHealthStringBuilder.Append(value: $"[END]{nameof(ConsumableBuilderHealth<Template1>)}[END]");

            throw new NotImplementedException(message: consumableBuilderHealthStringBuilder.ToString(), inner: new Exception());
        }

        public override string ToString()
        {
            StringBuilder consumableBuilderHealthStringBuilder = new();

            consumableBuilderHealthStringBuilder.Append(value: $"[START]{nameof(ConsumableBuilderHealth<Template1>)}[START]");
            consumableBuilderHealthStringBuilder.AppendLine(value: string.Empty);
            consumableBuilderHealthStringBuilder.Append(value: $"Method not implemented in '{nameof(ConsumableBuilderHealth<Template1>)}' class");
            consumableBuilderHealthStringBuilder.AppendLine(value: string.Empty);
            consumableBuilderHealthStringBuilder.Append(value: $"[END]{nameof(ConsumableBuilderHealth<Template1>)}[END]");

            throw new NotImplementedException(message: consumableBuilderHealthStringBuilder.ToString(), inner: new Exception());
        }
    }
}