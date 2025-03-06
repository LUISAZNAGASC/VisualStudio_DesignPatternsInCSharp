namespace VisualStudio_DesignPatternsInCSharp.Scripts.CreationalDesignPatterns.SingletonDesignPattern.RegularSingletonDesignPattern
{
    using System;
    using System.Text;
    using System.Threading;

    public abstract class SingletonComponent<Template1>
        where Template1 : SingletonComponent<Template1>, new()
    {
        private static Lazy<Template1> SingletonComponentInstance { get; set; }

        protected SingletonComponent() : base()
        {
            SingletonComponentInstance = new Lazy<Template1>(valueFactory: () =>
            {
                return new Template1();
            }, mode: LazyThreadSafetyMode.ExecutionAndPublication);
        }

        public static Template1 GetSingletonComponentInstance()
        {
            SingletonComponentInstance ??= new Lazy<Template1>(valueFactory: () =>
            {
                return new Template1();
            }, mode: LazyThreadSafetyMode.ExecutionAndPublication);

            return SingletonComponentInstance.Value;
        }

        public override bool Equals(object uncastedSingletonComponent)
        {
            StringBuilder singletonComponentStringBuilder = new();

            singletonComponentStringBuilder.Append(value: $"[START]{nameof(SingletonComponent<Template1>)}[START]");
            singletonComponentStringBuilder.AppendLine(value: string.Empty);
            singletonComponentStringBuilder.Append(value: $"Method not implemented in '{nameof(SingletonComponent<Template1>)}' class");
            singletonComponentStringBuilder.AppendLine(value: string.Empty);
            singletonComponentStringBuilder.Append(value: $"[END]{nameof(SingletonComponent<Template1>)}[END]");

            throw new NotImplementedException(message: singletonComponentStringBuilder.ToString(), inner: new Exception());
        }

        public override int GetHashCode()
        {
            StringBuilder singletonComponentStringBuilder = new();

            singletonComponentStringBuilder.Append(value: $"[START]{nameof(SingletonComponent<Template1>)}[START]");
            singletonComponentStringBuilder.AppendLine(value: string.Empty);
            singletonComponentStringBuilder.Append(value: $"Method not implemented in '{nameof(SingletonComponent<Template1>)}' class");
            singletonComponentStringBuilder.AppendLine(value: string.Empty);
            singletonComponentStringBuilder.Append(value: $"[END]{nameof(SingletonComponent<Template1>)}[END]");

            throw new NotImplementedException(message: singletonComponentStringBuilder.ToString(), inner: new Exception());
        }

        public override string ToString()
        {
            StringBuilder singletonComponentStringBuilder = new();

            singletonComponentStringBuilder.Append(value: $"[START]{nameof(SingletonComponent<Template1>)}[START]");
            singletonComponentStringBuilder.AppendLine(value: string.Empty);
            singletonComponentStringBuilder.Append(value: $"Method not implemented in '{nameof(SingletonComponent<Template1>)}' class");
            singletonComponentStringBuilder.AppendLine(value: string.Empty);
            singletonComponentStringBuilder.Append(value: $"[END]{nameof(SingletonComponent<Template1>)}[END]");

            throw new NotImplementedException(message: singletonComponentStringBuilder.ToString(), inner: new Exception());
        }
    }
}