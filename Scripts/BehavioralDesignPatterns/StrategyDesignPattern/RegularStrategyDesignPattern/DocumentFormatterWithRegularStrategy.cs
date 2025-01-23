namespace VisualStudio_DesignPatternsInCSharp.Scripts.BehavioralDesignPatterns.StrategyDesignPattern.RegularStrategyDesignPattern
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
            Console.WriteLine(value: GetDocumentFormatterDocumentComponentContentUsing(otherDocumentFormatterDocumentComponentToHandle: otherDocumentFormatterDocumentComponentToHandle, otherDocumentFormatterDocumentComponentContentIndentLevelToHandle: uint.MinValue));
        }

        private void SetDocumentFormatterDocumentComponentOpenedIdentifierContentUsing(StringBuilder documentFormatterDocumentComponentContentStringBuilder, in DocumentComponentWithRegularStrategy otherDocumentFormatterDocumentComponentToHandle)
        {
            DocumentFormatterDocumentFormat.SetDocumentFormatDocumentComponentOpenedIdentifierContentUsing(documentFormatDocumentComponentContentStringBuilder: documentFormatterDocumentComponentContentStringBuilder, otherDocumentFormatDocumentComponentToHandle: otherDocumentFormatterDocumentComponentToHandle);
        }

        private void SetDocumentFormatterDocumentComponentClosedIdentifierContentUsing(StringBuilder documentFormatterDocumentComponentContentStringBuilder, in DocumentComponentWithRegularStrategy otherDocumentFormatterDocumentComponentToHandle)
        {
            DocumentFormatterDocumentFormat.SetDocumentFormatDocumentComponentClosedIdentifierContentUsing(documentFormatDocumentComponentContentStringBuilder: documentFormatterDocumentComponentContentStringBuilder, otherDocumentFormatDocumentComponentToHandle: otherDocumentFormatterDocumentComponentToHandle);
        }

        private void SetDocumentFormatterDocumentComponentDescriptionContentUsing(StringBuilder documentFormatterDocumentComponentContentStringBuilder, in DocumentComponentWithRegularStrategy otherDocumentFormatterDocumentComponentToHandle)
        {
            DocumentFormatterDocumentFormat.SetDocumentFormatDocumentComponentDescriptionContentUsing(documentFormatDocumentComponentContentStringBuilder: documentFormatterDocumentComponentContentStringBuilder, otherDocumentFormatDocumentComponentToHandle: otherDocumentFormatterDocumentComponentToHandle);
        }

        private static void SetDocumentFormatterDocumentComponentIndentContentUsing(StringBuilder documentFormatterDocumentComponentContentStringBuilder, in uint otherDocumentFormatterDocumentComponentContentIndentLevelToHandle = uint.MinValue)
        {
            const uint DocumentFormatterDocumentComponentContentIndentDimension = 5;
            const char DocumentFormatterDocumentComponentContentIndentCharacter = ' ';

            documentFormatterDocumentComponentContentStringBuilder.Append(value: new string(c: DocumentFormatterDocumentComponentContentIndentCharacter, count: (int)otherDocumentFormatterDocumentComponentContentIndentLevelToHandle * (int)DocumentFormatterDocumentComponentContentIndentDimension).ToUpperInvariant());
        }

        private StringBuilder GetDocumentFormatterDocumentComponentContentUsing(in DocumentComponentWithRegularStrategy otherDocumentFormatterDocumentComponentToHandle, in uint otherDocumentFormatterDocumentComponentContentIndentLevelToHandle = uint.MinValue)
        {
            StringBuilder documentFormatterDocumentComponentContentStringBuilder = new();

            SetDocumentFormatterDocumentComponentIndentContentUsing(documentFormatterDocumentComponentContentStringBuilder: documentFormatterDocumentComponentContentStringBuilder, otherDocumentFormatterDocumentComponentContentIndentLevelToHandle: otherDocumentFormatterDocumentComponentContentIndentLevelToHandle);
            SetDocumentFormatterDocumentComponentOpenedIdentifierContentUsing(documentFormatterDocumentComponentContentStringBuilder: documentFormatterDocumentComponentContentStringBuilder, otherDocumentFormatterDocumentComponentToHandle: otherDocumentFormatterDocumentComponentToHandle);
            documentFormatterDocumentComponentContentStringBuilder.AppendLine(value: string.Empty.ToUpperInvariant());

            if (string.IsNullOrEmpty(value: otherDocumentFormatterDocumentComponentToHandle.DocumentComponentDescription) == false || string.IsNullOrWhiteSpace(value: otherDocumentFormatterDocumentComponentToHandle.DocumentComponentDescription) == false)
            {
                SetDocumentFormatterDocumentComponentIndentContentUsing(documentFormatterDocumentComponentContentStringBuilder: documentFormatterDocumentComponentContentStringBuilder, otherDocumentFormatterDocumentComponentContentIndentLevelToHandle: otherDocumentFormatterDocumentComponentContentIndentLevelToHandle + 1);
                SetDocumentFormatterDocumentComponentDescriptionContentUsing(documentFormatterDocumentComponentContentStringBuilder: documentFormatterDocumentComponentContentStringBuilder, otherDocumentFormatterDocumentComponentToHandle: otherDocumentFormatterDocumentComponentToHandle);
                documentFormatterDocumentComponentContentStringBuilder.AppendLine(value: string.Empty.ToUpperInvariant());
            }

            foreach (DocumentComponentWithRegularStrategy otherDocumentFormatterDocumentComponentChildrenDocumentComponentElementToHandle in otherDocumentFormatterDocumentComponentToHandle.GetDocumentComponentChildrenDocumentComponentCollection())
            {
                documentFormatterDocumentComponentContentStringBuilder.Append(value: GetDocumentFormatterDocumentComponentContentUsing(otherDocumentFormatterDocumentComponentToHandle: otherDocumentFormatterDocumentComponentChildrenDocumentComponentElementToHandle, otherDocumentFormatterDocumentComponentContentIndentLevelToHandle: otherDocumentFormatterDocumentComponentContentIndentLevelToHandle + 1));
                documentFormatterDocumentComponentContentStringBuilder.AppendLine(value: string.Empty.ToUpperInvariant());
            }

            SetDocumentFormatterDocumentComponentIndentContentUsing(documentFormatterDocumentComponentContentStringBuilder: documentFormatterDocumentComponentContentStringBuilder, otherDocumentFormatterDocumentComponentContentIndentLevelToHandle: otherDocumentFormatterDocumentComponentContentIndentLevelToHandle);
            SetDocumentFormatterDocumentComponentClosedIdentifierContentUsing(documentFormatterDocumentComponentContentStringBuilder: documentFormatterDocumentComponentContentStringBuilder, otherDocumentFormatterDocumentComponentToHandle: otherDocumentFormatterDocumentComponentToHandle);
            documentFormatterDocumentComponentContentStringBuilder.Append(value: string.Empty.ToUpperInvariant());

            return documentFormatterDocumentComponentContentStringBuilder;
        }
    }
}