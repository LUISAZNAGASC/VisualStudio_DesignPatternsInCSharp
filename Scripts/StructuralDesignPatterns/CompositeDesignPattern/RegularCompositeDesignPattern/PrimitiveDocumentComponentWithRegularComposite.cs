namespace VisualStudio_DesignPatternsInCSharp.StructuralDesignPatterns.CompositeDesignPattern.RegularCompositeDesignPattern
{
    using System.Text;

    public sealed class PrimitiveDocumentComponentWithRegularComposite : DocumentComponentWithRegularComposite
    {
        public PrimitiveDocumentComponentWithRegularComposite(in string newPrimitiveDocumentComponentIdentifierToInitialize, in string newPrimitiveDocumentComponentDescriptionToInitialize) : base(newDocumentComponentIdentifierToInitialize: newPrimitiveDocumentComponentIdentifierToInitialize, newDocumentComponentDescriptionToInitialize: newPrimitiveDocumentComponentDescriptionToInitialize)
        {
            DocumentComponentIdentifier = newPrimitiveDocumentComponentIdentifierToInitialize;
            DocumentComponentDescription = newPrimitiveDocumentComponentDescriptionToInitialize;
        }

        protected override StringBuilder GetDocumentComponentContentUsing(in uint specificPrimitiveDocumentComponentContentIndentLevelToHandle = uint.MinValue)
        {
            StringBuilder primitiveDocumentComponentContentStringBuilder = new StringBuilder();

            SetDocumentComponentContentIndentContentUsing(documentComponentContentStringBuilder: primitiveDocumentComponentContentStringBuilder, specificDocumentComponentContentIndentLevelToHandle: specificPrimitiveDocumentComponentContentIndentLevelToHandle);
            SetDocumentComponentContentOpenedIdentifierContentUsing(documentComponentContentStringBuilder: primitiveDocumentComponentContentStringBuilder);
            primitiveDocumentComponentContentStringBuilder.AppendLine();

            if (string.IsNullOrEmpty(value: DocumentComponentDescription) == false || string.IsNullOrWhiteSpace(value: DocumentComponentDescription) == false)
            {
                SetDocumentComponentContentIndentContentUsing(documentComponentContentStringBuilder: primitiveDocumentComponentContentStringBuilder, specificDocumentComponentContentIndentLevelToHandle: specificPrimitiveDocumentComponentContentIndentLevelToHandle + 1);
                SetDocumentComponentContentDescriptionContentUsing(documentComponentContentStringBuilder: primitiveDocumentComponentContentStringBuilder);
                primitiveDocumentComponentContentStringBuilder.AppendLine();
            }

            SetDocumentComponentContentIndentContentUsing(documentComponentContentStringBuilder: primitiveDocumentComponentContentStringBuilder, specificDocumentComponentContentIndentLevelToHandle: specificPrimitiveDocumentComponentContentIndentLevelToHandle);
            SetDocumentComponentContentClosedIdentifierContentUsing(documentComponentContentStringBuilder: primitiveDocumentComponentContentStringBuilder);

            return primitiveDocumentComponentContentStringBuilder;
        }
    }
}