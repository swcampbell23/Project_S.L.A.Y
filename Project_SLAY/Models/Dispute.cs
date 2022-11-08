namespace Project_SLAY.Models
{
    public enum Status { Submitted, Accepted, Rejected, Adjusted}
    public class Dispute
    {
        public Int32 DisputeID { get; set; }
        public Decimal Amount { get; set; }
        public Status Status { get; set; }
        public String Comments { get; set; }
        public Transaction Transaction { get; set; }
    }
}
