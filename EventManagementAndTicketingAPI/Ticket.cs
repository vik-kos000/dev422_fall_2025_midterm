namespace EventManagementAndTicketingAPI
{
    public class Ticket
    {
        public int EventID { get; set; }
        public int UserID { get; set; }
        public required string Status { get; set; }
    }
}
