class Band
{
    private List<Album> albums = new List<Album>();

    public Band(string name)
    {
        Name = name;
    }

    public string Name { get; }

    public void AddAlbum(Album album)
    {
        albums.Add(album);
    }

    public void DisplayDiscography()
    {
        Console.WriteLine($"Discografia da banda {Name}");

        foreach (Album album in albums)
        {
            Console.WriteLine($"Álbum: {album.Name} ({album.TotalDuration})");
        }
    }
}