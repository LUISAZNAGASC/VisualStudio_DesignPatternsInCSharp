namespace VisualStudio_DesignPatternsInCSharp.StructuralDesignPatterns.CompositeDesignPattern.CompositeSpecificationDesignPattern
{
    using System.Collections.Generic;

    public abstract class TemplateCompositeSpecificationWithCompositeSpecification<TTemplateComponentWithCompositeSpecification> : TemplateSpecificationWithCompositeSpecification<TTemplateComponentWithCompositeSpecification>
    {
        protected IEnumerable<TemplateSpecificationWithCompositeSpecification<TTemplateComponentWithCompositeSpecification>> TemplateCompositeSpecificationTemplateSpecificationCollection { get; set; }

        public TemplateCompositeSpecificationWithCompositeSpecification(params TemplateSpecificationWithCompositeSpecification<TTemplateComponentWithCompositeSpecification>[] newTemplateCompositeSpecificationTemplateSpecificationCollectionToInitialize) : base()
        {
            TemplateCompositeSpecificationTemplateSpecificationCollection = newTemplateCompositeSpecificationTemplateSpecificationCollectionToInitialize;
        }
    }
}