using ABPEFTest.Automotive;
using ABPEFTest.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABPEFTest.Migrations.SeedData
{
    public class DefaultAutomotiveCreator
    {
        private readonly ABPEFTestDbContext _context;

        public DefaultAutomotiveCreator(ABPEFTestDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            CreateMakes();
            CreateModels();
            CreateCars();
        }

        private void CreateMakes()
        {
            var ford = _context.Makes.FirstOrDefault(m => m.Name == "Ford");
            if (ford == null)
            {
                ford = new Make { Name = "Ford" };
                _context.Makes.Add(ford);
                _context.SaveChanges();
            }

            var dodge = _context.Makes.FirstOrDefault(m => m.Name == "Dodge");
            if (dodge == null)
            {
                dodge = new Make { Name = "Dodge" };
                _context.Makes.Add(dodge);
                _context.SaveChanges();
            }
        }

        private void CreateModels()
        {
            var fordId = 0;
            var dodgeId = 0;

            var mustang = _context.Models.FirstOrDefault(m => m.Name == "Mustang");
            if (mustang == null)
            {
                if (fordId == 0)
                {
                    fordId = _context.Makes.FirstOrDefault(m => m.Name == "Ford").Id;
                }

                mustang = new Model { Name = "Mustang", MakeId = fordId };
                _context.Models.Add(mustang);
                _context.SaveChanges();
            }

            var f150 = _context.Models.FirstOrDefault(m => m.Name == "F-150");
            if (f150 == null)
            {
                if (fordId == 0)
                {
                    fordId = _context.Makes.FirstOrDefault(m => m.Name == "Ford").Id;
                }

                f150 = new Model { Name = "F-150", MakeId = fordId };
                _context.Models.Add(f150);
                _context.SaveChanges();
            }

            var charger = _context.Models.FirstOrDefault(m => m.Name == "Charger");
            if (charger == null)
            {
                if (dodgeId == 0)
                {
                    dodgeId = _context.Makes.FirstOrDefault(m => m.Name == "Dodge").Id;
                }

                charger = new Model { Name = "Charger", MakeId = dodgeId };
                _context.Models.Add(charger);
                _context.SaveChanges();
            }

            var ram = _context.Models.FirstOrDefault(m => m.Name == "Ram");
            if (ram == null)
            {
                if (dodgeId == 0)
                {
                    dodgeId = _context.Makes.FirstOrDefault(m => m.Name == "Dodge").Id;
                }

                ram = new Model { Name = "Ram", MakeId = dodgeId };
                _context.Models.Add(ram);
                _context.SaveChanges();
            }
        }

        private void CreateCars()
        {
            var mustangId = 0;
            var f150Id = 0;
            var ramId = 0;

            var joesCar = _context.Cars.FirstOrDefault(c => c.Name == "Joe's car");
            if (joesCar == null)
            {
                if (mustangId == 0)
                {
                    mustangId = _context.Models.FirstOrDefault(m => m.Name == "Mustang").Id;
                }

                joesCar = new Car { Name = "Joe's car", ModelId = mustangId };
                _context.Cars.Add(joesCar);
                _context.SaveChanges();
            }

            var samsCar = _context.Cars.FirstOrDefault(c => c.Name == "Sam's car");
            if (samsCar == null)
            {
                if (mustangId == 0)
                {
                    mustangId = _context.Models.FirstOrDefault(m => m.Name == "Mustang").Id;
                }

                samsCar = new Car { Name = "Sam's car", ModelId = mustangId };
                _context.Cars.Add(samsCar);
                _context.SaveChanges();
            }

            var fredsCar = _context.Cars.FirstOrDefault(c => c.Name == "Fred's car");
            if (fredsCar == null)
            {
                if (f150Id == 0)
                {
                    f150Id = _context.Models.FirstOrDefault(m => m.Name == "F-150").Id;
                }

                fredsCar = new Car { Name = "Fred's car", ModelId = f150Id };
                _context.Cars.Add(fredsCar);
                _context.SaveChanges();
            }

            var harrysCar = _context.Cars.FirstOrDefault(c => c.Name == "Harry's car");
            if (harrysCar == null)
            {
                if (ramId == 0)
                {
                    ramId = _context.Models.FirstOrDefault(m => m.Name == "Ram").Id;
                }

                harrysCar = new Car { Name = "Harry's car", ModelId = ramId };
                _context.Cars.Add(harrysCar);
                _context.SaveChanges();
            }

            var ronsCar = _context.Cars.FirstOrDefault(c => c.Name == "Ron's car");
            if (ronsCar == null)
            {
                if (ramId == 0)
                {
                    ramId = _context.Models.FirstOrDefault(m => m.Name == "Ram").Id;
                }

                ronsCar = new Car { Name = "Ron's car", ModelId = ramId };
                _context.Cars.Add(ronsCar);
                _context.SaveChanges();
            }

            var georgesCar = _context.Cars.FirstOrDefault(c => c.Name == "George's car");
            if (georgesCar == null)
            {
                if (ramId == 0)
                {
                    ramId = _context.Models.FirstOrDefault(m => m.Name == "Ram").Id;
                }

                georgesCar = new Car { Name = "George's car", ModelId = ramId };
                _context.Cars.Add(georgesCar);
                _context.SaveChanges();
            }
        }
    }
}
