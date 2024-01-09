using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, Rent_Car_DatabaseContext>, ICarDal
    {
        public List<CarDetailDto> GetProductDetails()
        {
            using (Rent_Car_DatabaseContext contex = new Rent_Car_DatabaseContext())
            {
                var result = from p in contex.Cars
                             join b in contex.Brands
                             on p.BrandId equals b.BrandId
                             join c in contex.Colors
                             on b.ColorId equals c.ColorId
                             select new CarDetailDto
                             {
                                 CarName = p.CarName,
                                 BrandName = b.BrandName,
                                 ColorName = c.ColorName,
                                 DailyPrice = p.DailyPrice
                             };
                return result.ToList();
            }
        }
    }
}
