namespace VisualStudio_DesignPatternsInCSharp.Scripts.StructuralDesignPatterns.CompositeDesignPattern.CompositeSpecificationDesignPattern
{
    public class TemplateConjunctionSpecificationWithCompositeSpecification<TTemplateComponentWithCompositeSpecification>(params TemplateSpecificationWithCompositeSpecification<TTemplateComponentWithCompositeSpecification>[] otherTemplateConjunctionSpecificationTemplateSpecificationCollectionToHandle) : TemplateCompositeSpecificationWithCompositeSpecification<TTemplateComponentWithCompositeSpecification>(otherTemplateCompositeSpecificationTemplateSpecificationCollectionToHandle: otherTemplateConjunctionSpecificationTemplateSpecificationCollectionToHandle) where TTemplateComponentWithCompositeSpecification : class
    {
        public override bool CheckTemplateSpecificationIsValidUsing(in TTemplateComponentWithCompositeSpecification otherTemplateConjunctionSpecificationTemplateComponentToHandle)
        {
            foreach (TemplateSpecificationWithCompositeSpecification<TTemplateComponentWithCompositeSpecification> templateConjunctionSpecificationTemplateSpecificationElement in TemplateCompositeSpecificationTemplateSpecificationCollection)
            {
                if (templateConjunctionSpecificationTemplateSpecificationElement.CheckTemplateSpecificationIsValidUsing(otherTemplateSpecificationTemplateComponentToHandle: otherTemplateConjunctionSpecificationTemplateComponentToHandle) == false)
                {
                    return false;
                }
            }

            return true;
        }
    }
}