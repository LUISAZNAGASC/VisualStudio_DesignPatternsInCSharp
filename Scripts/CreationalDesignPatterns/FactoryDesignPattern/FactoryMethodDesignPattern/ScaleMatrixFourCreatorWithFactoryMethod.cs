namespace VisualStudio_DesignPatternsInCSharp.CreationalDesignPatterns.FactoryDesignPattern.FactoryMethodDesignPattern
{
    public sealed class ScaleMatrixFourCreatorWithFactoryMethod : MatrixFourCreatorWithFactoryMethod
    {
        public ScaleMatrixFourCreatorWithFactoryMethod(in double newScaleMatrixFourCreatorXDimensionToInitialize, in double newScaleMatrixFourCreatorYDimensionToInitialize, in double newScaleMatrixFourCreatorZDimensionToInitialize) : base(newMatrixFourCreatorXTransformationToInitialize: newScaleMatrixFourCreatorXDimensionToInitialize, newMatrixFourCreatorYTransformationToInitialize: newScaleMatrixFourCreatorYDimensionToInitialize, newMatrixFourCreatorZTransformationToInitialize: newScaleMatrixFourCreatorZDimensionToInitialize)
        {

        }

        public override void SetMatrixFourCreatorXTransformationUsing(in double newScaleMatrixFourCreatorXDimensionToDefine)
        {
            MatrixFourComponentWithFactoryMethod scaleMatrixFourCreatorMatrixFourComponent = MatrixFourComponentWithFactoryMethod.GetMatrixFourComponentIdentity();
            scaleMatrixFourCreatorMatrixFourComponent.SetMatrixFourComponentElementUsing(matrixFourComponentRowLevel: MatrixFourRowLevel.MatrixFourRowLevelX, matrixFourComponentColumnLevel: MatrixFourColumnLevel.MatrixFourColumnLevelA, newMatrixFourComponentElementToDefine: newScaleMatrixFourCreatorXDimensionToDefine);

            MatrixFourCreatorMatrixFourComponent = MatrixFourComponentWithFactoryMethod.GetMatrixFourComponentMultiplicationUsing(firstMatrixFourComponentToHandle: MatrixFourCreatorMatrixFourComponent, secondMatrixFourComponentToHandle: scaleMatrixFourCreatorMatrixFourComponent);
        }

        public override void SetMatrixFourCreatorYTransformationUsing(in double newScaleMatrixFourCreatorYDimensionToDefine)
        {
            MatrixFourComponentWithFactoryMethod scaleMatrixFourCreatorMatrixFourComponent = MatrixFourComponentWithFactoryMethod.GetMatrixFourComponentIdentity();
            scaleMatrixFourCreatorMatrixFourComponent.SetMatrixFourComponentElementUsing(matrixFourComponentRowLevel: MatrixFourRowLevel.MatrixFourRowLevelY, matrixFourComponentColumnLevel: MatrixFourColumnLevel.MatrixFourColumnLevelB, newMatrixFourComponentElementToDefine: newScaleMatrixFourCreatorYDimensionToDefine);

            MatrixFourCreatorMatrixFourComponent = MatrixFourComponentWithFactoryMethod.GetMatrixFourComponentMultiplicationUsing(firstMatrixFourComponentToHandle: MatrixFourCreatorMatrixFourComponent, secondMatrixFourComponentToHandle: scaleMatrixFourCreatorMatrixFourComponent);
        }

        public override void SetMatrixFourCreatorZTransformationUsing(in double newScaleMatrixFourCreatorZDimensionToDefine)
        {
            MatrixFourComponentWithFactoryMethod scaleMatrixFourCreatorMatrixFourComponent = MatrixFourComponentWithFactoryMethod.GetMatrixFourComponentIdentity();
            scaleMatrixFourCreatorMatrixFourComponent.SetMatrixFourComponentElementUsing(matrixFourComponentRowLevel: MatrixFourRowLevel.MatrixFourRowLevelZ, matrixFourComponentColumnLevel: MatrixFourColumnLevel.MatrixFourColumnLevelC, newMatrixFourComponentElementToDefine: newScaleMatrixFourCreatorZDimensionToDefine);

            MatrixFourCreatorMatrixFourComponent = MatrixFourComponentWithFactoryMethod.GetMatrixFourComponentMultiplicationUsing(firstMatrixFourComponentToHandle: MatrixFourCreatorMatrixFourComponent, secondMatrixFourComponentToHandle: scaleMatrixFourCreatorMatrixFourComponent);
        }
    }
}