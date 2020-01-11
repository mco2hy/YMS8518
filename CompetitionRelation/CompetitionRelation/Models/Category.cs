using System.ComponentModel.DataAnnotations;

namespace CompetitionRelation.Models
{
    public class Category
    {
        public int Id { get; set; }
        [Required,MaxLength(15)]
        public string CategoryName { get; set; }
        public string Decription { get; set; }
        public byte[] Picture { get; set; }

        
    }
}
