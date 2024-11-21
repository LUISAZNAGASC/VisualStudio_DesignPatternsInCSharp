namespace VisualStudio_DesignPatternsInCSharp.CreationalDesignPatterns.BuilderDesignPattern.StepwiseBuilderDesignPattern
{
    public sealed class ProductCreatorWithStepwiseBuilder
    {
        private class ProductImplementationWithStepwiseBuilder : IProductShapeLabelDefinitionWithStepwiseBuilder, IProductSizeLabelDefinitionWithStepwiseBuilder, IProductMaterialLabelDefinitionWithStepwiseBuilder, IProductComponentDefinitionWithStepwiseBuilder
        {
            private ProductComponentWithStepwiseBuilder ProductImplementationProductComponent { get; set; }

            public ProductImplementationWithStepwiseBuilder() : base()
            {
                ProductImplementationProductComponent = new ProductComponentWithStepwiseBuilder();
            }

            public IProductSizeLabelDefinitionWithStepwiseBuilder SetProductShapeLabelDefinitionUsing(in ProductShapeLabelWithStepwiseBuilder newProductImplementationProductShapeLabelToDefine)
            {
                ProductImplementationProductComponent.SetProductComponentShapeLabelUsing(newProductComponentShapeLabelToDefine: newProductImplementationProductShapeLabelToDefine);

                return this;
            }

            public IProductMaterialLabelDefinitionWithStepwiseBuilder SetProductSizeLabelDefinitionUsing(in ProductSizeLabelWithStepwiseBuilder newProductImplementationProductSizeLabelToDefine)
            {
                ProductImplementationProductComponent.SetProductComponentSizeLabelUsing(newProductComponentSizeLabelToDefine: newProductImplementationProductSizeLabelToDefine);

                return this;
            }

            public IProductComponentDefinitionWithStepwiseBuilder SetProductMaterialLabelDefinitionUsing(in ProductMaterialLabelWithStepwiseBuilder newProductImplementationProductMaterialLabelToDefine)
            {
                ProductImplementationProductComponent.SetProductComponentMaterialLabelUsing(newProductComponentMaterialLabelToDefine: newProductImplementationProductMaterialLabelToDefine);

                return this;
            }

            public ProductComponentWithStepwiseBuilder GetProductComponentDefinition()
            {
                return ProductImplementationProductComponent;
            }
        }

        private ProductCreatorWithStepwiseBuilder() : base()
        {

        }

        public static IProductShapeLabelDefinitionWithStepwiseBuilder CreateProductCreatorProductComponent()
        {
            return new ProductImplementationWithStepwiseBuilder();
        }
    }
}