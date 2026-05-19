class Episode
{
    private List<Guest> guests = new List<Guest>();
    public Episode(Podcast podcast, int sequence, string title, int duration)
    {
        Podcast = podcast;
        Sequence = sequence;
        Title = title;
        Duration = duration;
    }

    public Podcast Podcast { get; }
    public int Sequence { get; }
    public int Duration { get; }
    public string Title { get; }
    public string Resume => $"{Sequence}. {Title} ({Duration} min) - " +
        $"{string.Join(", ", guests.Select(g => g.Name))}";
    
    public void AddGuest(Guest guest) 
    {
        guests.Add(guest);
    }

    public void DisplayGuests()
    {
        foreach (Guest guest in guests)
        {
            Console.WriteLine($"Nome: {guest.Name}");
            Console.WriteLine($"Idade: {guest.Age}\n");
        }
        
    }

}