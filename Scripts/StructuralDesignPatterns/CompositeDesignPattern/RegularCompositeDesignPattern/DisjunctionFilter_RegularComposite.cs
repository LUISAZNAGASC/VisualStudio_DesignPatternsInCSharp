namespace VisualStudio_DesignPatternsInCSharp.Scripts.StructuralDesignPatterns.CompositeDesignPattern.RegularCompositeDesignPattern
{
    using System;
    using System.Text;

    public sealed class DisjunctionFilter<Template1> : FilterComponent<Template1> where Template1 : class
    {
        private FilterComponent<Template1> DisjunctionFilterLeft { get; }

        private FilterComponent<Template1> DisjunctionFilterRight { get; }

        private DisjunctionFilter() : base()
        {

        }

        public DisjunctionFilter(in FilterComponent<Template1> disjunctionFilterLeft, in FilterComponent<Template1> disjunctionFilterRight)
        {
            DisjunctionFilterLeft = disjunctionFilterLeft;

            DisjunctionFilterRight = disjunctionFilterRight;
        }

        public override bool CheckFilterComponentField(in Template1 disjunctionFilterInput)
        {
            if (DisjunctionFilterLeft is null || DisjunctionFilterRight is null)
            {
                StringBuilder disjunctionFilterStringBuilder = new();

                disjunctionFilterStringBuilder.Append(value: $"[START]{nameof(DisjunctionFilter<Template1>)}[START]");
                disjunctionFilterStringBuilder.AppendLine(value: string.Empty);
                disjunctionFilterStringBuilder.Append(value: $"There was an issue in '{nameof(DisjunctionFilter<Template1>)}' class");
                disjunctionFilterStringBuilder.AppendLine(value: string.Empty);
                disjunctionFilterStringBuilder.Append(value: $"[END]{nameof(DisjunctionFilter<Template1>)}[END]");

                throw new InvalidOperationException(message: disjunctionFilterStringBuilder.ToString(), innerException: new Exception());
            }

            if (disjunctionFilterInput is null)
            {
                StringBuilder disjunctionFilterStringBuilder = new();

                disjunctionFilterStringBuilder.Append(value: $"[START]{nameof(DisjunctionFilter<Template1>)}[START]");
                disjunctionFilterStringBuilder.AppendLine(value: string.Empty);
                disjunctionFilterStringBuilder.Append(value: $"There was an issue in '{nameof(DisjunctionFilter<Template1>)}' class");
                disjunctionFilterStringBuilder.AppendLine(value: string.Empty);
                disjunctionFilterStringBuilder.Append(value: $"[END]{nameof(DisjunctionFilter<Template1>)}[END]");

                throw new InvalidOperationException(message: disjunctionFilterStringBuilder.ToString(), innerException: new Exception());
            }

            if (DisjunctionFilterLeft.CheckFilterComponentField(filterComponentInput: disjunctionFilterInput))
            {
                return true;
            }

            if (DisjunctionFilterRight.CheckFilterComponentField(filterComponentInput: disjunctionFilterInput))
            {
                return true;
            }

            return false;
        }

        public override bool Equals(object uncastedDisjunctionFilter)
        {
            StringBuilder disjunctionFilterStringBuilder = new();

            disjunctionFilterStringBuilder.Append(value: $"[START]{nameof(DisjunctionFilter<Template1>)}[START]");
            disjunctionFilterStringBuilder.AppendLine(value: string.Empty);
            disjunctionFilterStringBuilder.Append(value: $"Method not implemented in '{nameof(DisjunctionFilter<Template1>)}' class");
            disjunctionFilterStringBuilder.AppendLine(value: string.Empty);
            disjunctionFilterStringBuilder.Append(value: $"[END]{nameof(DisjunctionFilter<Template1>)}[END]");

            throw new NotImplementedException(message: disjunctionFilterStringBuilder.ToString(), inner: new Exception());
        }

        public override int GetHashCode()
        {
            StringBuilder disjunctionFilterStringBuilder = new();

            disjunctionFilterStringBuilder.Append(value: $"[START]{nameof(DisjunctionFilter<Template1>)}[START]");
            disjunctionFilterStringBuilder.AppendLine(value: string.Empty);
            disjunctionFilterStringBuilder.Append(value: $"Method not implemented in '{nameof(DisjunctionFilter<Template1>)}' class");
            disjunctionFilterStringBuilder.AppendLine(value: string.Empty);
            disjunctionFilterStringBuilder.Append(value: $"[END]{nameof(DisjunctionFilter<Template1>)}[END]");

            throw new NotImplementedException(message: disjunctionFilterStringBuilder.ToString(), inner: new Exception());
        }

        public override string ToString()
        {
            StringBuilder disjunctionFilterStringBuilder = new();

            disjunctionFilterStringBuilder.Append(value: $"[START]{nameof(DisjunctionFilter<Template1>)}[START]");
            disjunctionFilterStringBuilder.AppendLine(value: string.Empty);
            disjunctionFilterStringBuilder.Append(value: $"Method not implemented in '{nameof(DisjunctionFilter<Template1>)}' class");
            disjunctionFilterStringBuilder.AppendLine(value: string.Empty);
            disjunctionFilterStringBuilder.Append(value: $"[END]{nameof(DisjunctionFilter<Template1>)}[END]");

            throw new NotImplementedException(message: disjunctionFilterStringBuilder.ToString(), inner: new Exception());
        }
    }
}