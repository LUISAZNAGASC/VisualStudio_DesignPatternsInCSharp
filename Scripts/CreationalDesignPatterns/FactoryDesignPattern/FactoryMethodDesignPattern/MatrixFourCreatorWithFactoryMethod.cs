namespace VisualStudio_DesignPatternsInCSharp.CreationalDesignPatterns.FactoryDesignPattern.FactoryMethodDesignPattern
{
    public abstract class MatrixFourCreatorWithFactoryMethod
    {
        protected MatrixFourComponentWithFactoryMethod MatrixFourCreatorMatrixFourComponent { get; set; }

        public MatrixFourCreatorWithFactoryMethod(in double otherMatrixFourCreatorXTransformationToHandle, in double otherMatrixFourCreatorYTransformationToHandle, in double otherMatrixFourCreatorZTransformationToHandle) : base()
        {
            MatrixFourCreatorMatrixFourComponent = MatrixFourComponentWithFactoryMethod.GetMatrixFourComponentIdentity();

            SetMatrixFourCreatorXTransformationUsing(otherMatrixFourCreatorXTransformationToHandle: otherMatrixFourCreatorXTransformationToHandle);
            SetMatrixFourCreatorYTransformationUsing(otherMatrixFourCreatorYTransformationToHandle: otherMatrixFourCreatorYTransformationToHandle);
            SetMatrixFourCreatorZTransformationUsing(otherMatrixFourCreatorZTransformationToHandle: otherMatrixFourCreatorZTransformationToHandle);
        }

        public MatrixFourComponentWithFactoryMethod GetMatrixFourCreatorMatrixFourComponent()
        {
            return MatrixFourCreatorMatrixFourComponent;
        }

        public abstract void SetMatrixFourCreatorXTransformationUsing(in double otherMatrixFourCreatorXTransformationToHandle);

        public abstract void SetMatrixFourCreatorYTransformationUsing(in double otherMatrixFourCreatorYTransformationToHandle);

        public abstract void SetMatrixFourCreatorZTransformationUsing(in double otherMatrixFourCreatorZTransformationToHandle);
    }
}