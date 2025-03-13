namespace VisualStudio_DesignPatternsInCSharp.Scripts.StructuralDesignPatterns.CompositeDesignPattern.RegularCompositeDesignPattern
{
    using System;
    using System.Text;

    public sealed class ConjunctionFilter<Template1> : FilterComponent<Template1> where Template1 : class
    {
        private FilterComponent<Template1> ConjunctionFilterLeft { get; }

        private FilterComponent<Template1> ConjunctionFilterRight { get; }

        private ConjunctionFilter() : base()
        {

        }

        public ConjunctionFilter(in FilterComponent<Template1> conjunctionFilterLeft, in FilterComponent<Template1> conjunctionFilterRight) : base()
        {
            ConjunctionFilterLeft = conjunctionFilterLeft;

            ConjunctionFilterRight = conjunctionFilterRight;
        }

        public override bool CheckFilterComponentField(in Template1 conjunctionFilterInput)
        {
            if (ConjunctionFilterLeft is null || ConjunctionFilterRight is null)
            {
                StringBuilder conjunctionFilterStringBuilder = new();

                conjunctionFilterStringBuilder.Append(value: $"[START]{nameof(ConjunctionFilter<Template1>)}[START]");
                conjunctionFilterStringBuilder.AppendLine(value: string.Empty);
                conjunctionFilterStringBuilder.Append(value: $"There was an issue in '{nameof(ConjunctionFilter<Template1>)}' class");
                conjunctionFilterStringBuilder.AppendLine(value: string.Empty);
                conjunctionFilterStringBuilder.Append(value: $"[END]{nameof(ConjunctionFilter<Template1>)}[END]");

                throw new InvalidOperationException(message: conjunctionFilterStringBuilder.ToString(), innerException: new Exception());
            }

            if (conjunctionFilterInput is null)
            {
                StringBuilder conjunctionFilterStringBuilder = new();

                conjunctionFilterStringBuilder.Append(value: $"[START]{nameof(ConjunctionFilter<Template1>)}[START]");
                conjunctionFilterStringBuilder.AppendLine(value: string.Empty);
                conjunctionFilterStringBuilder.Append(value: $"There was an issue in '{nameof(ConjunctionFilter<Template1>)}' class");
                conjunctionFilterStringBuilder.AppendLine(value: string.Empty);
                conjunctionFilterStringBuilder.Append(value: $"[END]{nameof(ConjunctionFilter<Template1>)}[END]");

                throw new InvalidOperationException(message: conjunctionFilterStringBuilder.ToString(), innerException: new Exception());
            }

            if (!ConjunctionFilterLeft.CheckFilterComponentField(filterComponentInput: conjunctionFilterInput))
            {
                return false;
            }

            if (!ConjunctionFilterRight.CheckFilterComponentField(filterComponentInput: conjunctionFilterInput))
            {
                return false;
            }

            return true;
        }

        public override bool Equals(object uncastedConjunctionFilter)
        {
            StringBuilder conjunctionFilterStringBuilder = new();

            conjunctionFilterStringBuilder.Append(value: $"[START]{nameof(ConjunctionFilter<Template1>)}[START]");
            conjunctionFilterStringBuilder.AppendLine(value: string.Empty);
            conjunctionFilterStringBuilder.Append(value: $"Method not implemented in '{nameof(ConjunctionFilter<Template1>)}' class");
            conjunctionFilterStringBuilder.AppendLine(value: string.Empty);
            conjunctionFilterStringBuilder.Append(value: $"[END]{nameof(ConjunctionFilter<Template1>)}[END]");

            throw new NotImplementedException(message: conjunctionFilterStringBuilder.ToString(), inner: new Exception());
        }

        public override int GetHashCode()
        {
            StringBuilder conjunctionFilterStringBuilder = new();

            conjunctionFilterStringBuilder.Append(value: $"[START]{nameof(ConjunctionFilter<Template1>)}[START]");
            conjunctionFilterStringBuilder.AppendLine(value: string.Empty);
            conjunctionFilterStringBuilder.Append(value: $"Method not implemented in '{nameof(ConjunctionFilter<Template1>)}' class");
            conjunctionFilterStringBuilder.AppendLine(value: string.Empty);
            conjunctionFilterStringBuilder.Append(value: $"[END]{nameof(ConjunctionFilter<Template1>)}[END]");

            throw new NotImplementedException(message: conjunctionFilterStringBuilder.ToString(), inner: new Exception());
        }

        public override string ToString()
        {
            StringBuilder conjunctionFilterStringBuilder = new();

            conjunctionFilterStringBuilder.Append(value: $"[START]{nameof(ConjunctionFilter<Template1>)}[START]");
            conjunctionFilterStringBuilder.AppendLine(value: string.Empty);
            conjunctionFilterStringBuilder.Append(value: $"Method not implemented in '{nameof(ConjunctionFilter<Template1>)}' class");
            conjunctionFilterStringBuilder.AppendLine(value: string.Empty);
            conjunctionFilterStringBuilder.Append(value: $"[END]{nameof(ConjunctionFilter<Template1>)}[END]");

            throw new NotImplementedException(message: conjunctionFilterStringBuilder.ToString(), inner: new Exception());
        }
    }
}