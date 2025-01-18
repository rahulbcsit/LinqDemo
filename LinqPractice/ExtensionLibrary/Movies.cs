internal class Movie
{
    public Movie(string name, int year, float rating)
    {
        Name = name;
        Year = year;
        Rating = rating;
    }
    public string Name { get; set; }

    public int Year {get; set;}

    public float Rating {get; set;}
}