namespace VisualStudio_DesignPatternsInCSharp.Scripts.StructuralDesignPatterns.CompositeDesignPattern.RegularCompositeDesignPattern
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public sealed class CompositeSpecification<Template1>(
        IEnumerable<SpecificationComponent<Template1>> compositeSpecificationFieldCollection) : SpecificationComponent<Template1>()
        where Template1 : class
    {
        public override bool CheckSpecificationComponentField(in Template1 compositeSpecificationInput)
        {
            if (compositeSpecificationFieldCollection is null)
            {
                return false;
            }

            foreach (SpecificationComponent<Template1> compositeSpecificationFieldElement in compositeSpecificationFieldCollection)
            {
                if (compositeSpecificationFieldElement is null)
                {
                    return false;
                }

                if (!compositeSpecificationFieldElement.CheckSpecificationComponentField(specificationComponentInput: compositeSpecificationInput))
                {
                    return false;
                }
            }

            return true;
        }

        public override bool Equals(object uncastedCompositeSpecification)
        {
            StringBuilder compositeSpecificationStringBuilder = new();

            compositeSpecificationStringBuilder.Append(value: $"[START]{nameof(CompositeSpecification<Template1>)}[START]");
            compositeSpecificationStringBuilder.AppendLine(value: string.Empty);
            compositeSpecificationStringBuilder.Append(value: $"Method not implemented in '{nameof(CompositeSpecification<Template1>)}' class");
            compositeSpecificationStringBuilder.AppendLine(value: string.Empty);
            compositeSpecificationStringBuilder.Append(value: $"[END]{nameof(CompositeSpecification<Template1>)}[END]");

            throw new NotImplementedException(message: compositeSpecificationStringBuilder.ToString(), inner: new Exception());
        }

        public override int GetHashCode()
        {
            StringBuilder compositeSpecificationStringBuilder = new();

            compositeSpecificationStringBuilder.Append(value: $"[START]{nameof(CompositeSpecification<Template1>)}[START]");
            compositeSpecificationStringBuilder.AppendLine(value: string.Empty);
            compositeSpecificationStringBuilder.Append(value: $"Method not implemented in '{nameof(CompositeSpecification<Template1>)}' class");
            compositeSpecificationStringBuilder.AppendLine(value: string.Empty);
            compositeSpecificationStringBuilder.Append(value: $"[END]{nameof(CompositeSpecification<Template1>)}[END]");

            throw new NotImplementedException(message: compositeSpecificationStringBuilder.ToString(), inner: new Exception());
        }

        public override string ToString()
        {
            StringBuilder compositeSpecificationStringBuilder = new();

            compositeSpecificationStringBuilder.Append(value: $"[START]{nameof(CompositeSpecification<Template1>)}[START]");
            compositeSpecificationStringBuilder.AppendLine(value: string.Empty);
            compositeSpecificationStringBuilder.Append(value: $"Method not implemented in '{nameof(CompositeSpecification<Template1>)}' class");
            compositeSpecificationStringBuilder.AppendLine(value: string.Empty);
            compositeSpecificationStringBuilder.Append(value: $"[END]{nameof(CompositeSpecification<Template1>)}[END]");

            throw new NotImplementedException(message: compositeSpecificationStringBuilder.ToString(), inner: new Exception());
        }
    }
}