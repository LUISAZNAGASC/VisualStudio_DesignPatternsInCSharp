namespace VisualStudio_DesignPatternsInCSharp.CreationalDesignPatterns.BuilderDesignPattern.FluentBuilderDesignPattern
{
    public sealed class DocumentCreatorWithFluentBuilder
    {
        private DocumentComponentWithFluentBuilder DocumentCreatorRootDocumentComponent { get; set; }

        private DocumentCreatorWithFluentBuilder(in string newDocumentCreatorRootDocumentComponentIdentifierToInitialize, in string newDocumentCreatorRootDocumentComponentDescriptionToInitialize) : base()
        {
            DocumentCreatorRootDocumentComponent = new DocumentComponentWithFluentBuilder(newDocumentComponentIdentifierToInitialize: newDocumentCreatorRootDocumentComponentIdentifierToInitialize, newDocumentComponentDescriptionToInitialize: newDocumentCreatorRootDocumentComponentDescriptionToInitialize);
        }

        public DocumentComponentWithFluentBuilder GetDocumentCreatorRootDocumentComponent()
        {
            return DocumentCreatorRootDocumentComponent;
        }

        public DocumentCreatorWithFluentBuilder AddDocumentCreatorRootDocumentComponentChildrenDocumentComponentElementUsing(in string newDocumentCreatorRootDocumentComponentChildrenDocumentComponentIdentifierToAdd, in string newDocumentCreatorRootDocumentComponentChildrenDocumentComponentDescriptionToAdd)
        {
            if (DocumentCreatorRootDocumentComponent == null)
            {
                return null;
            }

            DocumentComponentWithFluentBuilder newDocumentCreatorRootDocumentComponentChildrenDocumentComponentElement = new DocumentComponentWithFluentBuilder(newDocumentComponentIdentifierToInitialize: newDocumentCreatorRootDocumentComponentChildrenDocumentComponentIdentifierToAdd, newDocumentComponentDescriptionToInitialize: newDocumentCreatorRootDocumentComponentChildrenDocumentComponentDescriptionToAdd);

            if (DocumentCreatorRootDocumentComponent.AddDocumentComponentChildrenDocumentComponentElementUsing(newDocumentComponentChildrenDocumentComponentElementToAdd: newDocumentCreatorRootDocumentComponentChildrenDocumentComponentElement) == false)
            {
                return null;
            }

            return this;
        }

        public static DocumentCreatorWithFluentBuilder CreateDocumentCreatorRootDocumentComponentUsing(in string newDocumentCreatorRootDocumentComponentIdentifierToCreate, in string newDocumentCreatorRootDocumentComponentDescriptionToCreate)
        {
            return new DocumentCreatorWithFluentBuilder(newDocumentCreatorRootDocumentComponentIdentifierToInitialize: newDocumentCreatorRootDocumentComponentIdentifierToCreate, newDocumentCreatorRootDocumentComponentDescriptionToInitialize: newDocumentCreatorRootDocumentComponentDescriptionToCreate);
        }
    }
}