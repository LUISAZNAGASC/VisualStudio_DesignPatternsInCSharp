namespace VisualStudio_DesignPatternsInCSharp.StructuralDesignPatterns.CompositeDesignPattern.CompositeSpecificationDesignPattern
{
    using System;
    using System.Collections.Generic;

    public static class ProductFilterWithCompositeSpecification
    {
        public static IEnumerable<ProductComponentWithCompositeSpecification> GetProductFilterAllProductComponentCombinationCollection()
        {
            foreach (ProductShapeLabelWithCompositeSpecification currentProductFilterProductShapeLabelToRead in Enum.GetValues(enumType: typeof(ProductShapeLabelWithCompositeSpecification)))
            {
                foreach (ProductSizeLabelWithCompositeSpecification currentProductFilterProductSizeLabelToRead in Enum.GetValues(enumType: typeof(ProductSizeLabelWithCompositeSpecification)))
                {
                    foreach (ProductMaterialLabelWithCompositeSpecification currentProductFilterProductMaterialLabelToRead in Enum.GetValues(enumType: typeof(ProductMaterialLabelWithCompositeSpecification)))
                    {
                        yield return new ProductComponentWithCompositeSpecification(newProductComponentShapeLabelToInitialize: currentProductFilterProductShapeLabelToRead, newProductComponentSizeLabelToInitialize: currentProductFilterProductSizeLabelToRead, newProductComponentMaterialLabelToInitialize: currentProductFilterProductMaterialLabelToRead); ;
                    }
                }
            }
        }

        public static IEnumerable<ProductComponentWithCompositeSpecification> GetProductFilterFilteredProductComponentCollectionUsing(IEnumerable<ProductComponentWithCompositeSpecification> specificProductFilterProductComponentCollectionToFilter, TemplateSpecificationWithCompositeSpecification<ProductComponentWithCompositeSpecification> specificProductFilterProductSpecificationToFilter)
        {
            foreach (ProductComponentWithCompositeSpecification specificProductFilterProductComponentElementToFilter in specificProductFilterProductComponentCollectionToFilter)
            {
                if (specificProductFilterProductSpecificationToFilter.CheckTemplateSpecificationIsValidUsing(specificTemplateSpecificationTemplateComponentToCheck: specificProductFilterProductComponentElementToFilter) == true)
                {
                    yield return specificProductFilterProductComponentElementToFilter;
                }
            }
        }
    }
}