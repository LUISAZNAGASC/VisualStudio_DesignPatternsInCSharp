namespace VisualStudio_DesignPatternsInCSharp.Scripts.CreationalDesignPatterns.BuilderDesignPattern.RegularBuilderDesignPattern
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public enum ProductSize : uint
    {
        ProductSizeNone = 0, ProductSizeSmall = 1, ProductSizeMedium = 2, ProductSizeLarge = 3
    }

    public enum ProductWeight : uint
    {
        ProductWeightNone = 0, ProductWeightLight = 1, ProductWeightMedium = 2, ProductWeightHeavy = 3
    }

    public abstract class ProductComponent
    {
        public string ProductComponentName { get; private set; }

        public ProductSize ProductComponentWidth { get; private set; }

        public ProductSize ProductComponentHeight { get; private set; }

        public ProductSize ProductComponentDepth { get; private set; }

        public ProductWeight ProductComponentWeight { get; private set; }

        public ProductComponent() : base()
        {
            SetProductComponentName(productComponentName: nameof(ProductComponentName));

            SetProductComponentWidth(productComponentWidth: ProductSize.ProductSizeNone);

            SetProductComponentHeight(productComponentHeight: ProductSize.ProductSizeNone);

            SetProductComponentDepth(productComponentDepth: ProductSize.ProductSizeNone);

            SetProductComponentWeight(productComponentWeight: ProductWeight.ProductWeightNone);
        }

        public ProductComponent(
            in string productComponentName,
            in ProductSize productComponentWidth,
            in ProductSize productComponentHeight,
            in ProductSize productComponentDepth,
            in ProductWeight productComponentWeight) : base()
        {
            SetProductComponentName(productComponentName: productComponentName);

            SetProductComponentWidth(productComponentWidth: productComponentWidth);

            SetProductComponentHeight(productComponentHeight: productComponentHeight);

            SetProductComponentDepth(productComponentDepth: productComponentDepth);

            SetProductComponentWeight(productComponentWeight: productComponentWeight);
        }

        public void SetProductComponentName(in string productComponentName)
        {
            if (string.IsNullOrEmpty(value: productComponentName) || string.IsNullOrWhiteSpace(value: productComponentName))
            {
                ProductComponentName = $"{nameof(ProductComponentName)}Undefined";

                return;
            }

            ProductComponentName = productComponentName;
        }

        public void SetProductComponentWidth(in ProductSize productComponentWidth)
        {
            if (!Enum.IsDefined(value: productComponentWidth) || productComponentWidth == ProductSize.ProductSizeNone)
            {
                ProductComponentWidth = ProductSize.ProductSizeNone;

                return;
            }

            ProductComponentWidth = productComponentWidth;
        }

        public void SetProductComponentHeight(in ProductSize productComponentHeight)
        {
            if (!Enum.IsDefined(value: productComponentHeight) || productComponentHeight == ProductSize.ProductSizeNone)
            {
                ProductComponentHeight = ProductSize.ProductSizeNone;

                return;
            }

            ProductComponentHeight = productComponentHeight;
        }

        public void SetProductComponentDepth(in ProductSize productComponentDepth)
        {
            if (!Enum.IsDefined(value: productComponentDepth) || productComponentDepth == ProductSize.ProductSizeNone)
            {
                ProductComponentDepth = ProductSize.ProductSizeNone;

                return;
            }

            ProductComponentDepth = productComponentDepth;
        }

        public void SetProductComponentWeight(in ProductWeight productComponentWeight)
        {
            if (!Enum.IsDefined(value: productComponentWeight) || productComponentWeight == ProductWeight.ProductWeightNone)
            {
                ProductComponentWeight = ProductWeight.ProductWeightNone;

                return;
            }

            ProductComponentWeight = productComponentWeight;
        }

        public override bool Equals(object uncastedProductComponent)
        {
            if (ReferenceEquals(objA: this, objB: uncastedProductComponent))
            {
                return true;
            }

            if (uncastedProductComponent is null || uncastedProductComponent.GetType() != typeof(ProductComponent))
            {
                return false;
            }

            if (uncastedProductComponent is not ProductComponent castedProductComponent)
            {
                return false;
            }

            if (!EqualityComparer<string>.Default.Equals(x: ProductComponentName, y: castedProductComponent.ProductComponentName))
            {
                return false;
            }

            if (!EqualityComparer<ProductSize>.Default.Equals(x: ProductComponentWidth, y: castedProductComponent.ProductComponentWidth))
            {
                return false;
            }

            if (!EqualityComparer<ProductSize>.Default.Equals(x: ProductComponentHeight, y: castedProductComponent.ProductComponentHeight))
            {
                return false;
            }

            if (!EqualityComparer<ProductSize>.Default.Equals(x: ProductComponentDepth, y: castedProductComponent.ProductComponentDepth))
            {
                return false;
            }

            if (!EqualityComparer<ProductWeight>.Default.Equals(x: ProductComponentWeight, y: castedProductComponent.ProductComponentWeight))
            {
                return false;
            }

            return true;
        }

        public override int GetHashCode()
        {
            const int ProductComponentHashCodeInitialPrime = 0B1001111;
            const int ProductComponentHashCodeMultiplierPrime = 0B1100001;

            int productComponentHashCode = ProductComponentHashCodeInitialPrime;

            productComponentHashCode = HashCode.Combine(value1: ProductComponentHashCodeMultiplierPrime ^ productComponentHashCode, value2: ProductComponentName);

            productComponentHashCode = HashCode.Combine(value1: ProductComponentHashCodeMultiplierPrime ^ productComponentHashCode, value2: ProductComponentWidth);

            productComponentHashCode = HashCode.Combine(value1: ProductComponentHashCodeMultiplierPrime ^ productComponentHashCode, value2: ProductComponentHeight);

            productComponentHashCode = HashCode.Combine(value1: ProductComponentHashCodeMultiplierPrime ^ productComponentHashCode, value2: ProductComponentDepth);

            productComponentHashCode = HashCode.Combine(value1: ProductComponentHashCodeMultiplierPrime ^ productComponentHashCode, value2: ProductComponentWeight);

            return productComponentHashCode;
        }

        public override string ToString()
        {
            StringBuilder productComponentStringBuilder = new();

            productComponentStringBuilder.Append(value: $"[START]{nameof(ProductComponent)}[START]");
            productComponentStringBuilder.AppendLine(value: string.Empty);
            productComponentStringBuilder.Append(value: $"{nameof(ProductComponentName)}: {ProductComponentName}");
            productComponentStringBuilder.AppendLine(value: string.Empty);
            productComponentStringBuilder.Append(value: $"{nameof(ProductComponentWidth)}: {ProductComponentWidth}");
            productComponentStringBuilder.AppendLine(value: string.Empty);
            productComponentStringBuilder.Append(value: $"{nameof(ProductComponentHeight)}: {ProductComponentHeight}");
            productComponentStringBuilder.AppendLine(value: string.Empty);
            productComponentStringBuilder.Append(value: $"{nameof(ProductComponentDepth)}: {ProductComponentDepth}");
            productComponentStringBuilder.AppendLine(value: string.Empty);
            productComponentStringBuilder.Append(value: $"{nameof(ProductComponentWeight)}: {ProductComponentWeight}");
            productComponentStringBuilder.AppendLine(value: string.Empty);
            productComponentStringBuilder.Append(value: $"[END]{nameof(ProductComponent)}[END]");

            return productComponentStringBuilder.ToString();
        }
    }
}