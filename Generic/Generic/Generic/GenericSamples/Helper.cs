namespace Generic.GenericSamples
{
    public class Helper
    {
        public SwapModel<T> Run<T>(SwapModel<T> swapModel)
        {
            T z = swapModel.X;
            swapModel.X = swapModel.Y;
            swapModel.Y = z;

            return swapModel;
        }

        /*
        public void Test<T>(T objects) where T : IComparable<T> , new()
        {

        }
        */
    }
}