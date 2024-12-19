namespace VisualStudio_DesignPatternsInCSharp.StructuralDesignPatterns.CompositeDesignPattern.RegularCompositeDesignPattern
{
    using System;
    using System.Text;

    public abstract class DocumentComponentWithRegularComposite
    {
        public string DocumentComponentIdentifier { get; protected set; }
        public string DocumentComponentDescription { get; protected set; }

        public DocumentComponentWithRegularComposite(in string newDocumentComponentIdentifierToInitialize, in string newDocumentComponentDescriptionToInitialize) : base()
        {
            DocumentComponentIdentifier = newDocumentComponentIdentifierToInitialize;
            DocumentComponentDescription = newDocumentComponentDescriptionToInitialize;
        }

        public void SetDocumentComponentIdentifierUsing(in string newDocumentComponentIdentifierToInitialize)
        {
            DocumentComponentIdentifier = newDocumentComponentIdentifierToInitialize;
        }

        public void SetDocumentComponentDescriptionUsing(in string newDocumentComponentDescriptionToInitialize)
        {
            DocumentComponentDescription = newDocumentComponentDescriptionToInitialize;
        }

        public void DisplayDocumentComponentContent()
        {
            Console.WriteLine(value: GetDocumentComponentContentUsing(specificDocumentComponentToHandle: this, specificDocumentComponentContentIndentLevelToHandle: uint.MinValue));
        }

        protected void SetDocumentComponentContentOpenedIdentifierContentUsing(StringBuilder documentComponentContentStringBuilder)
        {
            documentComponentContentStringBuilder.Append(value: $"< {DocumentComponentIdentifier.ToUpperInvariant()} >".ToUpperInvariant());
        }

        protected void SetDocumentComponentContentClosedIdentifierContentUsing(StringBuilder documentComponentContentStringBuilder)
        {
            documentComponentContentStringBuilder.Append(value: $"</ {DocumentComponentIdentifier.ToUpperInvariant()} >".ToUpperInvariant());
        }

        protected void SetDocumentComponentContentDescriptionContentUsing(StringBuilder documentComponentContentStringBuilder)
        {
            documentComponentContentStringBuilder.Append(value: $"<!-- {DocumentComponentDescription.ToUpperInvariant()} -->".ToUpperInvariant());
        }

        protected void SetDocumentComponentContentIndentContentUsing(StringBuilder documentComponentContentStringBuilder, in uint specificDocumentComponentContentIndentLevelToHandle = uint.MinValue)
        {
            const uint DocumentComponentContentIndentDimension = 5;
            const char DocumentComponentContentIndentCharacter = ' ';

            documentComponentContentStringBuilder.Append(value: new string(c: DocumentComponentContentIndentCharacter, count: (int)specificDocumentComponentContentIndentLevelToHandle * (int)DocumentComponentContentIndentDimension).ToUpperInvariant());
        }

        protected abstract StringBuilder GetDocumentComponentContentUsing(in uint specificDocumentComponentContentIndentLevelToHandle = uint.MinValue);

        protected static StringBuilder GetDocumentComponentContentUsing(in DocumentComponentWithRegularComposite specificDocumentComponentToHandle, in uint specificDocumentComponentContentIndentLevelToHandle = uint.MinValue)
        {
            StringBuilder documentComponentContentStringBuilder = new StringBuilder();

            documentComponentContentStringBuilder.Append(value: specificDocumentComponentToHandle.GetDocumentComponentContentUsing(specificDocumentComponentContentIndentLevelToHandle: specificDocumentComponentContentIndentLevelToHandle));

            return documentComponentContentStringBuilder;
        }

        public override bool Equals(object specificDocumentComponentUndefinedObject)
        {
            if (ReferenceEquals(objA: this, objB: specificDocumentComponentUndefinedObject) == true)
            {
                return true;
            }

            if (specificDocumentComponentUndefinedObject == null || specificDocumentComponentUndefinedObject is DocumentComponentWithRegularComposite specificDocumentComponentDefinedObject == false)
            {
                return false;
            }

            if (DocumentComponentIdentifier != specificDocumentComponentDefinedObject.DocumentComponentIdentifier || DocumentComponentDescription != specificDocumentComponentDefinedObject.DocumentComponentDescription)
            {
                return false;
            }

            return true;
        }

        public override int GetHashCode()
        {
            const int DocumentComponentHashCodeInitialPrime = 17;
            const int DocumentComponentHashCodeMultiplierPrime = 23;

            int documentComponentHashCode = DocumentComponentHashCodeInitialPrime;

            documentComponentHashCode = documentComponentHashCode * DocumentComponentHashCodeMultiplierPrime + DocumentComponentIdentifier?.GetHashCode() ?? default;
            documentComponentHashCode = documentComponentHashCode * DocumentComponentHashCodeMultiplierPrime + DocumentComponentDescription?.GetHashCode() ?? default;

            return documentComponentHashCode;
        }
    }
}