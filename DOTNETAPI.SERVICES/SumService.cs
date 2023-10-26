using DOTNETAPI.MODELS;
namespace DOTNETAPI.SERVICES;

public class SumService : ISumService
{
  public int sum (int a , int b) {
    return a + b;
  }
}