namespace VisualStudio_DesignPatternsInCSharp.StructuralDesignPatterns.CompositeDesignPattern.CompositeSpecificationDesignPattern
{
    public sealed class ProductSizeSpecificationWithCompositeSpecification : TemplateSpecificationWithCompositeSpecification<ProductComponentWithCompositeSpecification>
    {
        private ProductSizeLabelWithCompositeSpecification ProductSizeSpecificationProductSizeLabel { get; set; }

        public ProductSizeSpecificationWithCompositeSpecification(in ProductSizeLabelWithCompositeSpecification newProductSizeSpecificationProductSizeLabelToInitialize) : base()
        {
            ProductSizeSpecificationProductSizeLabel = newProductSizeSpecificationProductSizeLabelToInitialize;
        }

        public override bool CheckTemplateSpecificationIsValidUsing(in ProductComponentWithCompositeSpecification specificProductSizeSpecificationProductComponentToCheck)
        {
            return ProductSizeSpecificationProductSizeLabel == specificProductSizeSpecificationProductComponentToCheck.ProductComponentSizeLabel;
        }
    }
}