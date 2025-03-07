using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Card
{
    //Fields, example: Rank rank;
    private int Rank rank;
    private int Suit suit;
    private bool faceUp;
    //check the help documentation for the fields

    //Card Constructor
    public Card(Suit suit, Rank rank)
    {
        this.suit = suit;
        this.rank = rank;
        this.faceUp = false; // making cards start face down by default
    }

    //Define properties for all above fields
    //code example: public Suit Suit { get { return suit; } }
    public Suit Suit {
        get {
            return suit;
        }
    }
    public Rank Rank {
        get {
            return suit;
        }
    }
    public bool faceUp {
        get {
            return faceUp;
        }
    }

    public void FlipOver()
    {
        // if face down then face up
        if (faceUp == false)
        {
            faceUp = true;
        }
        // if face up then down
        else
        {
            faceUp = false;
        }
    }

}
