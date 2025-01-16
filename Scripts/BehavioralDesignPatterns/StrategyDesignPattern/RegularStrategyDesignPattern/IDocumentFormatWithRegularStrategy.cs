﻿namespace VisualStudio_DesignPatternsInCSharp.BehavioralDesignPatterns.StrategyDesignPattern.RegularStrategyDesignPattern
{
    using System.Text;

    public interface IDocumentFormatWithRegularStrategy
    {
        void SetDocumentFormatDocumentComponentContentOpenedIdentifierContentUsing(StringBuilder documentFormatDocumentComponentContentStringBuilder, in DocumentComponentWithRegularStrategy otherDocumentFormatDocumentComponentToHandle);

        void SetDocumentFormatDocumentComponentContentClosedIdentifierContentUsing(StringBuilder documentFormatDocumentComponentContentStringBuilder, in DocumentComponentWithRegularStrategy otherDocumentFormatDocumentComponentToHandle);

        void SetDocumentFormatDocumentComponentContentDescriptionContentUsing(StringBuilder documentFormatDocumentComponentContentStringBuilder, in DocumentComponentWithRegularStrategy otherDocumentFormatDocumentComponentToHandle);
    }
}