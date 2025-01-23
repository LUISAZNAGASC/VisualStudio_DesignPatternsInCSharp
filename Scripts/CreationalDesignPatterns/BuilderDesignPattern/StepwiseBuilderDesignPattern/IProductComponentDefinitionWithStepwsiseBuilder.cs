namespace VisualStudio_DesignPatternsInCSharp.Scripts.CreationalDesignPatterns.BuilderDesignPattern.StepwiseBuilderDesignPattern
{
    public interface IProductComponentDefinitionWithStepwiseBuilder
    {
        ProductComponentWithStepwiseBuilder GetProductComponentDefinition();
    }
}