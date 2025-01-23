namespace VisualStudio_DesignPatternsInCSharp.Scripts.BehavioralDesignPatterns.CommandDesignPattern.RegularCommandDesignPattern
{
    public sealed class ProductShapeCommandWithRegularCommand(in ProductComponentWithRegularCommand otherProductShapeCommandProductComponentToHandle, in ProductShapeLabelWithRegularCommand otherProductShapeCommandForwardProductShapeLabelToHandle) : TemplateCommandWithRegularCommand<ProductComponentWithRegularCommand>(otherTemplateCommandTemplateComponentToHandle: otherProductShapeCommandProductComponentToHandle)
    {
        private ProductShapeLabelWithRegularCommand ProductShapeCommandForwardProductShapeLabel { get; } = otherProductShapeCommandForwardProductShapeLabelToHandle;
        private ProductShapeLabelWithRegularCommand ProductShapeCommandBackwardProductShapeLabel { get; } = otherProductShapeCommandProductComponentToHandle.ProductComponentShapeLabel;

        public override void ExecuteTemplateCommandCallOperation()
        {
            if (TemplateCommandTemplateComponent == null)
            {
                return;
            }

            TemplateCommandTemplateComponent.SetProductComponentShapeLabelUsing(otherProductComponentShapeLabelToHandle: ProductShapeCommandForwardProductShapeLabel);
        }

        public override void ExecuteTemplateCommandUndoOperation()
        {
            if (TemplateCommandTemplateComponent == null)
            {
                return;
            }

            TemplateCommandTemplateComponent.SetProductComponentShapeLabelUsing(otherProductComponentShapeLabelToHandle: ProductShapeCommandBackwardProductShapeLabel);
        }
    }
}