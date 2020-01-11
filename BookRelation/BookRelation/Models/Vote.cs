namespace BookRelation.Models
{
    public class Vote
    {
        public int Id { get; set; }
        public int Votes { get; set; }
        public int Count { get; set; }

        public Book Book { get; set; }
        public int BookId { get; set; }
    }
}
