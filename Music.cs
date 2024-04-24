Music music1 = new Music();
music1.Name = "Numb";
music1.Artist = "Linkin Park";
music1.Duration = 273;
music1.Available = true;

Music music2 = new Music();
music2.Name = "Before I forget";
music2.Artist = "Slipknot";
music2.Duration = 367;
music2.Available = false;

music1 music3 = new Music();
music3.Name = "Warriors";
music3.Artist = "Imagine Dragons";
music3.Duration = 350;
music3.Available = true;

music1.ShowTechDetail();
music2.ShowTechDetail();
music3.ShowTechDetail();
