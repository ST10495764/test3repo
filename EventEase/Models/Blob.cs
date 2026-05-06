using System.ComponentModel.DataAnnotations;

namespace EventEase.Models
{
    public class Blob
    {
        [Key]
        [Required]
        public required int Id {  get; set; }

        [Required]
        public required string BlobName {  get; set; }

        [Required]
        public required string BlobURI { get; set; }

    }
}
