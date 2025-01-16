namespace VisualStudio_DesignPatternsInCSharp.StructuralDesignPatterns.CompositeDesignPattern.CompositeSpecificationDesignPattern
{
    public sealed class ProductSizeSpecificationWithCompositeSpecification(in ProductSizeLabelWithCompositeSpecification otherProductSizeSpecificationProductSizeLabelToHandle) : TemplateSpecificationWithCompositeSpecification<ProductComponentWithCompositeSpecification>()
    {
        private ProductSizeLabelWithCompositeSpecification ProductSizeSpecificationProductSizeLabel { get; } = otherProductSizeSpecificationProductSizeLabelToHandle;

        public override bool CheckTemplateSpecificationIsValidUsing(in ProductComponentWithCompositeSpecification otherProductSizeSpecificationProductComponentToHandle)
        {
            return ProductSizeSpecificationProductSizeLabel == otherProductSizeSpecificationProductComponentToHandle.ProductComponentSizeLabel;
        }
    }
}