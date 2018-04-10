using System;


namespace SSExample
{
  class Program
  {
    static void Main()
    {
      var appHost = new AppHost();
      appHost.Init();
      appHost.Start(@"http://*:8080/");

      Console.WriteLine(@"Listening.... Press any key to exit.");
      Console.ReadKey();

      appHost.Dispose();
    }
  }
}
