using System.ComponentModel.DataAnnotations;

namespace NguyenNgocManMan.Models {
    public class Comment {
        public int ID { get; set; }
        [Required]
        public string Author { get; set; }
        [Required]
        public string Content { get; set; }
        public DateTime CreateAt { get; set; }
    }
}