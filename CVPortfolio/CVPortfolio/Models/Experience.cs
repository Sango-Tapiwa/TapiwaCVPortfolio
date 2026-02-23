using System.ComponentModel.DataAnnotations;

namespace CVPortfolio.Models
{
    public class Experience
    {
        public int Id { get; set; }

        [Required]
        [StringLength(200)]
        public string JobTitle { get; set; } = string.Empty;

        [Required]
        [StringLength(200)]
        public string Company { get; set; } = string.Empty;

        [StringLength(100)]
        public string? Location { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        public bool IsCurrent { get; set; }

        [StringLength(2000)]
        public string? Description { get; set; }

        public int DisplayOrder { get; set; }
    }
}
