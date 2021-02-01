using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        private object car;

        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car {BrandId=1, CarId=1, ColorId=3, DailyPrice=1000, ModelYear=2015, Description="Economic class"},
                new Car {BrandId=2, CarId=1, ColorId=4, DailyPrice=1500, ModelYear=2019, Description="Premium class"},
                new Car {BrandId=3, CarId=1, ColorId=4, DailyPrice=1100, ModelYear=2015, Description="Comfort class"},
                new Car {BrandId=4, CarId=2, ColorId=3, DailyPrice=1200, ModelYear=2016, Description="Comfort class"},
                new Car {BrandId=5, CarId=2, ColorId=3, DailyPrice=1300, ModelYear=2017, Description="Economic class"}

            };
        }

        public int CarId { get; private set; }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int CarqId)
        {
            return _cars.Where(c => c.CarId == CarId).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate=_cars.SingleOrDefault(c => c.CarId == car.CarId);
            carToUpdate.CarId = car.CarId;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.Description = car.Description;

        }
    }
}
