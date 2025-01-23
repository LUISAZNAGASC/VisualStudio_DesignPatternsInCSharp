namespace VisualStudio_DesignPatternsInCSharp.Scripts.BehavioralDesignPatterns.CommandDesignPattern.RegularCommandDesignPattern
{
    public enum ProductShapeLabelWithRegularCommand : uint
    {
        ProductShapeLabelUndefined = 0,
        ProductShapeLabelCube = 1,
        ProductShapeLabelSphere = 2,
        ProductShapeLabelCylinder = 3,
        ProductShapeLabelCapsule = 4
    }

    public enum ProductSizeLabelWithRegularCommand : uint
    {
        ProductSizeLabelUndefined = 0,
        ProductSizeLabelSmall = 1,
        ProductSizeLabelMedium = 2,
        ProductSizeLabelLarge = 3
    }

    public enum ProductMaterialLabelWithRegularCommand : uint
    {
        ProductMaterialLabelUndefined = 0,
        ProductMaterialLabelFabric = 1,
        ProductMaterialLabelWood = 2,
        ProductMaterialLabelPlastic = 3,
        ProductMaterialLabelMetal = 4
    }

    public sealed class ProductComponentWithRegularCommand(in ProductShapeLabelWithRegularCommand otherProductComponentShapeLabelToHandle, in ProductSizeLabelWithRegularCommand otherProductComponentSizeLabelToHandle, in ProductMaterialLabelWithRegularCommand otherProductComponentMaterialLabelToHandle) : object()
    {
        public ProductShapeLabelWithRegularCommand ProductComponentShapeLabel { get; private set; } = otherProductComponentShapeLabelToHandle;
        public ProductSizeLabelWithRegularCommand ProductComponentSizeLabel { get; private set; } = otherProductComponentSizeLabelToHandle;
        public ProductMaterialLabelWithRegularCommand ProductComponentMaterialLabel { get; private set; } = otherProductComponentMaterialLabelToHandle;

        public void SetProductComponentShapeLabelUsing(in ProductShapeLabelWithRegularCommand otherProductComponentShapeLabelToHandle)
        {
            ProductComponentShapeLabel = otherProductComponentShapeLabelToHandle;
        }

        public void SetProductComponentSizeLabelUsing(in ProductSizeLabelWithRegularCommand otherProductComponentSizeLabelToHandle)
        {
            ProductComponentSizeLabel = otherProductComponentSizeLabelToHandle;
        }

        public void SetProductComponentMaterialLabelUsing(in ProductMaterialLabelWithRegularCommand otherProductComponentMaterialLabelToHandle)
        {
            ProductComponentMaterialLabel = otherProductComponentMaterialLabelToHandle;
        }

        public override bool Equals(object otherProductComponentUndefinedObjectToHandle)
        {
            if (ReferenceEquals(objA: this, objB: otherProductComponentUndefinedObjectToHandle) == true)
            {
                return true;
            }

            if (otherProductComponentUndefinedObjectToHandle == null || otherProductComponentUndefinedObjectToHandle is ProductComponentWithRegularCommand otherDocumentComponentDefinedObjectToHandle == false)
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