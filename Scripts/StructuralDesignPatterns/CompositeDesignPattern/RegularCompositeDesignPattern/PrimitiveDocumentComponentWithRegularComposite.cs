namespace VisualStudio_DesignPatternsInCSharp.StructuralDesignPatterns.CompositeDesignPattern.RegularCompositeDesignPattern
{
    using System.Text;

    public sealed class PrimitiveDocumentComponentWithRegularComposite(in string otherPrimitiveDocumentComponentIdentifierToHandle, in string otherPrimitiveDocumentComponentDescriptionToHandle) : DocumentComponentWithRegularComposite(otherDocumentComponentIdentifierToHandle: otherPrimitiveDocumentComponentIdentifierToHandle, otherDocumentComponentDescriptionToHandle: otherPrimitiveDocumentComponentDescriptionToHandle)
    {
        protected override StringBuilder GetDocumentComponentContentUsing(in uint otherPrimitiveDocumentComponentContentIndentLevelToHandle = uint.MinValue)
        {
            StringBuilder primitiveDocumentComponentContentStringBuilder = new();

            SetDocumentComponentContentIndentContentUsing(documentComponentContentStringBuilder: primitiveDocumentComponentContentStringBuilder, otherDocumentComponentContentIndentLevelToHandle: otherPrimitiveDocumentComponentContentIndentLevelToHandle);
            SetDocumentComponentContentOpenedIdentifierContentUsing(documentComponentContentStringBuilder: primitiveDocumentComponentContentStringBuilder);
            primitiveDocumentComponentContentStringBuilder.AppendLine();

            if (string.IsNullOrEmpty(value: DocumentComponentDescription) == false || string.IsNullOrWhiteSpace(value: DocumentComponentDescription) == false)
            {
                SetDocumentComponentContentIndentContentUsing(documentComponentContentStringBuilder: primitiveDocumentComponentContentStringBuilder, otherDocumentComponentContentIndentLevelToHandle: otherPrimitiveDocumentComponentContentIndentLevelToHandle + 1);
                SetDocumentComponentContentDescriptionContentUsing(documentComponentContentStringBuilder: primitiveDocumentComponentContentStringBuilder);
                primitiveDocumentComponentContentStringBuilder.AppendLine();
            }

            SetDocumentComponentContentIndentContentUsing(documentComponentContentStringBuilder: primitiveDocumentComponentContentStringBuilder, otherDocumentComponentContentIndentLevelToHandle: otherPrimitiveDocumentComponentContentIndentLevelToHandle);
            SetDocumentComponentContentClosedIdentifierContentUsing(documentComponentContentStringBuilder: primitiveDocumentComponentContentStringBuilder);

            return primitiveDocumentComponentContentStringBuilder;
        }

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
            return GetDocumentComponentContentUsing(otherDocumentComponentToHandle: this, otherDocumentComponentContentIndentLevelToHandle: uint.MinValue).ToString().ToUpperInvariant();
        }
    }
}