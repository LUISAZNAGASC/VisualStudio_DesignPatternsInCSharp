namespace VisualStudio_DesignPatternsInCSharp.Scripts.CreationalDesignPatterns.SingletonDesignPattern.RegularSingletonDesignPattern
{
    using System.Collections.Generic;

    public sealed class TemplateDatabaseWithRegularSingleton<TTemplateComponentWithRegularSingleton> where TTemplateComponentWithRegularSingleton : class
    {
        private List<TTemplateComponentWithRegularSingleton> TemplateDatabaseTemplateComponentCollection { get; set; }

        private static TemplateDatabaseWithRegularSingleton<TTemplateComponentWithRegularSingleton> TemplateDatabaseInstance { get; set; }

        private TemplateDatabaseWithRegularSingleton() : base()
        {
            TemplateDatabaseTemplateComponentCollection = [];
        }

        public static TemplateDatabaseWithRegularSingleton<TTemplateComponentWithRegularSingleton> GetTemplateDatabaseInstance()
        {
            TemplateDatabaseInstance ??= new TemplateDatabaseWithRegularSingleton<TTemplateComponentWithRegularSingleton>();

            return TemplateDatabaseInstance;
        }

        public IEnumerable<TTemplateComponentWithRegularSingleton> GetTemplateDatabaseTemplateComponentCollection()
        {
            TemplateDatabaseTemplateComponentCollection ??= [];

            foreach (TTemplateComponentWithRegularSingleton templateDatabaseTemplateComponentElement in TemplateDatabaseTemplateComponentCollection)
            {
                yield return templateDatabaseTemplateComponentElement;
            }
        }

        public TTemplateComponentWithRegularSingleton GetTemplateDatabaseTemplateComponentElementUsing(in uint otherTemplateDatabaseTemplateComponentCollectionIndexToHandle)
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

        public bool AddTemplateDatabaseTemplateComponentElementUsing(in TTemplateComponentWithRegularSingleton otherTemplateDatabaseTemplateComponentElementToHandle)
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

        public bool RemoveTemplateDatabaseTemplateComponentElementUsing(in TTemplateComponentWithRegularSingleton otherTemplateDatabaseTemplateComponentElementToHandle)
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
    }
}