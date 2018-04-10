using Funq;
using ServiceStack;
using ServiceStack.Api.OpenApi;
using ServiceStack.Text;


namespace SSExample
{
  public class AppHost : AppHostHttpListenerBase
  {
    public AppHost() : base("SSExample", typeof(Program).Assembly)
    {}

    
    public override void Configure(Container container)
    {
      Plugins.Add(new OpenApiFeature());

      JsConfig.EmitLowercaseUnderscoreNames = true;
    }
  }
}
