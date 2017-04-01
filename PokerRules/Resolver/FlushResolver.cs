using System.Collections.Generic;
using System.Linq;
using PokerAssignment.Data;

namespace PokerAssignment.Resolver
{
    /// <summary>
    /// Flush resolver (5 of the kind)
    /// </summary>
    public class FlushResolver : PokerResolver
    {
        public override void resolve(IList<Card> cards)
        {
            Resolved =
                cards
                    .GroupBy(card => card.Suit)
                    .Any(group => group.Count() == 5);
            if (Resolved)
            {
                Data = Hand.Flush;
            }
            else
            {
                Data = Hand.NotResolved;
            }
        }
        
    }
}
