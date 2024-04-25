class Music
{

    public Music(Banda artista, string name, int duration)
    {
        Artist = artista;
        Name = name;
        Duration = duration;
    }

    public string Name { get; }
    public Banda Artist { get; }
    public int Duration { get; }
    public bool Available { get; set; }

    public string Description =>
        $"A música { Name } percente à banda { Artist }";

    public void ShowTechDetail()
    {
        Console.WriteLine($"Nome: { Name }");
        Console.WriteLine($"Artista: { Artist.Nome }");
        Console.WriteLine($"Duration: { Duration }");
        if ( Available )
        {
            Console.WriteLine("Disponível no plano.");
        } else
        {
            Console.WriteLine("Adquira o plano Plus+");
        }
    }
    
};