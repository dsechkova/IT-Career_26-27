using System;
using System.Collections.Generic;
using System.Text;

namespace P01___Box
{
    public class ListOfCars : Box<Car>
    {
       private List<Car> cars;

        public ListOfCars()
        {
            cars = new List<Car>();
        }

        public void Add(Car car)
        {
            cars.Add(car);
           
        }
    }
}
