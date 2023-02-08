using System.ComponentModel.DataAnnotations;

namespace Fantasy_Baseball_Game.Models
{
    public class Player
    {
        [Key]
        public int Id { get; set; }

        public string PlayerName { get; set; }

        public string Position { get; set; }

        public float Salary { get; set; }
    }
}
