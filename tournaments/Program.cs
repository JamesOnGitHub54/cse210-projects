// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Team firebirds = new Team("Firebirds");
Team coyotes = new Team("Coyotes");

Player john = new Player("John Henderson", 12);

//john.Display();

Player tim = new Player("Tim Nunn", 13);

Player keller = new Player("Clayton Keller", 9);

firebirds.AddPlayer(john);
firebirds.AddPlayer(tim);


firebirds.DisplayRoster();

coyotes.AddPlayer(keller);
coyotes.DisplayRoster();