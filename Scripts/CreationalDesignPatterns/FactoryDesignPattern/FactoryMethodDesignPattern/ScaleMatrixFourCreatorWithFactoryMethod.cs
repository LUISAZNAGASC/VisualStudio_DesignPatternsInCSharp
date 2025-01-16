namespace VisualStudio_DesignPatternsInCSharp.CreationalDesignPatterns.FactoryDesignPattern.FactoryMethodDesignPattern
{
    public sealed class ScaleMatrixFourCreatorWithFactoryMethod(in double otherScaleMatrixFourCreatorXDimensionToHandle, in double otherScaleMatrixFourCreatorYDimensionToHandle, in double otherScaleMatrixFourCreatorZDimensionToHandle) : MatrixFourCreatorWithFactoryMethod(otherMatrixFourCreatorXTransformationToHandle: otherScaleMatrixFourCreatorXDimensionToHandle, otherMatrixFourCreatorYTransformationToHandle: otherScaleMatrixFourCreatorYDimensionToHandle, otherMatrixFourCreatorZTransformationToHandle: otherScaleMatrixFourCreatorZDimensionToHandle)
    {
        public override void SetMatrixFourCreatorXTransformationUsing(in double otherScaleMatrixFourCreatorXDimensionToHandle)
        {
            MatrixFourComponentWithFactoryMethod scaleMatrixFourCreatorMatrixFourComponent = MatrixFourComponentWithFactoryMethod.GetMatrixFourComponentIdentity();
            scaleMatrixFourCreatorMatrixFourComponent.SetMatrixFourComponentElementUsing(otherMatrixFourComponentRowLevelToHandle: MatrixFourRowLevelWithFactoryMethod.MatrixFourRowLevelX, otherMatrixFourComponentColumnLevelToHandle: MatrixFourColumnLevelWithFactoryMethod.MatrixFourColumnLevelA, otherMatrixFourComponentElementToHandle: otherScaleMatrixFourCreatorXDimensionToHandle);

            MatrixFourCreatorMatrixFourComponent = MatrixFourComponentWithFactoryMethod.GetMatrixFourComponentMultiplicationUsing(leftMatrixFourComponentToHandle: MatrixFourCreatorMatrixFourComponent, rightMatrixFourComponentToHandle: scaleMatrixFourCreatorMatrixFourComponent);
        }

        public override void SetMatrixFourCreatorYTransformationUsing(in double otherScaleMatrixFourCreatorYDimensionToHandle)
        {
            MatrixFourComponentWithFactoryMethod scaleMatrixFourCreatorMatrixFourComponent = MatrixFourComponentWithFactoryMethod.GetMatrixFourComponentIdentity();
            scaleMatrixFourCreatorMatrixFourComponent.SetMatrixFourComponentElementUsing(otherMatrixFourComponentRowLevelToHandle: MatrixFourRowLevelWithFactoryMethod.MatrixFourRowLevelY, otherMatrixFourComponentColumnLevelToHandle: MatrixFourColumnLevelWithFactoryMethod.MatrixFourColumnLevelB, otherMatrixFourComponentElementToHandle: otherScaleMatrixFourCreatorYDimensionToHandle);

            MatrixFourCreatorMatrixFourComponent = MatrixFourComponentWithFactoryMethod.GetMatrixFourComponentMultiplicationUsing(leftMatrixFourComponentToHandle: MatrixFourCreatorMatrixFourComponent, rightMatrixFourComponentToHandle: scaleMatrixFourCreatorMatrixFourComponent);
        }

        public override void SetMatrixFourCreatorZTransformationUsing(in double otherScaleMatrixFourCreatorZDimensionToHandle)
        {
            MatrixFourComponentWithFactoryMethod scaleMatrixFourCreatorMatrixFourComponent = MatrixFourComponentWithFactoryMethod.GetMatrixFourComponentIdentity();
            scaleMatrixFourCreatorMatrixFourComponent.SetMatrixFourComponentElementUsing(otherMatrixFourComponentRowLevelToHandle: MatrixFourRowLevelWithFactoryMethod.MatrixFourRowLevelZ, otherMatrixFourComponentColumnLevelToHandle: MatrixFourColumnLevelWithFactoryMethod.MatrixFourColumnLevelC, otherMatrixFourComponentElementToHandle: otherScaleMatrixFourCreatorZDimensionToHandle);

            MatrixFourCreatorMatrixFourComponent = MatrixFourComponentWithFactoryMethod.GetMatrixFourComponentMultiplicationUsing(leftMatrixFourComponentToHandle: MatrixFourCreatorMatrixFourComponent, rightMatrixFourComponentToHandle: scaleMatrixFourCreatorMatrixFourComponent);
        }
    }
}