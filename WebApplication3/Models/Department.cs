using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication3.Models
{
    [Table("Departmen")]
    public class Department
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]//generate number auto
        public int Dnum {  get; set; }
        public string Dname {  get; set; }
        public int Dcode {  get; set; }
        
        public List<Employee> Employees { get; set; }
    }
}
