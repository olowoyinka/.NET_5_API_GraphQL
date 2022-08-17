using System.ComponentModel.DataAnnotations;

namespace GraphQL_Intro.Models
{
    public class Player
    {
        [Key]
        public int Id { get; set; }

        public int? ShirtNo { get; set; }

        public string Name { get; set; }

        public int? Appearances { get; set; }

        public int? Goals { get; set; }

        public int? PositionId { get; set; }
        public Position Position { get; set; }
    }
}