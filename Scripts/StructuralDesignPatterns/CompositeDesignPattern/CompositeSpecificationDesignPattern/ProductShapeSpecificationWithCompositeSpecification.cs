namespace VisualStudio_DesignPatternsInCSharp.StructuralDesignPatterns.CompositeDesignPattern.CompositeSpecificationDesignPattern
{
    public sealed class ProductShapeSpecificationWithCompositeSpecification : TemplateSpecificationWithCompositeSpecification<ProductComponentWithCompositeSpecification>
    {
        private ProductShapeLabelWithCompositeSpecification ProductShapeSpecificationProductShapeLabel { get; set; }

        public ProductShapeSpecificationWithCompositeSpecification(in ProductShapeLabelWithCompositeSpecification newProductShapeSpecificationProductShapeLabelToInitialize) : base()
        {
            ProductShapeSpecificationProductShapeLabel = newProductShapeSpecificationProductShapeLabelToInitialize;
        }

        public override bool CheckTemplateSpecificationIsValidUsing(in ProductComponentWithCompositeSpecification specificProductShapeSpecificationProductComponentToCheck)
        {
            return ProductShapeSpecificationProductShapeLabel == specificProductShapeSpecificationProductComponentToCheck.ProductComponentShapeLabel;
        }
    }
}