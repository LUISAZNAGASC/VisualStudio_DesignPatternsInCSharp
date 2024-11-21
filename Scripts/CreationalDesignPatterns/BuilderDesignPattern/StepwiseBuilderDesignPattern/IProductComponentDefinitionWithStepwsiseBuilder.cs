namespace VisualStudio_DesignPatternsInCSharp.CreationalDesignPatterns.BuilderDesignPattern.StepwiseBuilderDesignPattern
{
    public interface IProductComponentDefinitionWithStepwiseBuilder
    {
        ProductComponentWithStepwiseBuilder GetProductComponentDefinition();
    }
}