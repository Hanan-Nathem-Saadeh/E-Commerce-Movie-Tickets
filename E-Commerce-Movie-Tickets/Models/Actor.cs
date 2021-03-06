using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace E_Commerce_Movie_Tickets.Models
{
    public class Actor
    {
        [Key]
        public int Id { get; set; }
        public string profilePictureURL { get; set; }
        public string FullName { get; set; }
        public string Bio { get; set; }
        // Relationships
        public List<Actor_Movie> Actors_Movies { get; set; }
    }
}
