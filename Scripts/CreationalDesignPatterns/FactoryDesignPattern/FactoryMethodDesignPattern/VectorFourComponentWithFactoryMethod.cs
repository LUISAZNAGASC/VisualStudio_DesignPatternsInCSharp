namespace VisualStudio_DesignPatternsInCSharp.CreationalDesignPatterns.FactoryDesignPattern.FactoryMethodDesignPattern
{
    using System;
    using System.Text;

    public struct VectorFourComponentWithFactoryMethod
    {
        public double VectorFourComponentXNumber { get; private set; }
        public double VectorFourComponentYNumber { get; private set; }
        public double VectorFourComponentZNumber { get; private set; }
        public double VectorFourComponentWNumber { get; private set; }

        public VectorFourComponentWithFactoryMethod(in double newVectorFourComponentXNumberToInitialize, in double newVectorFourComponentYNumberToInitialize, in double newVectorFourComponentZNumberToInitialize, in double newVectorFourComponentWNumberToInitialize) : this()
        {
            VectorFourComponentXNumber = newVectorFourComponentXNumberToInitialize;
            VectorFourComponentYNumber = newVectorFourComponentYNumberToInitialize;
            VectorFourComponentZNumber = newVectorFourComponentZNumberToInitialize;
            VectorFourComponentWNumber = newVectorFourComponentWNumberToInitialize;
        }

        public void DisplayVectorFourComponentContent()
        {
            Console.WriteLine(value: GetVectorFourComponentContentUsing(specificVectorFourComponentToHandle: this));
        }

        public StringBuilder GetVectorFourComponentContent()
        {
            StringBuilder vectorFourComponentContentStringBuilder = new StringBuilder();

            vectorFourComponentContentStringBuilder.Append(value: "{ ".ToUpperInvariant());
            vectorFourComponentContentStringBuilder.Append(value: $"{VectorFourComponentXNumber.ToString().ToUpperInvariant()}".ToUpperInvariant());
            vectorFourComponentContentStringBuilder.Append(value: " , ".ToUpperInvariant());
            vectorFourComponentContentStringBuilder.Append(value: $"{VectorFourComponentYNumber.ToString().ToUpperInvariant()}".ToUpperInvariant());
            vectorFourComponentContentStringBuilder.Append(value: " , ".ToUpperInvariant());
            vectorFourComponentContentStringBuilder.Append(value: $"{VectorFourComponentZNumber.ToString().ToUpperInvariant()}".ToUpperInvariant());
            vectorFourComponentContentStringBuilder.Append(value: " , ".ToUpperInvariant());
            vectorFourComponentContentStringBuilder.Append(value: $"{VectorFourComponentWNumber.ToString().ToUpperInvariant()}".ToUpperInvariant());
            vectorFourComponentContentStringBuilder.Append(value: " }".ToUpperInvariant());

            return vectorFourComponentContentStringBuilder;
        }

        private static StringBuilder GetVectorFourComponentContentUsing(in VectorFourComponentWithFactoryMethod specificVectorFourComponentToHandle)
        {
            StringBuilder vectorFourComponentContentStringBuilder = new StringBuilder();

            vectorFourComponentContentStringBuilder.Append(value: specificVectorFourComponentToHandle.GetVectorFourComponentContent());

            return vectorFourComponentContentStringBuilder;
        }

        public override bool Equals(object specificVectorFourComponentUndefinedObject)
        {
            if (ReferenceEquals(objA: this, objB: specificVectorFourComponentUndefinedObject) == true)
            {
                return true;
            }

            if (specificVectorFourComponentUndefinedObject == null || specificVectorFourComponentUndefinedObject is VectorFourComponentWithFactoryMethod specificVectorFourComponentDefinedObject == false)
            {
                return false;
            }

            if (VectorFourComponentXNumber != specificVectorFourComponentDefinedObject.VectorFourComponentXNumber || VectorFourComponentYNumber != specificVectorFourComponentDefinedObject.VectorFourComponentYNumber || VectorFourComponentZNumber != specificVectorFourComponentDefinedObject.VectorFourComponentZNumber || VectorFourComponentWNumber != specificVectorFourComponentDefinedObject.VectorFourComponentWNumber)
            {
                return false;
            }

            return true;
        }

        public override int GetHashCode()
        {
            const int VectorFourComponentHashCodeInitialPrime = 17;
            const int VectorFourComponentHashCodeMultiplierPrime = 23;

            int vectorFourComponentHashCode = VectorFourComponentHashCodeInitialPrime;

            vectorFourComponentHashCode = vectorFourComponentHashCode * VectorFourComponentHashCodeMultiplierPrime + VectorFourComponentXNumber.GetHashCode();
            vectorFourComponentHashCode = vectorFourComponentHashCode * VectorFourComponentHashCodeMultiplierPrime + VectorFourComponentYNumber.GetHashCode();
            vectorFourComponentHashCode = vectorFourComponentHashCode * VectorFourComponentHashCodeMultiplierPrime + VectorFourComponentZNumber.GetHashCode();
            vectorFourComponentHashCode = vectorFourComponentHashCode * VectorFourComponentHashCodeMultiplierPrime + VectorFourComponentWNumber.GetHashCode();

            return vectorFourComponentHashCode;
        }

        public override string ToString()
        {
            return GetVectorFourComponentContent().ToString().ToUpperInvariant();
        }
    }
}