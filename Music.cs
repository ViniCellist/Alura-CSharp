Album albumDoQueen = new Album();
albumDoQueen.Name = "A night at the opera";

Music music1 = new Music();
music1.Name = "Love of my life";
music1.TotalTime = 213;

Music music2 = new Music();
music2.Name = "Bohemian Rhapsody";
music2.TotalTime = 354;

albumDoQueen.AdicionarMusica(music1);
albumDoQueen.AdicionarMusica(music2);

albumDoQueen.ShowAlbumMusic();