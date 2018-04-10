using System.Runtime.Serialization;
using ServiceStack;

namespace SSExample
{
  [DataContract]
  public class PointDto
  {
    [DataMember(Name = "point-id")]
    public int PointId { get; set; }

    [DataMember(Name = "name")]
    public string Name { get; set; }
  }


  /// <summary>
  /// This works as expected since the route's variable place-holder exactly matches the DTO property name.
  /// </summary>
  [Route("/v1/works/point/{PointId}", "GET")]
  public class WorksPointGetDto : IReturn<PointDto>
  {
    public int PointId { get; set; }
  }


  /// <summary>
  /// Given that one might assume from the above example that the route's variable place-holder must match the 
  /// DTO property name exactly, why does this one work?  It gives the impression that ServiceStack is using the 
  /// DataMember attribute to resolve the variable place-holder, but because this does work, I am assuming that
  /// the DTO property name matching is being done case-insensitively.
  /// </summary>
  [Route("/v1/why/does/this/work/point/{pointid}", "GET")]
  [DataContract]
  public class WhyDoesThisWorkPointGetDto : IReturn<PointDto>
  {
    [DataMember(Name = "pointid")]
    public int PointId { get; set; }
  }


  /// <summary>
  /// 
  /// Why does this not work?
  /// 
  /// I assume this does not work because the route's variable place-holder does not match the DTO property name.
  /// However this is desirable since we have standardized on a kebab-case naming convention that is supported
  /// by the DataMember attribute.  Not being able to use the kebab-case name in the route causes the non-standard
  /// name to show up in SwaggerUI and the OpenAPI output from which we generate user documentation even though
  /// the DataMember attribute is honored by SwaggerUI in its parameters list resulting in a name case mismatch 
  /// between the parameter and route shown in SwaggerUI and OpenAPI.
  /// </summary>
  [Route("/v1/why/does/this/not/work/point/{point-id}", "GET")]
  [DataContract]
  public class WhyDoesThisNotWorkPointGetDto : IReturn<PointDto>
  {
    [DataMember(Name = "point-id")]
    public int PointId { get; set; }
  }
}
