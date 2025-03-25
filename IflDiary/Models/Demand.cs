namespace IflDiary.Models
{
    public class Demand
    {
        public int Id { get; set; }
        public int DemandNumber { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime ReceivedOn { get; set; }
        public string Required { get; set; }
        public int PurchaserId { get; set; }
        public virtual Purchaser Purchaser { get; set; }
        public int DemandCategoryId { get; set; }
        public virtual DemandCategory DemandCategory { get; set; }
        public int ElectricalDepartmentId { get; set; }
        public virtual ElectricalDepartment ElectricalDepartment { get; set; }


    }
}
