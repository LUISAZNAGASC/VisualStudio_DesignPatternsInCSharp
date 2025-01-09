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

            productComponentContentStringBuilder.Append(value: "[>> ENTRY_POINT::PRODUCT_COMPONENT::ENTRY_POINT >>] ".ToUpperInvariant());
            productComponentContentStringBuilder.AppendLine();
            productComponentContentStringBuilder.Append(value: $"PRODUCT_COMPONENT.SHAPE_LABEL : {ProductComponentShapeLabel.ToString().ToUpperInvariant()}".ToUpperInvariant());
            productComponentContentStringBuilder.AppendLine();
            productComponentContentStringBuilder.Append(value: $"PRODUCT_COMPONENT.SIZE_LABEL : {ProductComponentSizeLabel.ToString().ToUpperInvariant()}".ToUpperInvariant());
            productComponentContentStringBuilder.AppendLine();
            productComponentContentStringBuilder.Append(value: $"PRODUCT_COMPONENT.MATERIAL_LABEL : {ProductComponentMaterialLabel.ToString().ToUpperInvariant()}".ToUpperInvariant());
            productComponentContentStringBuilder.AppendLine();
            productComponentContentStringBuilder.Append(value: "[<< EXIT_POINT::PRODUCT_COMPONENT::EXIT_POINT <<]".ToUpperInvariant());

            return productComponentContentStringBuilder;
        }

        private static StringBuilder GetProductComponentContentUsing(in ProductComponentWithCompositeSpecification specificProductComponentToHandle)
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

            if (specificProductComponentUndefinedObject == null || specificProductComponentUndefinedObject is ProductComponentWithCompositeSpecification specificDocumentComponentDefinedObject == false)
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

        public override string ToString()
        {
            return GetProductComponentContentUsing(specificProductComponentToHandle: this).ToString().ToUpperInvariant();
        }
    }
}