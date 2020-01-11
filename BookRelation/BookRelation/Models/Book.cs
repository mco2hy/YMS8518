using System.Collections.Generic;

namespace BookRelation.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int AuthorId { get; set; }
        public Author Author { get; set; }

        public Vote Vote { get; set; }

        public List<Page> Pages { get; set; }
    }
}
