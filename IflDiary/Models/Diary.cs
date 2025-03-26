namespace IflDiary.Models
{
    public class Diary
    {
        public int Id { get; set; }
        public string ActivityNumber { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime FeedbackOn { get; set; }
        public string Description { get; set; }
        public int DepartmentId { get; set; }
        public virtual Department Department { get; set; } 
    }
}
