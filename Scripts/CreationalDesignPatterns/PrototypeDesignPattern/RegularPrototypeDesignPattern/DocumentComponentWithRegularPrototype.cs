namespace VisualStudio_DesignPatternsInCSharp.CreationalDesignPatterns.PrototypeDesignPattern.RegularPrototypeDesignPattern
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public sealed class DocumentComponentWithRegularPrototype(in string otherDocumentComponentIdentifierToHandle, in string otherDocumentComponentDescriptionToHandle) : object()
    {
        public string DocumentComponentIdentifier { get; private set; } = otherDocumentComponentIdentifierToHandle;
        public string DocumentComponentDescription { get; private set; } = otherDocumentComponentDescriptionToHandle;

        private List<DocumentComponentWithRegularPrototype> DocumentComponentChildrenDocumentComponentCollection { get; set; } = [];

        public void SetDocumentComponentIdentifierUsing(in string otherDocumentComponentIdentifierToHandle)
        {
            DocumentComponentIdentifier = otherDocumentComponentIdentifierToHandle;
        }

        public void SetDocumentComponentDescriptionUsing(in string otherDocumentComponentDescriptionToHandle)
        {
            DocumentComponentDescription = otherDocumentComponentDescriptionToHandle;
        }

        public IEnumerable<DocumentComponentWithRegularPrototype> GetDocumentComponentChildrenDocumentComponentCollection()
        {
            DocumentComponentChildrenDocumentComponentCollection ??= [];

            foreach (DocumentComponentWithRegularPrototype documentComponentChildrenDocumentComponentElement in DocumentComponentChildrenDocumentComponentCollection)
            {
                yield return documentComponentChildrenDocumentComponentElement;
            }
        }

        public DocumentComponentWithRegularPrototype GetDocumentComponentChildrenDocumentComponentElementUsing(in uint otherDocumentComponentChildrenDocumentComponentCollectionIndexToHandle)
        {
            if (DocumentComponentChildrenDocumentComponentCollection == null)
            {
                return null;
            }

            if (otherDocumentComponentChildrenDocumentComponentCollectionIndexToHandle < uint.MinValue || otherDocumentComponentChildrenDocumentComponentCollectionIndexToHandle >= DocumentComponentChildrenDocumentComponentCollection.Count)
            {
                return null;
            }

            return DocumentComponentChildrenDocumentComponentCollection[index: (int)otherDocumentComponentChildrenDocumentComponentCollectionIndexToHandle];
        }

        public bool AddDocumentComponentChildrenDocumentComponentElementUsing(in DocumentComponentWithRegularPrototype otherDocumentComponentChildrenDocumentComponentElementToHandle)
        {
            if (DocumentComponentChildrenDocumentComponentCollection == null)
            {
                return false;
            }

            if (otherDocumentComponentChildrenDocumentComponentElementToHandle == null)
            {
                return false;
            }

            DocumentComponentChildrenDocumentComponentCollection.Add(item: otherDocumentComponentChildrenDocumentComponentElementToHandle);

            return true;
        }

        public bool RemoveDocumentComponentChildrenDocumentComponentElementUsing(in DocumentComponentWithRegularPrototype otherDocumentComponentChildrenDocumentComponentElementToHandle)
        {
            if (DocumentComponentChildrenDocumentComponentCollection == null)
            {
                return false;
            }

            if (otherDocumentComponentChildrenDocumentComponentElementToHandle == null)
            {
                return false;
            }

            if (DocumentComponentChildrenDocumentComponentCollection.Contains(item: otherDocumentComponentChildrenDocumentComponentElementToHandle) == false)
            {
                return false;
            }

            return DocumentComponentChildrenDocumentComponentCollection.Remove(item: otherDocumentComponentChildrenDocumentComponentElementToHandle);
        }

        public void DisplayDocumentComponentContent()
        {
            Console.WriteLine(value: GetDocumentComponentContentUsing(otherDocumentComponentToHandle: this, otherDocumentComponentContentIndentLevelToHandle: uint.MinValue));
        }

        private void SetDocumentComponentContentOpenedIdentifierContentUsing(StringBuilder documentComponentContentStringBuilder)
        {
            documentComponentContentStringBuilder.Append(value: $"< {DocumentComponentIdentifier.ToUpperInvariant()} >".ToUpperInvariant());
        }

        private void SetDocumentComponentContentClosedIdentifierContentUsing(StringBuilder documentComponentContentStringBuilder)
        {
            documentComponentContentStringBuilder.Append(value: $"</ {DocumentComponentIdentifier.ToUpperInvariant()} >".ToUpperInvariant());
        }

        private void SetDocumentComponentContentDescriptionContentUsing(StringBuilder documentComponentContentStringBuilder)
        {
            documentComponentContentStringBuilder.Append(value: $"<!-- {DocumentComponentDescription.ToUpperInvariant()} -->".ToUpperInvariant());
        }

        private void SetDocumentComponentContentIndentContentUsing(StringBuilder documentComponentContentStringBuilder, in uint otherDocumentComponentContentIndentLevelToHandle = uint.MinValue)
        {
            const uint DocumentComponentContentIndentDimension = 5;
            const char DocumentComponentContentIndentCharacter = ' ';

            documentComponentContentStringBuilder.Append(value: new string(c: DocumentComponentContentIndentCharacter, count: (int)otherDocumentComponentContentIndentLevelToHandle * (int)DocumentComponentContentIndentDimension).ToUpperInvariant());
        }

        private StringBuilder GetDocumentComponentContentUsing(in uint otherDocumentComponentContentIndentLevelToHandle = uint.MinValue)
        {
            StringBuilder documentComponentContentStringBuilder = new();

            SetDocumentComponentContentIndentContentUsing(documentComponentContentStringBuilder: documentComponentContentStringBuilder, otherDocumentComponentContentIndentLevelToHandle: otherDocumentComponentContentIndentLevelToHandle);
            SetDocumentComponentContentOpenedIdentifierContentUsing(documentComponentContentStringBuilder: documentComponentContentStringBuilder);
            documentComponentContentStringBuilder.AppendLine();

            if (string.IsNullOrEmpty(value: DocumentComponentDescription) == false || string.IsNullOrWhiteSpace(value: DocumentComponentDescription) == false)
            {
                SetDocumentComponentContentIndentContentUsing(documentComponentContentStringBuilder: documentComponentContentStringBuilder, otherDocumentComponentContentIndentLevelToHandle: otherDocumentComponentContentIndentLevelToHandle + 1);
                SetDocumentComponentContentDescriptionContentUsing(documentComponentContentStringBuilder: documentComponentContentStringBuilder);
                documentComponentContentStringBuilder.AppendLine();
            }

            foreach (DocumentComponentWithRegularPrototype documentComponentChildrenDocumentComponentElement in DocumentComponentChildrenDocumentComponentCollection)
            {
                documentComponentContentStringBuilder.Append(value: GetDocumentComponentContentUsing(otherDocumentComponentToHandle: documentComponentChildrenDocumentComponentElement, otherDocumentComponentContentIndentLevelToHandle: otherDocumentComponentContentIndentLevelToHandle + 1));
                documentComponentContentStringBuilder.AppendLine();
            }

            SetDocumentComponentContentIndentContentUsing(documentComponentContentStringBuilder: documentComponentContentStringBuilder, otherDocumentComponentContentIndentLevelToHandle: otherDocumentComponentContentIndentLevelToHandle);
            SetDocumentComponentContentClosedIdentifierContentUsing(documentComponentContentStringBuilder: documentComponentContentStringBuilder);

            return documentComponentContentStringBuilder;
        }

        private static StringBuilder GetDocumentComponentContentUsing(in DocumentComponentWithRegularPrototype otherDocumentComponentToHandle, in uint otherDocumentComponentContentIndentLevelToHandle = uint.MinValue)
        {
            StringBuilder documentComponentContentStringBuilder = new();

            documentComponentContentStringBuilder.Append(value: otherDocumentComponentToHandle.GetDocumentComponentContentUsing(otherDocumentComponentContentIndentLevelToHandle: otherDocumentComponentContentIndentLevelToHandle));

            return documentComponentContentStringBuilder;
        }

        public override bool Equals(object otherDocumentComponentUndefinedObjectTOHandle)
        {
            if (ReferenceEquals(objA: this, objB: otherDocumentComponentUndefinedObjectTOHandle) == true)
            {
                return true;
            }

            if (otherDocumentComponentUndefinedObjectTOHandle == null || otherDocumentComponentUndefinedObjectTOHandle is DocumentComponentWithRegularPrototype otherDocumentComponentDefinedObjectToHandle == false)
            {
                return false;
            }

            if (DocumentComponentIdentifier != otherDocumentComponentDefinedObjectToHandle.DocumentComponentIdentifier || DocumentComponentDescription != otherDocumentComponentDefinedObjectToHandle.DocumentComponentDescription)
            {
                return false;
            }

            if (DocumentComponentChildrenDocumentComponentCollection == null || otherDocumentComponentDefinedObjectToHandle.DocumentComponentChildrenDocumentComponentCollection == null || DocumentComponentChildrenDocumentComponentCollection.Count != otherDocumentComponentDefinedObjectToHandle.DocumentComponentChildrenDocumentComponentCollection.Count)
            {
                return false;
            }

            for (uint documentComponentChildrenDocumentComponentCollectionIndex = uint.MinValue; documentComponentChildrenDocumentComponentCollectionIndex < DocumentComponentChildrenDocumentComponentCollection.Count; documentComponentChildrenDocumentComponentCollectionIndex++)
            {
                if (DocumentComponentChildrenDocumentComponentCollection[index: (int)documentComponentChildrenDocumentComponentCollectionIndex].Equals(otherDocumentComponentUndefinedObjectTOHandle: otherDocumentComponentDefinedObjectToHandle.DocumentComponentChildrenDocumentComponentCollection[index: (int)documentComponentChildrenDocumentComponentCollectionIndex]) == false)
                {
                    return false;
                }
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

            if (DocumentComponentChildrenDocumentComponentCollection != null)
            {
                foreach (DocumentComponentWithRegularPrototype documentComponentChildrenDocumentComponentElement in DocumentComponentChildrenDocumentComponentCollection)
                {
                    documentComponentHashCode = documentComponentHashCode * DocumentComponentHashCodeMultiplierPrime + documentComponentChildrenDocumentComponentElement?.GetHashCode() ?? default;
                }
            }

            return documentComponentHashCode;
        }

        public override string ToString()
        {
            return GetDocumentComponentContentUsing(otherDocumentComponentToHandle: this, otherDocumentComponentContentIndentLevelToHandle: uint.MinValue).ToString().ToUpperInvariant();
        }

        public DocumentComponentWithRegularPrototype GetDocumentComponentDeepCopy()
        {
            DocumentComponentWithRegularPrototype documentComponentDeepCopy = new(otherDocumentComponentIdentifierToHandle: DocumentComponentIdentifier, otherDocumentComponentDescriptionToHandle: DocumentComponentDescription);

            foreach (DocumentComponentWithRegularPrototype documentComponentChildrenDocumentComponentElement in DocumentComponentChildrenDocumentComponentCollection)
            {
                documentComponentDeepCopy.AddDocumentComponentChildrenDocumentComponentElementUsing(otherDocumentComponentChildrenDocumentComponentElementToHandle: documentComponentChildrenDocumentComponentElement.GetDocumentComponentDeepCopy());
            }

            return documentComponentDeepCopy;
        }
    }
}