using System;

namespace CleanArchitectureSample1.UseCases
{
    public interface IClock
    {
        DateTimeOffset OffsetNow { get; set; }
    }
}