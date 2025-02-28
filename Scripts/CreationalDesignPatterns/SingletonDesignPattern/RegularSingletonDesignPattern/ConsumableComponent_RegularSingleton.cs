namespace VisualStudio_DesignPatternsInCSharp.Scripts.CreationalDesignPatterns.SingletonDesignPattern.RegularSingletonDesignPattern
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public enum ConsumableEffectFactor : uint
    {
        ConsumableEffectFactorNone = 0, ConsumableEffectFactorEmpty = 1, ConsumableEffectFactorLow = 2, ConsumableEffectFactorMiddle = 3, ConsumableEffectFactorHigh = 4, ConsumableEffectFactorFull = 5
    }

    public sealed class ConsumableComponent : ProductComponent
    {
        public ConsumableEffectFactor ConsumableComponentHealingFactor { get; private set; }

        public ConsumableEffectFactor ConsumableComponentDamageFactor { get; private set; }

        public ConsumableComponent() : base()
        {
            SetConsumableComponentHealingFactor(consumableComponentHealingFactor: ConsumableEffectFactor.ConsumableEffectFactorNone);

            SetConsumableComponentDamageFactor(consumableComponentDamageFactor: ConsumableEffectFactor.ConsumableEffectFactorNone);
        }

        public ConsumableComponent(
            in string consumableComponentIdentifier,
            in string consumableComponentDescription,
            in ProductSizeFactor consumableComponentWidthFactor,
            in ProductSizeFactor consumableComponentHeightFactor,
            in ProductSizeFactor consumableComponentDepthFactor,
            in ProductWeightFactor consumableComponentWeightFactor,
            in ConsumableEffectFactor consumableComponentHealingFactor,
            in ConsumableEffectFactor consumableComponentDamageFactor) : base(
                productComponentIdentifier: consumableComponentIdentifier,
                productComponentDescription: consumableComponentDescription,
                productComponentWidthFactor: consumableComponentWidthFactor,
                productComponentHeightFactor: consumableComponentHeightFactor,
                productComponentDepthFactor: consumableComponentDepthFactor,
                productComponentWeightFactor: consumableComponentWeightFactor)
        {
            SetConsumableComponentHealingFactor(consumableComponentHealingFactor: consumableComponentHealingFactor);

            SetConsumableComponentDamageFactor(consumableComponentDamageFactor: consumableComponentDamageFactor);
        }

        public void SetConsumableComponentHealingFactor(in ConsumableEffectFactor consumableComponentHealingFactor)
        {
            if (!Enum.IsDefined(value: consumableComponentHealingFactor))
            {
                ConsumableComponentHealingFactor = ConsumableEffectFactor.ConsumableEffectFactorNone;

                return;
            }

            ConsumableComponentHealingFactor = consumableComponentHealingFactor;
        }

        public void SetConsumableComponentDamageFactor(in ConsumableEffectFactor consumableComponentDamageFactor)
        {
            if (!Enum.IsDefined(value: consumableComponentDamageFactor))
            {
                ConsumableComponentDamageFactor = ConsumableEffectFactor.ConsumableEffectFactorNone;

                return;
            }

            ConsumableComponentDamageFactor = consumableComponentDamageFactor;
        }

        public override bool Equals(object uncastedConsumableComponent)
        {
            if (ReferenceEquals(objA: this, objB: uncastedConsumableComponent))
            {
                return true;
            }

            if (uncastedConsumableComponent is null || uncastedConsumableComponent.GetType() != typeof(ConsumableComponent))
            {
                return false;
            }

            if (uncastedConsumableComponent is not ConsumableComponent castedConsumableComponent)
            {
                return false;
            }

            if (!EqualityComparer<string>.Default.Equals(x: ProductComponentIdentifier, y: castedConsumableComponent.ProductComponentIdentifier))
            {
                return false;
            }

            if (!EqualityComparer<string>.Default.Equals(x: ProductComponentDescription, y: castedConsumableComponent.ProductComponentDescription))
            {
                return false;
            }

            if (!EqualityComparer<ProductSizeFactor>.Default.Equals(x: ProductComponentWidthFactor, y: castedConsumableComponent.ProductComponentWidthFactor))
            {
                return false;
            }

            if (!EqualityComparer<ProductSizeFactor>.Default.Equals(x: ProductComponentHeightFactor, y: castedConsumableComponent.ProductComponentHeightFactor))
            {
                return false;
            }

            if (!EqualityComparer<ProductSizeFactor>.Default.Equals(x: ProductComponentDepthFactor, y: castedConsumableComponent.ProductComponentDepthFactor))
            {
                return false;
            }

            if (!EqualityComparer<ProductWeightFactor>.Default.Equals(x: ProductComponentWeightFactor, y: castedConsumableComponent.ProductComponentWeightFactor))
            {
                return false;
            }

            if (!EqualityComparer<ConsumableEffectFactor>.Default.Equals(x: ConsumableComponentHealingFactor, y: castedConsumableComponent.ConsumableComponentHealingFactor))
            {
                return false;
            }

            if (!EqualityComparer<ConsumableEffectFactor>.Default.Equals(x: ConsumableComponentDamageFactor, y: castedConsumableComponent.ConsumableComponentDamageFactor))
            {
                return false;
            }

            return true;
        }

        public override int GetHashCode()
        {
            const int ConsumableComponentHashCodeInitialPrime = 0B1001111;
            const int ConsumableComponentHashCodeMultiplierPrime = 0B1100001;

            int consumableComponentHashCode = ConsumableComponentHashCodeInitialPrime;

            consumableComponentHashCode = HashCode.Combine(value1: ConsumableComponentHashCodeMultiplierPrime ^ consumableComponentHashCode, value2: ProductComponentIdentifier);

            consumableComponentHashCode = HashCode.Combine(value1: ConsumableComponentHashCodeMultiplierPrime ^ consumableComponentHashCode, value2: ProductComponentDescription);

            consumableComponentHashCode = HashCode.Combine(value1: ConsumableComponentHashCodeMultiplierPrime ^ consumableComponentHashCode, value2: ProductComponentWidthFactor);

            consumableComponentHashCode = HashCode.Combine(value1: ConsumableComponentHashCodeMultiplierPrime ^ consumableComponentHashCode, value2: ProductComponentHeightFactor);

            consumableComponentHashCode = HashCode.Combine(value1: ConsumableComponentHashCodeMultiplierPrime ^ consumableComponentHashCode, value2: ProductComponentDepthFactor);

            consumableComponentHashCode = HashCode.Combine(value1: ConsumableComponentHashCodeMultiplierPrime ^ consumableComponentHashCode, value2: ProductComponentWeightFactor);

            consumableComponentHashCode = HashCode.Combine(value1: ConsumableComponentHashCodeMultiplierPrime ^ consumableComponentHashCode, value2: ConsumableComponentHealingFactor);

            consumableComponentHashCode = HashCode.Combine(value1: ConsumableComponentHashCodeMultiplierPrime ^ consumableComponentHashCode, value2: ConsumableComponentDamageFactor);

            return consumableComponentHashCode;
        }

        public override string ToString()
        {
            StringBuilder consumableComponentStringBuilder = new();

            consumableComponentStringBuilder.Append(value: $"[START]{nameof(ConsumableComponent)}[START]");
            consumableComponentStringBuilder.AppendLine(value: string.Empty);
            consumableComponentStringBuilder.Append(value: $"{nameof(ProductComponentIdentifier)}: {ProductComponentIdentifier}");
            consumableComponentStringBuilder.AppendLine(value: string.Empty);
            consumableComponentStringBuilder.Append(value: $"{nameof(ProductComponentDescription)}: {ProductComponentDescription}");
            consumableComponentStringBuilder.AppendLine(value: string.Empty);
            consumableComponentStringBuilder.Append(value: $"{nameof(ProductComponentWidthFactor)}: {ProductComponentWidthFactor}");
            consumableComponentStringBuilder.AppendLine(value: string.Empty);
            consumableComponentStringBuilder.Append(value: $"{nameof(ProductComponentHeightFactor)}: {ProductComponentHeightFactor}");
            consumableComponentStringBuilder.AppendLine(value: string.Empty);
            consumableComponentStringBuilder.Append(value: $"{nameof(ProductComponentDepthFactor)}: {ProductComponentDepthFactor}");
            consumableComponentStringBuilder.AppendLine(value: string.Empty);
            consumableComponentStringBuilder.Append(value: $"{nameof(ProductComponentWeightFactor)}: {ProductComponentWeightFactor}");
            consumableComponentStringBuilder.AppendLine(value: string.Empty);
            consumableComponentStringBuilder.Append(value: $"{nameof(ConsumableComponentHealingFactor)}: {ConsumableComponentHealingFactor}");
            consumableComponentStringBuilder.AppendLine(value: string.Empty);
            consumableComponentStringBuilder.Append(value: $"{nameof(ConsumableComponentDamageFactor)}: {ConsumableComponentDamageFactor}");
            consumableComponentStringBuilder.AppendLine(value: string.Empty);
            consumableComponentStringBuilder.Append(value: $"[END]{nameof(ConsumableComponent)}[END]");

            return consumableComponentStringBuilder.ToString();
        }
    }
}