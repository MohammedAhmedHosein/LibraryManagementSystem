using System.ComponentModel.DataAnnotations;

namespace LibraryManagementSystem.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }

        [Required]
        [StringLength(50)]
        public string Username { get; set; }

        [Required]
        [StringLength(256)]
        public string PasswordHash { get; set; } // Store hashed passwords

        [StringLength(100)]
        public string Email { get; set; }

        [Required]
        public string Role { get; set; } // Role (e.g., 'admin', 'librarian', 'member')

    }
}
