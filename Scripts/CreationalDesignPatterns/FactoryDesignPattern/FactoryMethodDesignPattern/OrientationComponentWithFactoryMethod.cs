namespace VisualStudio_DesignPatternsInCSharp.CreationalDesignPatterns.FactoryDesignPattern.FactoryMethodDesignPattern
{
    using System;
    using System.Text;

    public sealed class OrientationComponentWithFactoryMethod
    {
        private VectorFourComponentWithFactoryMethod OrientationComponentFirstRow { get; set; }
        private VectorFourComponentWithFactoryMethod OrientationComponentSecondRow { get; set; }
        private VectorFourComponentWithFactoryMethod OrientationComponentThirdRow { get; set; }
        private VectorFourComponentWithFactoryMethod OrientationComponentFourthRow { get; set; }

        private OrientationComponentWithFactoryMethod(in VectorFourComponentWithFactoryMethod newOrientationComponentFirstRowToInitialize, in VectorFourComponentWithFactoryMethod newOrientationComponentSecondRowToInitialize, in VectorFourComponentWithFactoryMethod newOrientationComponentThirdRowToInitialize, in VectorFourComponentWithFactoryMethod newOrientationComponentFourthRowToInitialize)
        {
            OrientationComponentFirstRow = newOrientationComponentFirstRowToInitialize;
            OrientationComponentSecondRow = newOrientationComponentSecondRowToInitialize;
            OrientationComponentThirdRow = newOrientationComponentThirdRowToInitialize;
            OrientationComponentFourthRow = newOrientationComponentFourthRowToInitialize;
        }

        public double[,] GetOrientationComponentCollection()
        {
            return new double[,]
            {
                {
                    OrientationComponentFirstRow.VectorFourComponentXNumber,
                    OrientationComponentFirstRow.VectorFourComponentYNumber,
                    OrientationComponentFirstRow.VectorFourComponentZNumber,
                    OrientationComponentFirstRow.VectorFourComponentWNumber
                },
                {
                    OrientationComponentSecondRow.VectorFourComponentXNumber,
                    OrientationComponentSecondRow.VectorFourComponentYNumber,
                    OrientationComponentSecondRow.VectorFourComponentZNumber,
                    OrientationComponentSecondRow.VectorFourComponentWNumber
                },
                {
                    OrientationComponentThirdRow.VectorFourComponentXNumber,
                    OrientationComponentThirdRow.VectorFourComponentYNumber,
                    OrientationComponentThirdRow.VectorFourComponentZNumber,
                    OrientationComponentThirdRow.VectorFourComponentWNumber
                },
                {
                    OrientationComponentFourthRow.VectorFourComponentXNumber,
                    OrientationComponentFourthRow.VectorFourComponentYNumber,
                    OrientationComponentFourthRow.VectorFourComponentZNumber,
                    OrientationComponentFourthRow.VectorFourComponentWNumber
                }
            };
        }

        public void DisplayOrientationComponentContent()
        {
            Console.WriteLine(value: GetOrientationComponentContentUsing(specificOrientationComponentToHandle: this));
        }

        public StringBuilder GetOrientationComponentContent()
        {
            StringBuilder orientationComponentContentStringBuilder = new StringBuilder();

            orientationComponentContentStringBuilder.Append(value: "{ ".ToUpperInvariant());
            orientationComponentContentStringBuilder.Append(value: $"{OrientationComponentFirstRow.ToString().ToUpperInvariant()}".ToUpperInvariant());
            orientationComponentContentStringBuilder.Append(value: " , ".ToUpperInvariant());
            orientationComponentContentStringBuilder.Append(value: $"{OrientationComponentSecondRow.ToString().ToUpperInvariant()}".ToUpperInvariant());
            orientationComponentContentStringBuilder.Append(value: " , ".ToUpperInvariant());
            orientationComponentContentStringBuilder.Append(value: $"{OrientationComponentThirdRow.ToString().ToUpperInvariant()}".ToUpperInvariant());
            orientationComponentContentStringBuilder.Append(value: " , ".ToUpperInvariant());
            orientationComponentContentStringBuilder.Append(value: $"{OrientationComponentFourthRow.ToString().ToUpperInvariant()}".ToUpperInvariant());
            orientationComponentContentStringBuilder.Append(value: " }".ToUpperInvariant());

            return orientationComponentContentStringBuilder;
        }

        private static StringBuilder GetOrientationComponentContentUsing(in OrientationComponentWithFactoryMethod specificOrientationComponentToHandle)
        {
            StringBuilder orientationComponentContentStringBuilder = new StringBuilder();

            orientationComponentContentStringBuilder.Append(value: specificOrientationComponentToHandle.GetOrientationComponentContent());

            return orientationComponentContentStringBuilder;
        }

        public override bool Equals(object specificOrientationComponentUndefinedObject)
        {
            if (ReferenceEquals(objA: this, objB: specificOrientationComponentUndefinedObject) == true)
            {
                return true;
            }

            if (specificOrientationComponentUndefinedObject == null || specificOrientationComponentUndefinedObject is OrientationComponentWithFactoryMethod specificOrientationComponentDefinedObject == false)
            {
                return false;
            }

            if (OrientationComponentFirstRow.Equals(specificVectorFourComponentUndefinedObject: specificOrientationComponentDefinedObject.OrientationComponentFirstRow) == false || OrientationComponentSecondRow.Equals(specificVectorFourComponentUndefinedObject: specificOrientationComponentDefinedObject.OrientationComponentSecondRow) == false || OrientationComponentThirdRow.Equals(specificVectorFourComponentUndefinedObject: specificOrientationComponentDefinedObject.OrientationComponentThirdRow) == false || OrientationComponentFourthRow.Equals(specificVectorFourComponentUndefinedObject: specificOrientationComponentDefinedObject.OrientationComponentFourthRow) == false)
            {
                return false;
            }

            return true;
        }

        public override int GetHashCode()
        {
            const int OrientationComponentHashCodeInitialPrime = 17;
            const int OrientationComponentHashCodeMultiplierPrime = 23;

            int orientationComponentHashCode = OrientationComponentHashCodeInitialPrime;

            orientationComponentHashCode = orientationComponentHashCode * OrientationComponentHashCodeMultiplierPrime + OrientationComponentFirstRow.GetHashCode();
            orientationComponentHashCode = orientationComponentHashCode * OrientationComponentHashCodeMultiplierPrime + OrientationComponentSecondRow.GetHashCode();
            orientationComponentHashCode = orientationComponentHashCode * OrientationComponentHashCodeMultiplierPrime + OrientationComponentThirdRow.GetHashCode();
            orientationComponentHashCode = orientationComponentHashCode * OrientationComponentHashCodeMultiplierPrime + OrientationComponentFourthRow.GetHashCode();

            return orientationComponentHashCode;
        }

        public override string ToString()
        {
            return GetOrientationComponentContentUsing(specificOrientationComponentToHandle: this).ToString().ToUpperInvariant();
        }

        public static class OrientationFactoryWithFactoryMethod
        {
            private const double OrientationComponentNumericConstantZero = 0.0;
            private const double OrientationComponentNumericConstantOne = 1.0;
            private const double OrientationComponentNumericConstantDegreesToRadians = Math.PI / 180.0;

            public static OrientationComponentWithFactoryMethod GetOrientationComponentPitchRotationUsing(in double orientationComponentTargetPitchAngle)
            {
                double orientationComponentSinePitchAngle = Math.Sin(a: orientationComponentTargetPitchAngle * OrientationComponentNumericConstantDegreesToRadians);
                double orientationComponentCosinePitchAngle = Math.Cos(d: orientationComponentTargetPitchAngle * OrientationComponentNumericConstantDegreesToRadians);

                VectorFourComponentWithFactoryMethod orientationComponentFirstRow = new VectorFourComponentWithFactoryMethod(newVectorFourComponentXNumberToInitialize: OrientationComponentNumericConstantOne, newVectorFourComponentYNumberToInitialize: OrientationComponentNumericConstantZero, newVectorFourComponentZNumberToInitialize: OrientationComponentNumericConstantZero, newVectorFourComponentWNumberToInitialize: OrientationComponentNumericConstantZero);
                VectorFourComponentWithFactoryMethod orientationComponentSecondRow = new VectorFourComponentWithFactoryMethod(newVectorFourComponentXNumberToInitialize: OrientationComponentNumericConstantZero, newVectorFourComponentYNumberToInitialize: orientationComponentCosinePitchAngle, newVectorFourComponentZNumberToInitialize: -orientationComponentSinePitchAngle, newVectorFourComponentWNumberToInitialize: OrientationComponentNumericConstantZero);
                VectorFourComponentWithFactoryMethod orientationComponentThirdRow = new VectorFourComponentWithFactoryMethod(newVectorFourComponentXNumberToInitialize: OrientationComponentNumericConstantZero, newVectorFourComponentYNumberToInitialize: orientationComponentSinePitchAngle, newVectorFourComponentZNumberToInitialize: orientationComponentCosinePitchAngle, newVectorFourComponentWNumberToInitialize: OrientationComponentNumericConstantZero);
                VectorFourComponentWithFactoryMethod orientationComponentFourthRow = new VectorFourComponentWithFactoryMethod(newVectorFourComponentXNumberToInitialize: OrientationComponentNumericConstantZero, newVectorFourComponentYNumberToInitialize: OrientationComponentNumericConstantZero, newVectorFourComponentZNumberToInitialize: OrientationComponentNumericConstantZero, newVectorFourComponentWNumberToInitialize: OrientationComponentNumericConstantOne);

                return new OrientationComponentWithFactoryMethod(newOrientationComponentFirstRowToInitialize: orientationComponentFirstRow, newOrientationComponentSecondRowToInitialize: orientationComponentSecondRow, newOrientationComponentThirdRowToInitialize: orientationComponentThirdRow, newOrientationComponentFourthRowToInitialize: orientationComponentFourthRow);
            }

            public static OrientationComponentWithFactoryMethod GetOrientationComponentYawRotationUsing(in double orientationComponentTargetYawAngle)
            {
                double orientationComponentSineYawAngle = Math.Sin(a: orientationComponentTargetYawAngle * OrientationComponentNumericConstantDegreesToRadians);
                double orientationComponentCosineYawAngle = Math.Cos(d: orientationComponentTargetYawAngle * OrientationComponentNumericConstantDegreesToRadians);

                VectorFourComponentWithFactoryMethod orientationComponentFirstRow = new VectorFourComponentWithFactoryMethod(newVectorFourComponentXNumberToInitialize: orientationComponentCosineYawAngle, newVectorFourComponentYNumberToInitialize: OrientationComponentNumericConstantZero, newVectorFourComponentZNumberToInitialize: orientationComponentSineYawAngle, newVectorFourComponentWNumberToInitialize: OrientationComponentNumericConstantZero);
                VectorFourComponentWithFactoryMethod orientationComponentSecondRow = new VectorFourComponentWithFactoryMethod(newVectorFourComponentXNumberToInitialize: OrientationComponentNumericConstantZero, newVectorFourComponentYNumberToInitialize: OrientationComponentNumericConstantOne, newVectorFourComponentZNumberToInitialize: OrientationComponentNumericConstantZero, newVectorFourComponentWNumberToInitialize: OrientationComponentNumericConstantZero);
                VectorFourComponentWithFactoryMethod orientationComponentThirdRow = new VectorFourComponentWithFactoryMethod(newVectorFourComponentXNumberToInitialize: -orientationComponentSineYawAngle, newVectorFourComponentYNumberToInitialize: OrientationComponentNumericConstantZero, newVectorFourComponentZNumberToInitialize: orientationComponentCosineYawAngle, newVectorFourComponentWNumberToInitialize: OrientationComponentNumericConstantZero);
                VectorFourComponentWithFactoryMethod orientationComponentFourthRow = new VectorFourComponentWithFactoryMethod(newVectorFourComponentXNumberToInitialize: OrientationComponentNumericConstantZero, newVectorFourComponentYNumberToInitialize: OrientationComponentNumericConstantZero, newVectorFourComponentZNumberToInitialize: OrientationComponentNumericConstantZero, newVectorFourComponentWNumberToInitialize: OrientationComponentNumericConstantOne);

                return new OrientationComponentWithFactoryMethod(newOrientationComponentFirstRowToInitialize: orientationComponentFirstRow, newOrientationComponentSecondRowToInitialize: orientationComponentSecondRow, newOrientationComponentThirdRowToInitialize: orientationComponentThirdRow, newOrientationComponentFourthRowToInitialize: orientationComponentFourthRow);
            }

            public static OrientationComponentWithFactoryMethod GetOrientationComponentRollRotationUsing(in double orientationComponentTargetRollAngle)
            {
                double orientationComponentSineRollAngle = Math.Sin(a: orientationComponentTargetRollAngle * OrientationComponentNumericConstantDegreesToRadians);
                double orientationComponentCosineRollAngle = Math.Cos(d: orientationComponentTargetRollAngle * OrientationComponentNumericConstantDegreesToRadians);

                VectorFourComponentWithFactoryMethod orientationComponentFirstRow = new VectorFourComponentWithFactoryMethod(newVectorFourComponentXNumberToInitialize: orientationComponentCosineRollAngle, newVectorFourComponentYNumberToInitialize: -orientationComponentSineRollAngle, newVectorFourComponentZNumberToInitialize: OrientationComponentNumericConstantZero, newVectorFourComponentWNumberToInitialize: OrientationComponentNumericConstantZero);
                VectorFourComponentWithFactoryMethod orientationComponentSecondRow = new VectorFourComponentWithFactoryMethod(newVectorFourComponentXNumberToInitialize: orientationComponentSineRollAngle, newVectorFourComponentYNumberToInitialize: orientationComponentCosineRollAngle, newVectorFourComponentZNumberToInitialize: OrientationComponentNumericConstantZero, newVectorFourComponentWNumberToInitialize: OrientationComponentNumericConstantZero); ;
                VectorFourComponentWithFactoryMethod orientationComponentThirdRow = new VectorFourComponentWithFactoryMethod(newVectorFourComponentXNumberToInitialize: OrientationComponentNumericConstantZero, newVectorFourComponentYNumberToInitialize: OrientationComponentNumericConstantZero, newVectorFourComponentZNumberToInitialize: OrientationComponentNumericConstantOne, newVectorFourComponentWNumberToInitialize: OrientationComponentNumericConstantZero);
                VectorFourComponentWithFactoryMethod orientationComponentFourthRow = new VectorFourComponentWithFactoryMethod(newVectorFourComponentXNumberToInitialize: OrientationComponentNumericConstantZero, newVectorFourComponentYNumberToInitialize: OrientationComponentNumericConstantZero, newVectorFourComponentZNumberToInitialize: OrientationComponentNumericConstantZero, newVectorFourComponentWNumberToInitialize: OrientationComponentNumericConstantOne);

                return new OrientationComponentWithFactoryMethod(newOrientationComponentFirstRowToInitialize: orientationComponentFirstRow, newOrientationComponentSecondRowToInitialize: orientationComponentSecondRow, newOrientationComponentThirdRowToInitialize: orientationComponentThirdRow, newOrientationComponentFourthRowToInitialize: orientationComponentFourthRow);
            }
        }
    }
}