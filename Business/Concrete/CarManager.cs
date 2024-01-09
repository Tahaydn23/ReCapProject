using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
       private readonly  ICarDal _carDal;
        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public IResult Add(Car car)
        {
            if (car.CarName.Length < 2)
            {
                return new ErrorResult(Messages.CarNameInvalid);
            }
            _carDal.Add(car);

            return new Result(true,Messages.CarAdded);
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAllCars();
        }

        public Car GetById(int carId)
        {
            return _carDal.Get(p=>p.carId == carId);
        }

        public List<CarDetailDto> GetProductDetails()
        {
            throw new NotImplementedException();
        }
    }
}
