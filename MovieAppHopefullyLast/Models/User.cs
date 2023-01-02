using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MovieAppHopefullyLast.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        [Column(TypeName ="nvarchar(50)")]
        public string UserName { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string UserEmail { get; set; }
        [Column(TypeName = "nvarchar(20)")]
        public string UserPassword { get; set; }
    }
}
