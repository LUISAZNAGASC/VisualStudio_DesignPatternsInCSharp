namespace VisualStudio_DesignPatternsInCSharp.Scripts.CreationalDesignPatterns.PrototypeDesignPattern.RegularPrototypeDesignPattern
{
    public enum ProductShapeLabelWithRegularPrototype : uint
    {
        ProductShapeLabelUndefined = 0,
        ProductShapeLabelCube = 1,
        ProductShapeLabelSphere = 2,
        ProductShapeLabelCylinder = 3,
        ProductShapeLabelCapsule = 4
    }

    public enum ProductSizeLabelWithRegularPrototype : uint
    {
        ProductSizeLabelUndefined = 0,
        ProductSizeLabelSmall = 1,
        ProductSizeLabelMedium = 2,
        ProductSizeLabelLarge = 3
    }

    public enum ProductMaterialLabelWithRegularPrototype : uint
    {
        ProductMaterialLabelUndefined = 0,
        ProductMaterialLabelFabric = 1,
        ProductMaterialLabelWood = 2,
        ProductMaterialLabelPlastic = 3,
        ProductMaterialLabelMetal = 4
    }

    public sealed class ProductComponentWithRegularPrototype(in ProductShapeLabelWithRegularPrototype otherProductComponentShapeLabelToHandle, in ProductSizeLabelWithRegularPrototype otherProductComponentSizeLabelToHandle, in ProductMaterialLabelWithRegularPrototype otherProductComponentMaterialLabelToHandle) : object()
    {
        public ProductShapeLabelWithRegularPrototype ProductComponentShapeLabel { get; private set; } = otherProductComponentShapeLabelToHandle;
        public ProductSizeLabelWithRegularPrototype ProductComponentSizeLabel { get; private set; } = otherProductComponentSizeLabelToHandle;
        public ProductMaterialLabelWithRegularPrototype ProductComponentMaterialLabel { get; private set; } = otherProductComponentMaterialLabelToHandle;

        public void SetProductComponentShapeLabelUsing(in ProductShapeLabelWithRegularPrototype otherProductComponentShapeLabelToHandle)
        {
            ProductComponentShapeLabel = otherProductComponentShapeLabelToHandle;
        }

        public void SetProductComponentSizeLabelUsing(in ProductSizeLabelWithRegularPrototype otherProductComponentSizeLabelToHandle)
        {
            ProductComponentSizeLabel = otherProductComponentSizeLabelToHandle;
        }

        public void SetProductComponentMaterialLabelUsing(in ProductMaterialLabelWithRegularPrototype otherProductComponentMaterialLabelToHandle)
        {
            ProductComponentMaterialLabel = otherProductComponentMaterialLabelToHandle;
        }

        public override bool Equals(object otherProductComponentUndefinedObjectToHandle)
        {
            if (ReferenceEquals(objA: this, objB: otherProductComponentUndefinedObjectToHandle) == true)
            {
                return true;
            }

            if (otherProductComponentUndefinedObjectToHandle == null || otherProductComponentUndefinedObjectToHandle is ProductComponentWithRegularPrototype otherDocumentComponentDefinedObjectToHandle == false)
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

        public ProductComponentWithRegularPrototype GetProductComponentDeepCopy()
        {
            ProductComponentWithRegularPrototype productComponentDeepCopy = new(otherProductComponentShapeLabelToHandle: ProductComponentShapeLabel, otherProductComponentSizeLabelToHandle: ProductComponentSizeLabel, otherProductComponentMaterialLabelToHandle: ProductComponentMaterialLabel);

            productComponentDeepCopy.SetProductComponentShapeLabelUsing(otherProductComponentShapeLabelToHandle: ProductComponentShapeLabel);
            productComponentDeepCopy.SetProductComponentSizeLabelUsing(otherProductComponentSizeLabelToHandle: ProductComponentSizeLabel);
            productComponentDeepCopy.SetProductComponentMaterialLabelUsing(otherProductComponentMaterialLabelToHandle: ProductComponentMaterialLabel);

            return productComponentDeepCopy;
        }
    }
}