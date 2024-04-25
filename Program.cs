Banda queen = new Banda("Queen");
Album albumDoQueen = new Album("A night at the opera");
Music music1 = new Music(queen, "Love of my life", 213);
Music music2 = new Music(queen, "Bohemian Rhapsody", 354);

albumDoQueen.AdicionarMusica(music1);
albumDoQueen.AdicionarMusica(music2);
queen.AdicionarAlbum(albumDoQueen);

music1.ShowTechDetail();
music2.ShowTechDetail();
albumDoQueen.ShowAlbumMusic();
queen.ExibirDiscografia();