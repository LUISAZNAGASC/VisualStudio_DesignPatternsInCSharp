namespace VisualStudio_DesignPatternsInCSharp.CreationalDesignPatterns.FactoryDesignPattern.FactoryMethodDesignPattern
{
    using System;

    public sealed class RotationMatrixFourCreatorWithFactoryMethod : MatrixFourCreatorWithFactoryMethod
    {
        private const double RotationMatrixFourCreatorDegreesToRadiansConversor = Math.PI / 180.0;

        public RotationMatrixFourCreatorWithFactoryMethod(in double newRotationMatrixFourCreatorXOrientationToInitialize, in double newRotationMatrixFourCreatorYOrientationToInitialize, in double newRotationMatrixFourCreatorZOrientationToInitialize) : base(newMatrixFourCreatorXTransformationToInitialize: newRotationMatrixFourCreatorXOrientationToInitialize, newMatrixFourCreatorYTransformationToInitialize: newRotationMatrixFourCreatorYOrientationToInitialize, newMatrixFourCreatorZTransformationToInitialize: newRotationMatrixFourCreatorZOrientationToInitialize)
        {

        }

        public override void SetMatrixFourCreatorXTransformationUsing(in double newRotationMatrixFourCreatorXOrientationToDefine)
        {
            MatrixFourComponentWithFactoryMethod rotationMatrixFourCreatorMatrixFourComponent = MatrixFourComponentWithFactoryMethod.GetMatrixFourComponentIdentity();
            rotationMatrixFourCreatorMatrixFourComponent.SetMatrixFourComponentElementUsing(matrixFourComponentRowLevel: MatrixFourRowLevel.MatrixFourRowLevelY, matrixFourComponentColumnLevel: MatrixFourColumnLevel.MatrixFourColumnLevelB, newMatrixFourComponentElementToDefine: Math.Cos(d: RotationMatrixFourCreatorDegreesToRadiansConversor * newRotationMatrixFourCreatorXOrientationToDefine));
            rotationMatrixFourCreatorMatrixFourComponent.SetMatrixFourComponentElementUsing(matrixFourComponentRowLevel: MatrixFourRowLevel.MatrixFourRowLevelZ, matrixFourComponentColumnLevel: MatrixFourColumnLevel.MatrixFourColumnLevelB, newMatrixFourComponentElementToDefine: -Math.Sin(a: RotationMatrixFourCreatorDegreesToRadiansConversor * newRotationMatrixFourCreatorXOrientationToDefine));
            rotationMatrixFourCreatorMatrixFourComponent.SetMatrixFourComponentElementUsing(matrixFourComponentRowLevel: MatrixFourRowLevel.MatrixFourRowLevelY, matrixFourComponentColumnLevel: MatrixFourColumnLevel.MatrixFourColumnLevelC, newMatrixFourComponentElementToDefine: Math.Sin(a: RotationMatrixFourCreatorDegreesToRadiansConversor * newRotationMatrixFourCreatorXOrientationToDefine));
            rotationMatrixFourCreatorMatrixFourComponent.SetMatrixFourComponentElementUsing(matrixFourComponentRowLevel: MatrixFourRowLevel.MatrixFourRowLevelZ, matrixFourComponentColumnLevel: MatrixFourColumnLevel.MatrixFourColumnLevelC, newMatrixFourComponentElementToDefine: Math.Cos(d: RotationMatrixFourCreatorDegreesToRadiansConversor * newRotationMatrixFourCreatorXOrientationToDefine));

            MatrixFourCreatorMatrixFourComponent = MatrixFourComponentWithFactoryMethod.GetMatrixFourComponentMultiplicationUsing(firstMatrixFourComponentToHandle: MatrixFourCreatorMatrixFourComponent, secondMatrixFourComponentToHandle: rotationMatrixFourCreatorMatrixFourComponent);
        }

        public override void SetMatrixFourCreatorYTransformationUsing(in double newRotationMatrixFourCreatorYOrientationToDefine)
        {
            MatrixFourComponentWithFactoryMethod rotationMatrixFourCreatorMatrixFourComponent = MatrixFourComponentWithFactoryMethod.GetMatrixFourComponentIdentity();
            rotationMatrixFourCreatorMatrixFourComponent.SetMatrixFourComponentElementUsing(matrixFourComponentRowLevel: MatrixFourRowLevel.MatrixFourRowLevelX, matrixFourComponentColumnLevel: MatrixFourColumnLevel.MatrixFourColumnLevelA, newMatrixFourComponentElementToDefine: Math.Cos(d: RotationMatrixFourCreatorDegreesToRadiansConversor * newRotationMatrixFourCreatorYOrientationToDefine));
            rotationMatrixFourCreatorMatrixFourComponent.SetMatrixFourComponentElementUsing(matrixFourComponentRowLevel: MatrixFourRowLevel.MatrixFourRowLevelZ, matrixFourComponentColumnLevel: MatrixFourColumnLevel.MatrixFourColumnLevelA, newMatrixFourComponentElementToDefine: Math.Sin(a: RotationMatrixFourCreatorDegreesToRadiansConversor * newRotationMatrixFourCreatorYOrientationToDefine));
            rotationMatrixFourCreatorMatrixFourComponent.SetMatrixFourComponentElementUsing(matrixFourComponentRowLevel: MatrixFourRowLevel.MatrixFourRowLevelX, matrixFourComponentColumnLevel: MatrixFourColumnLevel.MatrixFourColumnLevelC, newMatrixFourComponentElementToDefine: -Math.Sin(a: RotationMatrixFourCreatorDegreesToRadiansConversor * newRotationMatrixFourCreatorYOrientationToDefine));
            rotationMatrixFourCreatorMatrixFourComponent.SetMatrixFourComponentElementUsing(matrixFourComponentRowLevel: MatrixFourRowLevel.MatrixFourRowLevelZ, matrixFourComponentColumnLevel: MatrixFourColumnLevel.MatrixFourColumnLevelC, newMatrixFourComponentElementToDefine: Math.Cos(d: RotationMatrixFourCreatorDegreesToRadiansConversor * newRotationMatrixFourCreatorYOrientationToDefine));

            MatrixFourCreatorMatrixFourComponent = MatrixFourComponentWithFactoryMethod.GetMatrixFourComponentMultiplicationUsing(firstMatrixFourComponentToHandle: MatrixFourCreatorMatrixFourComponent, secondMatrixFourComponentToHandle: rotationMatrixFourCreatorMatrixFourComponent);
        }

        public override void SetMatrixFourCreatorZTransformationUsing(in double newRotationMatrixFourCreatorZOrientationToDefine)
        {
            MatrixFourComponentWithFactoryMethod rotationMatrixFourCreatorMatrixFourComponent = MatrixFourComponentWithFactoryMethod.GetMatrixFourComponentIdentity();
            rotationMatrixFourCreatorMatrixFourComponent.SetMatrixFourComponentElementUsing(matrixFourComponentRowLevel: MatrixFourRowLevel.MatrixFourRowLevelX, matrixFourComponentColumnLevel: MatrixFourColumnLevel.MatrixFourColumnLevelA, newMatrixFourComponentElementToDefine: Math.Cos(d: RotationMatrixFourCreatorDegreesToRadiansConversor * newRotationMatrixFourCreatorZOrientationToDefine));
            rotationMatrixFourCreatorMatrixFourComponent.SetMatrixFourComponentElementUsing(matrixFourComponentRowLevel: MatrixFourRowLevel.MatrixFourRowLevelY, matrixFourComponentColumnLevel: MatrixFourColumnLevel.MatrixFourColumnLevelA, newMatrixFourComponentElementToDefine: -Math.Sin(a: RotationMatrixFourCreatorDegreesToRadiansConversor * newRotationMatrixFourCreatorZOrientationToDefine));
            rotationMatrixFourCreatorMatrixFourComponent.SetMatrixFourComponentElementUsing(matrixFourComponentRowLevel: MatrixFourRowLevel.MatrixFourRowLevelX, matrixFourComponentColumnLevel: MatrixFourColumnLevel.MatrixFourColumnLevelB, newMatrixFourComponentElementToDefine: Math.Sin(a: RotationMatrixFourCreatorDegreesToRadiansConversor * newRotationMatrixFourCreatorZOrientationToDefine));
            rotationMatrixFourCreatorMatrixFourComponent.SetMatrixFourComponentElementUsing(matrixFourComponentRowLevel: MatrixFourRowLevel.MatrixFourRowLevelY, matrixFourComponentColumnLevel: MatrixFourColumnLevel.MatrixFourColumnLevelB, newMatrixFourComponentElementToDefine: Math.Cos(d: RotationMatrixFourCreatorDegreesToRadiansConversor * newRotationMatrixFourCreatorZOrientationToDefine));

            MatrixFourCreatorMatrixFourComponent = MatrixFourComponentWithFactoryMethod.GetMatrixFourComponentMultiplicationUsing(firstMatrixFourComponentToHandle: MatrixFourCreatorMatrixFourComponent, secondMatrixFourComponentToHandle: rotationMatrixFourCreatorMatrixFourComponent);
        }
    }
}