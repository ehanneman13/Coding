using System;
using System.Collections.Generic;
using Card;

namespace Deck
{
    class Deck
    {
        public List<Card> DeckOfCards = new List<Card>();//List for 52 Cards, currently empty
        
        public Deck() 
        {
            foreach (var suit in Enum.GetValues(typeof(Card.Suit)))
            {
                foreach (var faceValue in Enum.GetValues(typeof(Card.FaceValue)))
                {
                    deckOfCards.Add(new Card(suit, faceValue));
                }
            }
        }

        public Card draw()
        {
            //draw a Card, from Deck, remove it from Deck
            Card card = deckOfCards[0];
            deckOfCards.RemoveAt(0);
            return card;
        }
        
        public void shuffle()   //does this need a parameter?
        {
            //loop to shuffle
            var newDeck = new List<Card>();
            var random = new Random();
            
            while (deckOfCards.Count > 0)
            {
                int index = random.Next(deckOfCards.Count);
                var card = deckOfCards[index];
                deckOfCards.RemoveAt(index);
                newDeck.Add(card);
            }

            deckOfCards = newDeck;
        }
        public string ReturnMessage()
        {
            return "Deck has been shuffled";
        }
    }   
}
