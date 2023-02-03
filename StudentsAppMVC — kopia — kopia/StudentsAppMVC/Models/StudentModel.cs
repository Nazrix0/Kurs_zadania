using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentsAppMVC.Models
{
    [Table("Students")]
    public class StudentModel
    {
        [Key]
        [DisplayName("Id")]
        public int StudentId { get; set; }
        [DisplayName("Imię")]
        [Required(ErrorMessage = "Pole imię jest obowiązkowe")]
        [StringLength(20, MinimumLength = 2, ErrorMessage = "Długość imienia musi byc w zakresie 2 - 20")]
        public string Name { get; set; }
        [DisplayName("Nazwisko")]
        public string LastName { get; set; }
        [EmailAddress(ErrorMessage = "Proszę podać poprawny adres email")]
        [Required(ErrorMessage = "Pole e-mail jest obowiązkowe")]
        [DisplayName("Email")]
        public string Email { get; set; }
        [Range(6, 100, ErrorMessage = "Proszę podać wiek w zakresie 6 - 100")]
        [Required(ErrorMessage = "Musisz podać wiek")]
        [DisplayName("Wiek")]
        public int Age { get; set; }
        [DisplayName("Aktywność")]
        public bool IsActive { get; set; }
    }
}
