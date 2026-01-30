using System.ComponentModel.DataAnnotations;

namespace BlazorWebApp.Models
{
    public class SampleData
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; } = string.Empty;

        [MaxLength(50)]
        public string Category { get; set; } = string.Empty;

        public DateTime Date { get; set; }

        [MaxLength(100)]
        public string Project { get; set; } = string.Empty;

        public int Year { get; set; }

        [MaxLength(100)]
        public string Branch { get; set; } = string.Empty;

        [MaxLength(50)]
        public string Region { get; set; } = "Marmara";

        [MaxLength(100)]
        public string Customer { get; set; } = string.Empty;

        [MaxLength(20)]
        public string Priority { get; set; } = "Medium";

        [MaxLength(100)]
        public string AssignedTo { get; set; } = string.Empty;

        [MaxLength(20)]
        public string PaymentStatus { get; set; } = "Paid";

        public decimal Value { get; set; }

        [MaxLength(20)]
        public string Status { get; set; } = "Active";

        [MaxLength(500)]
        public string Description { get; set; } = string.Empty;
    }
}
