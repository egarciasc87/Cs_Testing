using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightBooking.Domain
{
    public class Airline
    {
        public static int Counter = 0;
        internal int NumberPlanes { get; set; }
        public int Id { get; }
        public string Name { get; set; }

        public Airline(string name)
        {
            Counter++;
            this.Name = name;
            this.Id = Counter;
            this.NumberPlanes = 0;
        }

        public void AddPlanes(int numberPlanes)
        {
            this.NumberPlanes += numberPlanes;
        }

        public int GetNumberPlanes()
        {
            return this.NumberPlanes;
        }
    }
}
