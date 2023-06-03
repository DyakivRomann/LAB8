using System;


using System;
using System.Collections.Generic;

class MusicComposition
{
    public string Title { get; set; }
    public string Artist { get; set; }
    public string Album { get; set; }
    public string Genre { get; set; }
    public TimeSpan Duration { get; set; }

    public MusicComposition(string title, string artist, string album, string genge, TimeSpan duration)
    {
        Title = title;
        Artist = artist;
        Album = album;
        Genre = genge;
        Duration = duration;
    }
}
class Program
{
    static void Main(string[] args)
    {
        List<MusicComposition> tracks = new List<MusicComposition>()
        {
            new MusicComposition("Bohemian Rhapsody", "Queen", "A Night at the Opera", "Rock", new TimeSpan(0, 5, 55)),
            new MusicComposition("This dream", "Stepan Giga", "Without album", "Ballade", new TimeSpan(0, 8, 2)),
            new MusicComposition("Thriller", "Michael Jackson", "Thriller", "Pop", new TimeSpan(0, 5, 57)),
            new MusicComposition("Carpathian gold", "Stepan Giga", "The road to the temple", "Civic lyrics", new TimeSpan(0, 4, 53)),
            new MusicComposition("In heaven", "Sviatoslav Vakarchuk", "Earth", "Rock", new TimeSpan(0, 5, 32))
        };
        List<MusicComposition> sortedTracks = tracks
            .OrderBy(t => t.Genre)
            .ThenBy(t => t.Duration)
            .ToList();

        Console.WriteLine("Sorted Tracks:");
        foreach (MusicComposition track in sortedTracks)
        {
            Console.WriteLine($"{track.Title} by {track.Artist} ({track.Genre}, {track.Duration})");
        }


        string artistName = "Michael Jackson";
        List<MusicComposition> tracksByArtist = tracks
            .Where(t => t.Artist == artistName)
            .ToList();

        Console.WriteLine($"\nTracks by {artistName}:");
        foreach (MusicComposition track in tracksByArtist)
        {
            Console.WriteLine($"{track.Title} ({track.Album}, {track.Genre}, {track.Duration})");
        }



        Console.ReadKey();


    }
}