using System.ComponentModel.DataAnnotations;

namespace SoftwareII.Models
{
    public class Empleado
    {
            public int Id { get; set; }
            [Required]
            public string Name { get; set; }
            [Required]
            public string LastName { get; set; }
            [Required]
            [EmailAddress]
            public string Email { get; set; }
            [Required]
            public string Area { get; set; }
            [RegularExpression(@"^\d{9}$", ErrorMessage ="Only numbers accepted")]
            [Required]
            [StringLength(9)]
            public string Code { get; set; }
            [RegularExpression(@"^\d{9}$", ErrorMessage ="Only numbers accepted")]
            [Required]
            [StringLength(9)]
            [Phone]
            public string Phone { get; set; }
            [Required]
            public string Rol { get; set; }
    }
}



