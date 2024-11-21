namespace VisualStudio_DesignPatternsInCSharp.StructuralDesignPatterns.CompositeDesignPattern.CompositeSpecificationDesignPattern
{
    public abstract class TemplateSpecificationWithCompositeSpecification<TTemplateComponentWithCompositeSpecification>
    {
        public TemplateSpecificationWithCompositeSpecification() : base()
        {

        }

        public abstract bool CheckTemplateSpecificationIsValidUsing(in TTemplateComponentWithCompositeSpecification specificTemplateSpecificationTemplateComponentToCheck);
    }
}