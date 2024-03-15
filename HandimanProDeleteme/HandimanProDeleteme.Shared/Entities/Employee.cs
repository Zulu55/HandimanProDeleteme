using System.ComponentModel.DataAnnotations;

namespace HandimanProDeleteme.Shared.Entities
{
    public class Employee
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string FirstName { get; set; } = null!;

        [Required]
        [MaxLength(100)]
        public string LastName { get; set; } = null!;

        public decimal Salary { get; set; }
    }
}