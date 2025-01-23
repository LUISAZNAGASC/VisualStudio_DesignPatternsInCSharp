namespace VisualStudio_DesignPatternsInCSharp.Scripts.CreationalDesignPatterns.BuilderDesignPattern.FluentBuilderDesignPattern
{
    public sealed class DocumentCreatorWithFluentBuilder
    {
        private DocumentComponentWithFluentBuilder DocumentCreatorRootDocumentComponent { get; set; }

        private DocumentCreatorWithFluentBuilder(in string otherDocumentCreatorRootDocumentComponentIdentifierToHandle, in string otherDocumentCreatorRootDocumentComponentDescriptionToHandle) : base()
        {
            DocumentCreatorRootDocumentComponent = new DocumentComponentWithFluentBuilder(otherDocumentComponentIdentifierToHandle: otherDocumentCreatorRootDocumentComponentIdentifierToHandle, otherDocumentComponentDescriptionToHandle: otherDocumentCreatorRootDocumentComponentDescriptionToHandle);
        }

        public static DocumentCreatorWithFluentBuilder CreateDocumentCreatorRootDocumentComponentUsing(in string otherDocumentCreatorRootDocumentComponentIdentifierToHandle, in string otherDocumentCreatorRootDocumentComponentDescriptionToHandle)
        {
            return new DocumentCreatorWithFluentBuilder(otherDocumentCreatorRootDocumentComponentIdentifierToHandle: otherDocumentCreatorRootDocumentComponentIdentifierToHandle, otherDocumentCreatorRootDocumentComponentDescriptionToHandle: otherDocumentCreatorRootDocumentComponentDescriptionToHandle);
        }

        public DocumentComponentWithFluentBuilder GetDocumentCreatorRootDocumentComponent()
        {
            return DocumentCreatorRootDocumentComponent;
        }

        public DocumentCreatorWithFluentBuilder AddDocumentCreatorRootDocumentComponentChildrenDocumentComponentElementUsing(in string otherDocumentCreatorRootDocumentComponentChildrenDocumentComponentIdentifierToHandle, in string otherDocumentCreatorRootDocumentComponentChildrenDocumentComponentDescriptionToHandle)
        {
            if (DocumentCreatorRootDocumentComponent == null)
            {
                return null;
            }

            DocumentComponentWithFluentBuilder documentCreatorRootDocumentComponentChildrenDocumentComponentElement = new(otherDocumentComponentIdentifierToHandle: otherDocumentCreatorRootDocumentComponentChildrenDocumentComponentIdentifierToHandle, otherDocumentComponentDescriptionToHandle: otherDocumentCreatorRootDocumentComponentChildrenDocumentComponentDescriptionToHandle);

            if (DocumentCreatorRootDocumentComponent.AddDocumentComponentChildrenDocumentComponentElementUsing(otherDocumentComponentChildrenDocumentComponentElementToHandle: documentCreatorRootDocumentComponentChildrenDocumentComponentElement) == false)
            {
                return null;
            }

            return this;
        }
    }
}