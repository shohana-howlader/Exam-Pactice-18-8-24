namespace Exam_Pactice_18_8_24.Models
{
    public class Exprience
    {
        public int ExprienceId { get; set; }
        public string EmployeeId { get; set; }
        public string Title { get; set; } = null!;
        public int Duration { get; set; }
        public virtual Employee Employee { get; set; }=null!;
    }
}