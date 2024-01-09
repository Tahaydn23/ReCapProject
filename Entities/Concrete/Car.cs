using Core.Entities; 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Car:IEntity
    {
        public int carId { get; set; }
        public  int CarId { get; set; }
        public string CarName { get; set; }
        public int ColorId { get; set; }
        public int BrandId { get; set; }
        public int DailyPrice { get; set; }
        public int year { get; set; }

    }
}
