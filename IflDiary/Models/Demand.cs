namespace IflDiary.Models
{
    public class Demand
    {
        public int DemandId { get; set; }
        public int DemandNumber { get; set; }
        public DateTime DemandCreatedOn { get; set; }
        public DateTime DemandReceivedOn { get; set; }
        public string DemandCreateBy {  get; set; }
        public string DemandPurchaseBy { get; set; }
        public string DemandRequiredFor { get; set; }
        public string DemandCategory { get; set; }

    }
}
