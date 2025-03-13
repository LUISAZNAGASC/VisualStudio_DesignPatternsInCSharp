namespace VisualStudio_DesignPatternsInCSharp.Scripts.StructuralDesignPatterns.CompositeDesignPattern.RegularCompositeDesignPattern
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public sealed class CompositeFilter<Template1> : FilterComponent<Template1> where Template1 : class
    {
        private IEnumerable<FilterComponent<Template1>> CompositeFilterFieldCollection { get; }

        private CompositeFilter() : base()
        {

        }

        public CompositeFilter(in IEnumerable<FilterComponent<Template1>> compositeFilterFieldCollection) : base()
        {
            CompositeFilterFieldCollection = compositeFilterFieldCollection;
        }

        public override bool CheckFilterComponentField(in Template1 compositeFilterInput)
        {
            if (CompositeFilterFieldCollection is null)
            {
                StringBuilder compositeFilterStringBuilder = new();

                compositeFilterStringBuilder.Append(value: $"[START]{nameof(CompositeFilter<Template1>)}[START]");
                compositeFilterStringBuilder.AppendLine(value: string.Empty);
                compositeFilterStringBuilder.Append(value: $"There was an issue in '{nameof(CompositeFilter<Template1>)}' class");
                compositeFilterStringBuilder.AppendLine(value: string.Empty);
                compositeFilterStringBuilder.Append(value: $"[END]{nameof(CompositeFilter<Template1>)}[END]");

                throw new InvalidOperationException(message: compositeFilterStringBuilder.ToString(), innerException: new Exception());
            }

            if (compositeFilterInput is null)
            {
                StringBuilder compositeFilterStringBuilder = new();

                compositeFilterStringBuilder.Append(value: $"[START]{nameof(CompositeFilter<Template1>)}[START]");
                compositeFilterStringBuilder.AppendLine(value: string.Empty);
                compositeFilterStringBuilder.Append(value: $"There was an issue in '{nameof(CompositeFilter<Template1>)}' class");
                compositeFilterStringBuilder.AppendLine(value: string.Empty);
                compositeFilterStringBuilder.Append(value: $"[END]{nameof(CompositeFilter<Template1>)}[END]");

                throw new InvalidOperationException(message: compositeFilterStringBuilder.ToString(), innerException: new Exception());
            }

            foreach (FilterComponent<Template1> compositeFilterFieldElement in CompositeFilterFieldCollection)
            {
                if (compositeFilterFieldElement is null)
                {
                    StringBuilder compositeFilterStringBuilder = new();

                    compositeFilterStringBuilder.Append(value: $"[START]{nameof(CompositeFilter<Template1>)}[START]");
                    compositeFilterStringBuilder.AppendLine(value: string.Empty);
                    compositeFilterStringBuilder.Append(value: $"There was an issue in '{nameof(CompositeFilter<Template1>)}' class");
                    compositeFilterStringBuilder.AppendLine(value: string.Empty);
                    compositeFilterStringBuilder.Append(value: $"[END]{nameof(CompositeFilter<Template1>)}[END]");

                    throw new InvalidOperationException(message: compositeFilterStringBuilder.ToString(), innerException: new Exception());
                }

                if (!compositeFilterFieldElement.CheckFilterComponentField(filterComponentInput: compositeFilterInput))
                {
                    return false;
                }
            }

            return true;
        }

        public override bool Equals(object uncastedCompositeFilter)
        {
            StringBuilder compositeFilterStringBuilder = new();

            compositeFilterStringBuilder.Append(value: $"[START]{nameof(CompositeFilter<Template1>)}[START]");
            compositeFilterStringBuilder.AppendLine(value: string.Empty);
            compositeFilterStringBuilder.Append(value: $"Method not implemented in '{nameof(CompositeFilter<Template1>)}' class");
            compositeFilterStringBuilder.AppendLine(value: string.Empty);
            compositeFilterStringBuilder.Append(value: $"[END]{nameof(CompositeFilter<Template1>)}[END]");

            throw new NotImplementedException(message: compositeFilterStringBuilder.ToString(), inner: new Exception());
        }

        public override int GetHashCode()
        {
            StringBuilder compositeFilterStringBuilder = new();

            compositeFilterStringBuilder.Append(value: $"[START]{nameof(CompositeFilter<Template1>)}[START]");
            compositeFilterStringBuilder.AppendLine(value: string.Empty);
            compositeFilterStringBuilder.Append(value: $"Method not implemented in '{nameof(CompositeFilter<Template1>)}' class");
            compositeFilterStringBuilder.AppendLine(value: string.Empty);
            compositeFilterStringBuilder.Append(value: $"[END]{nameof(CompositeFilter<Template1>)}[END]");

            throw new NotImplementedException(message: compositeFilterStringBuilder.ToString(), inner: new Exception());
        }

        public override string ToString()
        {
            StringBuilder compositeFilterStringBuilder = new();

            compositeFilterStringBuilder.Append(value: $"[START]{nameof(CompositeFilter<Template1>)}[START]");
            compositeFilterStringBuilder.AppendLine(value: string.Empty);
            compositeFilterStringBuilder.Append(value: $"Method not implemented in '{nameof(CompositeFilter<Template1>)}' class");
            compositeFilterStringBuilder.AppendLine(value: string.Empty);
            compositeFilterStringBuilder.Append(value: $"[END]{nameof(CompositeFilter<Template1>)}[END]");

            throw new NotImplementedException(message: compositeFilterStringBuilder.ToString(), inner: new Exception());
        }
    }
}