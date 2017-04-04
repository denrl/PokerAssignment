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
            Resolved = cards != null && cards.Any();
            //
            if (Resolved)
            {
                Data = cards.Sum(x=>(long)x.Value);
            }
            else
            {
                Data = (long)Hand.NotResolved;
            }
        }
        

    }
}
