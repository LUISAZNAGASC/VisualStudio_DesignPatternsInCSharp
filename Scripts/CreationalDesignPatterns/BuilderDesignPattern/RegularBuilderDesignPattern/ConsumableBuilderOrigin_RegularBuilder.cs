namespace VisualStudio_DesignPatternsInCSharp.Scripts.CreationalDesignPatterns.BuilderDesignPattern.RegularBuilderDesignPattern
{
    using System;
    using System.Text;

    public abstract class ConsumableBuilderOrigin<Template1>
        where Template1 : ConsumableBuilderOrigin<Template1>
    {
        protected ConsumableComponent ConsumableBuilderOriginInstance { get; set; }

        protected ConsumableBuilderOrigin() : base()
        {
            ConsumableBuilderOriginInstance = new ConsumableComponent();
        }

        public ConsumableComponent GetConsumableBuilderOriginInstance()
        {
            ConsumableBuilderOriginInstance ??= new ConsumableComponent();

            return ConsumableBuilderOriginInstance;
        }

        public override bool Equals(object uncastedConsumableBuilderOrigin)
        {
            StringBuilder consumableBuilderOriginStringBuilder = new();

            consumableBuilderOriginStringBuilder.Append(value: $"[START]{nameof(ConsumableBuilderOrigin<Template1>)}[START]");
            consumableBuilderOriginStringBuilder.AppendLine(value: string.Empty);
            consumableBuilderOriginStringBuilder.Append(value: $"Method not implemented in '{nameof(ConsumableBuilderOrigin<Template1>)}' class");
            consumableBuilderOriginStringBuilder.AppendLine(value: string.Empty);
            consumableBuilderOriginStringBuilder.Append(value: $"[END]{nameof(ConsumableBuilderOrigin<Template1>)}[END]");

            throw new NotImplementedException(message: consumableBuilderOriginStringBuilder.ToString(), inner: new Exception());
        }

        public override int GetHashCode()
        {
            StringBuilder consumableBuilderOriginStringBuilder = new();

            consumableBuilderOriginStringBuilder.Append(value: $"[START]{nameof(ConsumableBuilderOrigin<Template1>)}[START]");
            consumableBuilderOriginStringBuilder.AppendLine(value: string.Empty);
            consumableBuilderOriginStringBuilder.Append(value: $"Method not implemented in '{nameof(ConsumableBuilderOrigin<Template1>)}' class");
            consumableBuilderOriginStringBuilder.AppendLine(value: string.Empty);
            consumableBuilderOriginStringBuilder.Append(value: $"[END]{nameof(ConsumableBuilderOrigin<Template1>)}[END]");

            throw new NotImplementedException(message: consumableBuilderOriginStringBuilder.ToString(), inner: new Exception());
        }

        public override string ToString()
        {
            StringBuilder consumableBuilderOriginStringBuilder = new();

            consumableBuilderOriginStringBuilder.Append(value: $"[START]{nameof(ConsumableBuilderOrigin<Template1>)}[START]");
            consumableBuilderOriginStringBuilder.AppendLine(value: string.Empty);
            consumableBuilderOriginStringBuilder.Append(value: $"Method not implemented in '{nameof(ConsumableBuilderOrigin<Template1>)}' class");
            consumableBuilderOriginStringBuilder.AppendLine(value: string.Empty);
            consumableBuilderOriginStringBuilder.Append(value: $"[END]{nameof(ConsumableBuilderOrigin<Template1>)}[END]");

            throw new NotImplementedException(message: consumableBuilderOriginStringBuilder.ToString(), inner: new Exception());
        }
    }
}