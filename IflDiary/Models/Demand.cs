namespace IflDiary.Models
{
    public class Demand
    {
        public int Id { get; set; }
        public int DemandNumber { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime ReceivedOn { get; set; }
        public string CreateBy {  get; set; }
        public string PurchaseBy { get; set; }
        public string RequiredFor { get; set; }
        public string Category { get; set; }

    }
}
