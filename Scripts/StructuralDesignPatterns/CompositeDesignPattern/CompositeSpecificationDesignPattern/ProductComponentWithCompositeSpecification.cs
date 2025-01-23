namespace VisualStudio_DesignPatternsInCSharp.Scripts.StructuralDesignPatterns.CompositeDesignPattern.CompositeSpecificationDesignPattern
{
    public enum ProductShapeLabelWithCompositeSpecification : uint
    {
        ProductShapeLabelUndefined = 0,
        ProductShapeLabelCube = 1,
        ProductShapeLabelSphere = 2,
        ProductShapeLabelCylinder = 3,
        ProductShapeLabelCapsule = 4
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

    public sealed class ProductComponentWithCompositeSpecification(in ProductShapeLabelWithCompositeSpecification otherProductComponentShapeLabelToHandle, in ProductSizeLabelWithCompositeSpecification otherProductComponentSizeLabelToHandle, in ProductMaterialLabelWithCompositeSpecification otherProductComponentMaterialLabelToHandle) : object()
    {
        public ProductShapeLabelWithCompositeSpecification ProductComponentShapeLabel { get; private set; } = otherProductComponentShapeLabelToHandle;
        public ProductSizeLabelWithCompositeSpecification ProductComponentSizeLabel { get; private set; } = otherProductComponentSizeLabelToHandle;
        public ProductMaterialLabelWithCompositeSpecification ProductComponentMaterialLabel { get; private set; } = otherProductComponentMaterialLabelToHandle;

        public void SetProductComponentShapeLabelUsing(in ProductShapeLabelWithCompositeSpecification otherProductComponentShapeLabelToHandle)
        {
            ProductComponentShapeLabel = otherProductComponentShapeLabelToHandle;
        }

        public void SetProductComponentSizeLabelUsing(in ProductSizeLabelWithCompositeSpecification otherProductComponentSizeLabelToHandle)
        {
            ProductComponentSizeLabel = otherProductComponentSizeLabelToHandle;
        }

        public void SetProductComponentMaterialLabelUsing(in ProductMaterialLabelWithCompositeSpecification otherProductComponentMaterialLabelToHandle)
        {
            ProductComponentMaterialLabel = otherProductComponentMaterialLabelToHandle;
        }

        public override bool Equals(object otherProductComponentUndefinedObjectToHandle)
        {
            if (ReferenceEquals(objA: this, objB: otherProductComponentUndefinedObjectToHandle) == true)
            {
                return true;
            }

            if (otherProductComponentUndefinedObjectToHandle == null || otherProductComponentUndefinedObjectToHandle is ProductComponentWithCompositeSpecification otherDocumentComponentDefinedObjectToHandle == false)
            {
                return false;
            }

            if (ProductComponentShapeLabel != otherDocumentComponentDefinedObjectToHandle.ProductComponentShapeLabel || ProductComponentSizeLabel != otherDocumentComponentDefinedObjectToHandle.ProductComponentSizeLabel || ProductComponentMaterialLabel != otherDocumentComponentDefinedObjectToHandle.ProductComponentMaterialLabel)
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
            return string.Empty.ToUpperInvariant();
        }
    }
}