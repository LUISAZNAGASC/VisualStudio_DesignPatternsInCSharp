namespace VisualStudio_DesignPatternsInCSharp.BehavioralDesignPatterns.StrategyDesignPattern.RegularStrategyDesignPattern
{
    using System;
    using System.Text;

    public sealed class DocumentFormatterWithRegularStrategy<TDocumentFormatWithRegularStrategy> where TDocumentFormatWithRegularStrategy : IDocumentFormatWithRegularStrategy, new()
    {
        private TDocumentFormatWithRegularStrategy DocumentFormatterDocumentFormat { get; }

        public DocumentFormatterWithRegularStrategy() : base()
        {
            DocumentFormatterDocumentFormat = new TDocumentFormatWithRegularStrategy();
        }

        public void DisplayDocumentFormatterDocumentComponentContentUsing(in DocumentComponentWithRegularStrategy otherDocumentFormatterDocumentComponentToHandle)
        {
            Console.WriteLine(value: GetDocumentFormatterDocumentComponentContentUsing(otherDocumentFormatterToHandle: this, otherDocumentFormatterDocumentComponentToHandle: otherDocumentFormatterDocumentComponentToHandle, otherDocumentFormatterDocumentComponentContentIndentLevelToHandle: uint.MinValue));
        }

        private void SetDocumentFormatterDocumentComponentContentOpenedIdentifierContentUsing(StringBuilder documentFormatterDocumentComponentContentStringBuilder, in DocumentComponentWithRegularStrategy otherDocumentFormatterDocumentComponentToHandle)
        {
            DocumentFormatterDocumentFormat.SetDocumentFormatDocumentComponentContentOpenedIdentifierContentUsing(documentFormatDocumentComponentContentStringBuilder: documentFormatterDocumentComponentContentStringBuilder, otherDocumentFormatDocumentComponentToHandle: otherDocumentFormatterDocumentComponentToHandle);
        }

        private void SetDocumentFormatterDocumentComponentContentClosedIdentifierContentUsing(StringBuilder documentFormatterDocumentComponentContentStringBuilder, in DocumentComponentWithRegularStrategy otherDocumentFormatterDocumentComponentToHandle)
        {
            DocumentFormatterDocumentFormat.SetDocumentFormatDocumentComponentContentClosedIdentifierContentUsing(documentFormatDocumentComponentContentStringBuilder: documentFormatterDocumentComponentContentStringBuilder, otherDocumentFormatDocumentComponentToHandle: otherDocumentFormatterDocumentComponentToHandle);
        }

        private void SetDocumentFormatterDocumentComponentContentDescriptionContentUsing(StringBuilder documentFormatterDocumentComponentContentStringBuilder, in DocumentComponentWithRegularStrategy otherDocumentFormatterDocumentComponentToHandle)
        {
            DocumentFormatterDocumentFormat.SetDocumentFormatDocumentComponentContentDescriptionContentUsing(documentFormatDocumentComponentContentStringBuilder: documentFormatterDocumentComponentContentStringBuilder, otherDocumentFormatDocumentComponentToHandle: otherDocumentFormatterDocumentComponentToHandle);
        }

        private void SetDocumentFormatterDocumentComponentContentIndentContentUsing(StringBuilder documentFormatterDocumentComponentContentStringBuilder, in uint otherDocumentFormatterDocumentComponentContentIndentLevelToHandle = uint.MinValue)
        {
            const uint DocumentFormatterDocumentComponentContentIndentDimension = 5;
            const char DocumentFormatterDocumentComponentContentIndentCharacter = ' ';

            documentFormatterDocumentComponentContentStringBuilder.Append(value: new string(c: DocumentFormatterDocumentComponentContentIndentCharacter, count: (int)otherDocumentFormatterDocumentComponentContentIndentLevelToHandle * (int)DocumentFormatterDocumentComponentContentIndentDimension).ToUpperInvariant());
        }

        private StringBuilder GetDocumentFormatterDocumentComponentContentUsing(in DocumentComponentWithRegularStrategy otherDocumentFormatterDocumentComponentToHandle, in uint otherDocumentFormatterDocumentComponentContentIndentLevelToHandle = uint.MinValue)
        {
            StringBuilder documentFormatterDocumentComponentContentStringBuilder = new();

            SetDocumentFormatterDocumentComponentContentIndentContentUsing(documentFormatterDocumentComponentContentStringBuilder: documentFormatterDocumentComponentContentStringBuilder, otherDocumentFormatterDocumentComponentContentIndentLevelToHandle: otherDocumentFormatterDocumentComponentContentIndentLevelToHandle);
            SetDocumentFormatterDocumentComponentContentOpenedIdentifierContentUsing(documentFormatterDocumentComponentContentStringBuilder: documentFormatterDocumentComponentContentStringBuilder, otherDocumentFormatterDocumentComponentToHandle: otherDocumentFormatterDocumentComponentToHandle);
            documentFormatterDocumentComponentContentStringBuilder.AppendLine();

            if (string.IsNullOrEmpty(value: otherDocumentFormatterDocumentComponentToHandle.DocumentComponentDescription) == false || string.IsNullOrWhiteSpace(value: otherDocumentFormatterDocumentComponentToHandle.DocumentComponentDescription) == false)
            {
                SetDocumentFormatterDocumentComponentContentIndentContentUsing(documentFormatterDocumentComponentContentStringBuilder: documentFormatterDocumentComponentContentStringBuilder, otherDocumentFormatterDocumentComponentContentIndentLevelToHandle: otherDocumentFormatterDocumentComponentContentIndentLevelToHandle + 1);
                SetDocumentFormatterDocumentComponentContentDescriptionContentUsing(documentFormatterDocumentComponentContentStringBuilder: documentFormatterDocumentComponentContentStringBuilder, otherDocumentFormatterDocumentComponentToHandle: otherDocumentFormatterDocumentComponentToHandle);
                documentFormatterDocumentComponentContentStringBuilder.AppendLine();
            }

            foreach (DocumentComponentWithRegularStrategy otherDocumentFormatterDocumentComponentChildrenDocumentComponentElementToHandle in otherDocumentFormatterDocumentComponentToHandle.GetDocumentComponentChildrenDocumentComponentCollection())
            {
                documentFormatterDocumentComponentContentStringBuilder.Append(value: GetDocumentFormatterDocumentComponentContentUsing(otherDocumentFormatterToHandle: this, otherDocumentFormatterDocumentComponentToHandle: otherDocumentFormatterDocumentComponentChildrenDocumentComponentElementToHandle, otherDocumentFormatterDocumentComponentContentIndentLevelToHandle: otherDocumentFormatterDocumentComponentContentIndentLevelToHandle + 1));
                documentFormatterDocumentComponentContentStringBuilder.AppendLine();
            }

            SetDocumentFormatterDocumentComponentContentIndentContentUsing(documentFormatterDocumentComponentContentStringBuilder: documentFormatterDocumentComponentContentStringBuilder, otherDocumentFormatterDocumentComponentContentIndentLevelToHandle: otherDocumentFormatterDocumentComponentContentIndentLevelToHandle);
            SetDocumentFormatterDocumentComponentContentClosedIdentifierContentUsing(documentFormatterDocumentComponentContentStringBuilder: documentFormatterDocumentComponentContentStringBuilder, otherDocumentFormatterDocumentComponentToHandle: otherDocumentFormatterDocumentComponentToHandle);

            return documentFormatterDocumentComponentContentStringBuilder;
        }

        private static StringBuilder GetDocumentFormatterDocumentComponentContentUsing(in DocumentFormatterWithRegularStrategy<TDocumentFormatWithRegularStrategy> otherDocumentFormatterToHandle, in DocumentComponentWithRegularStrategy otherDocumentFormatterDocumentComponentToHandle, in uint otherDocumentFormatterDocumentComponentContentIndentLevelToHandle = uint.MinValue)
        {
            StringBuilder documentFormatterDocumentComponentContentStringBuilder = new();

            documentFormatterDocumentComponentContentStringBuilder.Append(value: otherDocumentFormatterToHandle.GetDocumentFormatterDocumentComponentContentUsing(otherDocumentFormatterDocumentComponentToHandle: otherDocumentFormatterDocumentComponentToHandle, otherDocumentFormatterDocumentComponentContentIndentLevelToHandle: otherDocumentFormatterDocumentComponentContentIndentLevelToHandle));

            return documentFormatterDocumentComponentContentStringBuilder;
        }
    }
}