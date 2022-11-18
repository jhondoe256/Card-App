Card card = new Card();
card.CardType = CardType.Topps;
card.Picture = "https://Pic 1";
card.Hits = 200;
card.Runs = 22.58;
card.Player_FirstName = "Ken";
card.Player_LastName = "Griffey";


System.Console.WriteLine(card);
System.Console.WriteLine("-----------------------------------------------");

Card card2 = new Card("https://pic/01", "Dieon", "Sanders", CardType.Don_Russ, 1995, 400, 385);
System.Console.WriteLine(card2);
Console.ReadKey();


