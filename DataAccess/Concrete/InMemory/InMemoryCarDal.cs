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
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{BrandId=1,CarId=1,ColorId=1,DailyPrice=2000,Descpription="SUV",ModelYear=2015},
                new Car{BrandId=1,CarId=2,ColorId=1,DailyPrice=3000,Descpription="STAION",ModelYear=2015},
                new Car{BrandId=2,CarId=3,ColorId=2,DailyPrice=4000,Descpription="SEDAN",ModelYear=2015},
                new Car{BrandId=3,CarId=4,ColorId=3,DailyPrice=5000,Descpription="CROSSOVER",ModelYear=2015}
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c =>c.CarId==car.CarId);
            _cars.Remove(carToDelete);

        }

        public List<Car> GetAll()
        {
            return _cars;
        }

       

        public List<Car> GetById(int carId)
        {
            return _cars.Where(c => c.CarId == carId).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            carToUpdate.CarId = car.CarId;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Descpription = car.Descpription;
        }
    }
}
