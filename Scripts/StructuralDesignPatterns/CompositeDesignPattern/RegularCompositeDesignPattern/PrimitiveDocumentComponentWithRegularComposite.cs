namespace VisualStudio_DesignPatternsInCSharp.StructuralDesignPatterns.CompositeDesignPattern.RegularCompositeDesignPattern
{
    using System.Text;

    public sealed class PrimitiveDocumentComponentWithRegularComposite(in string newPrimitiveDocumentComponentIdentifierToInitialize, in string newPrimitiveDocumentComponentDescriptionToInitialize) : DocumentComponentWithRegularComposite(newDocumentComponentIdentifierToInitialize: newPrimitiveDocumentComponentIdentifierToInitialize, newDocumentComponentDescriptionToInitialize: newPrimitiveDocumentComponentDescriptionToInitialize)
    {
        protected override StringBuilder GetDocumentComponentContentUsing(in uint specificPrimitiveDocumentComponentContentIndentLevelToHandle = uint.MinValue)
        {
            StringBuilder primitiveDocumentComponentContentStringBuilder = new();

            SetDocumentComponentContentIndentContentUsing(documentComponentContentStringBuilder: primitiveDocumentComponentContentStringBuilder, specificDocumentComponentContentIndentLevelToHandle: specificPrimitiveDocumentComponentContentIndentLevelToHandle);
            SetDocumentComponentContentOpenedIdentifierContentUsing(documentComponentContentStringBuilder: primitiveDocumentComponentContentStringBuilder);
            primitiveDocumentComponentContentStringBuilder.AppendLine();

            if (string.IsNullOrEmpty(value: DocumentComponentDescription) == false || string.IsNullOrWhiteSpace(value: DocumentComponentDescription) == false)
            {
                SetDocumentComponentContentIndentContentUsing(documentComponentContentStringBuilder: primitiveDocumentComponentContentStringBuilder, specificDocumentComponentContentIndentLevelToHandle: specificPrimitiveDocumentComponentContentIndentLevelToHandle + 1);
                SetDocumentComponentContentDescriptionContentUsing(documentComponentContentStringBuilder: primitiveDocumentComponentContentStringBuilder);
                primitiveDocumentComponentContentStringBuilder.AppendLine();
            }

            SetDocumentComponentContentIndentContentUsing(documentComponentContentStringBuilder: primitiveDocumentComponentContentStringBuilder, specificDocumentComponentContentIndentLevelToHandle: specificPrimitiveDocumentComponentContentIndentLevelToHandle);
            SetDocumentComponentContentClosedIdentifierContentUsing(documentComponentContentStringBuilder: primitiveDocumentComponentContentStringBuilder);

            return primitiveDocumentComponentContentStringBuilder;
        }

        public override bool Equals(object specificPrimitiveDocumentComponentUndefinedObject)
        {
            if (ReferenceEquals(objA: this, objB: specificPrimitiveDocumentComponentUndefinedObject) == true)
            {
                return true;
            }

            if (specificPrimitiveDocumentComponentUndefinedObject == null || specificPrimitiveDocumentComponentUndefinedObject is PrimitiveDocumentComponentWithRegularComposite specificPrimitiveDocumentComponentDefinedObject == false)
            {
                return false;
            }

            if (DocumentComponentIdentifier != specificPrimitiveDocumentComponentDefinedObject.DocumentComponentIdentifier || DocumentComponentDescription != specificPrimitiveDocumentComponentDefinedObject.DocumentComponentDescription)
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
            return GetDocumentComponentContentUsing(specificDocumentComponentToHandle: this, specificDocumentComponentContentIndentLevelToHandle: uint.MinValue).ToString().ToUpperInvariant();
        }
    }
}