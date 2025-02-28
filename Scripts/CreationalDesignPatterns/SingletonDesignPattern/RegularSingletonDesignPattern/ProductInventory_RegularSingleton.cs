namespace VisualStudio_DesignPatternsInCSharp.Scripts.CreationalDesignPatterns.SingletonDesignPattern.RegularSingletonDesignPattern
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public sealed class ProductInventory : SingletonComponent<ProductInventory>
    {
        private List<ProductComponent> ProductInventoryReferenceCollection { get; set; }

        public ProductInventory() : base()
        {
            ProductInventoryReferenceCollection = new List<ProductComponent>(collection: []);
        }

        public bool CreateProductInventoryReferenceElement(in ProductComponent productInventoryReferenceElement)
        {
            if (ProductInventoryReferenceCollection is null)
            {
                ProductInventoryReferenceCollection = new List<ProductComponent>(collection: []);

                return false;
            }

            if (productInventoryReferenceElement is null)
            {
                return false;
            }

            ProductInventoryReferenceCollection.Add(item: productInventoryReferenceElement);

            return true;
        }

        public IEnumerable<ProductComponent> ReadProductInventoryReferenceCollection()
        {
            if (ProductInventoryReferenceCollection is null)
            {
                ProductInventoryReferenceCollection = new List<ProductComponent>(collection: []);

                yield break;
            }

            foreach (ProductComponent productInventoryReferenceElement in ProductInventoryReferenceCollection)
            {
                yield return productInventoryReferenceElement;
            }
        }

        public ProductComponent ReadProductInventoryReferenceElement(in int productInventoryReferenceIndex)
        {
            if (ProductInventoryReferenceCollection is null)
            {
                ProductInventoryReferenceCollection = new List<ProductComponent>(collection: []);

                return null;
            }

            if (productInventoryReferenceIndex < 0 || productInventoryReferenceIndex >= ProductInventoryReferenceCollection.Count)
            {
                return null;
            }

            return ProductInventoryReferenceCollection[index: productInventoryReferenceIndex];
        }

        public bool DeleteProductInventoryReferenceElement(in ProductComponent productInventoryReferenceElement)
        {
            if (ProductInventoryReferenceCollection is null)
            {
                ProductInventoryReferenceCollection = new List<ProductComponent>(collection: []);

                return false;
            }

            if (productInventoryReferenceElement is null)
            {
                return false;
            }

            if (!ProductInventoryReferenceCollection.Contains(item: productInventoryReferenceElement))
            {
                return false;
            }

            return ProductInventoryReferenceCollection.Remove(item: productInventoryReferenceElement);
        }

        public bool DeleteProductInventoryReferenceElement(in int productInventoryReferenceIndex)
        {
            if (ProductInventoryReferenceCollection is null)
            {
                ProductInventoryReferenceCollection = new List<ProductComponent>(collection: []);

                return false;
            }

            if (productInventoryReferenceIndex < 0 || productInventoryReferenceIndex >= ProductInventoryReferenceCollection.Count)
            {
                return false;
            }

            ProductInventoryReferenceCollection.RemoveAt(index: productInventoryReferenceIndex);

            return true;
        }

        public override bool Equals(object uncastedProductInventory)
        {
            StringBuilder productInventoryStringBuilder = new();

            productInventoryStringBuilder.Append(value: $"[START]{nameof(ProductInventory)}[START]");
            productInventoryStringBuilder.AppendLine(value: string.Empty);
            productInventoryStringBuilder.Append(value: $"Method not implemented in '{nameof(ProductInventory)}' class");
            productInventoryStringBuilder.AppendLine(value: string.Empty);
            productInventoryStringBuilder.Append(value: $"[END]{nameof(ProductInventory)}[END]");

            throw new NotImplementedException(message: productInventoryStringBuilder.ToString(), inner: new Exception());
        }

        public override int GetHashCode()
        {
            StringBuilder productInventoryStringBuilder = new();

            productInventoryStringBuilder.Append(value: $"[START]{nameof(ProductInventory)}[START]");
            productInventoryStringBuilder.AppendLine(value: string.Empty);
            productInventoryStringBuilder.Append(value: $"Method not implemented in '{nameof(ProductInventory)}' class");
            productInventoryStringBuilder.AppendLine(value: string.Empty);
            productInventoryStringBuilder.Append(value: $"[END]{nameof(ProductInventory)}[END]");

            throw new NotImplementedException(message: productInventoryStringBuilder.ToString(), inner: new Exception());
        }

        public override string ToString()
        {
            StringBuilder productInventoryStringBuilder = new();

            productInventoryStringBuilder.Append(value: $"[START]{nameof(ProductInventory)}[START]");
            productInventoryStringBuilder.AppendLine(value: string.Empty);
            productInventoryStringBuilder.Append(value: $"Method not implemented in '{nameof(ProductInventory)}' class");
            productInventoryStringBuilder.AppendLine(value: string.Empty);
            productInventoryStringBuilder.Append(value: $"[END]{nameof(ProductInventory)}[END]");

            throw new NotImplementedException(message: productInventoryStringBuilder.ToString(), inner: new Exception());
        }
    }
}