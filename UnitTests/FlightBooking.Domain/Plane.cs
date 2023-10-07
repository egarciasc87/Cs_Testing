using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightBooking.Domain
{
    public class Plane
    {
        public static int Counter = 0;
        public int Id { get; }
        public string Plate { get; set; }
        public string Model { get; set; }
        public int FullCapacity { get; set; }
        public Airline Airline { get; set; }

        public Plane(string plate, 
            string model,
            int fullCapacity)
        {
            Counter++;
            this.Id = Counter;
            this.Plate = plate;
            this.Model = model;
            this.FullCapacity = fullCapacity;
        }
    }
}
