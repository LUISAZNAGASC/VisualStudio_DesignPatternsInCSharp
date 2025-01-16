namespace VisualStudio_DesignPatternsInCSharp.BehavioralDesignPatterns.StrategyDesignPattern.RegularStrategyDesignPattern
{
    using System.Text;

    public sealed class TerminalDocumentFormatWithRegularStrategy : IDocumentFormatWithRegularStrategy
    {
        private TerminalDocumentFormatWithRegularStrategy() : base()
        {

        }

        public void SetDocumentFormatDocumentComponentContentOpenedIdentifierContentUsing(StringBuilder terminalDocumentFormatDocumentComponentContentStringBuilder, in DocumentComponentWithRegularStrategy otherTerminalDocumentFormatDocumentComponentToHandle)
        {
            terminalDocumentFormatDocumentComponentContentStringBuilder.Append(value: $"[>> $ {otherTerminalDocumentFormatDocumentComponentToHandle.DocumentComponentIdentifier.ToUpperInvariant()} $ >>]".ToUpperInvariant());
        }

        public void SetDocumentFormatDocumentComponentContentClosedIdentifierContentUsing(StringBuilder terminalDocumentFormatDocumentComponentContentStringBuilder, in DocumentComponentWithRegularStrategy otherTerminalDocumentFormatDocumentComponentToHandle)
        {
            terminalDocumentFormatDocumentComponentContentStringBuilder.Append(value: $"[<< $ {otherTerminalDocumentFormatDocumentComponentToHandle.DocumentComponentIdentifier.ToUpperInvariant()} $ <<]".ToUpperInvariant());
        }

        public void SetDocumentFormatDocumentComponentContentDescriptionContentUsing(StringBuilder terminalDocumentFormatDocumentComponentContentStringBuilder, in DocumentComponentWithRegularStrategy otherTerminalDocumentFormatDocumentComponentToHandle)
        {
            terminalDocumentFormatDocumentComponentContentStringBuilder.Append(value: $"[// $ {otherTerminalDocumentFormatDocumentComponentToHandle.DocumentComponentDescription.ToUpperInvariant()} $ //]".ToUpperInvariant());
        }
    }
}