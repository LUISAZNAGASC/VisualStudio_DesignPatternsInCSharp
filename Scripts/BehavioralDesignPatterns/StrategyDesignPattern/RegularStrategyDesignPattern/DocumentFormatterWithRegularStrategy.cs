namespace VisualStudio_DesignPatternsInCSharp.BehavioralDesignPatterns.StrategyDesignPattern.RegularStrategyDesignPattern
{
    using System;
    using System.Text;

    public sealed class DocumentFormatterWithRegularStrategy<TDocumentFormatWithRegularStrategy> where TDocumentFormatWithRegularStrategy : IDocumentFormatWithRegularStrategy, new()
    {
        private TDocumentFormatWithRegularStrategy DocumentFormatterDocumentFormat { get; set; }

        public DocumentFormatterWithRegularStrategy() : base()
        {
            DocumentFormatterDocumentFormat = new TDocumentFormatWithRegularStrategy();
        }

        public void DisplayDocumentFormatterDocumentComponentContentUsing(in DocumentComponentWithRegularStrategy specificDocumentFormatterDocumentComponentToDisplay)
        {
            Console.WriteLine(value: GetDocumentFormatterDocumentComponentContentUsing(specificDocumentFormatterToHandle: this, specificDocumentFormatterDocumentComponentToHandle: specificDocumentFormatterDocumentComponentToDisplay, specificDocumentFormatterDocumentComponentContentIndentLevelToHandle: uint.MinValue));
        }

        private void SetDocumentFormatterDocumentComponentContentOpenedIdentifierContentUsing(StringBuilder documentFormatterDocumentComponentContentStringBuilder, in DocumentComponentWithRegularStrategy specificDocumentFormatterDocumentComponentToHandle)
        {
            DocumentFormatterDocumentFormat.SetDocumentFormatDocumentComponentContentOpenedIdentifierContentUsing(documentFormatDocumentComponentContentStringBuilder: documentFormatterDocumentComponentContentStringBuilder, specificDocumentFormatDocumentComponentToHandle: specificDocumentFormatterDocumentComponentToHandle);
        }

        private void SetDocumentFormatterDocumentComponentContentClosedIdentifierContentUsing(StringBuilder documentFormatterDocumentComponentContentStringBuilder, in DocumentComponentWithRegularStrategy specificDocumentFormatterDocumentComponentToHandle)
        {
            DocumentFormatterDocumentFormat.SetDocumentFormatDocumentComponentContentClosedIdentifierContentUsing(documentFormatDocumentComponentContentStringBuilder: documentFormatterDocumentComponentContentStringBuilder, specificDocumentFormatDocumentComponentToHandle: specificDocumentFormatterDocumentComponentToHandle);
        }

        private void SetDocumentFormatterDocumentComponentContentDescriptionContentUsing(StringBuilder documentFormatterDocumentComponentContentStringBuilder, in DocumentComponentWithRegularStrategy specificDocumentFormatterDocumentComponentToHandle)
        {
            DocumentFormatterDocumentFormat.SetDocumentFormatDocumentComponentContentDescriptionContentUsing(documentFormatDocumentComponentContentStringBuilder: documentFormatterDocumentComponentContentStringBuilder, specificDocumentFormatDocumentComponentToHandle: specificDocumentFormatterDocumentComponentToHandle);
        }

        private void SetDocumentFormatterDocumentComponentContentIndentContentUsing(StringBuilder documentFormatterDocumentComponentContentStringBuilder, in uint specificDocumentFormatterDocumentComponentContentIndentLevelToHandle = uint.MinValue)
        {
            const uint DocumentFormatterDocumentComponentContentIndentDimension = 5;
            const char DocumentFormatterDocumentComponentContentIndentCharacter = ' ';

            documentFormatterDocumentComponentContentStringBuilder.Append(value: new string(c: DocumentFormatterDocumentComponentContentIndentCharacter, count: (int)specificDocumentFormatterDocumentComponentContentIndentLevelToHandle * (int)DocumentFormatterDocumentComponentContentIndentDimension).ToUpperInvariant());
        }

        private StringBuilder GetDocumentFormatterDocumentComponentContentUsing(in DocumentComponentWithRegularStrategy specificDocumentFormatterDocumentComponentToHandle, in uint specificDocumentFormatterDocumentComponentContentIndentLevelToHandle = uint.MinValue)
        {
            StringBuilder documentFormatterDocumentComponentContentStringBuilder = new();

            SetDocumentFormatterDocumentComponentContentIndentContentUsing(documentFormatterDocumentComponentContentStringBuilder: documentFormatterDocumentComponentContentStringBuilder, specificDocumentFormatterDocumentComponentContentIndentLevelToHandle: specificDocumentFormatterDocumentComponentContentIndentLevelToHandle);
            SetDocumentFormatterDocumentComponentContentOpenedIdentifierContentUsing(documentFormatterDocumentComponentContentStringBuilder: documentFormatterDocumentComponentContentStringBuilder, specificDocumentFormatterDocumentComponentToHandle: specificDocumentFormatterDocumentComponentToHandle);
            documentFormatterDocumentComponentContentStringBuilder.AppendLine();

            if (string.IsNullOrEmpty(value: specificDocumentFormatterDocumentComponentToHandle.DocumentComponentDescription) == false || string.IsNullOrWhiteSpace(value: specificDocumentFormatterDocumentComponentToHandle.DocumentComponentDescription) == false)
            {
                SetDocumentFormatterDocumentComponentContentIndentContentUsing(documentFormatterDocumentComponentContentStringBuilder: documentFormatterDocumentComponentContentStringBuilder, specificDocumentFormatterDocumentComponentContentIndentLevelToHandle: specificDocumentFormatterDocumentComponentContentIndentLevelToHandle + 1);
                SetDocumentFormatterDocumentComponentContentDescriptionContentUsing(documentFormatterDocumentComponentContentStringBuilder: documentFormatterDocumentComponentContentStringBuilder, specificDocumentFormatterDocumentComponentToHandle: specificDocumentFormatterDocumentComponentToHandle);
                documentFormatterDocumentComponentContentStringBuilder.AppendLine();
            }

            foreach (DocumentComponentWithRegularStrategy specificDocumentFormatterDocumentComponentChildrenDocumentComponentElement in specificDocumentFormatterDocumentComponentToHandle.GetDocumentComponentChildrenDocumentComponentCollection())
            {
                documentFormatterDocumentComponentContentStringBuilder.Append(value: GetDocumentFormatterDocumentComponentContentUsing(specificDocumentFormatterToHandle: this, specificDocumentFormatterDocumentComponentToHandle: specificDocumentFormatterDocumentComponentChildrenDocumentComponentElement, specificDocumentFormatterDocumentComponentContentIndentLevelToHandle: specificDocumentFormatterDocumentComponentContentIndentLevelToHandle + 1));
                documentFormatterDocumentComponentContentStringBuilder.AppendLine();
            }

            SetDocumentFormatterDocumentComponentContentIndentContentUsing(documentFormatterDocumentComponentContentStringBuilder: documentFormatterDocumentComponentContentStringBuilder, specificDocumentFormatterDocumentComponentContentIndentLevelToHandle: specificDocumentFormatterDocumentComponentContentIndentLevelToHandle);
            SetDocumentFormatterDocumentComponentContentClosedIdentifierContentUsing(documentFormatterDocumentComponentContentStringBuilder: documentFormatterDocumentComponentContentStringBuilder, specificDocumentFormatterDocumentComponentToHandle: specificDocumentFormatterDocumentComponentToHandle);

            return documentFormatterDocumentComponentContentStringBuilder;
        }

        private static StringBuilder GetDocumentFormatterDocumentComponentContentUsing(in DocumentFormatterWithRegularStrategy<TDocumentFormatWithRegularStrategy> specificDocumentFormatterToHandle, in DocumentComponentWithRegularStrategy specificDocumentFormatterDocumentComponentToHandle, in uint specificDocumentFormatterDocumentComponentContentIndentLevelToHandle = uint.MinValue)
        {
            StringBuilder documentFormatterDocumentComponentContentStringBuilder = new();

            documentFormatterDocumentComponentContentStringBuilder.Append(value: specificDocumentFormatterToHandle.GetDocumentFormatterDocumentComponentContentUsing(specificDocumentFormatterDocumentComponentToHandle: specificDocumentFormatterDocumentComponentToHandle, specificDocumentFormatterDocumentComponentContentIndentLevelToHandle: specificDocumentFormatterDocumentComponentContentIndentLevelToHandle));

            return documentFormatterDocumentComponentContentStringBuilder;
        }
    }
}