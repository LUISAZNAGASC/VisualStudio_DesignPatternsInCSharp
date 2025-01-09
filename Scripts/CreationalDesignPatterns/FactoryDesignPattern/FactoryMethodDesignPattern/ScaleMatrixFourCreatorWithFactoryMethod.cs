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
            scaleMatrixFourCreatorMatrixFourComponent.MatrixFourComponentAX = newScaleMatrixFourCreatorXDimensionToDefine;

            MatrixFourCreatorMatrixFourComponent *= scaleMatrixFourCreatorMatrixFourComponent;
        }

        public override void SetMatrixFourCreatorYTransformationUsing(in double newScaleMatrixFourCreatorYDimensionToDefine)
        {
            MatrixFourComponentWithFactoryMethod scaleMatrixFourCreatorMatrixFourComponent = MatrixFourComponentWithFactoryMethod.GetMatrixFourComponentIdentity();
            scaleMatrixFourCreatorMatrixFourComponent.MatrixFourComponentBY = newScaleMatrixFourCreatorYDimensionToDefine;

            MatrixFourCreatorMatrixFourComponent *= scaleMatrixFourCreatorMatrixFourComponent;
        }

        public override void SetMatrixFourCreatorZTransformationUsing(in double newScaleMatrixFourCreatorZDimensionToDefine)
        {
            MatrixFourComponentWithFactoryMethod scaleMatrixFourCreatorMatrixFourComponent = MatrixFourComponentWithFactoryMethod.GetMatrixFourComponentIdentity();
            scaleMatrixFourCreatorMatrixFourComponent.MatrixFourComponentCZ = newScaleMatrixFourCreatorZDimensionToDefine;

            MatrixFourCreatorMatrixFourComponent *= scaleMatrixFourCreatorMatrixFourComponent;
        }
    }
}