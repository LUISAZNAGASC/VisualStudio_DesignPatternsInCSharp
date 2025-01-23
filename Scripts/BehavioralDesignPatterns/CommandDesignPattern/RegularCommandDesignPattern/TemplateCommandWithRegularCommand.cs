namespace VisualStudio_DesignPatternsInCSharp.Scripts.BehavioralDesignPatterns.CommandDesignPattern.RegularCommandDesignPattern
{
    public abstract class TemplateCommandWithRegularCommand<TTemplateComponentWithRegularCommand>(in TTemplateComponentWithRegularCommand otherTemplateCommandTemplateComponentToHandle) : object() where TTemplateComponentWithRegularCommand : class
    {
        protected TTemplateComponentWithRegularCommand TemplateCommandTemplateComponent { get; set; } = otherTemplateCommandTemplateComponentToHandle;

        public abstract void ExecuteTemplateCommandCallOperation();

        public abstract void ExecuteTemplateCommandUndoOperation();
    }
}