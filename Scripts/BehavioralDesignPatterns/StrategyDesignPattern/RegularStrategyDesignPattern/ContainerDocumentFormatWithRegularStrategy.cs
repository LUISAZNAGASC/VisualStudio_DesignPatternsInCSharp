namespace VisualStudio_DesignPatternsInCSharp.BehavioralDesignPatterns.StrategyDesignPattern.RegularStrategyDesignPattern
{
    using System.Text;

    public sealed class ContainerDocumentFormatWithRegularStrategy : IDocumentFormatWithRegularStrategy
    {
        public void SetDocumentFormatDocumentComponentContentOpenedIdentifierContentUsing(StringBuilder containerDocumentFormatDocumentComponentContentStringBuilder, in DocumentComponentWithRegularStrategy specificContainerDocumentFormatDocumentComponentToHandle)
        {
            containerDocumentFormatDocumentComponentContentStringBuilder.Append(value: $"< {specificContainerDocumentFormatDocumentComponentToHandle.DocumentComponentIdentifier.ToUpperInvariant()} >".ToUpperInvariant());
        }

        public void SetDocumentFormatDocumentComponentContentClosedIdentifierContentUsing(StringBuilder containerDocumentFormatDocumentComponentContentStringBuilder, in DocumentComponentWithRegularStrategy specificContainerDocumentFormatDocumentComponentToHandle)
        {
            containerDocumentFormatDocumentComponentContentStringBuilder.Append(value: $"</ {specificContainerDocumentFormatDocumentComponentToHandle.DocumentComponentIdentifier.ToUpperInvariant()} >".ToUpperInvariant());
        }

        public void SetDocumentFormatDocumentComponentContentDescriptionContentUsing(StringBuilder containerDocumentFormatDocumentComponentContentStringBuilder, in DocumentComponentWithRegularStrategy specificContainerDocumentFormatDocumentComponentToHandle)
        {
            containerDocumentFormatDocumentComponentContentStringBuilder.Append(value: $"<!-- {specificContainerDocumentFormatDocumentComponentToHandle.DocumentComponentDescription.ToUpperInvariant()} -->".ToUpperInvariant());
        }
    }
}