namespace VisualStudio_DesignPatternsInCSharp.Scripts.StructuralDesignPatterns.CompositeDesignPattern.RegularCompositeDesignPattern
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public abstract class SpecificationComponent<Template1>
        where Template1 : class
    {
        protected SpecificationComponent() : base()
        {

        }

        public abstract bool CheckSpecificationComponentField(in Template1 specificationComponentInput);

        public IEnumerable<Template1> GetSpecificationComponentOutputCollection(IEnumerable<Template1> specificationComponentInputCollection)
        {
            if (specificationComponentInputCollection is null)
            {
                yield break;
            }

            foreach (Template1 specificationComponentInputElement in specificationComponentInputCollection)
            {
                if (specificationComponentInputElement is null)
                {
                    yield break;
                }

                if (CheckSpecificationComponentField(specificationComponentInput: specificationComponentInputElement))
                {
                    yield return specificationComponentInputElement;
                }
            }
        }

        public override bool Equals(object uncastedSpecificationComponent)
        {
            StringBuilder specificationComponentStringBuilder = new();

            specificationComponentStringBuilder.Append(value: $"[START]{nameof(SpecificationComponent<Template1>)}[START]");
            specificationComponentStringBuilder.AppendLine(value: string.Empty);
            specificationComponentStringBuilder.Append(value: $"Method not implemented in '{nameof(SpecificationComponent<Template1>)}' class");
            specificationComponentStringBuilder.AppendLine(value: string.Empty);
            specificationComponentStringBuilder.Append(value: $"[END]{nameof(SpecificationComponent<Template1>)}[END]");

            throw new NotImplementedException(message: specificationComponentStringBuilder.ToString(), inner: new Exception());
        }

        public override int GetHashCode()
        {
            StringBuilder specificationComponentStringBuilder = new();

            specificationComponentStringBuilder.Append(value: $"[START]{nameof(SpecificationComponent<Template1>)}[START]");
            specificationComponentStringBuilder.AppendLine(value: string.Empty);
            specificationComponentStringBuilder.Append(value: $"Method not implemented in '{nameof(SpecificationComponent<Template1>)}' class");
            specificationComponentStringBuilder.AppendLine(value: string.Empty);
            specificationComponentStringBuilder.Append(value: $"[END]{nameof(SpecificationComponent<Template1>)}[END]");

            throw new NotImplementedException(message: specificationComponentStringBuilder.ToString(), inner: new Exception());
        }

        public override string ToString()
        {
            StringBuilder specificationComponentStringBuilder = new();

            specificationComponentStringBuilder.Append(value: $"[START]{nameof(SpecificationComponent<Template1>)}[START]");
            specificationComponentStringBuilder.AppendLine(value: string.Empty);
            specificationComponentStringBuilder.Append(value: $"Method not implemented in '{nameof(SpecificationComponent<Template1>)}' class");
            specificationComponentStringBuilder.AppendLine(value: string.Empty);
            specificationComponentStringBuilder.Append(value: $"[END]{nameof(SpecificationComponent<Template1>)}[END]");

            throw new NotImplementedException(message: specificationComponentStringBuilder.ToString(), inner: new Exception());
        }
    }
}