namespace SplittingFeaturesAndSteps
{
    public class Calculator
    {
        public Calculator() { }
        public int FirstNumber { get; set; }
        public int SecondNumber { get; set; }
        public int Result { get; set; }

        public int Sum() =>
            Result = FirstNumber + SecondNumber;
    }
}
