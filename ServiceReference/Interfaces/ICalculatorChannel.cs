using System.ServiceModel;

namespace ServiceReference.Interfaces 
{
  public interface ICalculatorChannel : IClientChannel, ICalculatorService { }
}