using System;
using System.Collections.Generic;

namespace Deck_of_Cards
{
    public class Player {
        public string _name;

        List<Card> _hand;

        public Card DrawCard(){
            Card newCard = new Card();
            Deck newDeck = new Deck();
            if (newDeck.Cards.Count > 0)
            {
                newCard = newDeck.Deal();
                _hand.Add(newCard);
            }
            else{
                newDeck.New();
                newDeck.Randomize();
            }
            return newCard;
        }
        public Player() {

         }

         public Card DisCard(Card card){
            Card cartToDisCard = card;
            _hand.Remove(card);
            return cartToDisCard;
        }
    }      

    public class Card{
        public string stringVal;
        public string suit;
        public int cardVal;

        public Card(){}
    }

    public class Deck{
        public List<Card> Cards;
        public Deck(){}

        public Card Deal(){
            Card cardToDeal = Cards[1];

            if (Cards.Count > 0)
            {
                cardToDeal = Cards[1];
            }

            return cardToDeal;
        }

        public void Reset() {
            New();
        }

        public void Randomize(){
            Random rand = new Random();

            for (int i = 0; i < Cards.Count; i++)
            {
                int randIndex = rand.Next(Cards.Count);
                Card temp = Cards[i];
                Cards[i] = Cards[randIndex];
                Cards[randIndex] = temp;
            }
        }

        public void Shuffle() {
            Randomize();
        }
        public List<Card> New(){
            Cards = new List<Card>();
            Card newCard = new Card();
            string[] cardValue = new string[] { "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King"};
            string[] suit = new string[] { "Clubs", "Spades", "Hearts", "Diamonds" };
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < cardValue.Length; j++)
                {
                    newCard = new Card();
                    newCard.suit = suit[i];
                    newCard.stringVal = cardValue[j];
                    newCard.cardVal = j + 1;
                    Cards.Add(newCard);
                }
                //cls
                //Console.WriteLine(newCard.stringVal + " - " + newCard.suit + " - " + newCard.cardVal);
                
            }
            Console.WriteLine("----------------------------------------------");
            // foreach (var Card in Cards)
            // {
            //     Console.WriteLine(Card.stringVal + " - " + Card.suit + " - " + Card.cardVal);
            // }

            return Cards;
        }

        public void PrintDeck(){
            foreach (var Card in Cards)
            {
                Console.WriteLine(Card.stringVal + " - " + Card.suit + " - " + Card.cardVal);
            }
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Deck newDeck = new Deck();
            newDeck.New();
            newDeck.PrintDeck();
            newDeck.Randomize();
            newDeck.PrintDeck();
            newDeck.Shuffle();
            newDeck.PrintDeck();
            

        }
    }
}
