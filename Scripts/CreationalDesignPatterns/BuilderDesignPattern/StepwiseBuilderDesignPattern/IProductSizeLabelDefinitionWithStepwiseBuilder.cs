namespace VisualStudio_DesignPatternsInCSharp.Scripts.CreationalDesignPatterns.BuilderDesignPattern.StepwiseBuilderDesignPattern
{
    public interface IProductSizeLabelDefinitionWithStepwiseBuilder
    {
        IProductMaterialLabelDefinitionWithStepwiseBuilder SetProductSizeLabelDefinitionUsing(in ProductSizeLabelWithStepwiseBuilder otherProductSizeLabelDefinitionProductSizeLabelToHandle);
    }
}