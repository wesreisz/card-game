using System;
using System.Text;

namespace cardpicker_project
{
	public class Deck
	{
		private Card[] deck = new Card[52];
	
		public Deck()
		{
			deck[0] = new Card(Suits.SPADES, CardValue.ONE);
			deck[1] = new Card(Suits.SPADES, CardValue.TWO);
			deck[2] = new Card(Suits.SPADES, CardValue.THREE);
			deck[3] = new Card(Suits.SPADES, CardValue.FOUR);
			deck[4] = new Card(Suits.SPADES, CardValue.FIVE);
			deck[5] = new Card(Suits.SPADES, CardValue.SIX);
			deck[6] = new Card(Suits.SPADES, CardValue.SEVEN);
			deck[7] = new Card(Suits.SPADES, CardValue.EIGHT);
			deck[8] = new Card(Suits.SPADES, CardValue.NINE);
			deck[9] = new Card(Suits.SPADES, CardValue.JACK);
			deck[10] = new Card(Suits.SPADES, CardValue.QUEEN);
			deck[11] = new Card(Suits.SPADES, CardValue.KING);
			deck[12] = new Card(Suits.SPADES, CardValue.ACE);

			deck[13] = new Card(Suits.HEARTS, CardValue.ONE);
			deck[14] = new Card(Suits.HEARTS, CardValue.TWO);
			deck[15] = new Card(Suits.HEARTS, CardValue.THREE);
			deck[16] = new Card(Suits.HEARTS, CardValue.FOUR);
			deck[17] = new Card(Suits.HEARTS, CardValue.FIVE);
			deck[18] = new Card(Suits.HEARTS, CardValue.SIX);
			deck[19] = new Card(Suits.HEARTS, CardValue.SEVEN);
			deck[20] = new Card(Suits.HEARTS, CardValue.EIGHT);
			deck[21] = new Card(Suits.HEARTS, CardValue.NINE);
			deck[22] = new Card(Suits.HEARTS, CardValue.JACK);
			deck[23] = new Card(Suits.HEARTS, CardValue.QUEEN);
			deck[24] = new Card(Suits.HEARTS, CardValue.KING);
			deck[25] = new Card(Suits.HEARTS, CardValue.ACE);


			deck[26] = new Card(Suits.CLUBS, CardValue.ONE);
			deck[27] = new Card(Suits.CLUBS, CardValue.TWO);
			deck[28] = new Card(Suits.CLUBS, CardValue.THREE);
			deck[29] = new Card(Suits.CLUBS, CardValue.FOUR);
			deck[30] = new Card(Suits.CLUBS, CardValue.FIVE);
			deck[31] = new Card(Suits.CLUBS, CardValue.SIX);
			deck[32] = new Card(Suits.CLUBS, CardValue.SEVEN);
			deck[33] = new Card(Suits.CLUBS, CardValue.EIGHT);
			deck[34] = new Card(Suits.CLUBS, CardValue.NINE);
			deck[35] = new Card(Suits.CLUBS, CardValue.JACK);
			deck[36] = new Card(Suits.CLUBS, CardValue.QUEEN);
			deck[37] = new Card(Suits.CLUBS, CardValue.KING);
			deck[38] = new Card(Suits.CLUBS, CardValue.ACE);


			deck[39] = new Card(Suits.DIAMONDS, CardValue.ONE);
			deck[40] = new Card(Suits.DIAMONDS, CardValue.TWO);
			deck[41] = new Card(Suits.DIAMONDS, CardValue.THREE);
			deck[42] = new Card(Suits.DIAMONDS, CardValue.FOUR);
			deck[43] = new Card(Suits.DIAMONDS, CardValue.FIVE);
			deck[44] = new Card(Suits.DIAMONDS, CardValue.SIX);
			deck[45] = new Card(Suits.DIAMONDS, CardValue.SEVEN);
			deck[46] = new Card(Suits.DIAMONDS, CardValue.EIGHT);
			deck[47] = new Card(Suits.DIAMONDS, CardValue.NINE);
			deck[48] = new Card(Suits.DIAMONDS, CardValue.JACK);
			deck[49] = new Card(Suits.DIAMONDS, CardValue.QUEEN);
			deck[50] = new Card(Suits.DIAMONDS, CardValue.KING);
			deck[51] = new Card(Suits.DIAMONDS, CardValue.ACE);

		}
		public Stack<Card> Shuffle() {
			var rnd = new Random();
			this.deck = deck.OrderBy(x => rnd.Next()).ToArray();
			Stack <Card> mydeck = new Stack<Card>();
			foreach (Card card in deck) {
				mydeck.Push(card);
			}
			return mydeck;
		}
        public override string ToString()
        {
			StringBuilder sb = new StringBuilder();
			foreach (Card card in deck) {
				sb.Append(card.ToString() + "\n");		
			}
			return sb.ToString();
        }
    }
}

