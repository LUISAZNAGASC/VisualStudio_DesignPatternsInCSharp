namespace VisualStudio_DesignPatternsInCSharp.Scripts.BehavioralDesignPatterns.CommandDesignPattern.RegularCommandDesignPattern
{
    public sealed class ProductMaterialCommandWithRegularCommand(in ProductComponentWithRegularCommand otherProductMaterialCommandProductComponentToHandle, in ProductMaterialLabelWithRegularCommand otherProductMaterialCommandForwardProductMaterialLabelToHandle) : TemplateCommandWithRegularCommand<ProductComponentWithRegularCommand>(otherTemplateCommandTemplateComponentToHandle: otherProductMaterialCommandProductComponentToHandle)
    {
        private ProductMaterialLabelWithRegularCommand ProductMaterialCommandForwardProductMaterialLabel { get; } = otherProductMaterialCommandForwardProductMaterialLabelToHandle;
        private ProductMaterialLabelWithRegularCommand ProductMaterialCommandBackwardProductMaterialLabel { get; } = otherProductMaterialCommandProductComponentToHandle.ProductComponentMaterialLabel;

        public override void ExecuteTemplateCommandCallOperation()
        {
            if (TemplateCommandTemplateComponent == null)
            {
                return;
            }

            TemplateCommandTemplateComponent.SetProductComponentMaterialLabelUsing(otherProductComponentMaterialLabelToHandle: ProductMaterialCommandForwardProductMaterialLabel);
        }

        public override void ExecuteTemplateCommandUndoOperation()
        {
            if (TemplateCommandTemplateComponent == null)
            {
                return;
            }

            TemplateCommandTemplateComponent.SetProductComponentMaterialLabelUsing(otherProductComponentMaterialLabelToHandle: ProductMaterialCommandBackwardProductMaterialLabel);
        }
    }
}