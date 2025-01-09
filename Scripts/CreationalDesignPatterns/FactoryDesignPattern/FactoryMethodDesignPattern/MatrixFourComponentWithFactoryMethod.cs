namespace VisualStudio_DesignPatternsInCSharp.CreationalDesignPatterns.FactoryDesignPattern.FactoryMethodDesignPattern
{
    using System;
    using System.Text;

    public struct MatrixFourComponentWithFactoryMethod
    {
        public double MatrixFourComponentAX { get; set; }
        public double MatrixFourComponentAY { get; set; }
        public double MatrixFourComponentAZ { get; set; }
        public double MatrixFourComponentAW { get; set; }
        public double MatrixFourComponentBX { get; set; }
        public double MatrixFourComponentBY { get; set; }
        public double MatrixFourComponentBZ { get; set; }
        public double MatrixFourComponentBW { get; set; }
        public double MatrixFourComponentCX { get; set; }
        public double MatrixFourComponentCY { get; set; }
        public double MatrixFourComponentCZ { get; set; }
        public double MatrixFourComponentCW { get; set; }
        public double MatrixFourComponentDX { get; set; }
        public double MatrixFourComponentDY { get; set; }
        public double MatrixFourComponentDZ { get; set; }
        public double MatrixFourComponentDW { get; set; }

        public static MatrixFourComponentWithFactoryMethod GetMatrixFourComponentIdentity()
        {
            const double MatrixFourComponentIdentityUnfilledValue = 0.0;
            const double MatrixFourComponentIdentityFilledValue = 1.0;

            MatrixFourComponentWithFactoryMethod matrixFourComponentIdentity = new MatrixFourComponentWithFactoryMethod()
            {
                MatrixFourComponentAX = MatrixFourComponentIdentityFilledValue,
                MatrixFourComponentAY = MatrixFourComponentIdentityUnfilledValue,
                MatrixFourComponentAZ = MatrixFourComponentIdentityUnfilledValue,
                MatrixFourComponentAW = MatrixFourComponentIdentityUnfilledValue,
                MatrixFourComponentBX = MatrixFourComponentIdentityUnfilledValue,
                MatrixFourComponentBY = MatrixFourComponentIdentityFilledValue,
                MatrixFourComponentBZ = MatrixFourComponentIdentityUnfilledValue,
                MatrixFourComponentBW = MatrixFourComponentIdentityUnfilledValue,
                MatrixFourComponentCX = MatrixFourComponentIdentityUnfilledValue,
                MatrixFourComponentCY = MatrixFourComponentIdentityUnfilledValue,
                MatrixFourComponentCZ = MatrixFourComponentIdentityFilledValue,
                MatrixFourComponentCW = MatrixFourComponentIdentityUnfilledValue,
                MatrixFourComponentDX = MatrixFourComponentIdentityUnfilledValue,
                MatrixFourComponentDY = MatrixFourComponentIdentityUnfilledValue,
                MatrixFourComponentDZ = MatrixFourComponentIdentityUnfilledValue,
                MatrixFourComponentDW = MatrixFourComponentIdentityFilledValue
            };

            return matrixFourComponentIdentity;
        }

        public static MatrixFourComponentWithFactoryMethod operator *(in MatrixFourComponentWithFactoryMethod firstMatrixFourComponentToHandle, in MatrixFourComponentWithFactoryMethod secondMatrixFourComponentToHandle)
        {
            MatrixFourComponentWithFactoryMethod finalMatrixFourComponentToHandle = new MatrixFourComponentWithFactoryMethod()
            {
                MatrixFourComponentAX = firstMatrixFourComponentToHandle.MatrixFourComponentAX * secondMatrixFourComponentToHandle.MatrixFourComponentAX + firstMatrixFourComponentToHandle.MatrixFourComponentAY * secondMatrixFourComponentToHandle.MatrixFourComponentBX + firstMatrixFourComponentToHandle.MatrixFourComponentAZ * secondMatrixFourComponentToHandle.MatrixFourComponentCX + firstMatrixFourComponentToHandle.MatrixFourComponentAW * secondMatrixFourComponentToHandle.MatrixFourComponentDX,
                MatrixFourComponentAY = firstMatrixFourComponentToHandle.MatrixFourComponentAX * secondMatrixFourComponentToHandle.MatrixFourComponentAY + firstMatrixFourComponentToHandle.MatrixFourComponentAY * secondMatrixFourComponentToHandle.MatrixFourComponentBY + firstMatrixFourComponentToHandle.MatrixFourComponentAZ * secondMatrixFourComponentToHandle.MatrixFourComponentCY + firstMatrixFourComponentToHandle.MatrixFourComponentAW * secondMatrixFourComponentToHandle.MatrixFourComponentDY,
                MatrixFourComponentAZ = firstMatrixFourComponentToHandle.MatrixFourComponentAX * secondMatrixFourComponentToHandle.MatrixFourComponentAZ + firstMatrixFourComponentToHandle.MatrixFourComponentAY * secondMatrixFourComponentToHandle.MatrixFourComponentBZ + firstMatrixFourComponentToHandle.MatrixFourComponentAZ * secondMatrixFourComponentToHandle.MatrixFourComponentCZ + firstMatrixFourComponentToHandle.MatrixFourComponentAW * secondMatrixFourComponentToHandle.MatrixFourComponentDZ,
                MatrixFourComponentAW = firstMatrixFourComponentToHandle.MatrixFourComponentAX * secondMatrixFourComponentToHandle.MatrixFourComponentAW + firstMatrixFourComponentToHandle.MatrixFourComponentAY * secondMatrixFourComponentToHandle.MatrixFourComponentBW + firstMatrixFourComponentToHandle.MatrixFourComponentAZ * secondMatrixFourComponentToHandle.MatrixFourComponentCW + firstMatrixFourComponentToHandle.MatrixFourComponentAW * secondMatrixFourComponentToHandle.MatrixFourComponentDW,
                MatrixFourComponentBX = firstMatrixFourComponentToHandle.MatrixFourComponentBX * secondMatrixFourComponentToHandle.MatrixFourComponentAX + firstMatrixFourComponentToHandle.MatrixFourComponentBY * secondMatrixFourComponentToHandle.MatrixFourComponentBX + firstMatrixFourComponentToHandle.MatrixFourComponentBZ * secondMatrixFourComponentToHandle.MatrixFourComponentCX + firstMatrixFourComponentToHandle.MatrixFourComponentBW * secondMatrixFourComponentToHandle.MatrixFourComponentDX,
                MatrixFourComponentBY = firstMatrixFourComponentToHandle.MatrixFourComponentBX * secondMatrixFourComponentToHandle.MatrixFourComponentAY + firstMatrixFourComponentToHandle.MatrixFourComponentBY * secondMatrixFourComponentToHandle.MatrixFourComponentBY + firstMatrixFourComponentToHandle.MatrixFourComponentBZ * secondMatrixFourComponentToHandle.MatrixFourComponentCY + firstMatrixFourComponentToHandle.MatrixFourComponentBW * secondMatrixFourComponentToHandle.MatrixFourComponentDY,
                MatrixFourComponentBZ = firstMatrixFourComponentToHandle.MatrixFourComponentBX * secondMatrixFourComponentToHandle.MatrixFourComponentAZ + firstMatrixFourComponentToHandle.MatrixFourComponentBY * secondMatrixFourComponentToHandle.MatrixFourComponentBZ + firstMatrixFourComponentToHandle.MatrixFourComponentBZ * secondMatrixFourComponentToHandle.MatrixFourComponentCZ + firstMatrixFourComponentToHandle.MatrixFourComponentBW * secondMatrixFourComponentToHandle.MatrixFourComponentDZ,
                MatrixFourComponentBW = firstMatrixFourComponentToHandle.MatrixFourComponentBX * secondMatrixFourComponentToHandle.MatrixFourComponentAW + firstMatrixFourComponentToHandle.MatrixFourComponentBY * secondMatrixFourComponentToHandle.MatrixFourComponentBW + firstMatrixFourComponentToHandle.MatrixFourComponentBZ * secondMatrixFourComponentToHandle.MatrixFourComponentCW + firstMatrixFourComponentToHandle.MatrixFourComponentBW * secondMatrixFourComponentToHandle.MatrixFourComponentDW,
                MatrixFourComponentCX = firstMatrixFourComponentToHandle.MatrixFourComponentCX * secondMatrixFourComponentToHandle.MatrixFourComponentAX + firstMatrixFourComponentToHandle.MatrixFourComponentCY * secondMatrixFourComponentToHandle.MatrixFourComponentBX + firstMatrixFourComponentToHandle.MatrixFourComponentCZ * secondMatrixFourComponentToHandle.MatrixFourComponentCX + firstMatrixFourComponentToHandle.MatrixFourComponentCW * secondMatrixFourComponentToHandle.MatrixFourComponentDX,
                MatrixFourComponentCY = firstMatrixFourComponentToHandle.MatrixFourComponentCX * secondMatrixFourComponentToHandle.MatrixFourComponentAY + firstMatrixFourComponentToHandle.MatrixFourComponentCY * secondMatrixFourComponentToHandle.MatrixFourComponentBY + firstMatrixFourComponentToHandle.MatrixFourComponentCZ * secondMatrixFourComponentToHandle.MatrixFourComponentCY + firstMatrixFourComponentToHandle.MatrixFourComponentCW * secondMatrixFourComponentToHandle.MatrixFourComponentDY,
                MatrixFourComponentCZ = firstMatrixFourComponentToHandle.MatrixFourComponentCX * secondMatrixFourComponentToHandle.MatrixFourComponentAZ + firstMatrixFourComponentToHandle.MatrixFourComponentCY * secondMatrixFourComponentToHandle.MatrixFourComponentBZ + firstMatrixFourComponentToHandle.MatrixFourComponentCZ * secondMatrixFourComponentToHandle.MatrixFourComponentCZ + firstMatrixFourComponentToHandle.MatrixFourComponentCW * secondMatrixFourComponentToHandle.MatrixFourComponentDZ,
                MatrixFourComponentCW = firstMatrixFourComponentToHandle.MatrixFourComponentCX * secondMatrixFourComponentToHandle.MatrixFourComponentAW + firstMatrixFourComponentToHandle.MatrixFourComponentCY * secondMatrixFourComponentToHandle.MatrixFourComponentBW + firstMatrixFourComponentToHandle.MatrixFourComponentCZ * secondMatrixFourComponentToHandle.MatrixFourComponentCW + firstMatrixFourComponentToHandle.MatrixFourComponentCW * secondMatrixFourComponentToHandle.MatrixFourComponentDW,
                MatrixFourComponentDX = firstMatrixFourComponentToHandle.MatrixFourComponentDX * secondMatrixFourComponentToHandle.MatrixFourComponentAX + firstMatrixFourComponentToHandle.MatrixFourComponentDY * secondMatrixFourComponentToHandle.MatrixFourComponentBX + firstMatrixFourComponentToHandle.MatrixFourComponentDZ * secondMatrixFourComponentToHandle.MatrixFourComponentCX + firstMatrixFourComponentToHandle.MatrixFourComponentDW * secondMatrixFourComponentToHandle.MatrixFourComponentDX,
                MatrixFourComponentDY = firstMatrixFourComponentToHandle.MatrixFourComponentDX * secondMatrixFourComponentToHandle.MatrixFourComponentAY + firstMatrixFourComponentToHandle.MatrixFourComponentDY * secondMatrixFourComponentToHandle.MatrixFourComponentBY + firstMatrixFourComponentToHandle.MatrixFourComponentDZ * secondMatrixFourComponentToHandle.MatrixFourComponentCY + firstMatrixFourComponentToHandle.MatrixFourComponentDW * secondMatrixFourComponentToHandle.MatrixFourComponentDY,
                MatrixFourComponentDZ = firstMatrixFourComponentToHandle.MatrixFourComponentDX * secondMatrixFourComponentToHandle.MatrixFourComponentAZ + firstMatrixFourComponentToHandle.MatrixFourComponentDY * secondMatrixFourComponentToHandle.MatrixFourComponentBZ + firstMatrixFourComponentToHandle.MatrixFourComponentDZ * secondMatrixFourComponentToHandle.MatrixFourComponentCZ + firstMatrixFourComponentToHandle.MatrixFourComponentDW * secondMatrixFourComponentToHandle.MatrixFourComponentDZ,
                MatrixFourComponentDW = firstMatrixFourComponentToHandle.MatrixFourComponentDX * secondMatrixFourComponentToHandle.MatrixFourComponentAW + firstMatrixFourComponentToHandle.MatrixFourComponentDY * secondMatrixFourComponentToHandle.MatrixFourComponentBW + firstMatrixFourComponentToHandle.MatrixFourComponentDZ * secondMatrixFourComponentToHandle.MatrixFourComponentCW + firstMatrixFourComponentToHandle.MatrixFourComponentDW * secondMatrixFourComponentToHandle.MatrixFourComponentDW
            };

            return finalMatrixFourComponentToHandle;
        }

        public void DisplayMatrixFourComponentContent()
        {
            Console.WriteLine(value: GetMatrixFourComponentContentUsing(specificMatrixFourComponentToHandle: this));
        }

        private StringBuilder GetMatrixFourComponentContent()
        {
            const string MatrixFourComponentContentElementFormat = "+#000000.000000;-#000000.000000";

            StringBuilder matrixFourComponentContentStringBuilder = new StringBuilder();

            matrixFourComponentContentStringBuilder.Append(value: $"{MatrixFourComponentAX.ToString(format: MatrixFourComponentContentElementFormat).ToUpperInvariant()}".ToUpperInvariant());
            matrixFourComponentContentStringBuilder.Append(value: " ".ToUpperInvariant());
            matrixFourComponentContentStringBuilder.Append(value: $"{MatrixFourComponentAY.ToString(format: MatrixFourComponentContentElementFormat).ToUpperInvariant()}".ToUpperInvariant());
            matrixFourComponentContentStringBuilder.Append(value: " ".ToUpperInvariant());
            matrixFourComponentContentStringBuilder.Append(value: $"{MatrixFourComponentAZ.ToString(format: MatrixFourComponentContentElementFormat).ToUpperInvariant()}".ToUpperInvariant());
            matrixFourComponentContentStringBuilder.Append(value: " ".ToUpperInvariant());
            matrixFourComponentContentStringBuilder.Append(value: $"{MatrixFourComponentAW.ToString(format: MatrixFourComponentContentElementFormat).ToUpperInvariant()}".ToUpperInvariant());
            matrixFourComponentContentStringBuilder.AppendLine();
            matrixFourComponentContentStringBuilder.Append(value: $"{MatrixFourComponentBX.ToString(format: MatrixFourComponentContentElementFormat).ToUpperInvariant()}".ToUpperInvariant());
            matrixFourComponentContentStringBuilder.Append(value: " ".ToUpperInvariant());
            matrixFourComponentContentStringBuilder.Append(value: $"{MatrixFourComponentBY.ToString(format: MatrixFourComponentContentElementFormat).ToUpperInvariant()}".ToUpperInvariant());
            matrixFourComponentContentStringBuilder.Append(value: " ".ToUpperInvariant());
            matrixFourComponentContentStringBuilder.Append(value: $"{MatrixFourComponentBZ.ToString(format: MatrixFourComponentContentElementFormat).ToUpperInvariant()}".ToUpperInvariant());
            matrixFourComponentContentStringBuilder.Append(value: " ".ToUpperInvariant());
            matrixFourComponentContentStringBuilder.Append(value: $"{MatrixFourComponentBW.ToString(format: MatrixFourComponentContentElementFormat).ToUpperInvariant()}".ToUpperInvariant());
            matrixFourComponentContentStringBuilder.AppendLine();
            matrixFourComponentContentStringBuilder.Append(value: $"{MatrixFourComponentCX.ToString(format: MatrixFourComponentContentElementFormat).ToUpperInvariant()}".ToUpperInvariant());
            matrixFourComponentContentStringBuilder.Append(value: " ".ToUpperInvariant());
            matrixFourComponentContentStringBuilder.Append(value: $"{MatrixFourComponentCY.ToString(format: MatrixFourComponentContentElementFormat).ToUpperInvariant()}".ToUpperInvariant());
            matrixFourComponentContentStringBuilder.Append(value: " ".ToUpperInvariant());
            matrixFourComponentContentStringBuilder.Append(value: $"{MatrixFourComponentCZ.ToString(format: MatrixFourComponentContentElementFormat).ToUpperInvariant()}".ToUpperInvariant());
            matrixFourComponentContentStringBuilder.Append(value: " ".ToUpperInvariant());
            matrixFourComponentContentStringBuilder.Append(value: $"{MatrixFourComponentCW.ToString(format: MatrixFourComponentContentElementFormat).ToUpperInvariant()}".ToUpperInvariant());
            matrixFourComponentContentStringBuilder.AppendLine();
            matrixFourComponentContentStringBuilder.Append(value: $"{MatrixFourComponentDX.ToString(format: MatrixFourComponentContentElementFormat).ToUpperInvariant()}".ToUpperInvariant());
            matrixFourComponentContentStringBuilder.Append(value: " ".ToUpperInvariant());
            matrixFourComponentContentStringBuilder.Append(value: $"{MatrixFourComponentDY.ToString(format: MatrixFourComponentContentElementFormat).ToUpperInvariant()}".ToUpperInvariant());
            matrixFourComponentContentStringBuilder.Append(value: " ".ToUpperInvariant());
            matrixFourComponentContentStringBuilder.Append(value: $"{MatrixFourComponentDZ.ToString(format: MatrixFourComponentContentElementFormat).ToUpperInvariant()}".ToUpperInvariant());
            matrixFourComponentContentStringBuilder.Append(value: " ".ToUpperInvariant());
            matrixFourComponentContentStringBuilder.Append(value: $"{MatrixFourComponentDW.ToString(format: MatrixFourComponentContentElementFormat).ToUpperInvariant()}".ToUpperInvariant());

            return matrixFourComponentContentStringBuilder;
        }

        private static StringBuilder GetMatrixFourComponentContentUsing(in MatrixFourComponentWithFactoryMethod specificMatrixFourComponentToHandle)
        {
            StringBuilder matrixFourComponentContentStringBuilder = new StringBuilder();

            matrixFourComponentContentStringBuilder.Append(value: specificMatrixFourComponentToHandle.GetMatrixFourComponentContent());

            return matrixFourComponentContentStringBuilder;
        }

        public override bool Equals(object specificMatrixFourComponentUndefinedObject)
        {
            if (ReferenceEquals(objA: this, objB: specificMatrixFourComponentUndefinedObject) == true)
            {
                return true;
            }

            if (specificMatrixFourComponentUndefinedObject == null || specificMatrixFourComponentUndefinedObject is MatrixFourComponentWithFactoryMethod specificMatrixFourComponentDefinedObject == false)
            {
                return false;
            }

            if (Math.Abs(value: MatrixFourComponentAX - specificMatrixFourComponentDefinedObject.MatrixFourComponentAX) > double.Epsilon || Math.Abs(value: MatrixFourComponentAY - specificMatrixFourComponentDefinedObject.MatrixFourComponentAY) > double.Epsilon || Math.Abs(value: MatrixFourComponentAZ - specificMatrixFourComponentDefinedObject.MatrixFourComponentAZ) > double.Epsilon || Math.Abs(value: MatrixFourComponentAW - specificMatrixFourComponentDefinedObject.MatrixFourComponentAW) > double.Epsilon)
            {
                return false;
            }

            if (Math.Abs(value: MatrixFourComponentBX - specificMatrixFourComponentDefinedObject.MatrixFourComponentBX) > double.Epsilon || Math.Abs(value: MatrixFourComponentBY - specificMatrixFourComponentDefinedObject.MatrixFourComponentBY) > double.Epsilon || Math.Abs(value: MatrixFourComponentBZ - specificMatrixFourComponentDefinedObject.MatrixFourComponentBZ) > double.Epsilon || Math.Abs(value: MatrixFourComponentBW - specificMatrixFourComponentDefinedObject.MatrixFourComponentBW) > double.Epsilon)
            {
                return false;
            }

            if (Math.Abs(value: MatrixFourComponentCX - specificMatrixFourComponentDefinedObject.MatrixFourComponentCX) > double.Epsilon || Math.Abs(value: MatrixFourComponentCY - specificMatrixFourComponentDefinedObject.MatrixFourComponentCY) > double.Epsilon || Math.Abs(value: MatrixFourComponentCZ - specificMatrixFourComponentDefinedObject.MatrixFourComponentCZ) > double.Epsilon || Math.Abs(value: MatrixFourComponentCW - specificMatrixFourComponentDefinedObject.MatrixFourComponentCW) > double.Epsilon)
            {
                return false;
            }

            if (Math.Abs(value: MatrixFourComponentDX - specificMatrixFourComponentDefinedObject.MatrixFourComponentDX) > double.Epsilon || Math.Abs(value: MatrixFourComponentDY - specificMatrixFourComponentDefinedObject.MatrixFourComponentDY) > double.Epsilon || Math.Abs(value: MatrixFourComponentDZ - specificMatrixFourComponentDefinedObject.MatrixFourComponentDZ) > double.Epsilon || Math.Abs(value: MatrixFourComponentDW - specificMatrixFourComponentDefinedObject.MatrixFourComponentDW) > double.Epsilon)
            {
                return false;
            }

            return true;
        }

        public override int GetHashCode()
        {
            const int MatrixFourComponentHashCodeInitialPrime = 17;
            const int MatrixFourComponentHashCodeMultiplierPrime = 23;

            int matrixFourComponentHashCode = MatrixFourComponentHashCodeInitialPrime;

            matrixFourComponentHashCode = matrixFourComponentHashCode * MatrixFourComponentHashCodeMultiplierPrime + MatrixFourComponentAX.GetHashCode();
            matrixFourComponentHashCode = matrixFourComponentHashCode * MatrixFourComponentHashCodeMultiplierPrime + MatrixFourComponentAY.GetHashCode();
            matrixFourComponentHashCode = matrixFourComponentHashCode * MatrixFourComponentHashCodeMultiplierPrime + MatrixFourComponentAZ.GetHashCode();
            matrixFourComponentHashCode = matrixFourComponentHashCode * MatrixFourComponentHashCodeMultiplierPrime + MatrixFourComponentAW.GetHashCode();
            matrixFourComponentHashCode = matrixFourComponentHashCode * MatrixFourComponentHashCodeMultiplierPrime + MatrixFourComponentBX.GetHashCode();
            matrixFourComponentHashCode = matrixFourComponentHashCode * MatrixFourComponentHashCodeMultiplierPrime + MatrixFourComponentBY.GetHashCode();
            matrixFourComponentHashCode = matrixFourComponentHashCode * MatrixFourComponentHashCodeMultiplierPrime + MatrixFourComponentBZ.GetHashCode();
            matrixFourComponentHashCode = matrixFourComponentHashCode * MatrixFourComponentHashCodeMultiplierPrime + MatrixFourComponentBW.GetHashCode();
            matrixFourComponentHashCode = matrixFourComponentHashCode * MatrixFourComponentHashCodeMultiplierPrime + MatrixFourComponentCX.GetHashCode();
            matrixFourComponentHashCode = matrixFourComponentHashCode * MatrixFourComponentHashCodeMultiplierPrime + MatrixFourComponentCY.GetHashCode();
            matrixFourComponentHashCode = matrixFourComponentHashCode * MatrixFourComponentHashCodeMultiplierPrime + MatrixFourComponentCZ.GetHashCode();
            matrixFourComponentHashCode = matrixFourComponentHashCode * MatrixFourComponentHashCodeMultiplierPrime + MatrixFourComponentCW.GetHashCode();
            matrixFourComponentHashCode = matrixFourComponentHashCode * MatrixFourComponentHashCodeMultiplierPrime + MatrixFourComponentDX.GetHashCode();
            matrixFourComponentHashCode = matrixFourComponentHashCode * MatrixFourComponentHashCodeMultiplierPrime + MatrixFourComponentDY.GetHashCode();
            matrixFourComponentHashCode = matrixFourComponentHashCode * MatrixFourComponentHashCodeMultiplierPrime + MatrixFourComponentDZ.GetHashCode();
            matrixFourComponentHashCode = matrixFourComponentHashCode * MatrixFourComponentHashCodeMultiplierPrime + MatrixFourComponentDW.GetHashCode();

            return matrixFourComponentHashCode;
        }

        public override string ToString()
        {
            return GetMatrixFourComponentContentUsing(specificMatrixFourComponentToHandle: this).ToString().ToUpperInvariant();
        }
    }
}