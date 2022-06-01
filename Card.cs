using System;
namespace cardpicker_project
{
    public enum Suits {
		SPADES = 1, CLUBS = 2, DIAMONDS = 4, HEARTS = 8
	}
	public enum CardValue {
		ONE = 1, TWO = 2, THREE = 3, FOUR = 4, FIVE = 5,
		SIX = 6, SEVEN = 7, EIGHT = 8, NINE = 9,
		JACK = 11, QUEEN = 12, KING = 13, ACE = 14
	}
	static class Extensions
	{
		public static string ToFriendlyName(this Suits suits)
		{
			switch (suits){
				case Suits.CLUBS: return "Clubs";
				case Suits.DIAMONDS: return "Diamonds";
				case Suits.HEARTS: return "Hearts";
				case Suits.SPADES: return "Spades";
				default: return "";	
			}
		}

		public static string ToFriendlyName(this CardValue cardValue)
		{
			switch (cardValue)
			{
				case CardValue.ONE:  return "One";
				case CardValue.TWO: return "Two";
				case CardValue.THREE: return "Three";
				case CardValue.FOUR: return "Four";
				case CardValue.FIVE: return "Five";
				case CardValue.SIX: return "Six";
				case CardValue.SEVEN: return "Seven";
				case CardValue.EIGHT: return "Eight";
				case CardValue.NINE: return "Nine";
				case CardValue.JACK: return "Jack";
				case CardValue.QUEEN: return "Queen";
				case CardValue.KING: return "King";
				case CardValue.ACE: return "Ace";
				default: return "";
			}
		}
	}
	public class Card
	{
		private Suits suit;
		private CardValue cardValue;

		public Card(Suits suit, CardValue cardValue)
		{
			this.suit = suit;
			this.cardValue = cardValue;
		}


		override public String ToString() {
			return this.cardValue.ToFriendlyName() + " of " + this.suit.ToFriendlyName();		
		}
	}
}

