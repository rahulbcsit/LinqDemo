using Microsoft.VisualBasic;

internal static class MovieDataProvider
{
    public static IEnumerable<Movie> GetMovies(string getType)
    {
        return  getType switch
        {
             "Classic" => new List<Movie>()
                {
                new Movie("The Godfather", 1972, 9.2f),
                new Movie("Casablanca", 1942, 8.5f),
                new Movie("Gone with the Wind", 1939, 8.1f),
                },
            //   "Modern" => new()   
            //   {
            //      new Movie("Inception", "2010", 8.8f),
            //     new Movie("Parasite", "2019", 8.6f),
            //     new Movie("The Dark Knight", "2008", 9.0f)
            //   } ,
               "Thriller" =>  new[]
              {
                new Movie("Inception", 2010, 8.8f),
                new Movie("Parasite", 2019, 8.6f),
                new Movie("The Dark Knight", 2008, 9.0f),
              } ,
 
              _ => [
                 new Movie("Titanic", 1998, 9f),
                 new Movie("The fifth Element", 1997, 9.5f),
                 new Movie("Terminator 2", 1991, 9.4f),
                 new Movie("Avatar ", 2009, 8.2f), 
                 new Movie("Platoon" , 1986, 8.1f), 
                 new Movie("My neigbor Totoro", 1988, 10),
                 new Movie("Some random movie", 1980,8  ) 
              ]

        };
    }
}