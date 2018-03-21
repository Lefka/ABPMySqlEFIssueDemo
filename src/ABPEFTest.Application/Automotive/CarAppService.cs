using Abp.Domain.Repositories;
using ABPEFTest.Automotive.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace ABPEFTest.Automotive
{
    public class CarAppService : ABPEFTestAppServiceBase, ICarAppService
    {
        private IRepository<Car> _carRepository;

        public CarAppService(IRepository<Car> carRepository)
        {
            _carRepository = carRepository;
        }

        public ICollection<Car> GetCars(string searchString)
        {
            var query = _carRepository
                .GetAll()
                .Where( c =>
                    c.Name == searchString ||
                    c.Model.Name == searchString ||
                    c.Model.Make.Name == searchString
                );

            return query.ToList();
        }
    }
}
