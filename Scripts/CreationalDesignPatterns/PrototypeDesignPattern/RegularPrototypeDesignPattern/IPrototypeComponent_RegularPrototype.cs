namespace VisualStudio_DesignPatternsInCSharp.Scripts.CreationalDesignPatterns.PrototypeDesignPattern.RegularPrototypeDesignPattern
{
    public interface IPrototypeComponent<TemplateComponent1>
        where TemplateComponent1 : class, IPrototypeComponent<TemplateComponent1>
    {
        public TemplateComponent1 GetPrototypeComponentClonation();

        public void SetPrototypeComponentClonation(in TemplateComponent1 prototypeComponentClonation);
    }
}