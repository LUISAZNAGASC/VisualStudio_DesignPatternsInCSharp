namespace VisualStudio_DesignPatternsInCSharp.StructuralDesignPatterns.CompositeDesignPattern.CompositeSpecificationDesignPattern
{
    public sealed class ProductShapeSpecificationWithCompositeSpecification(in ProductShapeLabelWithCompositeSpecification newProductShapeSpecificationProductShapeLabelToInitialize) : TemplateSpecificationWithCompositeSpecification<ProductComponentWithCompositeSpecification>()
    {
        private ProductShapeLabelWithCompositeSpecification ProductShapeSpecificationProductShapeLabel { get; set; } = newProductShapeSpecificationProductShapeLabelToInitialize;

        public override bool CheckTemplateSpecificationIsValidUsing(in ProductComponentWithCompositeSpecification specificProductShapeSpecificationProductComponentToCheck)
        {
            return ProductShapeSpecificationProductShapeLabel == specificProductShapeSpecificationProductComponentToCheck.ProductComponentShapeLabel;
        }
    }
}