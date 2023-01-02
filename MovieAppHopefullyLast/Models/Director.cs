using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MovieAppHopefullyLast.Models
{
    public class Director
    {
        [Key]
        public int DirectorId { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string DirectorName { get; set; }
        [Column(TypeName = "nvarchar(500)")]
        public string DirectorDescription { get; set; }
    }
}
