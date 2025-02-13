using System;
using Cards2;

// loop while there's more input
string input = Console.ReadLine();

// Add your code between this comment
// and the comment below. You can of
// course add more space between the
// comments as needed

// declare a deck variable and create a deck object
// DON'T SHUFFLE THE DECK
Deck deck = new Deck();
Player[] players = new Player[4];

for (int i = 0; i < 4; i++)
    players[i] = new Player();

// deal 2 cards each to 4 players (deal properly, dealing
// the first card to each player before dealing the
// second card to each player)
for (int i = 0; i < 2; i++)
    for (int j = 0; j < 4; j++)
        players[j].AddCard(deck.Deal());

// deal 1 more card to players 2 and 3
players[1].AddCard(deck.Deal());
players[2].AddCard(deck.Deal());

// flip all the cards over
foreach (var player in players)
    foreach (var card in player.Cards)
        card.FlipOver();

// print the cards for player 1
Console.WriteLine("Player 1 cards:");
players[0].ShowCards();

// print the cards for player 2
Console.WriteLine("Player 2 cards:");
players[1].ShowCards();

// print the cards for player 3
Console.WriteLine("Player 3 cards:");
players[2].ShowCards();

// print the cards for player 4
Console.WriteLine("Player 4 cards:");
players[3].ShowCards();

