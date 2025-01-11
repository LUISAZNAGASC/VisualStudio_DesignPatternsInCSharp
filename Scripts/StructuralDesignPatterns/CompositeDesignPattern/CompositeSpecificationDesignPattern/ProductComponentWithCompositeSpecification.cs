namespace VisualStudio_DesignPatternsInCSharp.StructuralDesignPatterns.CompositeDesignPattern.CompositeSpecificationDesignPattern
{
    using System;
    using System.Text;

    public enum ProductShapeLabelWithCompositeSpecification : uint
    {
        ProductShapeLabelUndefined = 0,
        ProductShapeLabelCube = 1,
        ProductShapeLabelSphere = 2,
        ProductShapeLabelCapsule = 3,
        ProductShapeLabelCylinder = 4
    }

    public enum ProductSizeLabelWithCompositeSpecification : uint
    {
        ProductSizeLabelUndefined = 0,
        ProductSizeLabelSmall = 1,
        ProductSizeLabelMedium = 2,
        ProductSizeLabelLarge = 3
    }

    public enum ProductMaterialLabelWithCompositeSpecification : uint
    {
        ProductMaterialLabelUndefined = 0,
        ProductMaterialLabelFabric = 1,
        ProductMaterialLabelWood = 2,
        ProductMaterialLabelPlastic = 3,
        ProductMaterialLabelMetal = 4
    }

    public sealed class ProductComponentWithCompositeSpecification(in ProductShapeLabelWithCompositeSpecification newProductComponentShapeLabelToInitialize, in ProductSizeLabelWithCompositeSpecification newProductComponentSizeLabelToInitialize, in ProductMaterialLabelWithCompositeSpecification newProductComponentMaterialLabelToInitialize) : object()
    {
        public ProductShapeLabelWithCompositeSpecification ProductComponentShapeLabel { get; private set; } = newProductComponentShapeLabelToInitialize;
        public ProductSizeLabelWithCompositeSpecification ProductComponentSizeLabel { get; private set; } = newProductComponentSizeLabelToInitialize;
        public ProductMaterialLabelWithCompositeSpecification ProductComponentMaterialLabel { get; private set; } = newProductComponentMaterialLabelToInitialize;

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
            StringBuilder productComponentContentStringBuilder = new();

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
            StringBuilder productComponentContentStringBuilder = new();

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