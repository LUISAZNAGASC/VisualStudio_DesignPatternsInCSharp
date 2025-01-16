namespace VisualStudio_DesignPatternsInCSharp.StructuralDesignPatterns.CompositeDesignPattern.RegularCompositeDesignPattern
{
    using System;
    using System.Text;

    public abstract class DocumentComponentWithRegularComposite(in string otherDocumentComponentIdentifierToHandle, in string otherDocumentComponentDescriptionToHandle) : object()
    {
        public string DocumentComponentIdentifier { get; protected set; } = otherDocumentComponentIdentifierToHandle;
        public string DocumentComponentDescription { get; protected set; } = otherDocumentComponentDescriptionToHandle;

        public void SetDocumentComponentIdentifierUsing(in string otherDocumentComponentIdentifierToHandle)
        {
            DocumentComponentIdentifier = otherDocumentComponentIdentifierToHandle;
        }

        public void SetDocumentComponentDescriptionUsing(in string otherDocumentComponentDescriptionToHandle)
        {
            DocumentComponentDescription = otherDocumentComponentDescriptionToHandle;
        }

        public void DisplayDocumentComponentContent()
        {
            Console.WriteLine(value: GetDocumentComponentContentUsing(otherDocumentComponentToHandle: this, otherDocumentComponentContentIndentLevelToHandle: uint.MinValue));
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

        protected void SetDocumentComponentContentIndentContentUsing(StringBuilder documentComponentContentStringBuilder, in uint otherDocumentComponentContentIndentLevelToHandle = uint.MinValue)
        {
            const uint DocumentComponentContentIndentDimension = 5;
            const char DocumentComponentContentIndentCharacter = ' ';

            documentComponentContentStringBuilder.Append(value: new string(c: DocumentComponentContentIndentCharacter, count: (int)otherDocumentComponentContentIndentLevelToHandle * (int)DocumentComponentContentIndentDimension).ToUpperInvariant());
        }

        protected abstract StringBuilder GetDocumentComponentContentUsing(in uint otherDocumentComponentContentIndentLevelToHandle = uint.MinValue);

        protected static StringBuilder GetDocumentComponentContentUsing(in DocumentComponentWithRegularComposite otherDocumentComponentToHandle, in uint otherDocumentComponentContentIndentLevelToHandle = uint.MinValue)
        {
            StringBuilder documentComponentContentStringBuilder = new();

            documentComponentContentStringBuilder.Append(value: otherDocumentComponentToHandle.GetDocumentComponentContentUsing(otherDocumentComponentContentIndentLevelToHandle: otherDocumentComponentContentIndentLevelToHandle));

            return documentComponentContentStringBuilder;
        }

        public override bool Equals(object otherDocumentComponentUndefinedObjectToHandle)
        {
            if (ReferenceEquals(objA: this, objB: otherDocumentComponentUndefinedObjectToHandle) == true)
            {
                return true;
            }

            if (otherDocumentComponentUndefinedObjectToHandle == null || otherDocumentComponentUndefinedObjectToHandle is DocumentComponentWithRegularComposite otherDocumentComponentDefinedObjectToHandle == false)
            {
                return false;
            }

            if (DocumentComponentIdentifier != otherDocumentComponentDefinedObjectToHandle.DocumentComponentIdentifier || DocumentComponentDescription != otherDocumentComponentDefinedObjectToHandle.DocumentComponentDescription)
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

        public override string ToString()
        {
            return GetDocumentComponentContentUsing(otherDocumentComponentToHandle: this, otherDocumentComponentContentIndentLevelToHandle: uint.MinValue).ToString().ToUpperInvariant();
        }
    }
}