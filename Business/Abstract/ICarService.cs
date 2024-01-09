using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICarService
    {
        List<Car> GetAll();
        Car GetById(int carId);
        // List<Car> Insert();
        // List<Car> Update();
        // List<Car> Delete(); 
        List<CarDetailDto> GetProductDetails();
        IResult Add(Car car);
    }
}
