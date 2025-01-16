namespace VisualStudio_DesignPatternsInCSharp.StructuralDesignPatterns.CompositeDesignPattern.CompositeSpecificationDesignPattern
{
    using System;
    using System.Text;

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

        public void DisplayProductComponentContent()
        {
            Console.WriteLine(value: GetProductComponentContentUsing(otherProductComponentToHandle: this));
        }

        private void SetProductComponentContentEntryPointContentUsing(StringBuilder productComponentContentStringBuilder)
        {
            productComponentContentStringBuilder.Append(value: "[>> ENTRY_POINT::PRODUCT_COMPONENT::ENTRY_POINT >>] ".ToUpperInvariant());
        }

        private void SetProductComponentContentShapeLabelContentUsing(StringBuilder productComponentContentStringBuilder)
        {
            productComponentContentStringBuilder.Append(value: $"PRODUCT_COMPONENT.SHAPE_LABEL : {ProductComponentShapeLabel.ToString().ToUpperInvariant()}".ToUpperInvariant());
        }

        private void SetProductComponentContentSizeLabelContentUsing(StringBuilder productComponentContentStringBuilder)
        {
            productComponentContentStringBuilder.Append(value: $"PRODUCT_COMPONENT.SIZE_LABEL : {ProductComponentSizeLabel.ToString().ToUpperInvariant()}".ToUpperInvariant());
        }

        private void SetProductComponentContentMaterialLabelContentUsing(StringBuilder productComponentContentStringBuilder)
        {
            productComponentContentStringBuilder.Append(value: $"PRODUCT_COMPONENT.MATERIAL_LABEL : {ProductComponentMaterialLabel.ToString().ToUpperInvariant()}".ToUpperInvariant());
        }

        private void SetProductComponentContentExitPointContentUsing(StringBuilder productComponentContentStringBuilder)
        {
            productComponentContentStringBuilder.Append(value: "[<< EXIT_POINT::PRODUCT_COMPONENT::EXIT_POINT <<]".ToUpperInvariant());
        }

        private StringBuilder GetProductComponentContent()
        {
            StringBuilder productComponentContentStringBuilder = new();

            SetProductComponentContentEntryPointContentUsing(productComponentContentStringBuilder: productComponentContentStringBuilder);
            productComponentContentStringBuilder.AppendLine();
            SetProductComponentContentShapeLabelContentUsing(productComponentContentStringBuilder: productComponentContentStringBuilder);
            productComponentContentStringBuilder.AppendLine();
            SetProductComponentContentSizeLabelContentUsing(productComponentContentStringBuilder: productComponentContentStringBuilder);
            productComponentContentStringBuilder.AppendLine();
            SetProductComponentContentMaterialLabelContentUsing(productComponentContentStringBuilder: productComponentContentStringBuilder);
            productComponentContentStringBuilder.AppendLine();
            SetProductComponentContentExitPointContentUsing(productComponentContentStringBuilder: productComponentContentStringBuilder);

            return productComponentContentStringBuilder;
        }

        private static StringBuilder GetProductComponentContentUsing(in ProductComponentWithCompositeSpecification otherProductComponentToHandle)
        {
            StringBuilder productComponentContentStringBuilder = new();

            productComponentContentStringBuilder.Append(value: otherProductComponentToHandle.GetProductComponentContent());

            return productComponentContentStringBuilder;
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
            return GetProductComponentContentUsing(otherProductComponentToHandle: this).ToString().ToUpperInvariant();
        }
    }
}