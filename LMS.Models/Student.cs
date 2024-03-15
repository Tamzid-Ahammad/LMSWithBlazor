using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Models
{
    public class Student
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int StudentId { get; set; }
        [Required]
        [StringLength(50), MinLength(5)]
        public string StudentName { get; set; }
        public string? Address { get; set; }
        [EmailAddress]
        public string? Email { get; set; }
        [Phone]
        public string Phone { get; set; }
        public List<Book> Books { get; set; } = new List<Book>();
    }
}
