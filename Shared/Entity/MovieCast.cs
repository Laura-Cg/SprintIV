namespace ProySprintIII.Shared.Entity
{
    public class MovieCast
    {
        public int CastId {get;set;}
        public int MovieId {get;set;}
        public Cast Cast {get;set;}
        public Movie Movie {get;set;}

        public int OrderCredits {get;set;}
        public int Character {get;set;}
    }
}