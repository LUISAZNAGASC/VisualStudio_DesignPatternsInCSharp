namespace VisualStudio_DesignPatternsInCSharp.Scripts.CreationalDesignPatterns.PrototypeDesignPattern.RegularPrototypeDesignPattern
{
    public interface IPrototypeComponent<TemplateComponent1>
        where TemplateComponent1 : class, IPrototypeComponent<TemplateComponent1>, new()
    {
        public TemplateComponent1 GetPrototypeComponentClonation()
        {
            IPrototypeComponent<TemplateComponent1> prototypeComponentClonation = new TemplateComponent1();

            SetPrototypeComponentClonation(prototypeComponentClonation: (TemplateComponent1)prototypeComponentClonation);

            return (TemplateComponent1)prototypeComponentClonation;
        }

        public void SetPrototypeComponentClonation(in TemplateComponent1 prototypeComponentClonation);
    }
}