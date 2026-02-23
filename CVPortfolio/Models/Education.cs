using System.ComponentModel.DataAnnotations;

namespace CVPortfolio.Models
{
    public class Education
    {
        public int Id { get; set; }

        [Required]
        [StringLength(200)]
        public string Degree { get; set; } = string.Empty;

        [Required]
        [StringLength(200)]
        public string Institution { get; set; } = string.Empty;

        [StringLength(100)]
        public string? Location { get; set; }

        public int StartYear { get; set; }

        public int? EndYear { get; set; }

        [StringLength(1000)]
        public string? Description { get; set; }

        public int DisplayOrder { get; set; }
    }
}
