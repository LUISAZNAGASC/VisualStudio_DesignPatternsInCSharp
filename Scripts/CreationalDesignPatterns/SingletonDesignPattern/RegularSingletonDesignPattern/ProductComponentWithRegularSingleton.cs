namespace VisualStudio_DesignPatternsInCSharp.CreationalDesignPatterns.SingletonDesignPattern.RegularSingletonDesignPattern
{
    using System;
    using System.Text;

    public enum ProductShapeLabelWithRegularSingleton : uint
    {
        ProductShapeUndefinedLabel = 0,
        ProductShapeFirstLabel = 1,
        ProductShapeSecondLabel = 2,
        ProductShapeThirdLabel = 3,
        ProductShapeFourthLabel = 4
    }

    public enum ProductSizeLabelWithRegularSingleton : uint
    {
        ProductSizeUndefinedLabel = 0,
        ProductSizeFirstLabel = 1,
        ProductSizeSecondLabel = 2,
        ProductSizeThirdLabel = 3,
        ProductSizeFourthLabel = 4
    }

    public enum ProductMaterialLabelWithRegularSingleton : uint
    {
        ProductMaterialUndefinedLabel = 0,
        ProductMaterialFirstLabel = 1,
        ProductMaterialSecondLabel = 2,
        ProductMaterialThirdLabel = 3,
        ProductMaterialFourthLabel = 4
    }

    public sealed class ProductComponentWithRegularSingleton
    {
        public ProductShapeLabelWithRegularSingleton ProductComponentShapeLabel { get; private set; }
        public ProductSizeLabelWithRegularSingleton ProductComponentSizeLabel { get; private set; }
        public ProductMaterialLabelWithRegularSingleton ProductComponentMaterialLabel { get; private set; }

        public ProductComponentWithRegularSingleton(in ProductShapeLabelWithRegularSingleton newProductComponentShapeLabelToInitialize, in ProductSizeLabelWithRegularSingleton newProductComponentSizeLabelToInitilize, in ProductMaterialLabelWithRegularSingleton newProductComponentMaterialLabelToInitialize) : base()
        {
            ProductComponentShapeLabel = newProductComponentShapeLabelToInitialize;
            ProductComponentSizeLabel = newProductComponentSizeLabelToInitilize;
            ProductComponentMaterialLabel = newProductComponentMaterialLabelToInitialize;
        }

        public void SetProductComponentShapeLabelUsing(in ProductShapeLabelWithRegularSingleton newProductComponentShapeLabelToDefine)
        {
            ProductComponentShapeLabel = newProductComponentShapeLabelToDefine;
        }

        public void SetProductComponentSizeLabelUsing(in ProductSizeLabelWithRegularSingleton newProductComponentSizeLabelToDefine)
        {
            ProductComponentSizeLabel = newProductComponentSizeLabelToDefine;
        }

        public void SetProductComponentMaterialLabelUsing(in ProductMaterialLabelWithRegularSingleton newProductComponentMaterialLabelToDefine)
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

        private static StringBuilder GetProductComponentContentUsing(in ProductComponentWithRegularSingleton specificProductComponentToHandle)
        {
            StringBuilder productComponentContentStringBuilder = new StringBuilder();

            productComponentContentStringBuilder.Append(value: specificProductComponentToHandle.GetProductComponentContent());

            return productComponentContentStringBuilder;
        }

        public override bool Equals(object specificProductComponentUndefinedObject)
        {
            if (ReferenceEquals(objA: this, objB: specificProductComponentUndefinedObject) == true)
            {
                return true;
            }

            if (specificProductComponentUndefinedObject == null || specificProductComponentUndefinedObject is ProductComponentWithRegularSingleton specificDocumentComponentDefinedObject == false)
            {
                return false;
            }

            if (ProductComponentShapeLabel != specificDocumentComponentDefinedObject.ProductComponentShapeLabel || ProductComponentSizeLabel != specificDocumentComponentDefinedObject.ProductComponentSizeLabel || ProductComponentMaterialLabel != specificDocumentComponentDefinedObject.ProductComponentMaterialLabel)
            {
                return false;
            }

            return true;
        }

        public override int GetHashCode()
        {
            const int ProductComponentHashCodeInitialPrime = 17;
            const int ProductComponentHashCodeMultiplierPrime = 23;

            int productComponentHashCode = ProductComponentHashCodeInitialPrime;

            productComponentHashCode = productComponentHashCode * ProductComponentHashCodeMultiplierPrime + ProductComponentShapeLabel.GetHashCode();
            productComponentHashCode = productComponentHashCode * ProductComponentHashCodeMultiplierPrime + ProductComponentSizeLabel.GetHashCode();
            productComponentHashCode = productComponentHashCode * ProductComponentHashCodeMultiplierPrime + ProductComponentMaterialLabel.GetHashCode();

            return productComponentHashCode;
        }
    }
}