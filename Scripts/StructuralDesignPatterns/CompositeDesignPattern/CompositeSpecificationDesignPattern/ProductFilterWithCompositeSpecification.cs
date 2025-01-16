namespace VisualStudio_DesignPatternsInCSharp.StructuralDesignPatterns.CompositeDesignPattern.CompositeSpecificationDesignPattern
{
    using System;
    using System.Collections.Generic;

    public static class ProductFilterWithCompositeSpecification
    {
        public static IEnumerable<ProductComponentWithCompositeSpecification> GetProductFilterAllProductComponentCombinationCollection()
        {
            foreach (ProductShapeLabelWithCompositeSpecification productFilterProductShapeLabelElement in Enum.GetValues(enumType: typeof(ProductShapeLabelWithCompositeSpecification)))
            {
                foreach (ProductSizeLabelWithCompositeSpecification productFilterProductSizeLabelElement in Enum.GetValues(enumType: typeof(ProductSizeLabelWithCompositeSpecification)))
                {
                    foreach (ProductMaterialLabelWithCompositeSpecification productFilterProductMaterialLabelElement in Enum.GetValues(enumType: typeof(ProductMaterialLabelWithCompositeSpecification)))
                    {
                        yield return new ProductComponentWithCompositeSpecification(otherProductComponentShapeLabelToHandle: productFilterProductShapeLabelElement, otherProductComponentSizeLabelToHandle: productFilterProductSizeLabelElement, otherProductComponentMaterialLabelToHandle: productFilterProductMaterialLabelElement);
                    }
                }
            }
        }

        public static IEnumerable<ProductComponentWithCompositeSpecification> GetProductFilterFilteredProductComponentCollectionUsing(IEnumerable<ProductComponentWithCompositeSpecification> otherProductFilterProductComponentCollectionToHandle, TemplateSpecificationWithCompositeSpecification<ProductComponentWithCompositeSpecification> otherProductFilterProductSpecificationToHandle)
        {
            foreach (ProductComponentWithCompositeSpecification otherProductFilterProductComponentElementToHandle in otherProductFilterProductComponentCollectionToHandle)
            {
                if (otherProductFilterProductSpecificationToHandle.CheckTemplateSpecificationIsValidUsing(otherTemplateSpecificationTemplateComponentToHandle: otherProductFilterProductComponentElementToHandle) == true)
                {
                    yield return otherProductFilterProductComponentElementToHandle;
                }
            }
        }
    }
}