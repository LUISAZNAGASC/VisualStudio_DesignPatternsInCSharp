namespace VisualStudio_DesignPatternsInCSharp.Scripts.CreationalDesignPatterns.SingletonDesignPattern.RegularSingletonDesignPattern
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public enum ProductSizeFactor : uint
    {
        ProductSizeFactorNone = 0, ProductSizeFactorVerySmall = 1, ProductSizeFactorSmall = 2, ProductSizeFactorMedium = 3, ProductSizeFactorLarge = 4, ProductSizeFactorVeryLarge = 5
    }

    public enum ProductWeightFactor : uint
    {
        ProductWeightFactorNone = 0, ProductWeightFactorVeryLight = 1, ProductWeightFactorLight = 2, ProductWeightFactorMedium = 3, ProductWeightFactorHeavy = 4, ProductWeightFactorVeryHeavy = 5
    }

    public abstract class ProductComponent
    {
        public string ProductComponentIdentifier { get; private set; }

        public string ProductComponentDescription { get; private set; }

        public ProductSizeFactor ProductComponentWidthFactor { get; private set; }

        public ProductSizeFactor ProductComponentHeightFactor { get; private set; }

        public ProductSizeFactor ProductComponentDepthFactor { get; private set; }

        public ProductWeightFactor ProductComponentWeightFactor { get; private set; }

        public ProductComponent() : base()
        {
            SetProductComponentIdentifier(productComponentIdentifier: nameof(ProductComponentIdentifier));

            SetProductComponentDescription(productComponentDescription: nameof(ProductComponentDescription));

            SetProductComponentWidthFactor(productComponentWidthFactor: ProductSizeFactor.ProductSizeFactorNone);

            SetProductComponentHeightFactor(productComponentHeightFactor: ProductSizeFactor.ProductSizeFactorNone);

            SetProductComponentDepthFactor(productComponentDepthFactor: ProductSizeFactor.ProductSizeFactorNone);

            SetProductComponentWeightFactor(productComponentWeightFactor: ProductWeightFactor.ProductWeightFactorNone);
        }

        public ProductComponent(
            in string productComponentIdentifier,
            in string productComponentDescription,
            in ProductSizeFactor productComponentWidthFactor,
            in ProductSizeFactor productComponentHeightFactor,
            in ProductSizeFactor productComponentDepthFactor,
            in ProductWeightFactor productComponentWeightFactor) : base()
        {
            SetProductComponentIdentifier(productComponentIdentifier: productComponentIdentifier);

            SetProductComponentDescription(productComponentDescription: productComponentDescription);

            SetProductComponentWidthFactor(productComponentWidthFactor: productComponentWidthFactor);

            SetProductComponentHeightFactor(productComponentHeightFactor: productComponentHeightFactor);

            SetProductComponentDepthFactor(productComponentDepthFactor: productComponentDepthFactor);

            SetProductComponentWeightFactor(productComponentWeightFactor: productComponentWeightFactor);
        }

        public void SetProductComponentIdentifier(in string productComponentIdentifier)
        {
            if (string.IsNullOrEmpty(value: productComponentIdentifier) || string.IsNullOrWhiteSpace(value: productComponentIdentifier))
            {
                ProductComponentIdentifier = $"{nameof(ProductComponentIdentifier)}Undefined";

                return;
            }

            ProductComponentIdentifier = productComponentIdentifier;
        }

        public void SetProductComponentDescription(in string productComponentDescription)
        {
            if (string.IsNullOrEmpty(value: productComponentDescription) || string.IsNullOrWhiteSpace(value: productComponentDescription))
            {
                ProductComponentDescription = $"{nameof(ProductComponentDescription)}Undefined";

                return;
            }

            ProductComponentDescription = productComponentDescription;
        }

        public void SetProductComponentWidthFactor(in ProductSizeFactor productComponentWidthFactor)
        {
            if (!Enum.IsDefined(value: productComponentWidthFactor))
            {
                ProductComponentWidthFactor = ProductSizeFactor.ProductSizeFactorNone;

                return;
            }

            ProductComponentWidthFactor = productComponentWidthFactor;
        }

        public void SetProductComponentHeightFactor(in ProductSizeFactor productComponentHeightFactor)
        {
            if (!Enum.IsDefined(value: productComponentHeightFactor))
            {
                ProductComponentHeightFactor = ProductSizeFactor.ProductSizeFactorNone;

                return;
            }

            ProductComponentHeightFactor = productComponentHeightFactor;
        }

        public void SetProductComponentDepthFactor(in ProductSizeFactor productComponentDepthFactor)
        {
            if (!Enum.IsDefined(value: productComponentDepthFactor))
            {
                ProductComponentDepthFactor = ProductSizeFactor.ProductSizeFactorNone;

                return;
            }

            ProductComponentDepthFactor = productComponentDepthFactor;
        }

        public void SetProductComponentWeightFactor(in ProductWeightFactor productComponentWeightFactor)
        {
            if (!Enum.IsDefined(value: productComponentWeightFactor))
            {
                ProductComponentWeightFactor = ProductWeightFactor.ProductWeightFactorNone;

                return;
            }

            ProductComponentWeightFactor = productComponentWeightFactor;
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

            if (!EqualityComparer<string>.Default.Equals(x: ProductComponentIdentifier, y: castedProductComponent.ProductComponentIdentifier))
            {
                return false;
            }

            if (!EqualityComparer<string>.Default.Equals(x: ProductComponentDescription, y: castedProductComponent.ProductComponentDescription))
            {
                return false;
            }

            if (!EqualityComparer<ProductSizeFactor>.Default.Equals(x: ProductComponentWidthFactor, y: castedProductComponent.ProductComponentWidthFactor))
            {
                return false;
            }

            if (!EqualityComparer<ProductSizeFactor>.Default.Equals(x: ProductComponentHeightFactor, y: castedProductComponent.ProductComponentHeightFactor))
            {
                return false;
            }

            if (!EqualityComparer<ProductSizeFactor>.Default.Equals(x: ProductComponentDepthFactor, y: castedProductComponent.ProductComponentDepthFactor))
            {
                return false;
            }

            if (!EqualityComparer<ProductWeightFactor>.Default.Equals(x: ProductComponentWeightFactor, y: castedProductComponent.ProductComponentWeightFactor))
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

            productComponentHashCode = HashCode.Combine(value1: ProductComponentHashCodeMultiplierPrime ^ productComponentHashCode, value2: ProductComponentIdentifier);

            productComponentHashCode = HashCode.Combine(value1: ProductComponentHashCodeMultiplierPrime ^ productComponentHashCode, value2: ProductComponentDescription);

            productComponentHashCode = HashCode.Combine(value1: ProductComponentHashCodeMultiplierPrime ^ productComponentHashCode, value2: ProductComponentWidthFactor);

            productComponentHashCode = HashCode.Combine(value1: ProductComponentHashCodeMultiplierPrime ^ productComponentHashCode, value2: ProductComponentHeightFactor);

            productComponentHashCode = HashCode.Combine(value1: ProductComponentHashCodeMultiplierPrime ^ productComponentHashCode, value2: ProductComponentDepthFactor);

            productComponentHashCode = HashCode.Combine(value1: ProductComponentHashCodeMultiplierPrime ^ productComponentHashCode, value2: ProductComponentWeightFactor);

            return productComponentHashCode;
        }

        public override string ToString()
        {
            StringBuilder productComponentStringBuilder = new();

            productComponentStringBuilder.Append(value: $"[START]{nameof(ProductComponent)}[START]");
            productComponentStringBuilder.AppendLine(value: string.Empty);
            productComponentStringBuilder.Append(value: $"{nameof(ProductComponentIdentifier)}: {ProductComponentIdentifier}");
            productComponentStringBuilder.AppendLine(value: string.Empty);
            productComponentStringBuilder.Append(value: $"{nameof(ProductComponentDescription)}: {ProductComponentDescription}");
            productComponentStringBuilder.AppendLine(value: string.Empty);
            productComponentStringBuilder.Append(value: $"{nameof(ProductComponentWidthFactor)}: {ProductComponentWidthFactor}");
            productComponentStringBuilder.AppendLine(value: string.Empty);
            productComponentStringBuilder.Append(value: $"{nameof(ProductComponentHeightFactor)}: {ProductComponentHeightFactor}");
            productComponentStringBuilder.AppendLine(value: string.Empty);
            productComponentStringBuilder.Append(value: $"{nameof(ProductComponentDepthFactor)}: {ProductComponentDepthFactor}");
            productComponentStringBuilder.AppendLine(value: string.Empty);
            productComponentStringBuilder.Append(value: $"{nameof(ProductComponentWeightFactor)}: {ProductComponentWeightFactor}");
            productComponentStringBuilder.AppendLine(value: string.Empty);
            productComponentStringBuilder.Append(value: $"[END]{nameof(ProductComponent)}[END]");

            return productComponentStringBuilder.ToString();
        }
    }
}