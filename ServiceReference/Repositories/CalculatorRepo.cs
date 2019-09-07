using System;
using System.ServiceModel;
using System.Threading.Tasks;
using System.Xml;

using ServiceReference.Interfaces;

namespace ServiceReference.Repositories
{
  public class CalculatorRepo 
  {
    private readonly ICalculatorChannel proxy;

    public CalculatorRepo(string endpointAddress, double timeout)
    {
      BasicHttpBinding binding = new BasicHttpBinding(BasicHttpSecurityMode.None);  
      binding.SendTimeout = TimeSpan.FromSeconds(timeout);
      binding.MaxBufferSize = int.MaxValue;
      binding.MaxReceivedMessageSize = int.MaxValue;
      binding.AllowCookies = true;
      binding.ReaderQuotas = XmlDictionaryReaderQuotas.Max;

      EndpointAddress address = new EndpointAddress(endpointAddress);

      ChannelFactory<ICalculatorChannel> factory = new ChannelFactory<ICalculatorChannel>(binding, address);

      this.proxy = factory.CreateChannel();
    }

    public Task<int> AddAsync(int intA, int intB)
    {
        return this.proxy.AddAsync(intA, intB);
    }

    public Task<int> SubtractAsync(int intA, int intB)
    {
        return this.proxy.SubtractAsync(intA, intB);
    }

    public Task<int> MultiplyAsync(int intA, int intB)
    {
        return this.proxy.MultiplyAsync(intA, intB);
    }

    public Task<int> DivideAsync(int intA, int intB)
    {
        return this.proxy.DivideAsync(intA, intB);
    }
  }
}