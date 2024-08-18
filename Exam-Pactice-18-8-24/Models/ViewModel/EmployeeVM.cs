using System.ComponentModel.DataAnnotations;

namespace Exam_Pactice_18_8_24.Models.ViewModel
{
    public class EmployeeVM
    {
        public EmployeeVM()
        {
        }

        public EmployeeVM(List<ExprienceViewModel> expriences)
        {
            Expriences = new List<ExprienceViewModel>();
          
        }

        public int? EmployeeId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public bool IsActive { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime joinDate { get; set; }
        [Display(Name="Upload Image")]
        public IFormFile IMageFile { get; set; }
        [Required]
        public string? ImageName { get; set; }
        [Required]
        public string? ImageUrl { get; set; }
        [Required]
        public int Salary { get; set; }

        public List<ExprienceViewModel> Expriences { get; set; }
    }
}
