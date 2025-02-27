namespace VisualStudio_DesignPatternsInCSharp.Scripts.CreationalDesignPatterns.BuilderDesignPattern.RegularBuilderDesignPattern
{
    using System;
    using System.Text;

    public abstract class ConsumableBuilderOrigin<TemplateComponent1>
        where TemplateComponent1 : ConsumableBuilderOrigin<TemplateComponent1>
    {
        protected ConsumableComponent ConsumableBuilderOriginReference { get; set; }

        public ConsumableBuilderOrigin() : base()
        {
            ConsumableBuilderOriginReference = new ConsumableComponent();
        }

        public ConsumableComponent GetConsumableBuilderOriginReference()
        {
            ConsumableBuilderOriginReference ??= new ConsumableComponent();

            return ConsumableBuilderOriginReference;
        }

        public override bool Equals(object uncastedConsumableBuilderOrigin)
        {
            StringBuilder consumableBuilderOriginStringBuilder = new();

            consumableBuilderOriginStringBuilder.Append(value: $"[START]{nameof(ConsumableBuilderOrigin<TemplateComponent1>)}[START]");
            consumableBuilderOriginStringBuilder.AppendLine(value: string.Empty);
            consumableBuilderOriginStringBuilder.Append(value: $"Method not implemented in '{nameof(ConsumableBuilderOrigin<TemplateComponent1>)}' class");
            consumableBuilderOriginStringBuilder.AppendLine(value: string.Empty);
            consumableBuilderOriginStringBuilder.Append(value: $"[END]{nameof(ConsumableBuilderOrigin<TemplateComponent1>)}[END]");

            throw new NotImplementedException(message: consumableBuilderOriginStringBuilder.ToString(), inner: new Exception());
        }

        public override int GetHashCode()
        {
            StringBuilder consumableBuilderOriginStringBuilder = new();

            consumableBuilderOriginStringBuilder.Append(value: $"[START]{nameof(ConsumableBuilderOrigin<TemplateComponent1>)}[START]");
            consumableBuilderOriginStringBuilder.AppendLine(value: string.Empty);
            consumableBuilderOriginStringBuilder.Append(value: $"Method not implemented in '{nameof(ConsumableBuilderOrigin<TemplateComponent1>)}' class");
            consumableBuilderOriginStringBuilder.AppendLine(value: string.Empty);
            consumableBuilderOriginStringBuilder.Append(value: $"[END]{nameof(ConsumableBuilderOrigin<TemplateComponent1>)}[END]");

            throw new NotImplementedException(message: consumableBuilderOriginStringBuilder.ToString(), inner: new Exception());
        }

        public override string ToString()
        {
            StringBuilder consumableBuilderOriginStringBuilder = new();

            consumableBuilderOriginStringBuilder.Append(value: $"[START]{nameof(ConsumableBuilderOrigin<TemplateComponent1>)}[START]");
            consumableBuilderOriginStringBuilder.AppendLine(value: string.Empty);
            consumableBuilderOriginStringBuilder.Append(value: $"Method not implemented in '{nameof(ConsumableBuilderOrigin<TemplateComponent1>)}' class");
            consumableBuilderOriginStringBuilder.AppendLine(value: string.Empty);
            consumableBuilderOriginStringBuilder.Append(value: $"[END]{nameof(ConsumableBuilderOrigin<TemplateComponent1>)}[END]");

            throw new NotImplementedException(message: consumableBuilderOriginStringBuilder.ToString(), inner: new Exception());
        }
    }
}