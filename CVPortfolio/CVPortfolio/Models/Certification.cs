using System.ComponentModel.DataAnnotations;

namespace CVPortfolio.Models
{
    public class Certification
    {
        public int Id { get; set; }

        [Required]
        [StringLength(200)]
        public string Name { get; set; } = string.Empty;

        [Required]
        [StringLength(200)]
        public string Issuer { get; set; } = string.Empty;

        public DateTime IssueDate { get; set; }

        public DateTime? ExpiryDate { get; set; }

        [StringLength(500)]
        public string? CredentialUrl { get; set; }

        public int DisplayOrder { get; set; }
    }
}
