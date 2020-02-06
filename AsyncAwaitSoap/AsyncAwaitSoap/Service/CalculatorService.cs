using System.Threading.Tasks;

namespace AsyncAwaitSoap.Service
{
    /***
     * Class used for executing call to remote service
     */
    public class CalculatorService
    {
        public int FirstNumber { get; set; }
        public int SecondNumber { get; set; }

        public async Task<int> AddAsync()
        {
            using(var svc = new Calculator.CalculatorSoapClient())
            {
                var result = await svc.AddAsync(FirstNumber, SecondNumber);
                return result;
            }
        }
    }
}
