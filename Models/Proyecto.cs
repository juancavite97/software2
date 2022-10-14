using System.ComponentModel.DataAnnotations;

namespace SoftwareII.Models
{
        public class Proyecto
        {
            public int Id { get; set; }
            [Required]
            public string Name { get; set; }
            [Required]
            public string Description { get; set; }
            [Required]
            public int AreaDesarollo { get; set; }
            [Required]
            public int Stakeholder { get; set; }
            [Required]
            public int AreaQA { get; set; }
            [Required]
            public string Code { get; set; }
            [Required]
            public int Status { get; set; }
            [Required]
            [DataType(DataType.Date)]
            public DateTime FechaInicio { get; set; }
            [Required]
            [DataType(DataType.Date)]
            public DateTime FechaFin { get; set; }
            [Required]
            public int Rol { get; set; }
            
        }
        

}


