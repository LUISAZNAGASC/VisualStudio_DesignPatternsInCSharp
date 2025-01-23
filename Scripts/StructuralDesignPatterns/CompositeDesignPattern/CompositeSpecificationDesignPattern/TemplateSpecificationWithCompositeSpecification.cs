namespace VisualStudio_DesignPatternsInCSharp.Scripts.StructuralDesignPatterns.CompositeDesignPattern.CompositeSpecificationDesignPattern
{
    public abstract class TemplateSpecificationWithCompositeSpecification<TTemplateComponentWithCompositeSpecification> where TTemplateComponentWithCompositeSpecification : class
    {
        public TemplateSpecificationWithCompositeSpecification() : base()
        {

        }

        public abstract bool CheckTemplateSpecificationIsValidUsing(in TTemplateComponentWithCompositeSpecification otherTemplateSpecificationTemplateComponentToHandle);
    }
}