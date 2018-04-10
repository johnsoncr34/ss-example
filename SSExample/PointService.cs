using System.Collections.Generic;
using System.Linq;
using ServiceStack;

namespace SSExample
{

  public class PointService : Service
  {
    private static readonly List<PointDto> _pointStorage = new List<PointDto>();
    private static int IdCounter;


    static PointService()
    {
      _pointStorage.AddRange(new[]
      {
        new PointDto {PointId = IdCounter++, Name = "Zero"},
        new PointDto {PointId = IdCounter++, Name = "One"},
        new PointDto {PointId = IdCounter++, Name = "Two"},
        new PointDto {PointId = IdCounter++, Name = "Three"},
        new PointDto {PointId = IdCounter++, Name = "Four"}
      });
    }


    public PointDto Get(WorksPointGetDto requestDto)
    {
      return _pointStorage.FirstOrDefault(p => p.PointId == requestDto.PointId);
    }


    public PointDto Get(WhyDoesThisWorkPointGetDto requestDto)
    {
      return _pointStorage.FirstOrDefault(p => p.PointId == requestDto.PointId);
    }


    public PointDto Get(WhyDoesThisNotWorkPointGetDto requestDto)
    {
      return _pointStorage.FirstOrDefault(p => p.PointId == requestDto.PointId);
    }
  }
}