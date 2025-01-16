namespace VisualStudio_DesignPatternsInCSharp.BehavioralDesignPatterns.StrategyDesignPattern.RegularStrategyDesignPattern
{
    using System.Text;

    public sealed class ContainerDocumentFormatWithRegularStrategy : IDocumentFormatWithRegularStrategy
    {
        private ContainerDocumentFormatWithRegularStrategy() : base()
        {

        }

        public void SetDocumentFormatDocumentComponentContentOpenedIdentifierContentUsing(StringBuilder containerDocumentFormatDocumentComponentContentStringBuilder, in DocumentComponentWithRegularStrategy otherContainerDocumentFormatDocumentComponentToHandle)
        {
            containerDocumentFormatDocumentComponentContentStringBuilder.Append(value: $"< {otherContainerDocumentFormatDocumentComponentToHandle.DocumentComponentIdentifier.ToUpperInvariant()} >".ToUpperInvariant());
        }

        public void SetDocumentFormatDocumentComponentContentClosedIdentifierContentUsing(StringBuilder containerDocumentFormatDocumentComponentContentStringBuilder, in DocumentComponentWithRegularStrategy otherContainerDocumentFormatDocumentComponentToHandle)
        {
            containerDocumentFormatDocumentComponentContentStringBuilder.Append(value: $"</ {otherContainerDocumentFormatDocumentComponentToHandle.DocumentComponentIdentifier.ToUpperInvariant()} >".ToUpperInvariant());
        }

        public void SetDocumentFormatDocumentComponentContentDescriptionContentUsing(StringBuilder containerDocumentFormatDocumentComponentContentStringBuilder, in DocumentComponentWithRegularStrategy otherContainerDocumentFormatDocumentComponentToHandle)
        {
            containerDocumentFormatDocumentComponentContentStringBuilder.Append(value: $"<!-- {otherContainerDocumentFormatDocumentComponentToHandle.DocumentComponentDescription.ToUpperInvariant()} -->".ToUpperInvariant());
        }
    }
}