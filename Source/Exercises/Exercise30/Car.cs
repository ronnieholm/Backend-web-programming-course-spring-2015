using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Exercise30
{
    class Car
    {
        private string _licensePlate;
        private string _brand;
        private string _model;

        public Car(string plate, string brand, string model)
        {
            _licensePlate = plate;
            _brand = brand;
            _model = model;
        }

        public string GetLicensePlate()
        {
            return _licensePlate;
        }

        public string GetBrand()
        {
            return _brand;
        }

        public string GetModel()
        {
            return _model;
        }
    }
}
