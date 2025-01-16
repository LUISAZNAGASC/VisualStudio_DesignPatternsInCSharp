namespace VisualStudio_DesignPatternsInCSharp.CreationalDesignPatterns.FactoryDesignPattern.FactoryMethodDesignPattern
{
    using System;
    using System.Text;

    public enum MatrixFourRowLevelWithFactoryMethod : uint
    {
        MatrixFourRowLevelUndefined = 0,
        MatrixFourRowLevelX = 1,
        MatrixFourRowLevelY = 2,
        MatrixFourRowLevelZ = 3,
        MatrixFourRowLevelW = 4
    }

    public enum MatrixFourColumnLevelWithFactoryMethod : uint
    {
        MatrixFourColumnLevelUndefined = 0,
        MatrixFourColumnLevelA = 1,
        MatrixFourColumnLevelB = 2,
        MatrixFourColumnLevelC = 3,
        MatrixFourColumnLevelD = 4

    }

    public struct MatrixFourComponentWithFactoryMethod
    {
        private double MatrixFourComponentAX { get; set; }
        private double MatrixFourComponentAY { get; set; }
        private double MatrixFourComponentAZ { get; set; }
        private double MatrixFourComponentAW { get; set; }
        private double MatrixFourComponentBX { get; set; }
        private double MatrixFourComponentBY { get; set; }
        private double MatrixFourComponentBZ { get; set; }
        private double MatrixFourComponentBW { get; set; }
        private double MatrixFourComponentCX { get; set; }
        private double MatrixFourComponentCY { get; set; }
        private double MatrixFourComponentCZ { get; set; }
        private double MatrixFourComponentCW { get; set; }
        private double MatrixFourComponentDX { get; set; }
        private double MatrixFourComponentDY { get; set; }
        private double MatrixFourComponentDZ { get; set; }
        private double MatrixFourComponentDW { get; set; }

        public static MatrixFourComponentWithFactoryMethod GetMatrixFourComponentIdentity()
        {
            const double MatrixFourComponentIdentityUnfilledValue = 0.0;
            const double MatrixFourComponentIdentityFilledValue = 1.0;

            MatrixFourComponentWithFactoryMethod matrixFourComponentIdentity = new()
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

        public static MatrixFourComponentWithFactoryMethod GetMatrixFourComponentMultiplicationUsing(in MatrixFourComponentWithFactoryMethod leftMatrixFourComponentToHandle, in MatrixFourComponentWithFactoryMethod rightMatrixFourComponentToHandle)
        {
            MatrixFourComponentWithFactoryMethod finalMatrixFourComponentToHandle = new()
            {
                MatrixFourComponentAX = leftMatrixFourComponentToHandle.MatrixFourComponentAX * rightMatrixFourComponentToHandle.MatrixFourComponentAX + leftMatrixFourComponentToHandle.MatrixFourComponentAY * rightMatrixFourComponentToHandle.MatrixFourComponentBX + leftMatrixFourComponentToHandle.MatrixFourComponentAZ * rightMatrixFourComponentToHandle.MatrixFourComponentCX + leftMatrixFourComponentToHandle.MatrixFourComponentAW * rightMatrixFourComponentToHandle.MatrixFourComponentDX,
                MatrixFourComponentAY = leftMatrixFourComponentToHandle.MatrixFourComponentAX * rightMatrixFourComponentToHandle.MatrixFourComponentAY + leftMatrixFourComponentToHandle.MatrixFourComponentAY * rightMatrixFourComponentToHandle.MatrixFourComponentBY + leftMatrixFourComponentToHandle.MatrixFourComponentAZ * rightMatrixFourComponentToHandle.MatrixFourComponentCY + leftMatrixFourComponentToHandle.MatrixFourComponentAW * rightMatrixFourComponentToHandle.MatrixFourComponentDY,
                MatrixFourComponentAZ = leftMatrixFourComponentToHandle.MatrixFourComponentAX * rightMatrixFourComponentToHandle.MatrixFourComponentAZ + leftMatrixFourComponentToHandle.MatrixFourComponentAY * rightMatrixFourComponentToHandle.MatrixFourComponentBZ + leftMatrixFourComponentToHandle.MatrixFourComponentAZ * rightMatrixFourComponentToHandle.MatrixFourComponentCZ + leftMatrixFourComponentToHandle.MatrixFourComponentAW * rightMatrixFourComponentToHandle.MatrixFourComponentDZ,
                MatrixFourComponentAW = leftMatrixFourComponentToHandle.MatrixFourComponentAX * rightMatrixFourComponentToHandle.MatrixFourComponentAW + leftMatrixFourComponentToHandle.MatrixFourComponentAY * rightMatrixFourComponentToHandle.MatrixFourComponentBW + leftMatrixFourComponentToHandle.MatrixFourComponentAZ * rightMatrixFourComponentToHandle.MatrixFourComponentCW + leftMatrixFourComponentToHandle.MatrixFourComponentAW * rightMatrixFourComponentToHandle.MatrixFourComponentDW,
                MatrixFourComponentBX = leftMatrixFourComponentToHandle.MatrixFourComponentBX * rightMatrixFourComponentToHandle.MatrixFourComponentAX + leftMatrixFourComponentToHandle.MatrixFourComponentBY * rightMatrixFourComponentToHandle.MatrixFourComponentBX + leftMatrixFourComponentToHandle.MatrixFourComponentBZ * rightMatrixFourComponentToHandle.MatrixFourComponentCX + leftMatrixFourComponentToHandle.MatrixFourComponentBW * rightMatrixFourComponentToHandle.MatrixFourComponentDX,
                MatrixFourComponentBY = leftMatrixFourComponentToHandle.MatrixFourComponentBX * rightMatrixFourComponentToHandle.MatrixFourComponentAY + leftMatrixFourComponentToHandle.MatrixFourComponentBY * rightMatrixFourComponentToHandle.MatrixFourComponentBY + leftMatrixFourComponentToHandle.MatrixFourComponentBZ * rightMatrixFourComponentToHandle.MatrixFourComponentCY + leftMatrixFourComponentToHandle.MatrixFourComponentBW * rightMatrixFourComponentToHandle.MatrixFourComponentDY,
                MatrixFourComponentBZ = leftMatrixFourComponentToHandle.MatrixFourComponentBX * rightMatrixFourComponentToHandle.MatrixFourComponentAZ + leftMatrixFourComponentToHandle.MatrixFourComponentBY * rightMatrixFourComponentToHandle.MatrixFourComponentBZ + leftMatrixFourComponentToHandle.MatrixFourComponentBZ * rightMatrixFourComponentToHandle.MatrixFourComponentCZ + leftMatrixFourComponentToHandle.MatrixFourComponentBW * rightMatrixFourComponentToHandle.MatrixFourComponentDZ,
                MatrixFourComponentBW = leftMatrixFourComponentToHandle.MatrixFourComponentBX * rightMatrixFourComponentToHandle.MatrixFourComponentAW + leftMatrixFourComponentToHandle.MatrixFourComponentBY * rightMatrixFourComponentToHandle.MatrixFourComponentBW + leftMatrixFourComponentToHandle.MatrixFourComponentBZ * rightMatrixFourComponentToHandle.MatrixFourComponentCW + leftMatrixFourComponentToHandle.MatrixFourComponentBW * rightMatrixFourComponentToHandle.MatrixFourComponentDW,
                MatrixFourComponentCX = leftMatrixFourComponentToHandle.MatrixFourComponentCX * rightMatrixFourComponentToHandle.MatrixFourComponentAX + leftMatrixFourComponentToHandle.MatrixFourComponentCY * rightMatrixFourComponentToHandle.MatrixFourComponentBX + leftMatrixFourComponentToHandle.MatrixFourComponentCZ * rightMatrixFourComponentToHandle.MatrixFourComponentCX + leftMatrixFourComponentToHandle.MatrixFourComponentCW * rightMatrixFourComponentToHandle.MatrixFourComponentDX,
                MatrixFourComponentCY = leftMatrixFourComponentToHandle.MatrixFourComponentCX * rightMatrixFourComponentToHandle.MatrixFourComponentAY + leftMatrixFourComponentToHandle.MatrixFourComponentCY * rightMatrixFourComponentToHandle.MatrixFourComponentBY + leftMatrixFourComponentToHandle.MatrixFourComponentCZ * rightMatrixFourComponentToHandle.MatrixFourComponentCY + leftMatrixFourComponentToHandle.MatrixFourComponentCW * rightMatrixFourComponentToHandle.MatrixFourComponentDY,
                MatrixFourComponentCZ = leftMatrixFourComponentToHandle.MatrixFourComponentCX * rightMatrixFourComponentToHandle.MatrixFourComponentAZ + leftMatrixFourComponentToHandle.MatrixFourComponentCY * rightMatrixFourComponentToHandle.MatrixFourComponentBZ + leftMatrixFourComponentToHandle.MatrixFourComponentCZ * rightMatrixFourComponentToHandle.MatrixFourComponentCZ + leftMatrixFourComponentToHandle.MatrixFourComponentCW * rightMatrixFourComponentToHandle.MatrixFourComponentDZ,
                MatrixFourComponentCW = leftMatrixFourComponentToHandle.MatrixFourComponentCX * rightMatrixFourComponentToHandle.MatrixFourComponentAW + leftMatrixFourComponentToHandle.MatrixFourComponentCY * rightMatrixFourComponentToHandle.MatrixFourComponentBW + leftMatrixFourComponentToHandle.MatrixFourComponentCZ * rightMatrixFourComponentToHandle.MatrixFourComponentCW + leftMatrixFourComponentToHandle.MatrixFourComponentCW * rightMatrixFourComponentToHandle.MatrixFourComponentDW,
                MatrixFourComponentDX = leftMatrixFourComponentToHandle.MatrixFourComponentDX * rightMatrixFourComponentToHandle.MatrixFourComponentAX + leftMatrixFourComponentToHandle.MatrixFourComponentDY * rightMatrixFourComponentToHandle.MatrixFourComponentBX + leftMatrixFourComponentToHandle.MatrixFourComponentDZ * rightMatrixFourComponentToHandle.MatrixFourComponentCX + leftMatrixFourComponentToHandle.MatrixFourComponentDW * rightMatrixFourComponentToHandle.MatrixFourComponentDX,
                MatrixFourComponentDY = leftMatrixFourComponentToHandle.MatrixFourComponentDX * rightMatrixFourComponentToHandle.MatrixFourComponentAY + leftMatrixFourComponentToHandle.MatrixFourComponentDY * rightMatrixFourComponentToHandle.MatrixFourComponentBY + leftMatrixFourComponentToHandle.MatrixFourComponentDZ * rightMatrixFourComponentToHandle.MatrixFourComponentCY + leftMatrixFourComponentToHandle.MatrixFourComponentDW * rightMatrixFourComponentToHandle.MatrixFourComponentDY,
                MatrixFourComponentDZ = leftMatrixFourComponentToHandle.MatrixFourComponentDX * rightMatrixFourComponentToHandle.MatrixFourComponentAZ + leftMatrixFourComponentToHandle.MatrixFourComponentDY * rightMatrixFourComponentToHandle.MatrixFourComponentBZ + leftMatrixFourComponentToHandle.MatrixFourComponentDZ * rightMatrixFourComponentToHandle.MatrixFourComponentCZ + leftMatrixFourComponentToHandle.MatrixFourComponentDW * rightMatrixFourComponentToHandle.MatrixFourComponentDZ,
                MatrixFourComponentDW = leftMatrixFourComponentToHandle.MatrixFourComponentDX * rightMatrixFourComponentToHandle.MatrixFourComponentAW + leftMatrixFourComponentToHandle.MatrixFourComponentDY * rightMatrixFourComponentToHandle.MatrixFourComponentBW + leftMatrixFourComponentToHandle.MatrixFourComponentDZ * rightMatrixFourComponentToHandle.MatrixFourComponentCW + leftMatrixFourComponentToHandle.MatrixFourComponentDW * rightMatrixFourComponentToHandle.MatrixFourComponentDW
            };

            return finalMatrixFourComponentToHandle;
        }

        public void SetMatrixFourComponentElementUsing(in MatrixFourRowLevelWithFactoryMethod otherMatrixFourComponentRowLevelToHandle, in MatrixFourColumnLevelWithFactoryMethod otherMatrixFourComponentColumnLevelToHandle, in double otherMatrixFourComponentElementToHandle)
        {
            switch (otherMatrixFourComponentColumnLevelToHandle)
            {
                case MatrixFourColumnLevelWithFactoryMethod.MatrixFourColumnLevelUndefined:
                    break;
                case MatrixFourColumnLevelWithFactoryMethod.MatrixFourColumnLevelA:
                    switch (otherMatrixFourComponentRowLevelToHandle)
                    {
                        case MatrixFourRowLevelWithFactoryMethod.MatrixFourRowLevelUndefined:
                            break;
                        case MatrixFourRowLevelWithFactoryMethod.MatrixFourRowLevelX:
                            MatrixFourComponentAX = otherMatrixFourComponentElementToHandle;
                            break;
                        case MatrixFourRowLevelWithFactoryMethod.MatrixFourRowLevelY:
                            MatrixFourComponentAY = otherMatrixFourComponentElementToHandle;
                            break;
                        case MatrixFourRowLevelWithFactoryMethod.MatrixFourRowLevelZ:
                            MatrixFourComponentAZ = otherMatrixFourComponentElementToHandle;
                            break;
                        case MatrixFourRowLevelWithFactoryMethod.MatrixFourRowLevelW:
                            MatrixFourComponentAW = otherMatrixFourComponentElementToHandle;
                            break;
                        default:
                            break;
                    }

                    break;
                case MatrixFourColumnLevelWithFactoryMethod.MatrixFourColumnLevelB:
                    switch (otherMatrixFourComponentRowLevelToHandle)
                    {
                        case MatrixFourRowLevelWithFactoryMethod.MatrixFourRowLevelUndefined:
                            break;
                        case MatrixFourRowLevelWithFactoryMethod.MatrixFourRowLevelX:
                            MatrixFourComponentBX = otherMatrixFourComponentElementToHandle;
                            break;
                        case MatrixFourRowLevelWithFactoryMethod.MatrixFourRowLevelY:
                            MatrixFourComponentBY = otherMatrixFourComponentElementToHandle;
                            break;
                        case MatrixFourRowLevelWithFactoryMethod.MatrixFourRowLevelZ:
                            MatrixFourComponentBZ = otherMatrixFourComponentElementToHandle;
                            break;
                        case MatrixFourRowLevelWithFactoryMethod.MatrixFourRowLevelW:
                            MatrixFourComponentBW = otherMatrixFourComponentElementToHandle;
                            break;
                        default:
                            break;
                    }

                    break;
                case MatrixFourColumnLevelWithFactoryMethod.MatrixFourColumnLevelC:
                    switch (otherMatrixFourComponentRowLevelToHandle)
                    {
                        case MatrixFourRowLevelWithFactoryMethod.MatrixFourRowLevelUndefined:
                            break;
                        case MatrixFourRowLevelWithFactoryMethod.MatrixFourRowLevelX:
                            MatrixFourComponentCX = otherMatrixFourComponentElementToHandle;
                            break;
                        case MatrixFourRowLevelWithFactoryMethod.MatrixFourRowLevelY:
                            MatrixFourComponentCY = otherMatrixFourComponentElementToHandle;
                            break;
                        case MatrixFourRowLevelWithFactoryMethod.MatrixFourRowLevelZ:
                            MatrixFourComponentCZ = otherMatrixFourComponentElementToHandle;
                            break;
                        case MatrixFourRowLevelWithFactoryMethod.MatrixFourRowLevelW:
                            MatrixFourComponentCW = otherMatrixFourComponentElementToHandle;
                            break;
                        default:
                            break;
                    }

                    break;
                case MatrixFourColumnLevelWithFactoryMethod.MatrixFourColumnLevelD:
                    switch (otherMatrixFourComponentRowLevelToHandle)
                    {
                        case MatrixFourRowLevelWithFactoryMethod.MatrixFourRowLevelUndefined:
                            break;
                        case MatrixFourRowLevelWithFactoryMethod.MatrixFourRowLevelX:
                            MatrixFourComponentDX = otherMatrixFourComponentElementToHandle;
                            break;
                        case MatrixFourRowLevelWithFactoryMethod.MatrixFourRowLevelY:
                            MatrixFourComponentDY = otherMatrixFourComponentElementToHandle;
                            break;
                        case MatrixFourRowLevelWithFactoryMethod.MatrixFourRowLevelZ:
                            MatrixFourComponentDZ = otherMatrixFourComponentElementToHandle;
                            break;
                        case MatrixFourRowLevelWithFactoryMethod.MatrixFourRowLevelW:
                            MatrixFourComponentDW = otherMatrixFourComponentElementToHandle;
                            break;
                        default:
                            break;
                    }

                    break;
                default:
                    break;
            }
        }

        public readonly void DisplayMatrixFourComponentContent()
        {
            Console.WriteLine(value: GetMatrixFourComponentContentUsing(otherMatrixFourComponentToHandle: this));
        }

        private readonly void SetMatrixFourComponentContentElementContentUsing(StringBuilder matrixFourComponentContentStringBuilder, in double otherMatrixFourComponentContentElementToHandle)
        {
            const string MatrixFourComponentContentElementContentFormat = "+#000000.000000;-#000000.000000";

            matrixFourComponentContentStringBuilder.Append(value: $"{otherMatrixFourComponentContentElementToHandle.ToString(format: MatrixFourComponentContentElementContentFormat).ToUpperInvariant()}".ToUpperInvariant());
        }

        private readonly void SetMatrixFourComponentContentWhiteSpaceContentUsing(StringBuilder matrixFourComponentContentStringBuilder)
        {
            const uint MatrixFourComponentContentWhiteSpaceDimension = 1;
            const char MatrixFourComponentContentWhiteSpaceCharacter = ' ';

            matrixFourComponentContentStringBuilder.Append(value: new string(c: MatrixFourComponentContentWhiteSpaceCharacter, count: (int)MatrixFourComponentContentWhiteSpaceDimension).ToUpperInvariant());
        }

        private readonly StringBuilder GetMatrixFourComponentContent()
        {
            StringBuilder matrixFourComponentContentStringBuilder = new();

            SetMatrixFourComponentContentElementContentUsing(matrixFourComponentContentStringBuilder: matrixFourComponentContentStringBuilder, otherMatrixFourComponentContentElementToHandle: MatrixFourComponentAX);
            SetMatrixFourComponentContentWhiteSpaceContentUsing(matrixFourComponentContentStringBuilder: matrixFourComponentContentStringBuilder);
            SetMatrixFourComponentContentElementContentUsing(matrixFourComponentContentStringBuilder: matrixFourComponentContentStringBuilder, otherMatrixFourComponentContentElementToHandle: MatrixFourComponentAY);
            SetMatrixFourComponentContentWhiteSpaceContentUsing(matrixFourComponentContentStringBuilder: matrixFourComponentContentStringBuilder);
            SetMatrixFourComponentContentElementContentUsing(matrixFourComponentContentStringBuilder: matrixFourComponentContentStringBuilder, otherMatrixFourComponentContentElementToHandle: MatrixFourComponentAZ);
            SetMatrixFourComponentContentWhiteSpaceContentUsing(matrixFourComponentContentStringBuilder: matrixFourComponentContentStringBuilder);
            SetMatrixFourComponentContentElementContentUsing(matrixFourComponentContentStringBuilder: matrixFourComponentContentStringBuilder, otherMatrixFourComponentContentElementToHandle: MatrixFourComponentAW);
            matrixFourComponentContentStringBuilder.AppendLine();
            SetMatrixFourComponentContentElementContentUsing(matrixFourComponentContentStringBuilder: matrixFourComponentContentStringBuilder, otherMatrixFourComponentContentElementToHandle: MatrixFourComponentBX);
            SetMatrixFourComponentContentWhiteSpaceContentUsing(matrixFourComponentContentStringBuilder: matrixFourComponentContentStringBuilder);
            SetMatrixFourComponentContentElementContentUsing(matrixFourComponentContentStringBuilder: matrixFourComponentContentStringBuilder, otherMatrixFourComponentContentElementToHandle: MatrixFourComponentBY);
            SetMatrixFourComponentContentWhiteSpaceContentUsing(matrixFourComponentContentStringBuilder: matrixFourComponentContentStringBuilder);
            SetMatrixFourComponentContentElementContentUsing(matrixFourComponentContentStringBuilder: matrixFourComponentContentStringBuilder, otherMatrixFourComponentContentElementToHandle: MatrixFourComponentBZ);
            SetMatrixFourComponentContentWhiteSpaceContentUsing(matrixFourComponentContentStringBuilder: matrixFourComponentContentStringBuilder);
            SetMatrixFourComponentContentElementContentUsing(matrixFourComponentContentStringBuilder: matrixFourComponentContentStringBuilder, otherMatrixFourComponentContentElementToHandle: MatrixFourComponentBW);
            matrixFourComponentContentStringBuilder.AppendLine();
            SetMatrixFourComponentContentElementContentUsing(matrixFourComponentContentStringBuilder: matrixFourComponentContentStringBuilder, otherMatrixFourComponentContentElementToHandle: MatrixFourComponentCX);
            SetMatrixFourComponentContentWhiteSpaceContentUsing(matrixFourComponentContentStringBuilder: matrixFourComponentContentStringBuilder);
            SetMatrixFourComponentContentElementContentUsing(matrixFourComponentContentStringBuilder: matrixFourComponentContentStringBuilder, otherMatrixFourComponentContentElementToHandle: MatrixFourComponentCY);
            SetMatrixFourComponentContentWhiteSpaceContentUsing(matrixFourComponentContentStringBuilder: matrixFourComponentContentStringBuilder);
            SetMatrixFourComponentContentElementContentUsing(matrixFourComponentContentStringBuilder: matrixFourComponentContentStringBuilder, otherMatrixFourComponentContentElementToHandle: MatrixFourComponentCZ);
            SetMatrixFourComponentContentWhiteSpaceContentUsing(matrixFourComponentContentStringBuilder: matrixFourComponentContentStringBuilder);
            SetMatrixFourComponentContentElementContentUsing(matrixFourComponentContentStringBuilder: matrixFourComponentContentStringBuilder, otherMatrixFourComponentContentElementToHandle: MatrixFourComponentCW);
            matrixFourComponentContentStringBuilder.AppendLine();
            SetMatrixFourComponentContentElementContentUsing(matrixFourComponentContentStringBuilder: matrixFourComponentContentStringBuilder, otherMatrixFourComponentContentElementToHandle: MatrixFourComponentDX);
            SetMatrixFourComponentContentWhiteSpaceContentUsing(matrixFourComponentContentStringBuilder: matrixFourComponentContentStringBuilder);
            SetMatrixFourComponentContentElementContentUsing(matrixFourComponentContentStringBuilder: matrixFourComponentContentStringBuilder, otherMatrixFourComponentContentElementToHandle: MatrixFourComponentDY);
            SetMatrixFourComponentContentWhiteSpaceContentUsing(matrixFourComponentContentStringBuilder: matrixFourComponentContentStringBuilder);
            SetMatrixFourComponentContentElementContentUsing(matrixFourComponentContentStringBuilder: matrixFourComponentContentStringBuilder, otherMatrixFourComponentContentElementToHandle: MatrixFourComponentDZ);
            SetMatrixFourComponentContentWhiteSpaceContentUsing(matrixFourComponentContentStringBuilder: matrixFourComponentContentStringBuilder);
            SetMatrixFourComponentContentElementContentUsing(matrixFourComponentContentStringBuilder: matrixFourComponentContentStringBuilder, otherMatrixFourComponentContentElementToHandle: MatrixFourComponentDW);

            return matrixFourComponentContentStringBuilder;
        }

        private static StringBuilder GetMatrixFourComponentContentUsing(in MatrixFourComponentWithFactoryMethod otherMatrixFourComponentToHandle)
        {
            StringBuilder matrixFourComponentContentStringBuilder = new();

            matrixFourComponentContentStringBuilder.Append(value: otherMatrixFourComponentToHandle.GetMatrixFourComponentContent());

            return matrixFourComponentContentStringBuilder;
        }

        public override readonly bool Equals(object otherMatrixFourComponentUndefinedObjectToHandle)
        {
            if (ReferenceEquals(objA: this, objB: otherMatrixFourComponentUndefinedObjectToHandle) == true)
            {
                return true;
            }

            if (otherMatrixFourComponentUndefinedObjectToHandle == null || otherMatrixFourComponentUndefinedObjectToHandle is MatrixFourComponentWithFactoryMethod otherMatrixFourComponentDefinedObjectToHandle == false)
            {
                return false;
            }

            if (Math.Abs(value: MatrixFourComponentAX - otherMatrixFourComponentDefinedObjectToHandle.MatrixFourComponentAX) > double.Epsilon || Math.Abs(value: MatrixFourComponentAY - otherMatrixFourComponentDefinedObjectToHandle.MatrixFourComponentAY) > double.Epsilon || Math.Abs(value: MatrixFourComponentAZ - otherMatrixFourComponentDefinedObjectToHandle.MatrixFourComponentAZ) > double.Epsilon || Math.Abs(value: MatrixFourComponentAW - otherMatrixFourComponentDefinedObjectToHandle.MatrixFourComponentAW) > double.Epsilon)
            {
                return false;
            }

            if (Math.Abs(value: MatrixFourComponentBX - otherMatrixFourComponentDefinedObjectToHandle.MatrixFourComponentBX) > double.Epsilon || Math.Abs(value: MatrixFourComponentBY - otherMatrixFourComponentDefinedObjectToHandle.MatrixFourComponentBY) > double.Epsilon || Math.Abs(value: MatrixFourComponentBZ - otherMatrixFourComponentDefinedObjectToHandle.MatrixFourComponentBZ) > double.Epsilon || Math.Abs(value: MatrixFourComponentBW - otherMatrixFourComponentDefinedObjectToHandle.MatrixFourComponentBW) > double.Epsilon)
            {
                return false;
            }

            if (Math.Abs(value: MatrixFourComponentCX - otherMatrixFourComponentDefinedObjectToHandle.MatrixFourComponentCX) > double.Epsilon || Math.Abs(value: MatrixFourComponentCY - otherMatrixFourComponentDefinedObjectToHandle.MatrixFourComponentCY) > double.Epsilon || Math.Abs(value: MatrixFourComponentCZ - otherMatrixFourComponentDefinedObjectToHandle.MatrixFourComponentCZ) > double.Epsilon || Math.Abs(value: MatrixFourComponentCW - otherMatrixFourComponentDefinedObjectToHandle.MatrixFourComponentCW) > double.Epsilon)
            {
                return false;
            }

            if (Math.Abs(value: MatrixFourComponentDX - otherMatrixFourComponentDefinedObjectToHandle.MatrixFourComponentDX) > double.Epsilon || Math.Abs(value: MatrixFourComponentDY - otherMatrixFourComponentDefinedObjectToHandle.MatrixFourComponentDY) > double.Epsilon || Math.Abs(value: MatrixFourComponentDZ - otherMatrixFourComponentDefinedObjectToHandle.MatrixFourComponentDZ) > double.Epsilon || Math.Abs(value: MatrixFourComponentDW - otherMatrixFourComponentDefinedObjectToHandle.MatrixFourComponentDW) > double.Epsilon)
            {
                return false;
            }

            return true;
        }

        public override readonly int GetHashCode()
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

        public override readonly string ToString()
        {
            return GetMatrixFourComponentContentUsing(otherMatrixFourComponentToHandle: this).ToString().ToUpperInvariant();
        }
    }
}