namespace E_Commerce_Movie_Tickets.Models
{
    public class Actor_Movie
    {
        public int MovieId { get; set; }
        public Movie Movie { get; set; }    
        public int ActorId { get; set; }
        public Actor Actor { get; set; }
    }
}
