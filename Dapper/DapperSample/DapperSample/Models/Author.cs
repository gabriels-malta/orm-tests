using System.Collections.Generic;
using System.Linq;

namespace DapperSample.Models
{
    public class Author
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public IEnumerable<Book> Books { get; set; }

        public Author()
        {
            Books = Enumerable.Empty<Book>();
        }
    }
}
