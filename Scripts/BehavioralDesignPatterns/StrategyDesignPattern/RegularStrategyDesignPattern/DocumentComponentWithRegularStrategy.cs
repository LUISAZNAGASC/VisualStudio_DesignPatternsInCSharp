namespace VisualStudio_DesignPatternsInCSharp.BehavioralDesignPatterns.StrategyDesignPatterns.RegularStrategyDesignPattern
{
    using System.Collections.Generic;

    public sealed class DocumentComponentWithRegularStrategy
    {
        public string DocumentComponentIdentifier { get; private set; }
        public string DocumentComponentDescription { get; private set; }

        private List<DocumentComponentWithRegularStrategy> DocumentComponentChildrenDocumentComponentCollection { get; set; }

        public DocumentComponentWithRegularStrategy(in string newDocumentComponentIdentifierToInitialize, in string newDocumentComponentDescriptionToInitialize) : base()
        {
            DocumentComponentIdentifier = newDocumentComponentIdentifierToInitialize;
            DocumentComponentDescription = newDocumentComponentDescriptionToInitialize;

            DocumentComponentChildrenDocumentComponentCollection = new List<DocumentComponentWithRegularStrategy>();
        }

        public void SetDocumentComponentIdentifierUsing(in string newDocumentComponentIdentifierToDefine)
        {
            DocumentComponentIdentifier = newDocumentComponentIdentifierToDefine;
        }

        public void SetDocumentComponentDescriptionUsing(in string newDocumentComponentDescriptionToDefine)
        {
            DocumentComponentDescription = newDocumentComponentDescriptionToDefine;
        }

        public IEnumerable<DocumentComponentWithRegularStrategy> GetDocumentComponentChildrenDocumentComponentCollection()
        {
            if (DocumentComponentChildrenDocumentComponentCollection == null)
            {
                DocumentComponentChildrenDocumentComponentCollection = new List<DocumentComponentWithRegularStrategy>();
            }

            foreach (DocumentComponentWithRegularStrategy documentComponentChildrenDocumentComponentElement in DocumentComponentChildrenDocumentComponentCollection)
            {
                yield return documentComponentChildrenDocumentComponentElement;
            }
        }

        public DocumentComponentWithRegularStrategy GetDocumentComponentChildrenDocumentComponentElementUsing(in uint specificDocumentComponentChildrenDocumentComponentCollectionIndex)
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

        public bool AddDocumentComponentChildrenDocumentComponentElementUsing(in DocumentComponentWithRegularStrategy newDocumentComponentChildrenDocumentComponentElementToAdd)
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

        public bool RemoveDocumentComponentChildrenDocumentComponentElementUsing(in DocumentComponentWithRegularStrategy existingDocumentComponentChildrenDocumentComponentElementToRemove)
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

        public override bool Equals(object specificDocumentComponentUndefinedObject)
        {
            if (ReferenceEquals(objA: this, objB: specificDocumentComponentUndefinedObject) == true)
            {
                return true;
            }

            if (specificDocumentComponentUndefinedObject == null || specificDocumentComponentUndefinedObject is DocumentComponentWithRegularStrategy specificDocumentComponentDefinedObject == false)
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
                foreach (DocumentComponentWithRegularStrategy documentComponentChildrenDocumentComponentElement in DocumentComponentChildrenDocumentComponentCollection)
                {
                    documentComponentHashCode = documentComponentHashCode * DocumentComponentHashCodeMultiplierPrime + documentComponentChildrenDocumentComponentElement?.GetHashCode() ?? default;
                }
            }

            return documentComponentHashCode;
        }
    }
}