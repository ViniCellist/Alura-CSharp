class Album
{

    public Album(string name)
    {
        Name = name;
    }
    private List<Music> musicas = new List<Music>();
    public string Name { get; }
    public int TotalTime => musicas.Sum(musics => musics.Duration);

    public void AdicionarMusica(Music musica)
    {
        musicas.Add(musica);
    }

    public void ShowAlbumMusic()
    {
        Console.WriteLine($"Lista de músicas do álbum {Name}: \n");
        foreach (var musica in musicas)
        {
            Console.WriteLine($"Musica: {musica.Name}");
        }
        Console.WriteLine($"\nPara ouvir este álbum inteiro você precisa de {TotalTime}");
    }
}