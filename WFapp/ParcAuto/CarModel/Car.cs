using System;
using System.Collections.Generic;
using System.Text;

namespace CarModel
{
    public class Car
    {
        public int Id { get; set; }
        public string Model { get; set; }
        public string Manufacturer { get; set; }
        public int Year { get; set; }
        public string Combustibil { get; set; }
        public double Km { get; set; }
        public bool Status { get; set; }
        public List<Picture> Pictures { get; set; }

        public decimal Price { get; set; }

        public bool Sold { get; set; }

        public Vendor Owner { get; set; }

        public Car()
        {
            Pictures = new List<Picture>();
        }

        public void AddPicture(Picture newPicture)
        {
            Pictures.Add(newPicture);
        }

        public string Display  //metoda display pentru iteme
        {
            get
            {
                return string.Format("{0}. {1} - {2} : ${3}", Id, Model, Manufacturer, Price);
            }
        }
    }
}
