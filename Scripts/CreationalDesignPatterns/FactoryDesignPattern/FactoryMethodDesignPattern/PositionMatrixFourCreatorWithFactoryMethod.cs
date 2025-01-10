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
            positionMatrixFourCreatorMatrixFourComponent.SetMatrixFourComponentElementUsing(matrixFourComponentRowLevel: MatrixFourRowLevel.MatrixFourRowLevelW, matrixFourComponentColumnLevel: MatrixFourColumnLevel.MatrixFourColumnLevelA, newMatrixFourComponentElementToDefine: newPositionMatrixFourCreatorXTranslationToDefine);

            MatrixFourCreatorMatrixFourComponent = MatrixFourComponentWithFactoryMethod.GetMatrixFourComponentMultiplicationUsing(firstMatrixFourComponentToHandle: MatrixFourCreatorMatrixFourComponent, secondMatrixFourComponentToHandle: positionMatrixFourCreatorMatrixFourComponent);
        }

        public override void SetMatrixFourCreatorYTransformationUsing(in double newPositionMatrixFourCreatorYTranslationToDefine)
        {
            MatrixFourComponentWithFactoryMethod positionMatrixFourCreatorMatrixFourComponent = MatrixFourComponentWithFactoryMethod.GetMatrixFourComponentIdentity();
            positionMatrixFourCreatorMatrixFourComponent.SetMatrixFourComponentElementUsing(matrixFourComponentRowLevel: MatrixFourRowLevel.MatrixFourRowLevelW, matrixFourComponentColumnLevel: MatrixFourColumnLevel.MatrixFourColumnLevelB, newMatrixFourComponentElementToDefine: newPositionMatrixFourCreatorYTranslationToDefine);

            MatrixFourCreatorMatrixFourComponent = MatrixFourComponentWithFactoryMethod.GetMatrixFourComponentMultiplicationUsing(firstMatrixFourComponentToHandle: MatrixFourCreatorMatrixFourComponent, secondMatrixFourComponentToHandle: positionMatrixFourCreatorMatrixFourComponent);
        }

        public override void SetMatrixFourCreatorZTransformationUsing(in double newPositionMatrixFourCreatorZTranslationToDefine)
        {
            MatrixFourComponentWithFactoryMethod positionMatrixFourCreatorMatrixFourComponent = MatrixFourComponentWithFactoryMethod.GetMatrixFourComponentIdentity();
            positionMatrixFourCreatorMatrixFourComponent.SetMatrixFourComponentElementUsing(matrixFourComponentRowLevel: MatrixFourRowLevel.MatrixFourRowLevelW, matrixFourComponentColumnLevel: MatrixFourColumnLevel.MatrixFourColumnLevelC, newMatrixFourComponentElementToDefine: newPositionMatrixFourCreatorZTranslationToDefine);

            MatrixFourCreatorMatrixFourComponent = MatrixFourComponentWithFactoryMethod.GetMatrixFourComponentMultiplicationUsing(firstMatrixFourComponentToHandle: MatrixFourCreatorMatrixFourComponent, secondMatrixFourComponentToHandle: positionMatrixFourCreatorMatrixFourComponent);
        }
    }
}