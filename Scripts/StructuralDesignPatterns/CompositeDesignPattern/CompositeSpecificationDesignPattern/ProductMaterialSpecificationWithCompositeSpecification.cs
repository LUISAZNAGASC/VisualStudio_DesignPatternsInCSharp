namespace VisualStudio_DesignPatternsInCSharp.StructuralDesignPatterns.CompositeDesignPattern.CompositeSpecificationDesignPattern
{
    public sealed class ProductMaterialSpecificationWithCompositeSpecification : TemplateSpecificationWithCompositeSpecification<ProductComponentWithCompositeSpecification>
    {
        private ProductMaterialLabelWithCompositeSpecification ProductMaterialSpecificationProductMaterialLabel { get; set; }

        public ProductMaterialSpecificationWithCompositeSpecification(in ProductMaterialLabelWithCompositeSpecification newProductMaterialSpecificationProductMaterialLabelToInitialize) : base()
        {
            ProductMaterialSpecificationProductMaterialLabel = newProductMaterialSpecificationProductMaterialLabelToInitialize;
        }

        public override bool CheckTemplateSpecificationIsValidUsing(in ProductComponentWithCompositeSpecification specificProductMaterialSpecificationProductComponentToCheck)
        {
            return ProductMaterialSpecificationProductMaterialLabel == specificProductMaterialSpecificationProductComponentToCheck.ProductComponentMaterialLabel;
        }
    }
}