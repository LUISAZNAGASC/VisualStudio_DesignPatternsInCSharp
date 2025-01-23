namespace VisualStudio_DesignPatternsInCSharp.Scripts.BehavioralDesignPatterns.StrategyDesignPattern.RegularStrategyDesignPattern
{
    using System.Text;

    public sealed class ContainerDocumentFormatWithRegularStrategy : IDocumentFormatWithRegularStrategy
    {
        public ContainerDocumentFormatWithRegularStrategy() : base()
        {

        }

        public void SetDocumentFormatDocumentComponentOpenedIdentifierContentUsing(StringBuilder containerDocumentFormatDocumentComponentContentStringBuilder, in DocumentComponentWithRegularStrategy otherContainerDocumentFormatDocumentComponentToHandle)
        {
            containerDocumentFormatDocumentComponentContentStringBuilder.Append(value: $"< {otherContainerDocumentFormatDocumentComponentToHandle.DocumentComponentIdentifier.ToUpperInvariant()} >".ToUpperInvariant());
        }

        public void SetDocumentFormatDocumentComponentClosedIdentifierContentUsing(StringBuilder containerDocumentFormatDocumentComponentContentStringBuilder, in DocumentComponentWithRegularStrategy otherContainerDocumentFormatDocumentComponentToHandle)
        {
            containerDocumentFormatDocumentComponentContentStringBuilder.Append(value: $"</ {otherContainerDocumentFormatDocumentComponentToHandle.DocumentComponentIdentifier.ToUpperInvariant()} >".ToUpperInvariant());
        }

        public void SetDocumentFormatDocumentComponentDescriptionContentUsing(StringBuilder containerDocumentFormatDocumentComponentContentStringBuilder, in DocumentComponentWithRegularStrategy otherContainerDocumentFormatDocumentComponentToHandle)
        {
            containerDocumentFormatDocumentComponentContentStringBuilder.Append(value: $"<!-- {otherContainerDocumentFormatDocumentComponentToHandle.DocumentComponentDescription.ToUpperInvariant()} -->".ToUpperInvariant());
        }
    }
}