using System.Collections.Generic;
using System.Linq;
using PokerAssignment.Data;

namespace PokerAssignment.Resolver
{
    /// <summary>
    /// High Card resolver(ace)
    /// </summary>
    public class HighCardResolver : PokerResolver
    {

        public override void resolve(IList<Card> cards)
        {
            Resolved = cards != null && cards.Any(card=>card.Value == Weight.Ace);
            //
            if (Resolved)
            {
                Data = Hand.HighCard;
            }
            else
            {
                Data = Hand.NotResolved;
            }
        }
        

    }
}
