namespace Entity
{
    public class Booking
    {
        public Booking(int id, string departureStation, string arrivalStation, 
            string name, string surname)
        {
            Id = id;
            DepartureStation = departureStation;
            ArrivalStation = arrivalStation;
            Name = name;
            Surname = surname;
        }

        public int Id { get; set; }
        public string DepartureStation { get; private set; }
        public string ArrivalStation { get; private set; }
        public string Name { get; private set; }
        public string Surname { get; private set; }
    }
}
