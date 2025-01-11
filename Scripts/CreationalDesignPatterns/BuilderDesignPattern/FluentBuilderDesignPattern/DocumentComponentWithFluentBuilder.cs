namespace VisualStudio_DesignPatternsInCSharp.CreationalDesignPatterns.BuilderDesignPattern.FluentBuilderDesignPattern
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public sealed class DocumentComponentWithFluentBuilder(in string newDocumentComponentIdentifierToInitialize, in string newDocumentComponentDescriptionToInitialize) : object()
    {
        public string DocumentComponentIdentifier { get; private set; } = newDocumentComponentIdentifierToInitialize;
        public string DocumentComponentDescription { get; private set; } = newDocumentComponentDescriptionToInitialize;

        private List<DocumentComponentWithFluentBuilder> DocumentComponentChildrenDocumentComponentCollection { get; set; } = [];

        public void SetDocumentComponentIdentifierUsing(in string newDocumentComponentIdentifierToDefine)
        {
            DocumentComponentIdentifier = newDocumentComponentIdentifierToDefine;
        }

        public void SetDocumentComponentDescriptionUsing(in string newDocumentComponentDescriptionToDefine)
        {
            DocumentComponentDescription = newDocumentComponentDescriptionToDefine;
        }

        public IEnumerable<DocumentComponentWithFluentBuilder> GetDocumentComponentChildrenDocumentComponentCollection()
        {
            DocumentComponentChildrenDocumentComponentCollection ??= [];

            foreach (DocumentComponentWithFluentBuilder documentComponentChildrenDocumentComponentElement in DocumentComponentChildrenDocumentComponentCollection)
            {
                yield return documentComponentChildrenDocumentComponentElement;
            }
        }

        public DocumentComponentWithFluentBuilder GetDocumentComponentChildrenDocumentComponentElementUsing(in uint specificDocumentComponentChildrenDocumentComponentCollectionIndex)
        {
            if (DocumentComponentChildrenDocumentComponentCollection == null)
            {
                return null;
            }

            if (specificDocumentComponentChildrenDocumentComponentCollectionIndex < uint.MinValue || specificDocumentComponentChildrenDocumentComponentCollectionIndex >= DocumentComponentChildrenDocumentComponentCollection.Count)
            {
                return null;
            }

            return DocumentComponentChildrenDocumentComponentCollection[index: (int)specificDocumentComponentChildrenDocumentComponentCollectionIndex];
        }

        public bool AddDocumentComponentChildrenDocumentComponentElementUsing(in DocumentComponentWithFluentBuilder newDocumentComponentChildrenDocumentComponentElementToAdd)
        {
            if (DocumentComponentChildrenDocumentComponentCollection == null)
            {
                return false;
            }

            if (newDocumentComponentChildrenDocumentComponentElementToAdd == null)
            {
                return false;
            }

            DocumentComponentChildrenDocumentComponentCollection.Add(item: newDocumentComponentChildrenDocumentComponentElementToAdd);

            return true;
        }

        public bool RemoveDocumentComponentChildrenDocumentComponentElementUsing(in DocumentComponentWithFluentBuilder existingDocumentComponentChildrenDocumentComponentElementToRemove)
        {
            if (DocumentComponentChildrenDocumentComponentCollection == null)
            {
                return false;
            }

            if (existingDocumentComponentChildrenDocumentComponentElementToRemove == null)
            {
                return false;
            }

            if (DocumentComponentChildrenDocumentComponentCollection.Contains(item: existingDocumentComponentChildrenDocumentComponentElementToRemove) == false)
            {
                return false;
            }

            return DocumentComponentChildrenDocumentComponentCollection.Remove(item: existingDocumentComponentChildrenDocumentComponentElementToRemove);
        }

        public void DisplayDocumentComponentContent()
        {
            Console.WriteLine(value: GetDocumentComponentContentUsing(specificDocumentComponentToHandle: this, specificDocumentComponentContentIndentLevelToHandle: uint.MinValue));
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

        private void SetDocumentComponentContentIndentContentUsing(StringBuilder documentComponentContentStringBuilder, in uint specificDocumentComponentContentIndentLevelToHandle = uint.MinValue)
        {
            const uint DocumentComponentContentIndentDimension = 5;
            const char DocumentComponentContentIndentCharacter = ' ';

            documentComponentContentStringBuilder.Append(value: new string(c: DocumentComponentContentIndentCharacter, count: (int)specificDocumentComponentContentIndentLevelToHandle * (int)DocumentComponentContentIndentDimension).ToUpperInvariant());
        }

        private StringBuilder GetDocumentComponentContentUsing(in uint specificDocumentComponentContentIndentLevelToHandle = uint.MinValue)
        {
            StringBuilder documentComponentContentStringBuilder = new();

            SetDocumentComponentContentIndentContentUsing(documentComponentContentStringBuilder: documentComponentContentStringBuilder, specificDocumentComponentContentIndentLevelToHandle: specificDocumentComponentContentIndentLevelToHandle);
            SetDocumentComponentContentOpenedIdentifierContentUsing(documentComponentContentStringBuilder: documentComponentContentStringBuilder);
            documentComponentContentStringBuilder.AppendLine();

            if (string.IsNullOrEmpty(value: DocumentComponentDescription) == false || string.IsNullOrWhiteSpace(value: DocumentComponentDescription) == false)
            {
                SetDocumentComponentContentIndentContentUsing(documentComponentContentStringBuilder: documentComponentContentStringBuilder, specificDocumentComponentContentIndentLevelToHandle: specificDocumentComponentContentIndentLevelToHandle + 1);
                SetDocumentComponentContentDescriptionContentUsing(documentComponentContentStringBuilder: documentComponentContentStringBuilder);
                documentComponentContentStringBuilder.AppendLine();
            }

            foreach (DocumentComponentWithFluentBuilder documentComponentChildrenDocumentComponentElement in DocumentComponentChildrenDocumentComponentCollection)
            {
                documentComponentContentStringBuilder.Append(value: GetDocumentComponentContentUsing(specificDocumentComponentToHandle: documentComponentChildrenDocumentComponentElement, specificDocumentComponentContentIndentLevelToHandle: specificDocumentComponentContentIndentLevelToHandle + 1));
                documentComponentContentStringBuilder.AppendLine();
            }

            SetDocumentComponentContentIndentContentUsing(documentComponentContentStringBuilder: documentComponentContentStringBuilder, specificDocumentComponentContentIndentLevelToHandle: specificDocumentComponentContentIndentLevelToHandle);
            SetDocumentComponentContentClosedIdentifierContentUsing(documentComponentContentStringBuilder: documentComponentContentStringBuilder);

            return documentComponentContentStringBuilder;
        }

        private static StringBuilder GetDocumentComponentContentUsing(in DocumentComponentWithFluentBuilder specificDocumentComponentToHandle, in uint specificDocumentComponentContentIndentLevelToHandle = uint.MinValue)
        {
            StringBuilder documentComponentContentStringBuilder = new();

            documentComponentContentStringBuilder.Append(value: specificDocumentComponentToHandle.GetDocumentComponentContentUsing(specificDocumentComponentContentIndentLevelToHandle: specificDocumentComponentContentIndentLevelToHandle));

            return documentComponentContentStringBuilder;
        }

        public override bool Equals(object specificDocumentComponentUndefinedObject)
        {
            if (ReferenceEquals(objA: this, objB: specificDocumentComponentUndefinedObject) == true)
            {
                return true;
            }

            if (specificDocumentComponentUndefinedObject == null || specificDocumentComponentUndefinedObject is DocumentComponentWithFluentBuilder specificDocumentComponentDefinedObject == false)
            {
                return false;
            }

            if (DocumentComponentIdentifier != specificDocumentComponentDefinedObject.DocumentComponentIdentifier || DocumentComponentDescription != specificDocumentComponentDefinedObject.DocumentComponentDescription)
            {
                return false;
            }

            if (DocumentComponentChildrenDocumentComponentCollection == null || specificDocumentComponentDefinedObject.DocumentComponentChildrenDocumentComponentCollection == null || DocumentComponentChildrenDocumentComponentCollection.Count != specificDocumentComponentDefinedObject.DocumentComponentChildrenDocumentComponentCollection.Count)
            {
                return false;
            }

            for (uint documentComponentChildrenDocumentComponentCollectionIndex = uint.MinValue; documentComponentChildrenDocumentComponentCollectionIndex < DocumentComponentChildrenDocumentComponentCollection.Count; documentComponentChildrenDocumentComponentCollectionIndex++)
            {
                if (DocumentComponentChildrenDocumentComponentCollection[index: (int)documentComponentChildrenDocumentComponentCollectionIndex].Equals(specificDocumentComponentUndefinedObject: specificDocumentComponentDefinedObject.DocumentComponentChildrenDocumentComponentCollection[index: (int)documentComponentChildrenDocumentComponentCollectionIndex]) == false)
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
                foreach (DocumentComponentWithFluentBuilder documentComponentChildrenDocumentComponentElement in DocumentComponentChildrenDocumentComponentCollection)
                {
                    documentComponentHashCode = documentComponentHashCode * DocumentComponentHashCodeMultiplierPrime + documentComponentChildrenDocumentComponentElement?.GetHashCode() ?? default;
                }
            }

            return documentComponentHashCode;
        }

        public override string ToString()
        {
            return GetDocumentComponentContentUsing(specificDocumentComponentToHandle: this, specificDocumentComponentContentIndentLevelToHandle: uint.MinValue).ToString().ToUpperInvariant();
        }
    }
}