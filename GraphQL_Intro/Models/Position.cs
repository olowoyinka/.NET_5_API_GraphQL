using System.ComponentModel.DataAnnotations;

namespace GraphQL_Intro.Models
{
    public class Position
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public int DisplayOrder { get; set; }
    }
}