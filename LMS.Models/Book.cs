using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Models
{
    public class Book
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string BookTitle { get; set; }
        public string AuthorName { get; set; }
		public bool Available { get; set; }
		public decimal RentPrice { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime BookBorrowingDate { get; set; } = DateTime.Now;
        [Required]
        [DataType(DataType.Date)]
        public DateTime BookReturningDate { get; set; } = DateTime.Now.AddDays(7);
        public int BookReturningTimeInDays => (BookReturningDate - BookBorrowingDate).Days;
        public int? StudentId { get; set; }
        public Student? Student { get; set; }
    }
}
