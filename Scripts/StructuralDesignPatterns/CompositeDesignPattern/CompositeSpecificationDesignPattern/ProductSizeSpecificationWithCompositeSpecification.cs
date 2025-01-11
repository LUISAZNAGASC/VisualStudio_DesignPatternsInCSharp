namespace VisualStudio_DesignPatternsInCSharp.StructuralDesignPatterns.CompositeDesignPattern.CompositeSpecificationDesignPattern
{
    public sealed class ProductSizeSpecificationWithCompositeSpecification(in ProductSizeLabelWithCompositeSpecification newProductSizeSpecificationProductSizeLabelToInitialize) : TemplateSpecificationWithCompositeSpecification<ProductComponentWithCompositeSpecification>()
    {
        private ProductSizeLabelWithCompositeSpecification ProductSizeSpecificationProductSizeLabel { get; set; } = newProductSizeSpecificationProductSizeLabelToInitialize;

        public override bool CheckTemplateSpecificationIsValidUsing(in ProductComponentWithCompositeSpecification specificProductSizeSpecificationProductComponentToCheck)
        {
            return ProductSizeSpecificationProductSizeLabel == specificProductSizeSpecificationProductComponentToCheck.ProductComponentSizeLabel;
        }
    }
}