using System;
using ServiceStack;
using SSExample;

namespace SSClient
{
  class Program
  {
    static void Main()
    {
      var client = new JsonHttpClient("http://localhost:8080");


      var responseDto = client.Get((dynamic)new WorksPointGetDto {PointId = 3});
      Console.WriteLine($"This works and returned a DTO with name = {responseDto.Name}.");


      responseDto = client.Get((dynamic)new WhyDoesThisWorkPointGetDto {PointId = 3});
      Console.WriteLine($"Why does this work?  It also returned a DTO with name = {responseDto.Name}.");


      // This throws a "Bad Request" exception.
      responseDto = client.Get((dynamic)new WhyDoesThisNotWorkPointGetDto { PointId = 3 });
      Console.WriteLine($"Returned DTO with name {responseDto.Name}.");


      Console.WriteLine("\n\nPress any key to exit.");
      Console.ReadKey();
    }
  }
}
