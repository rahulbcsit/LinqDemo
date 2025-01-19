using ExtensionLibrary.Utilties;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        //Demo of groupby
        var movies = MovieDataProvider.GetMovies(); 
        MovieLinqUtilities.DisplayGroup(movies, m => m.Rating, MovieLinqUtilities.ConvertGroupedDataToDictionary, "ToDicitonary"); 
        MovieLinqUtilities.DisplayGroup(movies, m => m.Year, MovieLinqUtilities.ConvertGRoupData, "ToDicitonary");

        MovieLinqUtilities.ConvertToAnother(movies.GroupBy(x => x.Rating).ToArray());

    }
}