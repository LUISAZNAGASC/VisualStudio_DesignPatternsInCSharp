namespace VisualStudio_DesignPatternsInCSharp.Scripts.BehavioralDesignPatterns.CommandDesignPattern.RegularCommandDesignPattern
{
    using System.Collections.Generic;

    public sealed class TemplateCommandInvokerWithRegularCommand<TTemplateComponentWithRegularCommand> where TTemplateComponentWithRegularCommand : class
    {
        private Stack<TemplateCommandWithRegularCommand<TTemplateComponentWithRegularCommand>> TemplateCommandInvokerTemplateCommandCallStack { get; set; }
        private Stack<TemplateCommandWithRegularCommand<TTemplateComponentWithRegularCommand>> TemplateCommandInvokerTemplateCommandUndoStack { get; set; }

        public TemplateCommandInvokerWithRegularCommand() : base()
        {
            TemplateCommandInvokerTemplateCommandCallStack = new Stack<TemplateCommandWithRegularCommand<TTemplateComponentWithRegularCommand>>();
            TemplateCommandInvokerTemplateCommandUndoStack = new Stack<TemplateCommandWithRegularCommand<TTemplateComponentWithRegularCommand>>();
        }

        public void AddTemplateCommandInvokerTemplateCommandElementUsing(in TemplateCommandWithRegularCommand<TTemplateComponentWithRegularCommand> otherTemplateCommandInvokerTemplateCommandElementToHandle)
        {
            otherTemplateCommandInvokerTemplateCommandElementToHandle.ExecuteTemplateCommandCallOperation();

            TemplateCommandInvokerTemplateCommandCallStack.Clear();
            TemplateCommandInvokerTemplateCommandUndoStack.Push(item: otherTemplateCommandInvokerTemplateCommandElementToHandle);
        }

        public void ExecuteTemplateCommandInvokerCallOperation()
        {
            if (TemplateCommandInvokerTemplateCommandCallStack.Count <= uint.MinValue)
            {
                return;
            }

            TemplateCommandWithRegularCommand<TTemplateComponentWithRegularCommand> templateCommandInvokerTemplateCommand = TemplateCommandInvokerTemplateCommandCallStack.Pop();

            templateCommandInvokerTemplateCommand.ExecuteTemplateCommandCallOperation();

            TemplateCommandInvokerTemplateCommandUndoStack.Push(item: templateCommandInvokerTemplateCommand);
        }

        public void ExecuteTemplateCommandInvokerUndoOperation()
        {
            if (TemplateCommandInvokerTemplateCommandUndoStack.Count <= uint.MinValue)
            {
                return;
            }

            TemplateCommandWithRegularCommand<TTemplateComponentWithRegularCommand> templateCommandInvokerTemplateCommand = TemplateCommandInvokerTemplateCommandUndoStack.Pop();

            templateCommandInvokerTemplateCommand.ExecuteTemplateCommandUndoOperation();

            TemplateCommandInvokerTemplateCommandCallStack.Push(item: templateCommandInvokerTemplateCommand);
        }
    }
}