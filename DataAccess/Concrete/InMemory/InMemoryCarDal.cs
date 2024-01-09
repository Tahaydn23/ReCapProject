using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    
    public class InMemoryCarDal : ICarDal
    {
        
        List<Car> _cars;
   
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car {CarId=1, BrandId = 1, CarName = "Audi",ColorId = 23, DailyPrice=3000},
                new Car {CarId=2, BrandId = 2, CarName = "Audi", ColorId = 23, DailyPrice = 3000},
                new Car {CarId=3, BrandId = 3, CarName = "BMW", ColorId = 4, DailyPrice = 2000},
                new Car {CarId=4, BrandId = 4, CarName = "TOGG", ColorId = 6, DailyPrice = 1000}
            };
                
        }

        public string ColorId { get; private set; }

        public void Add(Car car)
        {
            _cars.Add(car);
        }
       
        public void Delete(Car car)
        {

            if (car != null)
            {
                foreach (var p in _cars)
                {
                    if (car.CarId == p.CarId)
                    {
       
                        _cars.Remove(p);

                    }
                }
           

               
            }
  
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void GetAll(Car car)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAllCars()
        {
            return _cars;
        }

        public List<Car> GetAllCars(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public void GetByld(Car car)
        {
            throw new NotImplementedException();
        }

        public List<CarDetailDto> GetProductDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {

        }
    }
}
