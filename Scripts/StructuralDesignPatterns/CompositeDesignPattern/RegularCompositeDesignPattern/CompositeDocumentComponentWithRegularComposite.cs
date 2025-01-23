namespace VisualStudio_DesignPatternsInCSharp.Scripts.StructuralDesignPatterns.CompositeDesignPattern.RegularCompositeDesignPattern
{
    using System.Collections.Generic;

    public sealed class CompositeDocumentComponentWithRegularComposite(in string otherCompositeDocumentComponentIdentifierToHandle, in string otherCompositeDocumentComponentDescriptionToHandle) : DocumentComponentWithRegularComposite(otherDocumentComponentIdentifierToHandle: otherCompositeDocumentComponentIdentifierToHandle, otherDocumentComponentDescriptionToHandle: otherCompositeDocumentComponentDescriptionToHandle)
    {
        private List<DocumentComponentWithRegularComposite> CompositeDocumentComponentChildrenDocumentComponentCollection { get; set; } = [];

        public IEnumerable<DocumentComponentWithRegularComposite> GetCompositeDocumentComponentChildrenDocumentComponentCollection()
        {
            CompositeDocumentComponentChildrenDocumentComponentCollection ??= [];

            foreach (DocumentComponentWithRegularComposite compositeDocumentComponentChildrenDocumentElement in CompositeDocumentComponentChildrenDocumentComponentCollection)
            {
                yield return compositeDocumentComponentChildrenDocumentElement;
            }
        }

        public DocumentComponentWithRegularComposite GetCompositeDocumentComponentChildrenDocumentComponentElementUsing(in uint otherCompositeDocumentComponentChildrenDocumentComponentCollectionIndexToHandle)
        {
            if (CompositeDocumentComponentChildrenDocumentComponentCollection == null)
            {
                return null;
            }

            if (otherCompositeDocumentComponentChildrenDocumentComponentCollectionIndexToHandle < uint.MinValue || otherCompositeDocumentComponentChildrenDocumentComponentCollectionIndexToHandle >= CompositeDocumentComponentChildrenDocumentComponentCollection.Count)
            {
                return null;
            }

            return CompositeDocumentComponentChildrenDocumentComponentCollection[index: (int)otherCompositeDocumentComponentChildrenDocumentComponentCollectionIndexToHandle];
        }

        public bool AddCompositeDocumentComponentChildrenDocumentComponentElementUsing(in DocumentComponentWithRegularComposite otherCompositeDocumentComponentChildrenDocumentComponentElementToHandle)
        {
            if (CompositeDocumentComponentChildrenDocumentComponentCollection == null)
            {
                return false;
            }

            if (otherCompositeDocumentComponentChildrenDocumentComponentElementToHandle == null)
            {
                return false;
            }

            CompositeDocumentComponentChildrenDocumentComponentCollection.Add(item: otherCompositeDocumentComponentChildrenDocumentComponentElementToHandle);

            return true;
        }

        public bool RemoveCompositeDocumentComponentChildrenDocumentComponentElementUsing(in DocumentComponentWithRegularComposite otherCompositeDocumentComponentChildrenDocumentComponentElementToHandle)
        {
            if (CompositeDocumentComponentChildrenDocumentComponentCollection == null)
            {
                return false;
            }

            if (otherCompositeDocumentComponentChildrenDocumentComponentElementToHandle == null)
            {
                return false;
            }

            if (CompositeDocumentComponentChildrenDocumentComponentCollection.Contains(item: otherCompositeDocumentComponentChildrenDocumentComponentElementToHandle) == false)
            {
                return false;
            }

            return CompositeDocumentComponentChildrenDocumentComponentCollection.Remove(item: otherCompositeDocumentComponentChildrenDocumentComponentElementToHandle);
        }

        public override bool Equals(object otherCompositeDocumentComponentUndefinedObjectToHandle)
        {
            if (ReferenceEquals(objA: this, objB: otherCompositeDocumentComponentUndefinedObjectToHandle) == true)
            {
                return true;
            }

            if (otherCompositeDocumentComponentUndefinedObjectToHandle == null || otherCompositeDocumentComponentUndefinedObjectToHandle is CompositeDocumentComponentWithRegularComposite otherCompositeDocumentComponentDefinedObjectToHandle == false)
            {
                return false;
            }

            if (DocumentComponentIdentifier != otherCompositeDocumentComponentDefinedObjectToHandle.DocumentComponentIdentifier || DocumentComponentDescription != otherCompositeDocumentComponentDefinedObjectToHandle.DocumentComponentDescription)
            {
                return false;
            }

            if (CompositeDocumentComponentChildrenDocumentComponentCollection == null || otherCompositeDocumentComponentDefinedObjectToHandle.CompositeDocumentComponentChildrenDocumentComponentCollection == null || CompositeDocumentComponentChildrenDocumentComponentCollection.Count != otherCompositeDocumentComponentDefinedObjectToHandle.CompositeDocumentComponentChildrenDocumentComponentCollection.Count)
            {
                return false;
            }

            for (uint compositeDocumentComponentChildrenDocumentComponentCollectionIndex = uint.MinValue; compositeDocumentComponentChildrenDocumentComponentCollectionIndex < CompositeDocumentComponentChildrenDocumentComponentCollection.Count; compositeDocumentComponentChildrenDocumentComponentCollectionIndex++)
            {
                if (CompositeDocumentComponentChildrenDocumentComponentCollection[index: (int)compositeDocumentComponentChildrenDocumentComponentCollectionIndex].Equals(otherDocumentComponentUndefinedObjectToHandle: otherCompositeDocumentComponentDefinedObjectToHandle.CompositeDocumentComponentChildrenDocumentComponentCollection[index: (int)compositeDocumentComponentChildrenDocumentComponentCollectionIndex]) == false)
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

        public override string ToString()
        {
            return string.Empty.ToUpperInvariant();
        }
    }
}