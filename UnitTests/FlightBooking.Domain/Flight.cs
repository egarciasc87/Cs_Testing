namespace FlightBooking.Domain
{
    public class Flight
    {
        public int SeatsRemaining { get; set; }
        public string passengerEmail { get; set; }
        public Plane Plane { get; set; }

        public Flight(int seatCapacity)
        {
            SeatsRemaining = seatCapacity;
        }

        public object? Book(string _passengerEmail, int _seatsBooked)
        {
            if (_seatsBooked > SeatsRemaining)
                return new OverBookingError();

            SeatsRemaining -= _seatsBooked;
            passengerEmail = _passengerEmail;
            
            return null;
        }

        public int GetSeatsRemaining()
        {
            return SeatsRemaining;
        }
    }

    public class OverBookingError
    {

    }
}