string[] data = GetDataFromFile();
List<Movie> list = new List<Movie>();

foreach (string line in data)
{
    string[] tempArray = line.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
    Movie newMovie = new Movie(tempArray[0], tempArray[1], tempArray[2]);

    list.Add(newMovie);
}

foreach (Movie movie in list)
{
    Console.WriteLine($"One of my favourite {movie.title} was released in {movie.year}.");

}

static string[] GetDataFromFile()
{
    string filePath = @"C:\data\movies.txt";
    return File.ReadAllLines(filePath);

}



class Movie
{
    public string title;
    public string rating;
    public string year;


    public Movie(string _title, string _rating, string _years)
    {
        title = _title;
        rating = _rating;
        year = _years;

    }

}