namespace VisualStudio_DesignPatternsInCSharp.StructuralDesignPatterns.CompositeDesignPattern.CompositeSpecificationDesignPattern
{
    public class TemplateConjunctionSpecificationWithCompositeSpecification<TTemplateComponentWithCompositeSpecification> : TemplateCompositeSpecificationWithCompositeSpecification<TTemplateComponentWithCompositeSpecification>
    {
        public TemplateConjunctionSpecificationWithCompositeSpecification(params TemplateSpecificationWithCompositeSpecification<TTemplateComponentWithCompositeSpecification>[] newTemplateConjunctionSpecificationTemplateSpecificationCollectionToInitialize) : base(newTemplateCompositeSpecificationTemplateSpecificationCollectionToInitialize: newTemplateConjunctionSpecificationTemplateSpecificationCollectionToInitialize)
        {
            TemplateCompositeSpecificationTemplateSpecificationCollection = newTemplateConjunctionSpecificationTemplateSpecificationCollectionToInitialize;
        }

        public override bool CheckTemplateSpecificationIsValidUsing(in TTemplateComponentWithCompositeSpecification specificTemplateConjunctionSpecificationTemplateComponentToCheck)
        {
            foreach (TemplateSpecificationWithCompositeSpecification<TTemplateComponentWithCompositeSpecification> templateConjunctionSpecificationTemplateSpecificationElement in TemplateCompositeSpecificationTemplateSpecificationCollection)
            {
                if (templateConjunctionSpecificationTemplateSpecificationElement.CheckTemplateSpecificationIsValidUsing(specificTemplateSpecificationTemplateComponentToCheck: specificTemplateConjunctionSpecificationTemplateComponentToCheck) == false)
                {
                    return false;
                }
            }

            return true;
        }
    }
}