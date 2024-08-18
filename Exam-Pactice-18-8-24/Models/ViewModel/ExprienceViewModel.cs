using System.ComponentModel.DataAnnotations;

namespace Exam_Pactice_18_8_24.Models.ViewModel
{
    public class ExprienceViewModel
    {
        [Required]
        public int Title { get; set; }
        [Required]
        public int Duration {  get; set; }
    }
}