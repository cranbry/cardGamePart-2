using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Deck
{

    //Deck Constructor
    public Deck()
    {
        foreach (Suit suit in Enum.GetValues(typeof(Suit)))
        {
            foreach (Rank rank in Enum.GetValues(typeof(Rank)))
            {

            }
        }
    }

    //Implement a property to get Cards
    public List<Card> Cards
    {
        get
        {
            return cards;
        }
    }

    //Takes top card from deck (if deck is not empty, otherwise return null)
    public Card TakeTopCard()
    {

    }

    //Shuffle Method
    public void Shuffle()
    {
        
 
    }

    //Cut method
    public void Cut(int index)
    {
        //implementation
    }
}

