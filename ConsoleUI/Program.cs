// See https://aka.ms/new-console-template for more information

using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;

CarTest();

static void CarTest()
{
    CarManager carManager = new CarManager(new EfCarDal());
    foreach (var car in carManager.GetProductDetails())
    {
        Console.WriteLine(car.CarName + "/" + car.BrandName + "/" + car.ColorName);

    }
}

