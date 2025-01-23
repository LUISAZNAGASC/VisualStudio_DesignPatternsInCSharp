namespace VisualStudio_DesignPatternsInCSharp.Scripts.CreationalDesignPatterns.BuilderDesignPattern.StepwiseBuilderDesignPattern
{
    public sealed class ProductCreatorWithStepwiseBuilder
    {
        private class ProductImplementationWithStepwiseBuilder : IProductShapeLabelDefinitionWithStepwiseBuilder, IProductSizeLabelDefinitionWithStepwiseBuilder, IProductMaterialLabelDefinitionWithStepwiseBuilder, IProductComponentDefinitionWithStepwiseBuilder
        {
            private ProductComponentWithStepwiseBuilder ProductImplementationProductComponent { get; set; }

            public ProductImplementationWithStepwiseBuilder() : base()
            {
                ProductImplementationProductComponent = new ProductComponentWithStepwiseBuilder(otherProductComponentShapeLabelToHandle: ProductShapeLabelWithStepwiseBuilder.ProductShapeLabelUndefined, otherProductComponentSizeLabelToHandle: ProductSizeLabelWithStepwiseBuilder.ProductSizeLabelUndefined, otherProductComponentMaterialLabelToHandle: ProductMaterialLabelWithStepwiseBuilder.ProductMaterialLabelUndefined);
            }

            public IProductSizeLabelDefinitionWithStepwiseBuilder SetProductShapeLabelDefinitionUsing(in ProductShapeLabelWithStepwiseBuilder otherProductImplementationProductShapeLabelToHandle)
            {
                ProductImplementationProductComponent.SetProductComponentShapeLabelUsing(otherProductComponentShapeLabelToHandle: otherProductImplementationProductShapeLabelToHandle);

                return this;
            }

            public IProductMaterialLabelDefinitionWithStepwiseBuilder SetProductSizeLabelDefinitionUsing(in ProductSizeLabelWithStepwiseBuilder otherProductImplementationProductSizeLabelToHandle)
            {
                ProductImplementationProductComponent.SetProductComponentSizeLabelUsing(otherProductComponentSizeLabelToHandle: otherProductImplementationProductSizeLabelToHandle);

                return this;
            }

            public IProductComponentDefinitionWithStepwiseBuilder SetProductMaterialLabelDefinitionUsing(in ProductMaterialLabelWithStepwiseBuilder otherProductImplementationProductMaterialLabelToHandle)
            {
                ProductImplementationProductComponent.SetProductComponentMaterialLabelUsing(otherProductComponentMaterialLabelToHandle: otherProductImplementationProductMaterialLabelToHandle);

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