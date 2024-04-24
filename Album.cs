class Album
{
    private List<Music> musicas = new List<Music>();
    public string Name { get; set; }
    public int TotalTime => musicas.Sum(musics => musics.Duration);

    public void AdicionarMusica(Music musica)
    {
        musics.Add(musica);
    }

    public void ShowAlbumMusic()
    {
        Console.WriteLine($"Lista d emúsicas do álbum {Name}: \n");
        foreach (var musica in musics)
        {
            Console.WriteLine($"Musica: {musica.Name}");
        }
        Console.WriteLine($"\nPara ouvir este álbum inteiro você precisa de {TotalTime}");
    }
}