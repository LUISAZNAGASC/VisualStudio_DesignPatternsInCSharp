namespace VisualStudio_DesignPatternsInCSharp.Scripts.StructuralDesignPatterns.CompositeDesignPattern.CompositeSpecificationDesignPattern
{
    using System.Collections.Generic;

    public sealed class TemplateDatabaseWithCompositeSpecification<TTemplateComponentWithCompositeSpecification> where TTemplateComponentWithCompositeSpecification : class
    {
        private List<TTemplateComponentWithCompositeSpecification> TemplateDatabaseTemplateComponentCollection { get; set; }

        private static TemplateDatabaseWithCompositeSpecification<TTemplateComponentWithCompositeSpecification> TemplateDatabaseInstance { get; set; }

        private TemplateDatabaseWithCompositeSpecification() : base()
        {
            TemplateDatabaseTemplateComponentCollection = [];
        }

        public static TemplateDatabaseWithCompositeSpecification<TTemplateComponentWithCompositeSpecification> GetTemplateDatabaseInstance()
        {
            TemplateDatabaseInstance ??= new TemplateDatabaseWithCompositeSpecification<TTemplateComponentWithCompositeSpecification>();

            return TemplateDatabaseInstance;
        }

        public IEnumerable<TTemplateComponentWithCompositeSpecification> GetTemplateDatabaseTemplateComponentCollection()
        {
            TemplateDatabaseTemplateComponentCollection ??= [];

            foreach (TTemplateComponentWithCompositeSpecification templateDatabaseTemplateComponentElement in TemplateDatabaseTemplateComponentCollection)
            {
                yield return templateDatabaseTemplateComponentElement;
            }
        }

        public TTemplateComponentWithCompositeSpecification GetTemplateDatabaseTemplateComponentElementUsing(in uint otherTemplateDatabaseTemplateComponentCollectionIndexToHandle)
        {
            if (TemplateDatabaseTemplateComponentCollection == null)
            {
                return null;
            }

            if (otherTemplateDatabaseTemplateComponentCollectionIndexToHandle < uint.MinValue || otherTemplateDatabaseTemplateComponentCollectionIndexToHandle >= TemplateDatabaseTemplateComponentCollection.Count)
            {
                return null;
            }

            return TemplateDatabaseTemplateComponentCollection[index: (int)otherTemplateDatabaseTemplateComponentCollectionIndexToHandle];
        }

        public bool AddTemplateDatabaseTemplateComponentElementUsing(in TTemplateComponentWithCompositeSpecification otherTemplateDatabaseTemplateComponentElementToHandle)
        {
            if (TemplateDatabaseTemplateComponentCollection == null)
            {
                return false;
            }

            if (otherTemplateDatabaseTemplateComponentElementToHandle == null)
            {
                return false;
            }

            TemplateDatabaseTemplateComponentCollection.Add(item: otherTemplateDatabaseTemplateComponentElementToHandle);

            return true;
        }

        public bool RemoveTemplateDatabaseTemplateComponentElementUsing(in TTemplateComponentWithCompositeSpecification otherTemplateDatabaseTemplateComponentElementToHandle)
        {
            if (TemplateDatabaseTemplateComponentCollection == null)
            {
                return false;
            }

            if (otherTemplateDatabaseTemplateComponentElementToHandle == null)
            {
                return false;
            }

            if (TemplateDatabaseTemplateComponentCollection.Contains(item: otherTemplateDatabaseTemplateComponentElementToHandle) == false)
            {
                return false;
            }

            return TemplateDatabaseTemplateComponentCollection.Remove(item: otherTemplateDatabaseTemplateComponentElementToHandle);
        }

        public IEnumerable<TTemplateComponentWithCompositeSpecification> GetTemplateDatabaseTemplateComponentCollectionUsing(TemplateSpecificationWithCompositeSpecification<TTemplateComponentWithCompositeSpecification> otherTemplateDatabaseTemplateTemplateSpecificationToHandle)
        {
            foreach (TTemplateComponentWithCompositeSpecification templateDatabaseTemplateComponentElement in TemplateDatabaseTemplateComponentCollection)
            {
                if (otherTemplateDatabaseTemplateTemplateSpecificationToHandle.CheckTemplateSpecificationIsValidUsing(otherTemplateSpecificationTemplateComponentToHandle: templateDatabaseTemplateComponentElement) == true)
                {
                    yield return templateDatabaseTemplateComponentElement;
                }
            }
        }
    }
}