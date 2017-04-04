using System.Collections.Generic;
using System.Linq;
using PokerAssignment.Data;

namespace PokerAssignment.Resolver
{
    /// <summary>
    /// Base class for many of a kind
    /// </summary>
    public abstract class MultiKindResolver : PokerResolver
    {
        private byte TotalSameCardKind { get; set; }

        protected MultiKindResolver(byte totalSameCardKind)
        {
            this.TotalSameCardKind = totalSameCardKind;
        }

        public override void resolve(IList<Card> cards)
        {
            Resolved =
                cards
                    .GroupBy(card => card.Value)
                    .Any(group => group.Count() >= TotalSameCardKind);
        }
        
    }
}
