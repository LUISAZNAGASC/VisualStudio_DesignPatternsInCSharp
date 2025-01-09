namespace VisualStudio_DesignPatternsInCSharp.BehavioralDesignPatterns.StrategyDesignPattern.RegularStrategyDesignPattern
{
    using System.Text;

    public sealed class TerminalDocumentFormatWithRegularStrategy : IDocumentFormatWithRegularStrategy
    {
        public void SetDocumentFormatDocumentComponentContentOpenedIdentifierContentUsing(StringBuilder terminalDocumentFormatDocumentComponentContentStringBuilder, in DocumentComponentWithRegularStrategy specificTerminalDocumentFormatDocumentComponentToHandle)
        {
            terminalDocumentFormatDocumentComponentContentStringBuilder.Append(value: $"[>> $ {specificTerminalDocumentFormatDocumentComponentToHandle.DocumentComponentIdentifier.ToUpperInvariant()} $ >>]".ToUpperInvariant());
        }

        public void SetDocumentFormatDocumentComponentContentClosedIdentifierContentUsing(StringBuilder terminalDocumentFormatDocumentComponentContentStringBuilder, in DocumentComponentWithRegularStrategy specificTerminalDocumentFormatDocumentComponentToHandle)
        {
            terminalDocumentFormatDocumentComponentContentStringBuilder.Append(value: $"[<< $ {specificTerminalDocumentFormatDocumentComponentToHandle.DocumentComponentIdentifier.ToUpperInvariant()} $ <<]".ToUpperInvariant());
        }

        public void SetDocumentFormatDocumentComponentContentDescriptionContentUsing(StringBuilder terminalDocumentFormatDocumentComponentContentStringBuilder, in DocumentComponentWithRegularStrategy specificTerminalDocumentFormatDocumentComponentToHandle)
        {
            terminalDocumentFormatDocumentComponentContentStringBuilder.Append(value: $"[// $ {specificTerminalDocumentFormatDocumentComponentToHandle.DocumentComponentDescription.ToUpperInvariant()} $ //]".ToUpperInvariant());
        }
    }
}