Podcast podpah = new Podcast("Igão", "PodPah");
Podcast floflobiuta = new Podcast("Virginia", "FloFloBiuta");

Episode eppdpah1 = new(podpah, 1, "Bate Bola com Brino", 45);

Episode eppodpah2 = new Episode(podpah, 2, "A Terra é Plana?", 80);

Episode epfloflo1 = new Episode(floflobiuta, 1, "Vini Jr. Traiu?", 95);

Guest brino = new Guest("Brino", 28);
Guest jao = new Guest("Jão", 32);
Guest skylab = new Guest("Skylab", 62);
Guest camila = new Guest("Camila Loures", 30);

eppdpah1.AddGuest(brino);
eppdpah1.AddGuest(jao);
podpah.AddEpisode(eppdpah1);

eppodpah2.AddGuest(skylab);
podpah.AddEpisode(eppodpah2);

epfloflo1.AddGuest(camila);
floflobiuta.AddEpisode(epfloflo1);

podpah.DisplayDetails();
floflobiuta.DisplayDetails();





//Band queen = new Band("Queen");

//Album queenAlbum = new Album("A Night At the Opera");

//Music music1 = new Music(queen, "Love of my Life")
//{
    //Duration = 213,
    //Available = true,
//};

//music1.Duration = 213;
//music1.Available = true;

//Music music2 = new Music(queen, "Bohemian Rhapsody")
//{
    //Duration = 354,
    //Available = false,
//};

//music2.Duration = 354;

//queenAlbum.AddMusic(music1);
//queenAlbum.AddMusic(music2);
//queen.AddAlbum(queenAlbum);

//music1.DisplayDatasheet();
//music2.DisplayDatasheet();
//queenAlbum.DisplayMusicsAlbum();
//queen.DisplayDiscography();