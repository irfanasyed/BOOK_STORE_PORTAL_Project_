using System.ComponentModel.DataAnnotations;

namespace BOOK_STORE_PORTAL_Project_.Dto
{
    public class UpdateTitleDto
    {
        [StringLength(200, ErrorMessage = "Title name cannot exceed 200 characters.")]
        public string Name { get; set; } 

        [StringLength(100, ErrorMessage = "Type cannot exceed 100 characters.")]
        public string Type { get; set; } 

        [Range(1, int.MaxValue, ErrorMessage = "Publisher ID must be a positive number.")]
        public int? PublisherId { get; set; } 

        [DataType(DataType.Date, ErrorMessage = "Publish date must be a valid date.")]
        public DateTime? PublishDate { get; set; } 

        [Range(0.01, double.MaxValue, ErrorMessage = "Price must be greater than 0.")]
        public decimal? Price { get; set; } 
    }
}
