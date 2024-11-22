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
    }
}