namespace VisualStudio_DesignPatternsInCSharp.CreationalDesignPatterns.BuilderDesignPattern.StepwiseBuilderDesignPattern
{
    using System;
    using System.Text;

    public enum ProductShapeLabelWithStepwiseBuilder : uint
    {
        ProductShapeUndefinedLabel = 0,
        ProductShapeFirstLabel = 1,
        ProductShapeSecondLabel = 2,
        ProductShapeThirdLabel = 3,
        ProductShapeFourthLabel = 4
    }

    public enum ProductSizeLabelWithStepwiseBuilder : uint
    {
        ProductSizeUndefinedLabel = 0,
        ProductSizeFirstLabel = 1,
        ProductSizeSecondLabel = 2,
        ProductSizeThirdLabel = 3,
        ProductSizeFourthLabel = 4
    }

    public enum ProductMaterialLabelWithStepwiseBuilder : uint
    {
        ProductMaterialUndefinedLabel = 0,
        ProductMaterialFirstLabel = 1,
        ProductMaterialSecondLabel = 2,
        ProductMaterialThirdLabel = 3,
        ProductMaterialFourthLabel = 4
    }

    public sealed class ProductComponentWithStepwiseBuilder
    {
        public ProductShapeLabelWithStepwiseBuilder ProductComponentShapeLabel { get; private set; }
        public ProductSizeLabelWithStepwiseBuilder ProductComponentSizeLabel { get; private set; }
        public ProductMaterialLabelWithStepwiseBuilder ProductComponentMaterialLabel { get; private set; }

        public ProductComponentWithStepwiseBuilder() : base()
        {
            ProductComponentShapeLabel = ProductShapeLabelWithStepwiseBuilder.ProductShapeUndefinedLabel;
            ProductComponentSizeLabel = ProductSizeLabelWithStepwiseBuilder.ProductSizeUndefinedLabel;
            ProductComponentMaterialLabel = ProductMaterialLabelWithStepwiseBuilder.ProductMaterialUndefinedLabel;
        }

        public void SetProductComponentShapeLabelUsing(in ProductShapeLabelWithStepwiseBuilder newProductComponentShapeLabelToDefine)
        {
            ProductComponentShapeLabel = newProductComponentShapeLabelToDefine;
        }

        public void SetProductComponentSizeLabelUsing(in ProductSizeLabelWithStepwiseBuilder newProductComponentSizeLabelToDefine)
        {
            ProductComponentSizeLabel = newProductComponentSizeLabelToDefine;
        }

        public void SetProductComponentMaterialLabelUsing(in ProductMaterialLabelWithStepwiseBuilder newProductComponentMaterialLabelToDefine)
        {
            ProductComponentMaterialLabel = newProductComponentMaterialLabelToDefine;
        }

        public void DisplayProductComponentContent()
        {
            Console.WriteLine(value: GetProductComponentContentUsing(specificProductComponentToHandle: this));
        }

        private StringBuilder GetProductComponentContent()
        {
            StringBuilder productComponentContentStringBuilder = new StringBuilder();

            productComponentContentStringBuilder.Append(value: "[ ".ToUpperInvariant());
            productComponentContentStringBuilder.Append(value: $"{ProductComponentShapeLabel.ToString().ToUpperInvariant()}".ToUpperInvariant());
            productComponentContentStringBuilder.Append(value: " , ".ToUpperInvariant());
            productComponentContentStringBuilder.Append(value: $"{ProductComponentSizeLabel.ToString().ToUpperInvariant()}".ToUpperInvariant());
            productComponentContentStringBuilder.Append(value: " , ".ToUpperInvariant());
            productComponentContentStringBuilder.Append(value: $"{ProductComponentMaterialLabel.ToString().ToUpperInvariant()}".ToUpperInvariant());
            productComponentContentStringBuilder.Append(value: " ]".ToUpperInvariant());

            return productComponentContentStringBuilder;
        }

        private static StringBuilder GetProductComponentContentUsing(in ProductComponentWithStepwiseBuilder specificProductComponentToHandle)
        {
            StringBuilder productComponentContentStringBuilder = new StringBuilder();

            productComponentContentStringBuilder.Append(value: specificProductComponentToHandle.GetProductComponentContent());

            return productComponentContentStringBuilder;
        }
    }
}