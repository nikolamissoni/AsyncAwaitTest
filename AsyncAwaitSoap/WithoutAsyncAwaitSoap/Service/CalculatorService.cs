namespace WithoutAsyncAwaitSoap.Service
{
    public class CalculatorService
    {
        public int FirstNumber { get; set; }
        public int SecondNumber { get; set; }

        public int Add()
        {
            using(var svc = new CalculatorServiceNoAsync.CalculatorSoapClient())
            {
                var result = svc.Add(FirstNumber, SecondNumber);
                return result;
            }
        }
    }
}
