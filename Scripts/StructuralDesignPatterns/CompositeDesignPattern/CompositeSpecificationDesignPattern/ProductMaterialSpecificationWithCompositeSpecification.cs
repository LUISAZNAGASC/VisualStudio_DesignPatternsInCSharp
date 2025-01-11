namespace VisualStudio_DesignPatternsInCSharp.StructuralDesignPatterns.CompositeDesignPattern.CompositeSpecificationDesignPattern
{
    public sealed class ProductMaterialSpecificationWithCompositeSpecification(in ProductMaterialLabelWithCompositeSpecification newProductMaterialSpecificationProductMaterialLabelToInitialize) : TemplateSpecificationWithCompositeSpecification<ProductComponentWithCompositeSpecification>()
    {
        private ProductMaterialLabelWithCompositeSpecification ProductMaterialSpecificationProductMaterialLabel { get; set; } = newProductMaterialSpecificationProductMaterialLabelToInitialize;

        public override bool CheckTemplateSpecificationIsValidUsing(in ProductComponentWithCompositeSpecification specificProductMaterialSpecificationProductComponentToCheck)
        {
            return ProductMaterialSpecificationProductMaterialLabel == specificProductMaterialSpecificationProductComponentToCheck.ProductComponentMaterialLabel;
        }
    }
}