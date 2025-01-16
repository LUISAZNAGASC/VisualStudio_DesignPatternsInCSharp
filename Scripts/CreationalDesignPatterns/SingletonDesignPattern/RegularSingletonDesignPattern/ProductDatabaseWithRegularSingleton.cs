namespace VisualStudio_DesignPatternsInCSharp.CreationalDesignPatterns.SingletonDesignPattern.RegularSingletonDesignPattern
{
    using System.Collections.Generic;

    public sealed class ProductDatabaseWithRegularSingleton
    {
        private List<ProductComponentWithRegularSingleton> ProductDatabaseProductComponentCollection { get; set; }

        private static ProductDatabaseWithRegularSingleton ProductDatabaseInstance { get; set; }

        private ProductDatabaseWithRegularSingleton() : base()
        {
            ProductDatabaseProductComponentCollection = [];
        }

        public static ProductDatabaseWithRegularSingleton GetProductDatabaseInstance()
        {
            ProductDatabaseInstance ??= new ProductDatabaseWithRegularSingleton();

            return ProductDatabaseInstance;
        }

        public IEnumerable<ProductComponentWithRegularSingleton> GetProductDatabaseProductComponentCollection()
        {
            ProductDatabaseProductComponentCollection ??= [];

            foreach (ProductComponentWithRegularSingleton productDatabaseProductComponentElement in ProductDatabaseProductComponentCollection)
            {
                yield return productDatabaseProductComponentElement;
            }
        }

        public ProductComponentWithRegularSingleton GetProductDatabaseProductComponentElementUsing(in uint otherProductDatabaseProductComponentCollectionIndexToHandle)
        {
            if (ProductDatabaseProductComponentCollection == null)
            {
                return null;
            }

            if (otherProductDatabaseProductComponentCollectionIndexToHandle < uint.MinValue || otherProductDatabaseProductComponentCollectionIndexToHandle >= ProductDatabaseProductComponentCollection.Count)
            {
                return null;
            }

            return ProductDatabaseProductComponentCollection[index: (int)otherProductDatabaseProductComponentCollectionIndexToHandle];
        }

        public bool AddProductDatabaseProductComponentElementUsing(in ProductComponentWithRegularSingleton otherProductDatabaseProductComponentElementToHandle)
        {
            if (ProductDatabaseProductComponentCollection == null)
            {
                return false;
            }

            if (otherProductDatabaseProductComponentElementToHandle == null)
            {
                return false;
            }

            ProductDatabaseProductComponentCollection.Add(item: otherProductDatabaseProductComponentElementToHandle);

            return true;
        }

        public bool RemoveProductDatabaseProductComponentElementUsing(in ProductComponentWithRegularSingleton otherProductDatabaseProductComponentElementToHandle)
        {
            if (ProductDatabaseProductComponentCollection == null)
            {
                return false;
            }

            if (otherProductDatabaseProductComponentElementToHandle == null)
            {
                return false;
            }

            if (ProductDatabaseProductComponentCollection.Contains(item: otherProductDatabaseProductComponentElementToHandle) == false)
            {
                return false;
            }

            return ProductDatabaseProductComponentCollection.Remove(item: otherProductDatabaseProductComponentElementToHandle);
        }
    }
}