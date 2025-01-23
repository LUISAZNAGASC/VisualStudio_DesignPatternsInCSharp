namespace VisualStudio_DesignPatternsInCSharp.Scripts.BehavioralDesignPatterns.CommandDesignPattern.RegularCommandDesignPattern
{
    public sealed class ProductSizeCommandWithRegularCommand(in ProductComponentWithRegularCommand otherProductSizeCommandProductComponentToHandle, in ProductSizeLabelWithRegularCommand otherProductSizeCommandForwardProductSizeLabelToHandle) : TemplateCommandWithRegularCommand<ProductComponentWithRegularCommand>(otherTemplateCommandTemplateComponentToHandle: otherProductSizeCommandProductComponentToHandle)
    {
        private ProductSizeLabelWithRegularCommand ProductSizeCommandForwardProductSizeLabel { get; } = otherProductSizeCommandForwardProductSizeLabelToHandle;
        private ProductSizeLabelWithRegularCommand ProductSizeCommandBackwardProductSizeLabel { get; } = otherProductSizeCommandProductComponentToHandle.ProductComponentSizeLabel;

        public override void ExecuteTemplateCommandCallOperation()
        {
            if (TemplateCommandTemplateComponent == null)
            {
                return;
            }

            TemplateCommandTemplateComponent.SetProductComponentSizeLabelUsing(otherProductComponentSizeLabelToHandle: ProductSizeCommandForwardProductSizeLabel);
        }

        public override void ExecuteTemplateCommandUndoOperation()
        {
            if (TemplateCommandTemplateComponent == null)
            {
                return;
            }

            TemplateCommandTemplateComponent.SetProductComponentSizeLabelUsing(otherProductComponentSizeLabelToHandle: ProductSizeCommandBackwardProductSizeLabel);
        }
    }
}