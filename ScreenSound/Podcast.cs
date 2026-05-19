class Podcast
{
    private List<Episode> episodes = new List<Episode>();
    public Podcast(string host, string name)
    {
        Title = name;
        Host = host;
    }

    public string Title { get; }
    public string Host { get; }
    public int TotalEpisodes => episodes.Count;

    public void AddEpisode(Episode episode)
    {
        episodes.Add(episode);
    }

    public void DisplayDetails()
    {
        Console.WriteLine("---------------------------------------------------------------");
        Console.WriteLine($"Podcast {Title}, apresentado por {Host}");
        foreach (var episode in episodes.OrderBy(e => e.Sequence)) 
        {
            Console.WriteLine($"> Episódio {episode.Sequence}: {episode.Title}");
            Console.WriteLine($"Resumo: {episode.Resume}");
            Console.WriteLine($"Duração do episódio: {episode.Duration}\n");
            Console.WriteLine("Convidados do episódio:");
            Console.WriteLine("***********************\n");
            episode.DisplayGuests();
        }
        Console.WriteLine($"\nTotal de episódios do Podcast: {TotalEpisodes}");
        Console.WriteLine("---------------------------------------------------------------\n");
    }
}