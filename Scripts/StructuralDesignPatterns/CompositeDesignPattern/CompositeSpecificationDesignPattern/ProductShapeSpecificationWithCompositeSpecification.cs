namespace VisualStudio_DesignPatternsInCSharp.StructuralDesignPatterns.CompositeDesignPattern.CompositeSpecificationDesignPattern
{
    public sealed class ProductShapeSpecificationWithCompositeSpecification(in ProductShapeLabelWithCompositeSpecification otherProductShapeSpecificationProductShapeLabelToHandle) : TemplateSpecificationWithCompositeSpecification<ProductComponentWithCompositeSpecification>()
    {
        private ProductShapeLabelWithCompositeSpecification ProductShapeSpecificationProductShapeLabel { get; } = otherProductShapeSpecificationProductShapeLabelToHandle;

        public override bool CheckTemplateSpecificationIsValidUsing(in ProductComponentWithCompositeSpecification otherProductShapeSpecificationProductComponentToHandle)
        {
            return ProductShapeSpecificationProductShapeLabel == otherProductShapeSpecificationProductComponentToHandle.ProductComponentShapeLabel;
        }
    }
}