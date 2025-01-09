namespace VisualStudio_DesignPatternsInCSharp.CreationalDesignPatterns.FactoryDesignPattern.FactoryMethodDesignPattern
{
    public sealed class PositionMatrixFourCreatorWithFactoryMethod : MatrixFourCreatorWithFactoryMethod
    {
        public PositionMatrixFourCreatorWithFactoryMethod(in double newPositionMatrixFourCreatorXTranslationToInitialize, in double newPositionMatrixFourCreatorYTranslationToInitialize, in double newPositionMatrixFourCreatorZTranslationToInitialize) : base(newMatrixFourCreatorXTransformationToInitialize: newPositionMatrixFourCreatorXTranslationToInitialize, newMatrixFourCreatorYTransformationToInitialize: newPositionMatrixFourCreatorYTranslationToInitialize, newMatrixFourCreatorZTransformationToInitialize: newPositionMatrixFourCreatorZTranslationToInitialize)
        {

        }

        public override void SetMatrixFourCreatorXTransformationUsing(in double newPositionMatrixFourCreatorXTranslationToDefine)
        {
            MatrixFourComponentWithFactoryMethod positionMatrixFourCreatorMatrixFourComponent = MatrixFourComponentWithFactoryMethod.GetMatrixFourComponentIdentity();
            positionMatrixFourCreatorMatrixFourComponent.MatrixFourComponentAW = newPositionMatrixFourCreatorXTranslationToDefine;

            MatrixFourCreatorMatrixFourComponent *= positionMatrixFourCreatorMatrixFourComponent;
        }

        public override void SetMatrixFourCreatorYTransformationUsing(in double newPositionMatrixFourCreatorYTranslationToDefine)
        {
            MatrixFourComponentWithFactoryMethod positionMatrixFourCreatorMatrixFourComponent = MatrixFourComponentWithFactoryMethod.GetMatrixFourComponentIdentity();
            positionMatrixFourCreatorMatrixFourComponent.MatrixFourComponentBW = newPositionMatrixFourCreatorYTranslationToDefine;

            MatrixFourCreatorMatrixFourComponent *= positionMatrixFourCreatorMatrixFourComponent;
        }

        public override void SetMatrixFourCreatorZTransformationUsing(in double newPositionMatrixFourCreatorZTranslationToDefine)
        {
            MatrixFourComponentWithFactoryMethod positionMatrixFourCreatorMatrixFourComponent = MatrixFourComponentWithFactoryMethod.GetMatrixFourComponentIdentity();
            positionMatrixFourCreatorMatrixFourComponent.MatrixFourComponentCW = newPositionMatrixFourCreatorZTranslationToDefine;

            MatrixFourCreatorMatrixFourComponent *= positionMatrixFourCreatorMatrixFourComponent;
        }
    }
}