
public class Card_Repository
{
    private readonly List<Card> _cardDb = new List<Card>();
    private int _count;

    //Create -> AddCard to database
    public bool AddCard(Card card)
    {
        if (card == null)
        {
            return false;
        }
        else
        {
            _count++;
            card.Id = _count;
            _cardDb.Add(card);
            return true;
        }
    }
    //Read -> Read a card from the database
    public Card GetCard(int id)
    {
        foreach (var card in _cardDb)
        {
            if (card.Id == id)
            {
                return card;
            }
        }
        return null;
    }
    //Read -> Read all the cards in database
    public List<Card> GetCards()
    {
        return _cardDb;
    }
    //Update -> Update a card
    public bool UpdateCard(int id, Card updatedCardInfo)
    {
        Card cardInDb = GetCard(id);
        if (cardInDb != null)
        {
            cardInDb.Player_FirstName = updatedCardInfo.Player_FirstName;
            cardInDb.Player_LastName = updatedCardInfo.Player_LastName;
            cardInDb.Hits = updatedCardInfo.Hits;
            cardInDb.Runs = updatedCardInfo.Runs;
            cardInDb.Year = updatedCardInfo.Year;
            cardInDb.Picture = updatedCardInfo.Picture;
            cardInDb.CardType = updatedCardInfo.CardType;

            return true;
        }
        return false;
    }
    //Delete a card
    public bool DeleteCard(int id)
    {
        Card cardInDb = GetCard(id);
        return _cardDb.Remove(cardInDb);
    }
    //Read -> get all Ken Griffey Cards
    public List<Card> GetAll(string playerName)
    {
        List<Card> populatedCards = new List<Card>();

        foreach (Card card in _cardDb)
        {
            if (card.PlayerName == playerName)
            {
                populatedCards.Add(card);
            }
        }
        return populatedCards;
    }
}
