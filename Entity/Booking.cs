namespace Entity
{
    public class Booking
    {
        public Booking(int id, string departureStation, string arrivalStation, 
            Passenger passenger)
        {
            Id = id;
            DepartureStation = departureStation;
            ArrivalStation = arrivalStation;
            Passenger = passenger;
        }

        public int Id { get; set; }
        public string DepartureStation { get; set; }
        public string ArrivalStation { get; set; }

        public Passenger Passenger { get; set; }
    }
}
