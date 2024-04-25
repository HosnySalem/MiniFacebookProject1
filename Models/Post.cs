using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MiniFacebookProject1.Models
{
    public class Post
    {
        public int Id { get; set; }

        [ForeignKey("User")]
        public string UserId { get; set; }
        public DateTime DateOfCreation { get; set; }
        [Required]
        public string Content { get; set; }

        public virtual User User { get; set; }
    }
}
