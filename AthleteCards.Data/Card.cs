public class Card
{
    //2. Create Constructors -> Create versions of cards on the fly.
    public Card()
    {
    }

    //Full Constructor
    public Card(
        string picture,
        string player_FirstName,
        string player_LastName,
        CardType cardType,
        int year,
        double runs,
        int hits)
    {
        Picture = picture;
        Player_FirstName = player_FirstName;
        Player_LastName = player_LastName;
        CardType = cardType;
        Year = year;
        Runs = runs;
        Hits = hits;
    }

    public Card(string player_FirstName, string player_LastName)
    {
        Player_FirstName = player_FirstName;
        Player_LastName = player_LastName;
    }

    //1. attributes -> Properties
    public int Id { get; set; }
    public string Picture { get; set; }
    public string Player_FirstName { get; set; }
    public string Player_LastName { get; set; }
    public string PlayerName
    {
        get
        {
            return $"{Player_FirstName} {Player_LastName}";
        }
    }
    public CardType CardType { get; set; }
    public int Year { get; set; }
    public double Runs { get; set; }
    public int Hits { get; set; }

    public override string ToString()
    {
        var str = $"Id: {Id}\nPicture: {Picture}\nPlayer Name: {PlayerName}\nCard Type: {CardType}\nYear: {Year}\nRuns: {Runs}\nHits: {Hits}\n";
        str += "----------------------------------------\n";

        return str;
    }
}
