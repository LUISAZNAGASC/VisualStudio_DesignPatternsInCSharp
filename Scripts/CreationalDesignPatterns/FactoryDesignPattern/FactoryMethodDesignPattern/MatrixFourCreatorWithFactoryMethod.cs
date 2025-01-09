namespace VisualStudio_DesignPatternsInCSharp.CreationalDesignPatterns.FactoryDesignPattern.FactoryMethodDesignPattern
{
    public abstract class MatrixFourCreatorWithFactoryMethod
    {
        protected MatrixFourComponentWithFactoryMethod MatrixFourCreatorMatrixFourComponent { get; set; }

        public MatrixFourCreatorWithFactoryMethod(in double newMatrixFourCreatorXTransformationToInitialize, in double newMatrixFourCreatorYTransformationToInitialize, in double newMatrixFourCreatorZTransformationToInitialize) : base()
        {
            MatrixFourCreatorMatrixFourComponent = MatrixFourComponentWithFactoryMethod.GetMatrixFourComponentIdentity();
            SetMatrixFourCreatorXTransformationUsing(newMatrixFourCreatorXTransformationToDefine: newMatrixFourCreatorXTransformationToInitialize);
            SetMatrixFourCreatorYTransformationUsing(newMatrixFourCreatorYTransformationToDefine: newMatrixFourCreatorYTransformationToInitialize);
            SetMatrixFourCreatorZTransformationUsing(newMatrixFourCreatorZTransformationToDefine: newMatrixFourCreatorZTransformationToInitialize);
        }

        public MatrixFourComponentWithFactoryMethod GetMatrixFourCreatorMatrixFourComponent()
        {
            return MatrixFourCreatorMatrixFourComponent;
        }

        public abstract void SetMatrixFourCreatorXTransformationUsing(in double newMatrixFourCreatorXTransformationToDefine);

        public abstract void SetMatrixFourCreatorYTransformationUsing(in double newMatrixFourCreatorYTransformationToDefine);

        public abstract void SetMatrixFourCreatorZTransformationUsing(in double newMatrixFourCreatorZTransformationToDefine);
    }
}