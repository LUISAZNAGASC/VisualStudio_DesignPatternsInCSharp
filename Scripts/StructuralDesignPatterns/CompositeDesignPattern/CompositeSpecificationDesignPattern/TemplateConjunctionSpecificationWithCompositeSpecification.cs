namespace VisualStudio_DesignPatternsInCSharp.StructuralDesignPatterns.CompositeDesignPattern.CompositeSpecificationDesignPattern
{
    public class TemplateConjunctionSpecificationWithCompositeSpecification<TTemplateComponentWithCompositeSpecification>(params TemplateSpecificationWithCompositeSpecification<TTemplateComponentWithCompositeSpecification>[] newTemplateConjunctionSpecificationTemplateSpecificationCollectionToInitialize) : TemplateCompositeSpecificationWithCompositeSpecification<TTemplateComponentWithCompositeSpecification>(newTemplateCompositeSpecificationTemplateSpecificationCollectionToInitialize: newTemplateConjunctionSpecificationTemplateSpecificationCollectionToInitialize)
    {
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