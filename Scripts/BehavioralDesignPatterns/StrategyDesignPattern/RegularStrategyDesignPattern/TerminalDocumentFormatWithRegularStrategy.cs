namespace VisualStudio_DesignPatternsInCSharp.Scripts.BehavioralDesignPatterns.StrategyDesignPattern.RegularStrategyDesignPattern
{
    using System.Text;

    public sealed class TerminalDocumentFormatWithRegularStrategy : IDocumentFormatWithRegularStrategy
    {
        public TerminalDocumentFormatWithRegularStrategy() : base()
        {

        }

        public void SetDocumentFormatDocumentComponentOpenedIdentifierContentUsing(StringBuilder terminalDocumentFormatDocumentComponentContentStringBuilder, in DocumentComponentWithRegularStrategy otherTerminalDocumentFormatDocumentComponentToHandle)
        {
            terminalDocumentFormatDocumentComponentContentStringBuilder.Append(value: $"[>> $ {otherTerminalDocumentFormatDocumentComponentToHandle.DocumentComponentIdentifier.ToUpperInvariant()} $ >>]".ToUpperInvariant());
        }

        public void SetDocumentFormatDocumentComponentClosedIdentifierContentUsing(StringBuilder terminalDocumentFormatDocumentComponentContentStringBuilder, in DocumentComponentWithRegularStrategy otherTerminalDocumentFormatDocumentComponentToHandle)
        {
            terminalDocumentFormatDocumentComponentContentStringBuilder.Append(value: $"[<< $ {otherTerminalDocumentFormatDocumentComponentToHandle.DocumentComponentIdentifier.ToUpperInvariant()} $ <<]".ToUpperInvariant());
        }

        public void SetDocumentFormatDocumentComponentDescriptionContentUsing(StringBuilder terminalDocumentFormatDocumentComponentContentStringBuilder, in DocumentComponentWithRegularStrategy otherTerminalDocumentFormatDocumentComponentToHandle)
        {
            terminalDocumentFormatDocumentComponentContentStringBuilder.Append(value: $"[// $ {otherTerminalDocumentFormatDocumentComponentToHandle.DocumentComponentDescription.ToUpperInvariant()} $ //]".ToUpperInvariant());
        }
    }
}