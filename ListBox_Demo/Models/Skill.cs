using System.ComponentModel.DataAnnotations;

namespace ListBox_Demo.Models
{
    public class Skill
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        [Display(Name = "Skills")]
        public string ProgrammingLanguage { get; set; }
    }
}
