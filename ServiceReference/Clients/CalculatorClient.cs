using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Threading.Tasks;

using ServiceReference.Interfaces;

namespace ServiceReference.Clients 
{
  public class CalculatorClient : ClientBase<ICalculatorService>, ICalculatorService
  {
    public CalculatorClient()
    {
    }

    public CalculatorClient(string endpointConfigurationName) : 
      base(endpointConfigurationName)
    {
    }

    public CalculatorClient(string endpointConfigurationName, string remoteAddress) : 
      base(endpointConfigurationName, remoteAddress)
    {
    }

    public CalculatorClient(string endpointConfigurationName, EndpointAddress remoteAddress) : 
      base(endpointConfigurationName, remoteAddress)
    {
    }

    public CalculatorClient(Binding binding, EndpointAddress endpoint) : 
      base(binding, endpoint)
    {
    }

    public Task<int> AddAsync(int intA, int intB)
    {
      return base.Channel.AddAsync(intA, intB);
    }

    public Task<int> DivideAsync(int intA, int intB)
    {
      return base.Channel.DivideAsync(intA, intB);
    }

    public Task<int> MultiplyAsync(int intA, int intB)
    {
      return base.Channel.MultiplyAsync(intA, intB);
    }

    public Task<int> SubtractAsync(int intA, int intB)
    {
      return base.Channel.SubtractAsync(intA, intB);
    }
  }
}