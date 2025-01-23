namespace VisualStudio_DesignPatternsInCSharp.Scripts.CreationalDesignPatterns.BuilderDesignPattern.StepwiseBuilderDesignPattern
{
    public interface IProductMaterialLabelDefinitionWithStepwiseBuilder
    {
        IProductComponentDefinitionWithStepwiseBuilder SetProductMaterialLabelDefinitionUsing(in ProductMaterialLabelWithStepwiseBuilder otherProductMaterialLabelDefinitionProductMaterialLabelToHandle);
    }
}