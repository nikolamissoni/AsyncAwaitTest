using AsyncAwaitSoap.Service;
using System.Threading.Tasks;

namespace AsyncAwaitSoap.Controller
{
    public class MathOpController
    {
        public async Task<string> Add(int firstNum, int secondNum)
        {
            var svc = new CalculatorService
            {
                FirstNumber = firstNum,
                SecondNumber = secondNum
            };
            var result = await svc.AddAsync();
            System.Console.WriteLine("Async add method got the result from SOAP svc");
            return result.ToString();
        }
    }
}
