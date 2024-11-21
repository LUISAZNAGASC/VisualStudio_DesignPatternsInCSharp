namespace VisualStudio_DesignPatternsInCSharp.StructuralDesignPatterns.CompositeDesignPattern.CompositeSpecificationDesignPattern
{
    using System;
    using System.Text;

    public enum ProductShapeLabelWithCompositeSpecification : uint
    {
        ProductShapeUndefinedLabel = 0,
        ProductShapeFirstLabel = 1,
        ProductShapeSecondLabel = 2,
        ProductShapeThirdLabel = 3,
        ProductShapeFourthLabel = 4
    }

    public enum ProductSizeLabelWithCompositeSpecification : uint
    {
        ProductSizeUndefinedLabel = 0,
        ProductSizeFirstLabel = 1,
        ProductSizeSecondLabel = 2,
        ProductSizeThirdLabel = 3,
        ProductSizeFourthLabel = 4
    }

    public enum ProductMaterialLabelWithCompositeSpecification : uint
    {
        ProductMaterialUndefinedLabel = 0,
        ProductMaterialFirstLabel = 1,
        ProductMaterialSecondLabel = 2,
        ProductMaterialThirdLabel = 3,
        ProductMaterialFourthLabel = 4
    }

    public sealed class ProductComponentWithCompositeSpecification
    {
        public ProductShapeLabelWithCompositeSpecification ProductComponentShapeLabel { get; private set; }
        public ProductSizeLabelWithCompositeSpecification ProductComponentSizeLabel { get; private set; }
        public ProductMaterialLabelWithCompositeSpecification ProductComponentMaterialLabel { get; private set; }

        public ProductComponentWithCompositeSpecification(in ProductShapeLabelWithCompositeSpecification newProductComponentShapeLabelToInitialize, in ProductSizeLabelWithCompositeSpecification newProductComponentSizeLabelToInitialize, in ProductMaterialLabelWithCompositeSpecification newProductComponentMaterialLabelToInitialize) : base()
        {
            ProductComponentShapeLabel = newProductComponentShapeLabelToInitialize;
            ProductComponentSizeLabel = newProductComponentSizeLabelToInitialize;
            ProductComponentMaterialLabel = newProductComponentMaterialLabelToInitialize;
        }

        public void SetProductComponentShapeLabelUsing(in ProductShapeLabelWithCompositeSpecification newProductComponentShapeLabelToDefine)
        {
            ProductComponentShapeLabel = newProductComponentShapeLabelToDefine;
        }

        public void SetProductComponentSizeLabelUsing(in ProductSizeLabelWithCompositeSpecification newProductComponentSizeLabelToDefine)
        {
            ProductComponentSizeLabel = newProductComponentSizeLabelToDefine;
        }

        public void SetProductComponentMaterialLabelUsing(in ProductMaterialLabelWithCompositeSpecification newProductComponentMaterialLabelToDefine)
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

        private static StringBuilder GetProductComponentContentUsing(in ProductComponentWithCompositeSpecification specificProductComponentToHandle)
        {
            StringBuilder productComponentContentStringBuilder = new StringBuilder();

            productComponentContentStringBuilder.Append(value: specificProductComponentToHandle.GetProductComponentContent());

            return productComponentContentStringBuilder;
        }
    }
}