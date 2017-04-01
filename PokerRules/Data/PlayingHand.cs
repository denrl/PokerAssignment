using System.Collections.Generic;

namespace PokerAssignment.Data
{
    /// <summary>
    /// Players hand
    /// </summary>
    public class PlayingHand
    {

        private IList<Card> cards = new List<Card>();

        public string Player { get; set; }

        public IList<Card> Cards
        {
            get { return cards; }
            set { cards = value; }
        }

        

    }
}
