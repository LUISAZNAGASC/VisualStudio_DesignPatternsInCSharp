namespace VisualStudio_DesignPatternsInCSharp.CreationalDesignPatterns.BuilderDesignPattern.StepwiseBuilderDesignPattern
{
    public interface IProductShapeLabelDefinitionWithStepwiseBuilder
    {
        IProductSizeLabelDefinitionWithStepwiseBuilder SetProductShapeLabelDefinitionUsing(in ProductShapeLabelWithStepwiseBuilder otherProductShapeLabelDefinitionProductShapeLabelToHandle);
    }
}