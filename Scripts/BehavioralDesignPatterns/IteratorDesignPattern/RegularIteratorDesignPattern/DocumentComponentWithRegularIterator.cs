namespace VisualStudio_DesignPatternsInCSharp.Scripts.BehavioralDesignPatterns.IteratorDesignPattern.RegularIteratorDesignPattern
{
    using System.Collections.Generic;

    public sealed class DocumentComponentWithRegularIterator(in string otherDocumentComponentIdentifierToHandle, in string otherDocumentComponentDescriptionToHandle) : object()
    {
        public string DocumentComponentIdentifier { get; private set; } = otherDocumentComponentIdentifierToHandle;
        public string DocumentComponentDescription { get; private set; } = otherDocumentComponentDescriptionToHandle;

        private List<DocumentComponentWithRegularIterator> DocumentComponentChildrenDocumentComponentCollection { get; set; } = [];

        public void SetDocumentComponentIdentifierUsing(in string otherDocumentComponentIdentifierToHandle)
        {
            DocumentComponentIdentifier = otherDocumentComponentIdentifierToHandle;
        }

        public void SetDocumentComponentDescriptionUsing(in string otherDocumentComponentDescriptionToHandle)
        {
            DocumentComponentDescription = otherDocumentComponentDescriptionToHandle;
        }

        public IEnumerable<DocumentComponentWithRegularIterator> GetDocumentComponentChildrenDocumentComponentCollection()
        {
            DocumentComponentChildrenDocumentComponentCollection ??= [];

            foreach (DocumentComponentWithRegularIterator documentComponentChildrenDocumentComponentElement in DocumentComponentChildrenDocumentComponentCollection)
            {
                yield return documentComponentChildrenDocumentComponentElement;
            }
        }

        public DocumentComponentWithRegularIterator GetDocumentComponentChildrenDocumentComponentElementUsing(in uint otherDocumentComponentChildrenDocumentComponentCollectionIndexToHandle)
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

        public bool AddDocumentComponentChildrenDocumentComponentElementUsing(in DocumentComponentWithRegularIterator otherDocumentComponentChildrenDocumentComponentElementToHandle)
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

        public bool RemoveDocumentComponentChildrenDocumentComponentElementUsing(in DocumentComponentWithRegularIterator otherDocumentComponentChildrenDocumentComponentElementToHandle)
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

        public override bool Equals(object otherDocumentComponentUndefinedObjectToHandle)
        {
            if (ReferenceEquals(objA: this, objB: otherDocumentComponentUndefinedObjectToHandle) == true)
            {
                return true;
            }

            if (otherDocumentComponentUndefinedObjectToHandle == null || otherDocumentComponentUndefinedObjectToHandle is DocumentComponentWithRegularIterator otherDocumentComponentDefinedObjectToHandle == false)
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
                if (DocumentComponentChildrenDocumentComponentCollection[index: (int)documentComponentChildrenDocumentComponentCollectionIndex].Equals(otherDocumentComponentUndefinedObjectToHandle: otherDocumentComponentDefinedObjectToHandle.DocumentComponentChildrenDocumentComponentCollection[index: (int)documentComponentChildrenDocumentComponentCollectionIndex]) == false)
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
                foreach (DocumentComponentWithRegularIterator documentComponentChildrenDocumentComponentElement in DocumentComponentChildrenDocumentComponentCollection)
                {
                    documentComponentHashCode = documentComponentHashCode * DocumentComponentHashCodeMultiplierPrime + documentComponentChildrenDocumentComponentElement?.GetHashCode() ?? default;
                }
            }

            return documentComponentHashCode;
        }

        public override string ToString()
        {
            return string.Empty.ToUpperInvariant();
        }
    }
}