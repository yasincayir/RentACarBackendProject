using Business.Concrete.Managers;
using DataAccess.Concrete.EntityFramework;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {

            //CarManager carManager = new CarManager(new EfCarDal());
            //foreach (var item in carManager.GetAll().Data)
            //{
            //    Console.WriteLine(item.Description);
            //}
            //CarDetails();

        }

        //private static void CarDetails()
        //{
        //    CarManager carManager = new CarManager(new EfCarDal());
        //    foreach (var item in carManager.GetCarDetails().Data)
        //    {
        //        Console.WriteLine(item.CarName + " " + item.ColorName + " " + item.BrandName);
        //    }
        //}
    }
}
