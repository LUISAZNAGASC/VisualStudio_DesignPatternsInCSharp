namespace VisualStudio_DesignPatternsInCSharp.Scripts.CreationalDesignPatterns.PrototypeDesignPattern.RegularPrototypeDesignPattern
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public enum ConsumableEffect : uint
    {
        ConsumableEffectNone = 0, ConsumableEffectEmpty = 1, ConsumableEffectLow = 2, ConsumableEffectMiddle = 3, ConsumableEffectHigh = 4, ConsumableEffectFull = 5
    }

    public sealed class ConsumableComponent : ProductComponent, IPrototypeComponent<ConsumableComponent>
    {
        public ConsumableEffect ConsumableComponentHealth { get; private set; }

        public ConsumableEffect ConsumableComponentDamage { get; private set; }

        public ConsumableComponent() : base()
        {
            SetConsumableComponentHealth(consumableComponentHealth: ConsumableEffect.ConsumableEffectNone);

            SetConsumableComponentDamage(consumableComponentDamage: ConsumableEffect.ConsumableEffectNone);
        }

        public ConsumableComponent(in string consumableComponentName, in ProductSize consumableComponentWidth, in ProductSize consumableComponentHeight, in ProductSize consumableComponentDepth, in ProductWeight consumableComponentWeight, in ConsumableEffect consumableComponentHealth, in ConsumableEffect consumableComponentDamage) : base(productComponentName: consumableComponentName, productComponentWidth: consumableComponentWidth, productComponentHeight: consumableComponentHeight, productComponentDepth: consumableComponentDepth, productComponentWeight: consumableComponentWeight)
        {
            SetConsumableComponentHealth(consumableComponentHealth: consumableComponentHealth);

            SetConsumableComponentDamage(consumableComponentDamage: consumableComponentDamage);
        }

        public void SetConsumableComponentHealth(in ConsumableEffect consumableComponentHealth)
        {
            if (!Enum.IsDefined(value: consumableComponentHealth) || consumableComponentHealth == ConsumableEffect.ConsumableEffectNone)
            {
                ConsumableComponentHealth = ConsumableEffect.ConsumableEffectNone;

                return;
            }

            ConsumableComponentHealth = consumableComponentHealth;
        }

        public void SetConsumableComponentDamage(in ConsumableEffect consumableComponentDamage)
        {
            if (!Enum.IsDefined(value: consumableComponentDamage) || consumableComponentDamage == ConsumableEffect.ConsumableEffectNone)
            {
                ConsumableComponentDamage = ConsumableEffect.ConsumableEffectNone;

                return;
            }

            ConsumableComponentDamage = consumableComponentDamage;
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

            if (!EqualityComparer<string>.Default.Equals(x: ProductComponentName, y: castedConsumableComponent.ProductComponentName))
            {
                return false;
            }

            if (!EqualityComparer<ProductSize>.Default.Equals(x: ProductComponentWidth, y: castedConsumableComponent.ProductComponentWidth))
            {
                return false;
            }

            if (!EqualityComparer<ProductSize>.Default.Equals(x: ProductComponentHeight, y: castedConsumableComponent.ProductComponentHeight))
            {
                return false;
            }

            if (!EqualityComparer<ProductSize>.Default.Equals(x: ProductComponentDepth, y: castedConsumableComponent.ProductComponentDepth))
            {
                return false;
            }

            if (!EqualityComparer<ProductWeight>.Default.Equals(x: ProductComponentWeight, y: castedConsumableComponent.ProductComponentWeight))
            {
                return false;
            }

            if (!EqualityComparer<ConsumableEffect>.Default.Equals(x: ConsumableComponentHealth, y: castedConsumableComponent.ConsumableComponentHealth))
            {
                return false;
            }

            if (!EqualityComparer<ConsumableEffect>.Default.Equals(x: ConsumableComponentDamage, y: castedConsumableComponent.ConsumableComponentDamage))
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

            consumableComponentHashCode = HashCode.Combine(value1: ConsumableComponentHashCodeMultiplierPrime ^ consumableComponentHashCode, value2: ProductComponentName);

            consumableComponentHashCode = HashCode.Combine(value1: ConsumableComponentHashCodeMultiplierPrime ^ consumableComponentHashCode, value2: ProductComponentWidth);

            consumableComponentHashCode = HashCode.Combine(value1: ConsumableComponentHashCodeMultiplierPrime ^ consumableComponentHashCode, value2: ProductComponentHeight);

            consumableComponentHashCode = HashCode.Combine(value1: ConsumableComponentHashCodeMultiplierPrime ^ consumableComponentHashCode, value2: ProductComponentDepth);

            consumableComponentHashCode = HashCode.Combine(value1: ConsumableComponentHashCodeMultiplierPrime ^ consumableComponentHashCode, value2: ProductComponentWeight);

            consumableComponentHashCode = HashCode.Combine(value1: ConsumableComponentHashCodeMultiplierPrime ^ consumableComponentHashCode, value2: ConsumableComponentHealth);

            consumableComponentHashCode = HashCode.Combine(value1: ConsumableComponentHashCodeMultiplierPrime ^ consumableComponentHashCode, value2: ConsumableComponentDamage);

            return consumableComponentHashCode;
        }

        public override string ToString()
        {
            StringBuilder consumableComponentStringBuilder = new();

            consumableComponentStringBuilder.Append(value: $"[START]{nameof(ConsumableComponent)}[START]");
            consumableComponentStringBuilder.AppendLine(value: string.Empty);
            consumableComponentStringBuilder.Append(value: $"{nameof(ProductComponentName)}: {ProductComponentName}");
            consumableComponentStringBuilder.AppendLine(value: string.Empty);
            consumableComponentStringBuilder.Append(value: $"{nameof(ProductComponentWidth)}: {ProductComponentWidth}");
            consumableComponentStringBuilder.AppendLine(value: string.Empty);
            consumableComponentStringBuilder.Append(value: $"{nameof(ProductComponentHeight)}: {ProductComponentHeight}");
            consumableComponentStringBuilder.AppendLine(value: string.Empty);
            consumableComponentStringBuilder.Append(value: $"{nameof(ProductComponentDepth)}: {ProductComponentDepth}");
            consumableComponentStringBuilder.AppendLine(value: string.Empty);
            consumableComponentStringBuilder.Append(value: $"{nameof(ProductComponentWeight)}: {ProductComponentWeight}");
            consumableComponentStringBuilder.AppendLine(value: string.Empty);
            consumableComponentStringBuilder.Append(value: $"{nameof(ConsumableComponentHealth)}: {ConsumableComponentHealth}");
            consumableComponentStringBuilder.AppendLine(value: string.Empty);
            consumableComponentStringBuilder.Append(value: $"{nameof(ConsumableComponentDamage)}: {ConsumableComponentDamage}");
            consumableComponentStringBuilder.AppendLine(value: string.Empty);
            consumableComponentStringBuilder.Append(value: $"[END]{nameof(ConsumableComponent)}[END]");

            return consumableComponentStringBuilder.ToString();
        }

        public void SetPrototypeComponentClonation(in ConsumableComponent consumableComponentClonation)
        {
            if (consumableComponentClonation is null)
            {
                return;
            }

            consumableComponentClonation.SetProductComponentName(productComponentName: ProductComponentName);

            consumableComponentClonation.SetProductComponentWidth(productComponentWidth: ProductComponentWidth);

            consumableComponentClonation.SetProductComponentHeight(productComponentHeight: ProductComponentHeight);

            consumableComponentClonation.SetProductComponentDepth(productComponentDepth: ProductComponentDepth);

            consumableComponentClonation.SetProductComponentWeight(productComponentWeight: ProductComponentWeight);

            consumableComponentClonation.SetConsumableComponentHealth(consumableComponentHealth: ConsumableComponentHealth);

            consumableComponentClonation.SetConsumableComponentDamage(consumableComponentDamage: ConsumableComponentDamage);
        }
    }
}