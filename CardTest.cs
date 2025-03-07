/* 
    Mouad Oulouali | HW2-A         
*/

using System;


string input;
// storing the input in a list
List<string> allInput = new List<string>();

// taking input until empty space is entered
Console.WriteLine("Enter empty space to start game:");
while ((input = Console.ReadLine()!) != "")
{
    // adding each input to the list.
    allInput.Add(input);
}

// checking the input
// foreach (string item in allInput)
// {
//     Console.WriteLine(item);
// }
Console.WriteLine("Game Card Tests:");
// declare a deck variables and create a deck object
// DON'T SHUFFLE THE DECK
Deck deck = new Deck();
Console.WriteLine($"New deck created with {deck.Cards.Count} cards");

// creating lists for each of the players to store cards
List<Card> player1 = new List<Card>();
List<Card> player2 = new List<Card>();
List<Card> player3 = new List<Card>();
List<Card> player4 = new List<Card>();

// deal 2 cards each to 4 players (deal properly, dealing
// the first card to each player before dealing the
// second card to each player)

// dealing first card to each of the players in order of player 1 to 4
player1.Add(deck.TakeTopCard());
player2.Add(deck.TakeTopCard());
player3.Add(deck.TakeTopCard());
player4.Add(deck.TakeTopCard());

// dealing second ccard
player1.Add(deck.TakeTopCard());
player2.Add(deck.TakeTopCard());
player3.Add(deck.TakeTopCard());
player4.Add(deck.TakeTopCard());

// deal 1 more card to players 2 and 3
player2.Add(deck.TakeTopCard());
player3.Add(deck.TakeTopCard());

// flip all the cards over
foreach (Card card in player1)
{
    card.FlipOver();
}
foreach (Card card in player2)
{
    card.FlipOver();
}
foreach (Card card in player3)
{
    card.FlipOver();
}
foreach (Card card in player4)
{
    card.FlipOver();
}
// print the cards for player 1
Console.WriteLine("Player 1's cards: ");
foreach (Card card in player1)
{
    Console.WriteLine($"{card.Rank} of {card.Suit}");
}

// print the cards for player 2
Console.WriteLine("Player 2's cards: ");
foreach (Card card in player2)
{
    Console.WriteLine($"{card.Rank} of {card.Suit}");
}

// print the cards for player 3
Console.WriteLine("Player 3's cards: ");
foreach (Card card in player3)
{
    Console.WriteLine($"{card.Rank} of {card.Suit}");
}

// print the cards for player 4
Console.WriteLine("Player 4's cards: ");
foreach (Card card in player4)
{
    Console.WriteLine($"{card.Rank} of {card.Suit}");
}
