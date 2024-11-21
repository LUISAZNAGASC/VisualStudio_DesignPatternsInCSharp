namespace VisualStudio_DesignPatternsInCSharp.CreationalDesignPatterns.BuilderDesignPattern.StepwiseBuilderDesignPattern
{
    public interface IProductSizeLabelDefinitionWithStepwiseBuilder
    {
        IProductMaterialLabelDefinitionWithStepwiseBuilder SetProductSizeLabelDefinitionUsing(in ProductSizeLabelWithStepwiseBuilder newProductSizeLabelDefinitionProductSizeLabelToDefine);
    }
}