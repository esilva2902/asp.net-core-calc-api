using System.Threading.Tasks;

using calcApi.Models;
using ServiceReference.Repositories;

namespace calcApi.Services
{
  public class CalculatorService {
    private readonly CalculatorRepo calcRepo;

    public CalculatorService(ICalculatorSettings settings) {
        this.calcRepo = new CalculatorRepo(settings.endpointAddress, settings.timeout);
    }

    public int add(int a, int b) 
    {
      Task<int> calculation = this.calcRepo.AddAsync(a, b);
      calculation.Wait();
      
      return calculation.Result;
    }

    public int subtract(int a, int b) 
    {
      Task<int> calculation = this.calcRepo.SubtractAsync(a, b);
      calculation.Wait();
      
      return calculation.Result;
    }

    public int multiply(int a, int b) 
    {
      Task<int> calculation = this.calcRepo.MultiplyAsync(a, b);
      calculation.Wait();
      
      return calculation.Result;
    }

    public int divide(int a, int b) 
    {
      Task<int> calculation = this.calcRepo.DivideAsync(a, b);
      calculation.Wait();
      
      return calculation.Result;
    }
  }
}