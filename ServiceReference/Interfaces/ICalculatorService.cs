using System.ServiceModel;
using System.Threading.Tasks;

namespace ServiceReference.Interfaces 
{
  [ServiceContract(ConfigurationName="ServiceReference.Interfaces.ICalculatorService")]
  public interface ICalculatorService 
  {    
      [OperationContract(Action="http://tempuri.org/Add", ReplyAction="*")]
      Task<int> AddAsync(int intA, int intB);
      
      [OperationContract(Action="http://tempuri.org/Subtract", ReplyAction="*")]
      Task<int> SubtractAsync(int intA, int intB);
      
      [OperationContract(Action="http://tempuri.org/Multiply", ReplyAction="*")]
      Task<int> MultiplyAsync(int intA, int intB);
      
      [OperationContract(Action="http://tempuri.org/Divide", ReplyAction="*")]
      Task<int> DivideAsync(int intA, int intB);
  }
}