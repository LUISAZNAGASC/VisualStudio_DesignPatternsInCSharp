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
            rotationMatrixFourCreatorMatrixFourComponent.MatrixFourComponentBY = Math.Cos(d: RotationMatrixFourCreatorDegreesToRadiansConversor * newRotationMatrixFourCreatorXOrientationToDefine);
            rotationMatrixFourCreatorMatrixFourComponent.MatrixFourComponentBZ = -Math.Sin(a: RotationMatrixFourCreatorDegreesToRadiansConversor * newRotationMatrixFourCreatorXOrientationToDefine);
            rotationMatrixFourCreatorMatrixFourComponent.MatrixFourComponentCY = Math.Sin(a: RotationMatrixFourCreatorDegreesToRadiansConversor * newRotationMatrixFourCreatorXOrientationToDefine);
            rotationMatrixFourCreatorMatrixFourComponent.MatrixFourComponentCZ = Math.Cos(d: RotationMatrixFourCreatorDegreesToRadiansConversor * newRotationMatrixFourCreatorXOrientationToDefine);

            MatrixFourCreatorMatrixFourComponent *= rotationMatrixFourCreatorMatrixFourComponent;
        }

        public override void SetMatrixFourCreatorYTransformationUsing(in double newRotationMatrixFourCreatorYOrientationToDefine)
        {
            MatrixFourComponentWithFactoryMethod rotationMatrixFourCreatorMatrixFourComponent = MatrixFourComponentWithFactoryMethod.GetMatrixFourComponentIdentity();
            rotationMatrixFourCreatorMatrixFourComponent.MatrixFourComponentAX = Math.Cos(d: RotationMatrixFourCreatorDegreesToRadiansConversor * newRotationMatrixFourCreatorYOrientationToDefine);
            rotationMatrixFourCreatorMatrixFourComponent.MatrixFourComponentAZ = Math.Sin(a: RotationMatrixFourCreatorDegreesToRadiansConversor * newRotationMatrixFourCreatorYOrientationToDefine);
            rotationMatrixFourCreatorMatrixFourComponent.MatrixFourComponentCX = -Math.Sin(a: RotationMatrixFourCreatorDegreesToRadiansConversor * newRotationMatrixFourCreatorYOrientationToDefine);
            rotationMatrixFourCreatorMatrixFourComponent.MatrixFourComponentCZ = Math.Cos(d: RotationMatrixFourCreatorDegreesToRadiansConversor * newRotationMatrixFourCreatorYOrientationToDefine);

            MatrixFourCreatorMatrixFourComponent *= rotationMatrixFourCreatorMatrixFourComponent;
        }

        public override void SetMatrixFourCreatorZTransformationUsing(in double newRotationMatrixFourCreatorZOrientationToDefine)
        {
            MatrixFourComponentWithFactoryMethod rotationMatrixFourCreatorMatrixFourComponent = MatrixFourComponentWithFactoryMethod.GetMatrixFourComponentIdentity();
            rotationMatrixFourCreatorMatrixFourComponent.MatrixFourComponentAX = Math.Cos(d: RotationMatrixFourCreatorDegreesToRadiansConversor * newRotationMatrixFourCreatorZOrientationToDefine);
            rotationMatrixFourCreatorMatrixFourComponent.MatrixFourComponentAY = -Math.Sin(a: RotationMatrixFourCreatorDegreesToRadiansConversor * newRotationMatrixFourCreatorZOrientationToDefine);
            rotationMatrixFourCreatorMatrixFourComponent.MatrixFourComponentBX = Math.Sin(a: RotationMatrixFourCreatorDegreesToRadiansConversor * newRotationMatrixFourCreatorZOrientationToDefine);
            rotationMatrixFourCreatorMatrixFourComponent.MatrixFourComponentBY = Math.Cos(d: RotationMatrixFourCreatorDegreesToRadiansConversor * newRotationMatrixFourCreatorZOrientationToDefine);

            MatrixFourCreatorMatrixFourComponent *= rotationMatrixFourCreatorMatrixFourComponent;
        }
    }
}