using System.ComponentModel.DataAnnotations;

namespace $safeprojectname$.Models
{
    public class Book
    {
        public int BookId { get; set; }

        [Required()]
        public string Title { get; set; }

        [Required()]
        public string Description { get; set; }

        [Required()]
        public Author Author { get; set; }
        public int AuthorId { get; set; }
       
        [Required()]
        public string Image { get; set; }

        [Required()]
        public string File { get; set; }

        public Genre Genre { get; set; }
        [Required()]
        public int GenreId { get; set; }
        
    }
}
