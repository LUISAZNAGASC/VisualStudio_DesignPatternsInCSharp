namespace VisualStudio_DesignPatternsInCSharp.Scripts.CreationalDesignPatterns.BuilderDesignPattern.RegularBuilderDesignPattern
{
    using System;
    using System.Text;

    public class ConsumableBuilderTarget<TemplateComponent1> : ConsumableBuilderDamageFactor<ConsumableBuilderTarget<TemplateComponent1>>
        where TemplateComponent1 : ConsumableBuilderTarget<TemplateComponent1>
    {
        protected ConsumableBuilderTarget() : base()
        {

        }

        public override bool Equals(object uncastedConsumableBuilderTarget)
        {
            StringBuilder consumableBuilderTargetStringBuilder = new();

            consumableBuilderTargetStringBuilder.Append(value: $"[START]{nameof(ConsumableBuilderTarget<TemplateComponent1>)}[START]");
            consumableBuilderTargetStringBuilder.AppendLine(value: string.Empty);
            consumableBuilderTargetStringBuilder.Append(value: $"Method not implemented in '{nameof(ConsumableBuilderTarget<TemplateComponent1>)}' class");
            consumableBuilderTargetStringBuilder.AppendLine(value: string.Empty);
            consumableBuilderTargetStringBuilder.Append(value: $"[END]{nameof(ConsumableBuilderTarget<TemplateComponent1>)}[END]");

            throw new NotImplementedException(message: consumableBuilderTargetStringBuilder.ToString(), inner: new Exception());
        }

        public override int GetHashCode()
        {
            StringBuilder consumableBuilderTargetStringBuilder = new();

            consumableBuilderTargetStringBuilder.Append(value: $"[START]{nameof(ConsumableBuilderTarget<TemplateComponent1>)}[START]");
            consumableBuilderTargetStringBuilder.AppendLine(value: string.Empty);
            consumableBuilderTargetStringBuilder.Append(value: $"Method not implemented in '{nameof(ConsumableBuilderTarget<TemplateComponent1>)}' class");
            consumableBuilderTargetStringBuilder.AppendLine(value: string.Empty);
            consumableBuilderTargetStringBuilder.Append(value: $"[END]{nameof(ConsumableBuilderTarget<TemplateComponent1>)}[END]");

            throw new NotImplementedException(message: consumableBuilderTargetStringBuilder.ToString(), inner: new Exception());
        }

        public override string ToString()
        {
            StringBuilder consumableBuilderTargetStringBuilder = new();

            consumableBuilderTargetStringBuilder.Append(value: $"[START]{nameof(ConsumableBuilderTarget<TemplateComponent1>)}[START]");
            consumableBuilderTargetStringBuilder.AppendLine(value: string.Empty);
            consumableBuilderTargetStringBuilder.Append(value: $"Method not implemented in '{nameof(ConsumableBuilderTarget<TemplateComponent1>)}' class");
            consumableBuilderTargetStringBuilder.AppendLine(value: string.Empty);
            consumableBuilderTargetStringBuilder.Append(value: $"[END]{nameof(ConsumableBuilderTarget<TemplateComponent1>)}[END]");

            throw new NotImplementedException(message: consumableBuilderTargetStringBuilder.ToString(), inner: new Exception());
        }
    }
}