namespace VisualStudio_DesignPatternsInCSharp.CreationalDesignPatterns.FactoryDesignPattern.FactoryMethodDesignPattern
{
    public sealed class PositionMatrixFourCreatorWithFactoryMethod(in double otherPositionMatrixFourCreatorXTranslationToHandle, in double otherPositionMatrixFourCreatorYTranslationToHandle, in double otherPositionMatrixFourCreatorZTranslationToHandle) : MatrixFourCreatorWithFactoryMethod(otherMatrixFourCreatorXTransformationToHandle: otherPositionMatrixFourCreatorXTranslationToHandle, otherMatrixFourCreatorYTransformationToHandle: otherPositionMatrixFourCreatorYTranslationToHandle, otherMatrixFourCreatorZTransformationToHandle: otherPositionMatrixFourCreatorZTranslationToHandle)
    {
        public override void SetMatrixFourCreatorXTransformationUsing(in double otherPositionMatrixFourCreatorXTranslationToHandle)
        {
            MatrixFourComponentWithFactoryMethod positionMatrixFourCreatorMatrixFourComponent = MatrixFourComponentWithFactoryMethod.GetMatrixFourComponentIdentity();
            positionMatrixFourCreatorMatrixFourComponent.SetMatrixFourComponentElementUsing(otherMatrixFourComponentRowLevelToHandle: MatrixFourRowLevelWithFactoryMethod.MatrixFourRowLevelW, otherMatrixFourComponentColumnLevelToHandle: MatrixFourColumnLevelWithFactoryMethod.MatrixFourColumnLevelA, otherMatrixFourComponentElementToHandle: otherPositionMatrixFourCreatorXTranslationToHandle);

            MatrixFourCreatorMatrixFourComponent = MatrixFourComponentWithFactoryMethod.GetMatrixFourComponentMultiplicationUsing(leftMatrixFourComponentToHandle: MatrixFourCreatorMatrixFourComponent, rightMatrixFourComponentToHandle: positionMatrixFourCreatorMatrixFourComponent);
        }

        public override void SetMatrixFourCreatorYTransformationUsing(in double otherPositionMatrixFourCreatorYTranslationToHandle)
        {
            MatrixFourComponentWithFactoryMethod positionMatrixFourCreatorMatrixFourComponent = MatrixFourComponentWithFactoryMethod.GetMatrixFourComponentIdentity();
            positionMatrixFourCreatorMatrixFourComponent.SetMatrixFourComponentElementUsing(otherMatrixFourComponentRowLevelToHandle: MatrixFourRowLevelWithFactoryMethod.MatrixFourRowLevelW, otherMatrixFourComponentColumnLevelToHandle: MatrixFourColumnLevelWithFactoryMethod.MatrixFourColumnLevelB, otherMatrixFourComponentElementToHandle: otherPositionMatrixFourCreatorYTranslationToHandle);

            MatrixFourCreatorMatrixFourComponent = MatrixFourComponentWithFactoryMethod.GetMatrixFourComponentMultiplicationUsing(leftMatrixFourComponentToHandle: MatrixFourCreatorMatrixFourComponent, rightMatrixFourComponentToHandle: positionMatrixFourCreatorMatrixFourComponent);
        }

        public override void SetMatrixFourCreatorZTransformationUsing(in double otherPositionMatrixFourCreatorZTranslationToHandle)
        {
            MatrixFourComponentWithFactoryMethod positionMatrixFourCreatorMatrixFourComponent = MatrixFourComponentWithFactoryMethod.GetMatrixFourComponentIdentity();
            positionMatrixFourCreatorMatrixFourComponent.SetMatrixFourComponentElementUsing(otherMatrixFourComponentRowLevelToHandle: MatrixFourRowLevelWithFactoryMethod.MatrixFourRowLevelW, otherMatrixFourComponentColumnLevelToHandle: MatrixFourColumnLevelWithFactoryMethod.MatrixFourColumnLevelC, otherMatrixFourComponentElementToHandle: otherPositionMatrixFourCreatorZTranslationToHandle);

            MatrixFourCreatorMatrixFourComponent = MatrixFourComponentWithFactoryMethod.GetMatrixFourComponentMultiplicationUsing(leftMatrixFourComponentToHandle: MatrixFourCreatorMatrixFourComponent, rightMatrixFourComponentToHandle: positionMatrixFourCreatorMatrixFourComponent);
        }
    }
}