﻿public class Movie
{
    public string Title { get; set; }
    public string Year { get; set; }
    public string imdbID { get; set; }
    public string Type { get; set; }
    public string Poster { get; set; }
}

public class MovieSearchResult
{
    public List<Movie> Search { get; set; }
    public string TotalResults { get; set; }
    public string Response { get; set; }
}
