using System.ComponentModel.DataAnnotations;

namespace BOOK_STORE_PORTAL_Project_.Dto
{
    public class ResponseRoyschedDto
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Title ID must be a positive number.")]
        public int TitleId { get; set; }

        [Required]
        [Range(0, int.MaxValue, ErrorMessage = "Low range must be a non-negative number.")]
        public int LowRange { get; set; }

        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "High range must be greater than zero.")]
        public int HighRange { get; set; }

        [Required(ErrorMessage = "Royalty percentage is required.")]
        [Range(0.01, 100.00, ErrorMessage = "Royalty must be between 0.01 and 100.")]
        public decimal Royalty { get; set; }
    }
}

