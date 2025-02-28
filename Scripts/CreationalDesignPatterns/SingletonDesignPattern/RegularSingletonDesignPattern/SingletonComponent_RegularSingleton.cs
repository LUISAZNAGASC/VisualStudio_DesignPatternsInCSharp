namespace VisualStudio_DesignPatternsInCSharp.Scripts.CreationalDesignPatterns.SingletonDesignPattern.RegularSingletonDesignPattern
{
    using System;
    using System.Text;

    public abstract class SingletonComponent<TemplateComponent1>
        where TemplateComponent1 : SingletonComponent<TemplateComponent1>, new()
    {
        private static TemplateComponent1 SingletonComponentReference { get; set; }

        protected SingletonComponent() : base()
        {
            SingletonComponentReference = new TemplateComponent1();
        }

        public static TemplateComponent1 GetSingletonComponentReference()
        {
            SingletonComponentReference ??= new TemplateComponent1();

            return SingletonComponentReference;
        }

        public override bool Equals(object uncastedSingletonComponent)
        {
            StringBuilder singletonComponentStringBuilder = new();

            singletonComponentStringBuilder.Append(value: $"[START]{nameof(SingletonComponent<TemplateComponent1>)}[START]");
            singletonComponentStringBuilder.AppendLine(value: string.Empty);
            singletonComponentStringBuilder.Append(value: $"Method not implemented in '{nameof(SingletonComponent<TemplateComponent1>)}' class");
            singletonComponentStringBuilder.AppendLine(value: string.Empty);
            singletonComponentStringBuilder.Append(value: $"[END]{nameof(SingletonComponent<TemplateComponent1>)}[END]");

            throw new NotImplementedException(message: singletonComponentStringBuilder.ToString(), inner: new Exception());
        }

        public override int GetHashCode()
        {
            StringBuilder singletonComponentStringBuilder = new();

            singletonComponentStringBuilder.Append(value: $"[START]{nameof(SingletonComponent<TemplateComponent1>)}[START]");
            singletonComponentStringBuilder.AppendLine(value: string.Empty);
            singletonComponentStringBuilder.Append(value: $"Method not implemented in '{nameof(SingletonComponent<TemplateComponent1>)}' class");
            singletonComponentStringBuilder.AppendLine(value: string.Empty);
            singletonComponentStringBuilder.Append(value: $"[END]{nameof(SingletonComponent<TemplateComponent1>)}[END]");

            throw new NotImplementedException(message: singletonComponentStringBuilder.ToString(), inner: new Exception());
        }

        public override string ToString()
        {
            StringBuilder singletonComponentStringBuilder = new();

            singletonComponentStringBuilder.Append(value: $"[START]{nameof(SingletonComponent<TemplateComponent1>)}[START]");
            singletonComponentStringBuilder.AppendLine(value: string.Empty);
            singletonComponentStringBuilder.Append(value: $"Method not implemented in '{nameof(SingletonComponent<TemplateComponent1>)}' class");
            singletonComponentStringBuilder.AppendLine(value: string.Empty);
            singletonComponentStringBuilder.Append(value: $"[END]{nameof(SingletonComponent<TemplateComponent1>)}[END]");

            throw new NotImplementedException(message: singletonComponentStringBuilder.ToString(), inner: new Exception());
        }
    }
}