namespace GcDealership.Models
{
    public class Vehicle
    {
        public int Id { get; set; }
        public string Make { get; set; } // e.g. Toyota
        public string Model { get; set; } // e.g. Camery
        public short Year { get; set; }
        public string Color { get; set; }
    }
}