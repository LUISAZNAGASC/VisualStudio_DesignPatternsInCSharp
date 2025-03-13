namespace VisualStudio_DesignPatternsInCSharp.Scripts.StructuralDesignPatterns.CompositeDesignPattern.RegularCompositeDesignPattern
{
    using System;
    using System.Text;

    public sealed class NegationFilter<Template1> : FilterComponent<Template1> where Template1 : class
    {
        private FilterComponent<Template1> NegationFilterUnary { get; }

        private NegationFilter() : base()
        {

        }

        public NegationFilter(in FilterComponent<Template1> negationFilterUnary) : base()
        {
            NegationFilterUnary = negationFilterUnary;
        }

        public override bool CheckFilterComponentField(in Template1 negationFilterInput)
        {
            if (NegationFilterUnary is null)
            {
                StringBuilder negationFilterStringBuilder = new();

                negationFilterStringBuilder.Append(value: $"[START]{nameof(NegationFilter<Template1>)}[START]");
                negationFilterStringBuilder.AppendLine(value: string.Empty);
                negationFilterStringBuilder.Append(value: $"There was an issue in '{nameof(NegationFilter<Template1>)}' class");
                negationFilterStringBuilder.AppendLine(value: string.Empty);
                negationFilterStringBuilder.Append(value: $"[END]{nameof(NegationFilter<Template1>)}[END]");

                throw new InvalidOperationException(message: negationFilterStringBuilder.ToString(), innerException: new Exception());
            }

            if (negationFilterInput is null)
            {
                StringBuilder negationFilterStringBuilder = new();

                negationFilterStringBuilder.Append(value: $"[START]{nameof(NegationFilter<Template1>)}[START]");
                negationFilterStringBuilder.AppendLine(value: string.Empty);
                negationFilterStringBuilder.Append(value: $"There was an issue in '{nameof(NegationFilter<Template1>)}' class");
                negationFilterStringBuilder.AppendLine(value: string.Empty);
                negationFilterStringBuilder.Append(value: $"[END]{nameof(NegationFilter<Template1>)}[END]");

                throw new InvalidOperationException(message: negationFilterStringBuilder.ToString(), innerException: new Exception());
            }

            return !NegationFilterUnary.CheckFilterComponentField(filterComponentInput: negationFilterInput);
        }

        public override bool Equals(object uncastedNegationFilter)
        {
            StringBuilder negationFilterStringBuilder = new();

            negationFilterStringBuilder.Append(value: $"[START]{nameof(NegationFilter<Template1>)}[START]");
            negationFilterStringBuilder.AppendLine(value: string.Empty);
            negationFilterStringBuilder.Append(value: $"Method not implemented in '{nameof(NegationFilter<Template1>)}' class");
            negationFilterStringBuilder.AppendLine(value: string.Empty);
            negationFilterStringBuilder.Append(value: $"[END]{nameof(NegationFilter<Template1>)}[END]");

            throw new NotImplementedException(message: negationFilterStringBuilder.ToString(), inner: new Exception());
        }

        public override int GetHashCode()
        {
            StringBuilder negationFilterStringBuilder = new();

            negationFilterStringBuilder.Append(value: $"[START]{nameof(NegationFilter<Template1>)}[START]");
            negationFilterStringBuilder.AppendLine(value: string.Empty);
            negationFilterStringBuilder.Append(value: $"Method not implemented in '{nameof(NegationFilter<Template1>)}' class");
            negationFilterStringBuilder.AppendLine(value: string.Empty);
            negationFilterStringBuilder.Append(value: $"[END]{nameof(NegationFilter<Template1>)}[END]");

            throw new NotImplementedException(message: negationFilterStringBuilder.ToString(), inner: new Exception());
        }

        public override string ToString()
        {
            StringBuilder negationFilterStringBuilder = new();

            negationFilterStringBuilder.Append(value: $"[START]{nameof(NegationFilter<Template1>)}[START]");
            negationFilterStringBuilder.AppendLine(value: string.Empty);
            negationFilterStringBuilder.Append(value: $"Method not implemented in '{nameof(NegationFilter<Template1>)}' class");
            negationFilterStringBuilder.AppendLine(value: string.Empty);
            negationFilterStringBuilder.Append(value: $"[END]{nameof(NegationFilter<Template1>)}[END]");

            throw new NotImplementedException(message: negationFilterStringBuilder.ToString(), inner: new Exception());
        }
    }
}