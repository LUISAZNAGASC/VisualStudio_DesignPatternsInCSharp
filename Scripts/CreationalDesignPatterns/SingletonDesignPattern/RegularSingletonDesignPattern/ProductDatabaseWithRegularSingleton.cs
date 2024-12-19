namespace VisualStudio_DesignPatternsInCSharp.CreationalDesignPatterns.SingletonDesignPattern.RegularSingletonDesignPattern
{
    using System.Collections.Generic;

    public sealed class ProductDatabaseWithRegularSingleton
    {
        private List<ProductComponentWithRegularSingleton> ProductDatabaseProductComponentCollection { get; set; }

        private ProductDatabaseWithRegularSingleton() : base()
        {
            ProductDatabaseProductComponentCollection = new List<ProductComponentWithRegularSingleton>();
        }

        public IEnumerable<ProductComponentWithRegularSingleton> GetProductDatabaseProductComponentCollection()
        {
            if (ProductDatabaseProductComponentCollection == null)
            {
                ProductDatabaseProductComponentCollection = new List<ProductComponentWithRegularSingleton>();
            }

            foreach (ProductComponentWithRegularSingleton productDatabaseProductComponentElement in ProductDatabaseProductComponentCollection)
            {
                yield return productDatabaseProductComponentElement;
            }
        }

        public ProductComponentWithRegularSingleton GetProductDatabaseProductComponentElementUsing(in uint specificProductDatabaseProductComponentCollectionIndex)
        {
            if (ProductDatabaseProductComponentCollection == null)
            {
                return null;
            }

            if (specificProductDatabaseProductComponentCollectionIndex < uint.MinValue || specificProductDatabaseProductComponentCollectionIndex >= ProductDatabaseProductComponentCollection.Count)
            {
                return null;
            }

            return ProductDatabaseProductComponentCollection[index: (int)specificProductDatabaseProductComponentCollectionIndex];
        }

        public bool AddProductDatabaseProductComponentElementUsing(in ProductComponentWithRegularSingleton newProductDatabaseProductComponentElementToAdd)
        {
            if (ProductDatabaseProductComponentCollection == null)
            {
                return false;
            }

            if (newProductDatabaseProductComponentElementToAdd == null)
            {
                return false;
            }

            ProductDatabaseProductComponentCollection.Add(item: newProductDatabaseProductComponentElementToAdd);

            return true;
        }

        public bool RemoveProductDatabaseProductComponentElementUsing(in ProductComponentWithRegularSingleton existingProductDatabaseProductComponentElementToRemove)
        {
            if (ProductDatabaseProductComponentCollection == null)
            {
                return false;
            }

            if (existingProductDatabaseProductComponentElementToRemove == null)
            {
                return false;
            }

            if (ProductDatabaseProductComponentCollection.Contains(item: existingProductDatabaseProductComponentElementToRemove) == false)
            {
                return false;
            }

            return ProductDatabaseProductComponentCollection.Remove(item: existingProductDatabaseProductComponentElementToRemove);
        }

        private static ProductDatabaseWithRegularSingleton ProductDatabaseInstance { get; set; }

        public static ProductDatabaseWithRegularSingleton GetProductDatabaseInstance()
        {
            if (ProductDatabaseInstance == null)
            {
                ProductDatabaseInstance = new ProductDatabaseWithRegularSingleton();
            }

            return ProductDatabaseInstance;
        }
    }
}