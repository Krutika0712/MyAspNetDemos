using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NyDemo.Models
{
    [Table("Admins")]
    public class Admin
    {

        [Key]
        public int AdminId { get; set; }


        [Required, StringLength(100)]
        public string AdminName { get; set; }


        #region Navigation Properties to the Book Model


        [Required]
        public int BookId { get; set; }


        [ForeignKey(nameof(Admin.BookId))]
        public Book Book { get; set; }


        #endregion


    }
}
