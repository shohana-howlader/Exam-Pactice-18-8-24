namespace Exam_Pactice_18_8_24.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; } = null!;
        public bool IsActive { get; set; }
        public DateTime joinDate { get; set; }
        public string? ImageName { get; set; }
        public string? ImageUrl { get; set; }
        public int Salary {  get; set; }
        public virtual ICollection<Exprience> Expriences { get; set; } = new List<Exprience>();
    }
}
