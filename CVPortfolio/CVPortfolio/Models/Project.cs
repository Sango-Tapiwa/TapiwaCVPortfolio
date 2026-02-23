using System.ComponentModel.DataAnnotations;

namespace CVPortfolio.Models
{
    public class Project
    {
        public int Id { get; set; }

        [Required]
        [StringLength(200)]
        public string Name { get; set; } = string.Empty;

        [Required]
        [StringLength(1000)]
        public string Description { get; set; } = string.Empty;

        [Required]
        [StringLength(500)]
        public string TechStack { get; set; } = string.Empty;

        [StringLength(500)]
        public string? GitHubUrl { get; set; }

        [StringLength(500)]
        public string? LiveDemoUrl { get; set; }

        [StringLength(500)]
        public string? ImageUrl { get; set; }

        public DateTime CreatedDate { get; set; }

        public int DisplayOrder { get; set; }
    }
}
