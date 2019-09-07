namespace calcApi.Models {
  public class CalculatorSettings : ICalculatorSettings 
  {
    public string endpointAddress { get; set; }
    public double timeout { get; set; }
  }

  public interface ICalculatorSettings 
  {
    string endpointAddress { get; set; }
    double timeout { get; set; }
  }
}