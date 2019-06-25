namespace WithoutAsyncAwaitSoap.Controller
{
    public class MathOpController
    {
        public string Add(int firstNum, int secondNum)
        {
            var svcNoAsync = new WithoutAsyncAwaitSoap.Service.CalculatorService
            {
                FirstNumber = firstNum,
                SecondNumber = secondNum
            };

            var result = svcNoAsync.Add();
            System.Console.WriteLine("Add method got the result from SOAP svc");
            return result.ToString();
        }
    }
}
