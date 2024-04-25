using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace MiniFacebookProject1.Models
{
    public class User:IdentityUser
    {
        //public byte[]? Photo { get; set; }
        //public string? PhotoContentType { get; set; }

        public string ImageFileName { get; set; }
        [MaxLength(100)]

        public string? BIO { get; set; }
        [Required(ErrorMessage = "Please Enter a Your BirthDate")]
        public DateTime? BirthDate { get; set; }
        [Required(ErrorMessage = "Please Enter a Valid Number Phone")]
        [Phone]
        public string? Phone { get; set; }
        public string? Gender { get; set; }
        public virtual List<Post> Posts { get; set; } = new List<Post>();
    }
}
