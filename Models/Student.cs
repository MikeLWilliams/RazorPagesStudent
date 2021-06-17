using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RazorPagesStudent.Models
{
    public class Student
    {
        public int ID { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Display(Name = "Certified Date")]
        [DataType(DataType.Date)]
        public DateTime CertifiedDate { get; set; }
        [Required]
        [StringLength (30)]
        public string Location { get; set; }
        [Range(1, 100)]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        [Display(Name = "Tuition & Fees Total")]
        public decimal TandF { get; set; }
        [StringLength (5)]
        [Required]
        public string Program { get; set; }
    }
}
