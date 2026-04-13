using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace project_net.Model
{
    [Table("Person")]
    public class Person
    {
        [Key]
        [Column("Id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        
        public long Id { get; set; }

        [Required]
        [Column("first_name",TypeName ="Varchar(100)")]
        [MaxLength(100)]
        public string FirstName { get; set; } = null!;

        [Required]
        [Column("last_name", TypeName = "Varchar(100)")]
        [MaxLength(100)]
        public string LastName { get; set; } = null!;

        [Required]
        [Column("address", TypeName = "Varchar(100)")]
        [MaxLength(100)]
        public string Address { get; set; } = null!;

        [Required]
        [Column("gender", TypeName = "Varchar(6)")]
        [MaxLength(6)]
        public string Gender { get; set; } = null!;
    }
}
