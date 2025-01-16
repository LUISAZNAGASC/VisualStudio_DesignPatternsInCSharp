namespace VisualStudio_DesignPatternsInCSharp.StructuralDesignPatterns.CompositeDesignPattern.CompositeSpecificationDesignPattern
{
    public sealed class ProductMaterialSpecificationWithCompositeSpecification(in ProductMaterialLabelWithCompositeSpecification otherProductMaterialSpecificationProductMaterialLabelToHandle) : TemplateSpecificationWithCompositeSpecification<ProductComponentWithCompositeSpecification>()
    {
        private ProductMaterialLabelWithCompositeSpecification ProductMaterialSpecificationProductMaterialLabel { get; } = otherProductMaterialSpecificationProductMaterialLabelToHandle;

        public override bool CheckTemplateSpecificationIsValidUsing(in ProductComponentWithCompositeSpecification otherProductMaterialSpecificationProductComponentToHandle)
        {
            return ProductMaterialSpecificationProductMaterialLabel == otherProductMaterialSpecificationProductComponentToHandle.ProductComponentMaterialLabel;
        }
    }
}