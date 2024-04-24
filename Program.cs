class Music
{
    public string Name { get; set; }
    public string Artist { get; set; }
    public int Duration { get; set; }
    public bool Available { get; set; }

    public string Description =>
        $"A música { Name } percente à banda { Artist }"

    public void ShowTechDetail()
    {
        Console.WriteLine($"Nome: { Name }");
        Console.WriteLine($"Artista: { Artist }");
        Console.WriteLine($"Duration: { Duration }");
        if ( Available )
        {
            Console.WriteLine("Disponível no plano.");
        } else
        {
            Console.WriteLine("Adquira o plano Plus+");
        };
    };
    
};