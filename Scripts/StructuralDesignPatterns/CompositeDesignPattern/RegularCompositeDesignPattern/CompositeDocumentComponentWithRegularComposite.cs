namespace VisualStudio_DesignPatternsInCSharp.StructuralDesignPatterns.CompositeDesignPattern.RegularCompositeDesignPattern
{
    using System.Collections.Generic;
    using System.Text;

    public sealed class CompositeDocumentComponentWithRegularComposite : DocumentComponentWithRegularComposite
    {
        private List<DocumentComponentWithRegularComposite> CompositeDocumentComponentChildrenDocumentComponentCollection { get; set; }

        public CompositeDocumentComponentWithRegularComposite(in string newCompositeDocumentComponentIdentifierToInitialize, in string newCompositeDocumentComponentDescriptionToInitialize) : base(newDocumentComponentIdentifierToInitialize: newCompositeDocumentComponentIdentifierToInitialize, newDocumentComponentDescriptionToInitialize: newCompositeDocumentComponentDescriptionToInitialize)
        {
            DocumentComponentIdentifier = newCompositeDocumentComponentIdentifierToInitialize;
            DocumentComponentDescription = newCompositeDocumentComponentDescriptionToInitialize;

            CompositeDocumentComponentChildrenDocumentComponentCollection = new List<DocumentComponentWithRegularComposite>();
        }

        public IEnumerable<DocumentComponentWithRegularComposite> GetCompositeDocumentComponentChildrenDocumentComponentCollection()
        {
            if (CompositeDocumentComponentChildrenDocumentComponentCollection == null)
            {
                CompositeDocumentComponentChildrenDocumentComponentCollection = new List<DocumentComponentWithRegularComposite>();
            }

            foreach (DocumentComponentWithRegularComposite compositeDocumentComponentChildrenDocumentElement in CompositeDocumentComponentChildrenDocumentComponentCollection)
            {
                yield return compositeDocumentComponentChildrenDocumentElement;
            }
        }

        public DocumentComponentWithRegularComposite GetCompositeDocumentComponentChildrenDocumentComponentElementUsing(in uint specificCompositeDocumentComponentChildrenDocumentComponentCollectionIndexToHandle)
        {
            if (CompositeDocumentComponentChildrenDocumentComponentCollection == null)
            {
                return null;
            }

            if (specificCompositeDocumentComponentChildrenDocumentComponentCollectionIndexToHandle < uint.MinValue || specificCompositeDocumentComponentChildrenDocumentComponentCollectionIndexToHandle >= CompositeDocumentComponentChildrenDocumentComponentCollection.Count)
            {
                return null;
            }

            return CompositeDocumentComponentChildrenDocumentComponentCollection[index: (int)specificCompositeDocumentComponentChildrenDocumentComponentCollectionIndexToHandle];
        }

        public bool AddCompositeDocumentComponentChildrenDocumentComponentElementUsing(in DocumentComponentWithRegularComposite newCompositeDocumentComponentChildrenDocumentComponentElementToAdd)
        {
            if (CompositeDocumentComponentChildrenDocumentComponentCollection == null)
            {
                return false;
            }

            if (newCompositeDocumentComponentChildrenDocumentComponentElementToAdd == null)
            {
                return false;
            }

            CompositeDocumentComponentChildrenDocumentComponentCollection.Add(item: newCompositeDocumentComponentChildrenDocumentComponentElementToAdd);

            return true;
        }

        public bool RemoveCompositeDocumentComponentChildrenDocumentComponentElementUsing(in DocumentComponentWithRegularComposite existingCompositeDocumentComponentChildrenDocumentComponentElementToRemove)
        {
            if (CompositeDocumentComponentChildrenDocumentComponentCollection == null)
            {
                return false;
            }

            if (existingCompositeDocumentComponentChildrenDocumentComponentElementToRemove == null)
            {
                return false;
            }

            if (CompositeDocumentComponentChildrenDocumentComponentCollection.Contains(item: existingCompositeDocumentComponentChildrenDocumentComponentElementToRemove) == false)
            {
                return false;
            }

            return CompositeDocumentComponentChildrenDocumentComponentCollection.Remove(item: existingCompositeDocumentComponentChildrenDocumentComponentElementToRemove);
        }

        protected override StringBuilder GetDocumentComponentContentUsing(in uint specificCompositeDocumentComponentContentIndentLevelToHandle = uint.MinValue)
        {
            StringBuilder compositeDocumentComponentContentStringBuilder = new StringBuilder();

            SetDocumentComponentContentIndentContentUsing(documentComponentContentStringBuilder: compositeDocumentComponentContentStringBuilder, specificDocumentComponentContentIndentLevelToHandle: specificCompositeDocumentComponentContentIndentLevelToHandle);
            SetDocumentComponentContentOpenedIdentifierContentUsing(documentComponentContentStringBuilder: compositeDocumentComponentContentStringBuilder);
            compositeDocumentComponentContentStringBuilder.AppendLine();

            if (string.IsNullOrEmpty(value: DocumentComponentDescription) == false || string.IsNullOrWhiteSpace(value: DocumentComponentDescription) == false)
            {
                SetDocumentComponentContentIndentContentUsing(documentComponentContentStringBuilder: compositeDocumentComponentContentStringBuilder, specificDocumentComponentContentIndentLevelToHandle: specificCompositeDocumentComponentContentIndentLevelToHandle + 1);
                SetDocumentComponentContentDescriptionContentUsing(documentComponentContentStringBuilder: compositeDocumentComponentContentStringBuilder);
                compositeDocumentComponentContentStringBuilder.AppendLine();
            }

            foreach (DocumentComponentWithRegularComposite compositeDocumentComponentChildrenDocumentComponentElement in CompositeDocumentComponentChildrenDocumentComponentCollection)
            {
                compositeDocumentComponentContentStringBuilder.Append(value: GetDocumentComponentContentUsing(specificDocumentComponentToHandle: compositeDocumentComponentChildrenDocumentComponentElement, specificDocumentComponentContentIndentLevelToHandle: specificCompositeDocumentComponentContentIndentLevelToHandle + 1));
                compositeDocumentComponentContentStringBuilder.AppendLine();
            }

            SetDocumentComponentContentIndentContentUsing(documentComponentContentStringBuilder: compositeDocumentComponentContentStringBuilder, specificDocumentComponentContentIndentLevelToHandle: specificCompositeDocumentComponentContentIndentLevelToHandle);
            SetDocumentComponentContentClosedIdentifierContentUsing(documentComponentContentStringBuilder: compositeDocumentComponentContentStringBuilder);

            return compositeDocumentComponentContentStringBuilder;
        }

        public override bool Equals(object specificCompositeDocumentComponentUndefinedObject)
        {
            if (ReferenceEquals(objA: this, objB: specificCompositeDocumentComponentUndefinedObject) == true)
            {
                return true;
            }

            if (specificCompositeDocumentComponentUndefinedObject == null || specificCompositeDocumentComponentUndefinedObject is CompositeDocumentComponentWithRegularComposite specificCompositeDocumentComponentDefinedObject == false)
            {
                return false;
            }

            if (DocumentComponentIdentifier != specificCompositeDocumentComponentDefinedObject.DocumentComponentIdentifier || DocumentComponentDescription != specificCompositeDocumentComponentDefinedObject.DocumentComponentDescription)
            {
                return false;
            }

            if (CompositeDocumentComponentChildrenDocumentComponentCollection == null || specificCompositeDocumentComponentDefinedObject.CompositeDocumentComponentChildrenDocumentComponentCollection == null || CompositeDocumentComponentChildrenDocumentComponentCollection.Count != specificCompositeDocumentComponentDefinedObject.CompositeDocumentComponentChildrenDocumentComponentCollection.Count)
            {
                return false;
            }

            for (uint compositeDocumentComponentChildrenDocumentComponentCollectionIndex = uint.MinValue; compositeDocumentComponentChildrenDocumentComponentCollectionIndex < CompositeDocumentComponentChildrenDocumentComponentCollection.Count; compositeDocumentComponentChildrenDocumentComponentCollectionIndex++)
            {
                if (CompositeDocumentComponentChildrenDocumentComponentCollection[index: (int)compositeDocumentComponentChildrenDocumentComponentCollectionIndex].Equals(specificDocumentComponentUndefinedObject: specificCompositeDocumentComponentDefinedObject.CompositeDocumentComponentChildrenDocumentComponentCollection[index: (int)compositeDocumentComponentChildrenDocumentComponentCollectionIndex]) == false)
                {
                    return false;
                }
            }

            return true;
        }

        public override int GetHashCode()
        {
            const int CompositeDocumentComponentHashCodeInitialPrime = 17;
            const int CompositeDocumentComponentHashCodeMultiplierPrime = 23;

            int compositeDocumentComponentHashCode = CompositeDocumentComponentHashCodeInitialPrime;

            compositeDocumentComponentHashCode = compositeDocumentComponentHashCode * CompositeDocumentComponentHashCodeMultiplierPrime + DocumentComponentIdentifier?.GetHashCode() ?? default;
            compositeDocumentComponentHashCode = compositeDocumentComponentHashCode * CompositeDocumentComponentHashCodeMultiplierPrime + DocumentComponentDescription?.GetHashCode() ?? default;

            if (CompositeDocumentComponentChildrenDocumentComponentCollection != null)
            {
                foreach (DocumentComponentWithRegularComposite compositeDocumentComponentChildrenDocumentComponentElement in CompositeDocumentComponentChildrenDocumentComponentCollection)
                {
                    compositeDocumentComponentHashCode = compositeDocumentComponentHashCode * CompositeDocumentComponentHashCodeMultiplierPrime + compositeDocumentComponentChildrenDocumentComponentElement?.GetHashCode() ?? default;
                }
            }

            return compositeDocumentComponentHashCode;
        }
    }
}