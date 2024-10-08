using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication3.Models
{
    public enum Gender
    {
        Male=1,
        Femail=2
    }
    [Table("Employee")]
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public Gender Gender_ { get; set; }
        public string Email { get; set; }
        public DateTime birthDate { get; set; }
        public decimal salary {  get; set; }
        [ForeignKey("department")]
        public int Dnum{get; set; }
        public Department department { get; set; }
    }
}
