namespace EventManagementAndTicketingAPI
{
    public class Event
    {
        public required string Name { get; set; }
        public DateTime Date { get; set; }
        public required string Venue { get; set; }
        public required string Genre { get; set; }
        public int AvailableTickets { get; set; }
        public int id { get; set; }
    }
}
