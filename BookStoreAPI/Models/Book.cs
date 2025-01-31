namespace BookStoreAPI.Models
{
    using System.ComponentModel.DataAnnotations;
    public class Book
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="The Title field is required.")]
        public string Title { get; set; }

        [Required(ErrorMessage ="The Author field is required.")]
        public string Author { get; set; }

        [Range(0.01, 10000.00, ErrorMessage ="The price must be between 0.01 to 10000.00.")]
        public decimal Price { get; set; }

        [DataType(DataType.Date)]
        public DateTime PublishDate { get; set; }

    }
}
