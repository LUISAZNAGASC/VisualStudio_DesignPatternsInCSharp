namespace VisualStudio_DesignPatternsInCSharp.CreationalDesignPatterns.BuilderDesignPattern.StepwiseBuilderDesignPattern
{
    public interface IProductMaterialLabelDefinitionWithStepwiseBuilder
    {
        IProductComponentDefinitionWithStepwiseBuilder SetProductMaterialLabelDefinitionUsing(in ProductMaterialLabelWithStepwiseBuilder otherProductMaterialLabelDefinitionProductMaterialLabelToHandle);
    }
}