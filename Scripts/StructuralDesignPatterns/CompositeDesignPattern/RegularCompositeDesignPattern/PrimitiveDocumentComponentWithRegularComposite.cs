namespace VisualStudio_DesignPatternsInCSharp.Scripts.StructuralDesignPatterns.CompositeDesignPattern.RegularCompositeDesignPattern
{
    public sealed class PrimitiveDocumentComponentWithRegularComposite(in string otherPrimitiveDocumentComponentIdentifierToHandle, in string otherPrimitiveDocumentComponentDescriptionToHandle) : DocumentComponentWithRegularComposite(otherDocumentComponentIdentifierToHandle: otherPrimitiveDocumentComponentIdentifierToHandle, otherDocumentComponentDescriptionToHandle: otherPrimitiveDocumentComponentDescriptionToHandle)
    {
        public override bool Equals(object otherPrimitiveDocumentComponentUndefinedObjectToHandle)
        {
            if (ReferenceEquals(objA: this, objB: otherPrimitiveDocumentComponentUndefinedObjectToHandle) == true)
            {
                return true;
            }

            if (otherPrimitiveDocumentComponentUndefinedObjectToHandle == null || otherPrimitiveDocumentComponentUndefinedObjectToHandle is PrimitiveDocumentComponentWithRegularComposite otherPrimitiveDocumentComponentDefinedObjectToHandle == false)
            {
                return false;
            }

            if (DocumentComponentIdentifier != otherPrimitiveDocumentComponentDefinedObjectToHandle.DocumentComponentIdentifier || DocumentComponentDescription != otherPrimitiveDocumentComponentDefinedObjectToHandle.DocumentComponentDescription)
            {
                return false;
            }

            return true;
        }

        public override int GetHashCode()
        {
            const int PrimitiveDocumentComponentHashCodeInitialPrime = 17;
            const int PrimitiveDocumentComponentHashCodeMultiplierPrime = 23;

            int primitiveDocumentComponentHashCode = PrimitiveDocumentComponentHashCodeInitialPrime;

            primitiveDocumentComponentHashCode = primitiveDocumentComponentHashCode * PrimitiveDocumentComponentHashCodeMultiplierPrime + DocumentComponentIdentifier?.GetHashCode() ?? default;
            primitiveDocumentComponentHashCode = primitiveDocumentComponentHashCode * PrimitiveDocumentComponentHashCodeMultiplierPrime + DocumentComponentDescription?.GetHashCode() ?? default;

            return primitiveDocumentComponentHashCode;
        }

        public override string ToString()
        {
            return string.Empty.ToUpperInvariant();
        }
    }
}