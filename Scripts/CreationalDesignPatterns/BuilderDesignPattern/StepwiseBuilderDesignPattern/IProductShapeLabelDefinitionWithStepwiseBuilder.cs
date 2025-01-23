namespace VisualStudio_DesignPatternsInCSharp.Scripts.CreationalDesignPatterns.BuilderDesignPattern.StepwiseBuilderDesignPattern
{
    public interface IProductShapeLabelDefinitionWithStepwiseBuilder
    {
        IProductSizeLabelDefinitionWithStepwiseBuilder SetProductShapeLabelDefinitionUsing(in ProductShapeLabelWithStepwiseBuilder otherProductShapeLabelDefinitionProductShapeLabelToHandle);
    }
}