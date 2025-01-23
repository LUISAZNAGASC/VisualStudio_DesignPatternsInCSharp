namespace VisualStudio_DesignPatternsInCSharp.Scripts.BehavioralDesignPatterns.StrategyDesignPattern.RegularStrategyDesignPattern
{
    using System.Text;

    public interface IDocumentFormatWithRegularStrategy
    {
        void SetDocumentFormatDocumentComponentOpenedIdentifierContentUsing(StringBuilder documentFormatDocumentComponentContentStringBuilder, in DocumentComponentWithRegularStrategy otherDocumentFormatDocumentComponentToHandle);

        void SetDocumentFormatDocumentComponentClosedIdentifierContentUsing(StringBuilder documentFormatDocumentComponentContentStringBuilder, in DocumentComponentWithRegularStrategy otherDocumentFormatDocumentComponentToHandle);

        void SetDocumentFormatDocumentComponentDescriptionContentUsing(StringBuilder documentFormatDocumentComponentContentStringBuilder, in DocumentComponentWithRegularStrategy otherDocumentFormatDocumentComponentToHandle);
    }
}