using Abp.Application.Services;
using System.Collections.Generic;

namespace ABPEFTest.Automotive.Interfaces
{
    public interface ICarAppService : IApplicationService
    {
        ICollection<Car> GetCars(string searchString);
    }
}
