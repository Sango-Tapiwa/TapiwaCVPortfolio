using System.ComponentModel.DataAnnotations;

namespace CVPortfolio.Models
{
    public class Profile
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string FullName { get; set; } = string.Empty;

        [Required]
        [StringLength(200)]
        public string ProfessionalTitle { get; set; } = string.Empty;

        [StringLength(500)]
        public string? PhotoUrl { get; set; }

        [Required]
        [StringLength(1000)]
        public string AboutMe { get; set; } = string.Empty;

        [Required]
        [EmailAddress]
        [StringLength(100)]
        public string Email { get; set; } = string.Empty;

        [StringLength(200)]
        public string? LinkedInUrl { get; set; }

        [StringLength(200)]
        public string? GitHubUrl { get; set; }

        [StringLength(100)]
        public string? Location { get; set; }

        [StringLength(50)]
        public string? Phone { get; set; }
    }
}
